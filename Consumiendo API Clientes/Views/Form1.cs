using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consumiendo_API_Clientes.Views;

namespace Consumiendo_API_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.BringToFront();
            if(rbAgregar.Checked==true)
            {
                if (agregarCliente.ShowDialog() == DialogResult.OK)
                {

                }
            }
            rbAgregar.Checked = false;
        }
    }
}
