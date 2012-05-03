using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace StockPC
{
    class clsUtil
    {
        public static int USUARIO_LOGADO = 0;

        #region -- Forms --

        public static void OpenForm(Form pai, Form filho)
        {
            try
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name.Equals(filho.Name))
                    {
                        Application.OpenForms[i].TopMost = true;
                        Application.OpenForms[i].BringToFront();
                        Application.OpenForms[i].Activate();
                        Application.OpenForms[i].Focus();
                        Application.DoEvents();
                        return;
                    }
                }

                filho.MdiParent = pai;
                Application.DoEvents();
                filho.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar abrir a janela!", "Stock PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region -- SQL --

        public static void ExecutarFuncao(string connectionString, string funcao, params string[] valores)
        {
            OdbcConnection conn = new OdbcConnection(connectionString);
            string SQL = "SELECT " + funcao + "(";
            for (int i = 0; i < valores.Length; i++)
			{
                SQL += ((valores[i] != null) ? "'" + valores[i] + "'" : "null");
                SQL += (i < valores.Length - 1) ? ", " : "";
			}
            SQL += ")";
            OdbcCommand command = new OdbcCommand(SQL, conn);

            try
            {
                conn.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string msg = e.Message.Split(';')[0];
                msg = (msg.Length > 0) ? msg.Split(':')[1] : string.Empty;
                MessageBox.Show(msg, "Stock PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static object RetonarFuncaoEscalar(string connectionString, string funcao, params string[] valores)
        {
            OdbcConnection conn = new OdbcConnection(connectionString);
            string SQL = "SELECT " + funcao + "(";
            for (int i = 0; i < valores.Length; i++)
            {
                SQL += ((valores[i] != null) ? "'" + valores[i] + "'" : "null");
                SQL += (i < valores.Length - 1) ? ", " : "";
            }
            SQL += ")";
            OdbcCommand command = new OdbcCommand(SQL, conn);

            try
            {
                conn.Open();

                return command.ExecuteScalar();
            }
            catch (Exception e)
            {
                string msg = e.Message.Split(';')[0];
                msg = (msg.Length > 0) ? msg.Split(':')[1] : string.Empty;
                MessageBox.Show(e.Message, "Stock PC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty;
            }
            finally
            {
                conn.Close();
            }
        }

        private static void PreencheCombobox(OdbcDataReader reader, ComboBox cb)
        {
            DataTable table = new DataTable();

            string[] colunas = new string[] { "Value", "Display" };
            bool fazer = true;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string[] valores = reader[0].ToString().Split('|');
                    string value = valores[0];
                    string display = (valores.Length == 2) ? valores[1] : valores[0];

                    if (fazer)
                    {
                        table.Columns.AddRange((valores.Length == 2) ? 
                            new DataColumn[] { new DataColumn(colunas[0]), new DataColumn(colunas[1]) } :
                            new DataColumn[] { new DataColumn(colunas[0]) });
                        table.Rows.Add((valores.Length == 2) ? new string[] { "0", "-- Selecione --" } : new string[] { "" });
                        fazer = false;
                    }

                    table.Rows.Add((valores.Length == 2) ? new string[] { value, display } : new string[] { value });
                }
            }

            cb.DataSource = null;
            cb.DataSource = table;
            cb.ValueMember = colunas[0];
            cb.DisplayMember = (table.Columns.Count == 2) ? colunas[1] : colunas[0];
        }

        private static void PreencheGrid(OdbcDataReader reader, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            bool fazer = true;
            int colBool = -1;
            while (reader.Read())
            {
                #region - Nomes Colunas -
                if (fazer)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetDataTypeName(i).Contains("bool"))
                        {
                            DataGridViewCheckBoxColumn colch = new DataGridViewCheckBoxColumn();
                            colch.Name = reader.GetName(i);
                            colch.HeaderText = reader.GetName(i);
                            colch.ReadOnly = true;

                            dgv.Columns.Add(colch);

                            colBool = i;
                        }
                        else
                        {
                            dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                            dgv.Columns[i].ReadOnly = true;
                        }
                    }
                    fazer = false;
                }
                #endregion

                #region - Valores Colunas -
                object[] linha = new object[reader.FieldCount];

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    /*reader.GetFieldType(i).ToString()*/
                    //MessageBox.Show("[" + reader.GetName(i) + "]: " + reader[i].ToString() + " (" + reader.GetDataTypeName(i) + ")");
                    linha[i] = (colBool == i) ? ((reader[i].ToString().Equals("0")) ? false : true) : reader[i];
                }

                dgv.Rows.Add(linha);
                #endregion
            }

            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //public static void TrazerDados(string connectionString, string tabela, ref DataGridView dgv)
        //{
        //    OdbcConnection conn = new OdbcConnection(connectionString);
        //    OdbcCommand command = new OdbcCommand("SELECT * FROM " + tabela, conn);

        //    try
        //    {
        //        conn.Open();

        //        PreencheGrid(command.ExecuteReader(), dgv);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Stock PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        public static void TrazerDados(string connectionString, string funcao, ref DataGridView dgv, params string[] valores)
        {
            OdbcConnection conn = new OdbcConnection(connectionString);
            string SQL = "SELECT * FROM " + funcao + "(";
            for (int i = 0; i < valores.Length; i++)
            {
                SQL += ((valores[i] != null) ? "'" + valores[i] + "'" : "null");
                SQL += (i < valores.Length - 1) ? ", " : "";
            }
            SQL += ")";
            OdbcCommand command = new OdbcCommand(SQL, conn);

            try
            {
                conn.Open();

                PreencheGrid(command.ExecuteReader(), dgv);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Stock PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void TrazerDados(string connectionString, string funcao, ref ComboBox cb, params string[] valores)
        {
            OdbcConnection conn = new OdbcConnection(connectionString);
            string SQL = "SELECT * FROM " + funcao + "(";
            for (int i = 0; i < valores.Length; i++)
            {
                SQL += ((valores[i] != null) ? "'" + valores[i] + "'" : "null");
                SQL += (i < valores.Length - 1) ? ", " : "";
            }
            SQL += ")";
            OdbcCommand command = new OdbcCommand(SQL, conn);

            try
            {
                conn.Open();

                PreencheCombobox(command.ExecuteReader(), cb);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Stock PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion
    }
}
