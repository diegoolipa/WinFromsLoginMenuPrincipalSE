using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;

namespace Presentacion
{
    public partial class FormularioPersonas : Form
    {
        public FormularioPersonas()
        {
            InitializeComponent();
        }

        private void FormularioPersonas_Load(object sender, EventArgs e)
        {
            MonstrarPersona();
        }

        public void MonstrarPersona()
        {
            PersonasModel personas = new PersonasModel();
            dataGridViewPersona.DataSource = personas.MostrarPersona();
        }
    }
}
