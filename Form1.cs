using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperaturasNacional
{
    public partial class Form1 : Form
    {
        List<Departamento> departamentos = new List<Departamento>();
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void cargarDepartamentos()
        {
            departamentos.Clear();
            string fileName = "Departamento.txt";
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(stream))

                while (reader.Peek() > -1)
                {
                    Departamento departamento = new Departamento();
                    departamento.IdDep = Convert.ToInt16(reader.ReadLine());
                    departamento.Nombre = reader.ReadLine();
                    departamentos.Add(departamento);
                }
        }

        private int ObtenerNumeroDep()
        {
            int numDep = 0;
            comboBox_departamentos.ValueMember = "nombre";
            string nombreDep = Convert.ToString(comboBox_departamentos.SelectedValue);

            Departamento depEncontrado = departamentos.Find(c => c.Nombre == nombreDep);
            if (nombreDep != null)
            {
                numDep = Convert.ToInt16(depEncontrado.IdDep);
            }
            return numDep;
        }

        private void button_registrarTemp_Click(object sender, EventArgs e)
        {
            string fileName = "Temperatura.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            int numDep = ObtenerNumeroDep();

            writer.WriteLine(numDep);
            writer.WriteLine(txt_temperatura.Text);

            writer.Close();
            MessageBox.Show("Datos del propietario guardados");

            comboBox_departamentos.Text = "";
            txt_temperatura.Text = "";
            comboBox_departamentos.Select();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
            comboBox_departamentos.DataSource = departamentos;
            comboBox_departamentos.DisplayMember = "nombre";
        }

        private void comboBox_departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
