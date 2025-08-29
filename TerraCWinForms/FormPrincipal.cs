using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraCWinForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            AbrirFormularioEnPanel(frm);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormularioEnPanel(Form formulario)
        {
            panelContenedor.Controls.Clear();  // Limpiar contenido anterior
            formulario.TopLevel = false;       // Hacer que no sea formulario independiente
            formulario.Dock = DockStyle.Fill;  // Ocupa todo el panel
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicio frm = new FormInicio();
            AbrirFormularioEnPanel(frm);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes();
            AbrirFormularioEnPanel(frm);
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            FormProyectos frm = new FormProyectos();
            AbrirFormularioEnPanel(frm);
        }

    }
}
