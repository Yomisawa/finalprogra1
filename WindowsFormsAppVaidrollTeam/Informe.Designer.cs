namespace WindowsFormsAppVaidrollTeam
{
    partial class Informe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.alumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alumnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnBindingSource
            // 
            this.alumnBindingSource.DataSource = typeof(WindowsFormsAppVaidrollTeam.Reportes.alumn);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsAppVaidrollTeam.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(789, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alumnBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsAppVaidrollTeam.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 37);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(788, 575);
            this.reportViewer2.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Maroon;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(780, 6);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(20, 20);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Informe
            // 
            this.BackgroundImage = global::WindowsFormsAppVaidrollTeam.Properties.Resources.reportes;
            this.ClientSize = new System.Drawing.Size(812, 624);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Informe_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.alumnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource alumnBindingSource;
        private System.Windows.Forms.Button btnsalir;
    }
}