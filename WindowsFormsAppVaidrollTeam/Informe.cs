using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsAppVaidrollTeam
{
    public partial class Informe : Form
    {
        public Informe()
        {
            InitializeComponent();
        }

        private void Informe_Load(object sender, EventArgs e)
        {

        }

        private void Informe_Load_1(object sender, EventArgs e)
        {
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
