using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsAppVaidrollTeam
{
    public partial class Reportes : Form
    {
        ClassNegocio objneg = new ClassNegocio();
        ClassEntidad objent = new ClassEntidad();
        public Reportes()
        {
            InitializeComponent();


        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            cbo1.Items.Add("Todos");
            cbo1.Items.Add("Curso");
            cbo1.Items.Add("Salones");
            cbo1.SelectedIndex = 0;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo1.SelectedIndex == 0)
            {
                cbo2.Text = "";
                cbo2.Enabled = false;
                dataGridView1.DataSource = objneg.N_listaralumnos();
            } else
          if (cbo1.SelectedIndex == 1)
            {
                cbo2.DataSource = objneg.N_listar_curso();
                cbo2.ValueMember = "id_cursos";
                cbo2.DisplayMember = "curso_nombre";
                cbo2.Enabled = true;
            }
            else if (cbo1.SelectedIndex == 2)
            {
                cbo2.DataSource = objneg.N_listar_salon();
                cbo2.ValueMember = "id_salon";
                cbo2.DisplayMember = "salon_nombre";
                cbo2.Enabled = true;
            }


        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo1.SelectedIndex == 0)
            {
                cbo2.Text = "";
            }
            else
        if (cbo1.SelectedIndex == 1)
            {
                objent.id_cod = cbo2.SelectedValue.ToString();
                DataTable dt = objneg.N_buscaralumnosXcurso(objent);
                dataGridView1.DataSource = dt;
            }
            else if (cbo1.SelectedIndex == 2)
            {
                objent.id_cod = cbo2.SelectedValue.ToString();
                DataTable dt = objneg.N_buscaralumnosXsalon(objent);
                dataGridView1.DataSource = dt;
            }
        }
        ReportDataSource rs = new ReportDataSource();
        private void btnentrar_Click(object sender, EventArgs e)
        {



            List<alumn> lst = new List<alumn>();
            lst.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                lst.Add(new alumn { cod_1 = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    nombre_1 = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    telefono_1 = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    matricula_1 = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    curso_1 = dataGridView1.Rows[i].Cells[5].Value.ToString(),
                    salon_1 = dataGridView1.Rows[i].Cells[7].Value.ToString()
                });

               
            }
            rs.Name = "DataSet1";
            rs.Value = lst;
            Informe frm = new Informe();
            frm.reportViewer2.LocalReport.DataSources.Clear();
            frm.reportViewer2.LocalReport.Refresh();
            frm.reportViewer2.LocalReport.DataSources.Add(rs);
            frm.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsAppVaidrollTeam.Report1.rdlc";
            frm.ShowDialog();

        }
        public class alumn
        {
            public string cod_1 { get; set; }
            public string nombre_1 { get; set; }

            public string telefono_1 { get; set; }
            public string matricula_1 { get; set; }

            public string curso_1 { get; set; }

            public string salon_1 { get; set; }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

