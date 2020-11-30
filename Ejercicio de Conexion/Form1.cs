using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_Conexion
{
    public partial class Form1 : Form
    {
        private SqlConnection Connexion = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string strConexion = @"Server=(LocalDB)\MSSQLLocalDB;Database=bd_local;Trusted_Connection=True;";
                try
                {
                    using (Connexion = new SqlConnection(strConexion))
                    {
                        Connexion.Open();
                    MessageBox.Show("Servidor: " + Connexion.DataSource +
                        "\nBase de Datos: " + Connexion.Database + "Estado: " + Connexion.State.ToString());
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error: " + E.Message);

                }
                finally
                {
                    Connexion.Close();
                    MessageBox.Show("Estado: " + Connexion.State.ToString());
                }
            
        }
    }
}
