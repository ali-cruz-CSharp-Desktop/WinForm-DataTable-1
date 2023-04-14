using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datatable1
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SampleDBTest"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            var FirstName = firstNameTextBox.Text;
            var LastName2 = lastNameTextBox.Text;
            var FechaAlta = fechaAltaDateTimeP.Value;

            // LLena DGV final

            int n = listaUsuariosDGV.Rows.Add();

            listaUsuariosDGV.Rows[n].Cells[2].Value = firstNameTextBox.Text;
            listaUsuariosDGV.Rows[n].Cells[3].Value = lastNameTextBox.Text;
            listaUsuariosDGV.Rows[n].Cells[4].Value = edadTextBox.Text;
            listaUsuariosDGV.Rows[n].Cells[5].Value = fechaAltaDateTimeP.Text;


            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spPeople1Insert", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", LastName2));
                    cmd.Parameters.Add(new SqlParameter("@FechaAlta", FechaAlta));

                    sql.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            edadTextBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // LLena el DGV sin personalizar, por default
            LlenaDataGridViewSinPersonalizar();
        }


        /*
         * Recoge las filas del spPeopleSelect_All alojandolas en el DT para llenar el DGV
         */
        private void LlenaDataGridViewSinPersonalizar()
        {
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spPeople1Select_All", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);
                    listaUsuariosDGVSinPersonalizar.DataSource = dt;                    
                }
            }
        }

        /*
         * Llena el data grid view con los datos recuperados desde el spPeopleSelect_ByLastName
         */
        private void LlenarDataGridPeoplePersonalizado()
        {
            // Realizar un connection string desde cero manualmente
            //var builder = new SqlConnectionStringBuilder();
            //builder.DataSource = ".";
            //builder.InitialCatalog = "Sample";
            //builder.IntegratedSecurity = true;
                        
            // SELECT BY LASTNAME
            var LastName = "Cruz";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spPeople1Select_ByLastName", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@LastName", LastName));
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);

             



                    var contadorRows = 0;

                    DataGridViewButtonColumn abreDocumentoButton = new DataGridViewButtonColumn();

                    abreDocumentoButton.FlatStyle = FlatStyle.Standard;
                    abreDocumentoButton.HeaderText = "Accion";
                    abreDocumentoButton.Name = "abreDocumento";
                    abreDocumentoButton.UseColumnTextForButtonValue = true;
                    abreDocumentoButton.Text = "Open";

                    listaUsuariosDGVPersonalizado.Columns.Add(abreDocumentoButton);

                    listaUsuariosDGVPersonalizado.AutoGenerateColumns = false;
                    listaUsuariosDGVPersonalizado.ColumnCount = 5;

                    //listaUsuariosDGVPersonalizado.Columns[0].HeaderText = "Accion";
                    //listaUsuariosDGVPersonalizado.Columns[0].Name = "accion";
                    listaUsuariosDGVPersonalizado.Columns[0].Name = "detalles";
                    listaUsuariosDGVPersonalizado.Columns[1].HeaderText = "Nombre";
                    listaUsuariosDGVPersonalizado.Columns[1].Name = "nombre";
                    listaUsuariosDGVPersonalizado.Columns[2].HeaderText = "Edad1";
                    listaUsuariosDGVPersonalizado.Columns[2].Name = "edad";
                    listaUsuariosDGVPersonalizado.Columns[3].HeaderText = "Apellido";
                    listaUsuariosDGVPersonalizado.Columns[3].Name = "apellido";
                    listaUsuariosDGVPersonalizado.Columns[4].HeaderText = "Id";
                    listaUsuariosDGVPersonalizado.Columns[4].Name = "id";
                    listaUsuariosDGVPersonalizado.Columns[4].Visible = false;



                    foreach (DataRow dr in dt.Rows)
                    {
                        var index = listaUsuariosDGVPersonalizado.Rows.Add();                        
                        listaUsuariosDGVPersonalizado.Rows[index].Cells[1].Value = dr["FirstName"].ToString();
                        listaUsuariosDGVPersonalizado.Rows[index].Cells[2].Value = dr["Edad"].ToString();
                        listaUsuariosDGVPersonalizado.Rows[index].Cells[3].Value = dr["LastName"].ToString();
                        listaUsuariosDGVPersonalizado.Rows[index].Cells[4].Value = dr["id"].ToString();
                    }
                }
            }
        }

        private void actualizaDGVButton_Click(object sender, EventArgs e)
        {
            LlenarDataGridPeoplePersonalizado();
        }

        private void listaUsuariosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                seleccionDGV3Lbl.Text = (string)listaUsuariosDGV.Rows[n].Cells[2].Value;
            }
        }

        private void listaUsuariosDGVSinPersonalizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(listaUsuariosDGVSinPersonalizar.CurrentCell.Value.ToString());
        }

        private void listaUsuariosDGVPersonalizado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var n = e.RowIndex;
            
            // Si hago click en la columna 1
            if (n != -1 && e.ColumnIndex == 0)
            {
                // Tomo el valor de la columna 4 que es el id.
                var rowSelected = (string)listaUsuariosDGVPersonalizado.Rows[n].Cells[4].Value;
                MessageBox.Show(rowSelected);
            }
        }
    }
}
