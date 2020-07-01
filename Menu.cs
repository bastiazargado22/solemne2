using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            int pedido = Tabla_Venta.Rows.Add();
            int PizzaFamiliar = 22000;
            int PizzMediana = 12000;
            int PizzaIndividual = 8000;
            int Individual = 1500;
            int Familiar = 5000;
            int cantPiz = Convert.ToInt32(CajaCantidadPizza.Text);
            int cantBeb = Convert.ToInt32(CajaCantidadBebida.Text); 


            if (BotonFamiliar.Checked == true && BebidaIndividual.Checked == true)
            {
                
                Tabla_Venta.Rows[pedido].Cells[0].Value = CajaCantidadPizza.Text;
                Tabla_Venta.Rows[pedido].Cells[1].Value = BotonFamiliar.Text;
                Tabla_Venta.Rows[pedido].Cells[2].Value = CajaCantidadBebida.Text;
                Tabla_Venta.Rows[pedido].Cells[3].Value = BebidaIndividual.Text;
                Tabla_Venta.Rows[pedido].Cells[4].Value = ((cantPiz * PizzaFamiliar) + (cantBeb * Individual));
            }
            else if (BotonFamiliar.Checked == true && BebidaFamiliar.Checked == true)
            {
                Tabla_Venta.Rows[pedido].Cells[0].Value = CajaCantidadPizza.Text;
                Tabla_Venta.Rows[pedido].Cells[1].Value = BotonFamiliar.Text;
                Tabla_Venta.Rows[pedido].Cells[2].Value = CajaCantidadBebida.Text;
                Tabla_Venta.Rows[pedido].Cells[3].Value = BebidaFamiliar.Text;
                Tabla_Venta.Rows[pedido].Cells[4].Value = ((cantPiz*PizzaFamiliar) + (cantBeb*Familiar));
            }
            if (BotonMediana.Checked == true && BebidaIndividual.Checked == true)
            {
                Tabla_Venta.Rows[pedido].Cells[0].Value = CajaCantidadPizza.Text;
                Tabla_Venta.Rows[pedido].Cells[1].Value = BotonMediana.Text;
                Tabla_Venta.Rows[pedido].Cells[2].Value = CajaCantidadBebida.Text;
                Tabla_Venta.Rows[pedido].Cells[3].Value = BebidaIndividual.Text;
                Tabla_Venta.Rows[pedido].Cells[4].Value = ((cantPiz * PizzMediana) + (cantBeb * Individual));
            }
            else if (BotonMediana.Checked == true && BebidaFamiliar.Checked == true)
            {
                Tabla_Venta.Rows[pedido].Cells[0].Value = CajaCantidadPizza.Text;
                Tabla_Venta.Rows[pedido].Cells[1].Value = BotonMediana.Text;
                Tabla_Venta.Rows[pedido].Cells[2].Value = CajaCantidadBebida.Text;
                Tabla_Venta.Rows[pedido].Cells[3].Value = BebidaFamiliar.Text;
                Tabla_Venta.Rows[pedido].Cells[4].Value = ((cantPiz * PizzMediana) + (cantBeb * Familiar));
            }
            if (BotonIndividual.Checked == true && BebidaIndividual.Checked == true)
            {
                Tabla_Venta.Rows[pedido].Cells[0].Value = CajaCantidadPizza.Text;
                Tabla_Venta.Rows[pedido].Cells[1].Value = BotonIndividual.Text;
                Tabla_Venta.Rows[pedido].Cells[2].Value = CajaCantidadBebida.Text;
                Tabla_Venta.Rows[pedido].Cells[3].Value = BebidaIndividual.Text;
                Tabla_Venta.Rows[pedido].Cells[4].Value = ((cantPiz * PizzaIndividual) + (cantBeb * Individual));
            }
            else if (BotonIndividual.Checked == true && BebidaFamiliar.Checked == true)
            {
                Tabla_Venta.Rows[pedido].Cells[0].Value = CajaCantidadPizza.Text;
                Tabla_Venta.Rows[pedido].Cells[1].Value = BotonIndividual.Text;
                Tabla_Venta.Rows[pedido].Cells[2].Value = CajaCantidadBebida.Text;
                Tabla_Venta.Rows[pedido].Cells[3].Value = BebidaFamiliar.Text;
                Tabla_Venta.Rows[pedido].Cells[4].Value = ((cantPiz * PizzaIndividual) + (cantBeb * Individual));
            }
            
            
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            int total=Convert.ToInt32(Tabla_Venta.Columns["Total"]);
            int sum = 0;
            for (int i = 0; i < Tabla_Venta.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(Tabla_Venta.Rows[i].Cells[4].Value);
            }
            


            MessageBox.Show("Total Vendido: " + "$ "+sum.ToString());
            MessageBox.Show("Adios");

            this.Close();
            Form1 otro = new Form1();
            otro.Show();


        }
    }
    }
