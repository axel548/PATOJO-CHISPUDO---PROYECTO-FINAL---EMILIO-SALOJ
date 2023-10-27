using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PATOJO_CHISPUDO___PROYECTO_FINAL___EMILIO_SALOJ
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\patojos_chispudos.accdb");
        OleDbCommand comando = new OleDbCommand();

        public Form1()
        {
            InitializeComponent();
            connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'patojos_chispudosDataSet.empleados'
            // Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.patojos_chispudosDataSet.empleados);
            //limpiarcampos();
        }
        private void limpiarcampos()
        {
            dpiTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            cargoTextBox.Clear();
            departamentoTextBox.Clear();
            sueldoTextBox.Clear();

            isrTextBox.Clear();
            igssTextBox.Clear();
            irtraTextBox.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                int sueldo = int.Parse(sueldoTextBox.Text);
                this.empleadosTableAdapter.Insertar(int.Parse(dpiTextBox.Text), nombreTextBox.Text, apellidoTextBox.Text, cargoTextBox.Text, departamentoTextBox.Text, sueldo, calculo_isr(sueldo), calculo_iggs(sueldo), calculo_irtra(sueldo));
                this.empleadosTableAdapter.Fill(this.patojos_chispudosDataSet.empleados);
                limpiarcampos();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadosTableAdapter.Buscar(patojos_chispudosDataSet.empleados, int.Parse(dpiTextBox.Text));
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void empleadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }
        private int calculo_isr(int sueldo)
        {
            int sueldo_anual = sueldo * 12;
            int calculo = 0;
            if (sueldo_anual <= 30000)
            {
                calculo = (int)(sueldo_anual * 0.05);
            }
            else
            {
                calculo = (int)(sueldo_anual * 0.07);
            }
            return calculo;
        }

        private int calculo_iggs(int sueldo)
        {
            return (int)(sueldo * 0.0483) + (int)(sueldo * 0.1067);
        }

        private int calculo_irtra(int sueldo)
        {
            return (int)(sueldo * 0.01);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadosTableAdapter.Eliminar(int.Parse(dpiTextBox.Text));
                this.empleadosTableAdapter.Fill(this.patojos_chispudosDataSet.empleados);
                limpiarcampos();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int sueldo = int.Parse(sueldoTextBox.Text);
                this.empleadosTableAdapter.Actualizar(int.Parse(dpiTextBox.Text), nombreTextBox.Text, apellidoTextBox.Text, cargoTextBox.Text, departamentoTextBox.Text, sueldo, calculo_isr(sueldo), calculo_iggs(sueldo), calculo_irtra(sueldo), int.Parse(dpiTextBox.Text));
                this.empleadosTableAdapter.Fill(this.patojos_chispudosDataSet.empleados);
                limpiarcampos();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
        }
    }
}
