using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            int resultado;

            try
            {
                resultado = calcular();

                lbl1.Text = " = " + resultado;

                 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error");
                
            }

            finally

            {   
                //Intrucciones
                //Operaciones sensibles...
            }           
        }


        private int calcular()
        {
            int a, b, r;

            try
            {
                a = int.Parse(txb1.Text);
                b = int.Parse(txb2.Text);
                r = a / b;

                return r;
            }
            catch (Exception ex )
            {
                //guardar registro de error

                throw;
            }

        }
    }
}
