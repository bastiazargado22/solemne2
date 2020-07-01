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
using MiLibrary;

namespace Login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Cajero WHERE nombre='{0}' AND pass='{1}'", textBoxUsuario.Text.Trim(), textBoxContraseña.Text.Trim());
                DataSet Ds = Utilidades.Ejecutar(CMD);

                string cuenta = Ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                string contraseña = Ds.Tables[0].Rows[0]["pass"].ToString().Trim();

                if (cuenta == textBoxUsuario.Text.Trim() && contraseña == textBoxContraseña.Text.Trim())
                {
                    this.Hide();
                    Menu menu1 = new Menu();
                    menu1.Show();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en contraseña o usuario");
                /*textBoxUsuario = "";
                textBoxContraseña = "";*/
            }
           
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
