namespace WindowsFormsApplication1
{
    partial class ConsultaEditora
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
            this.dgvConsultaEdit = new System.Windows.Forms.DataGridView();
            this.btnConsulSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaEdit
            // 
            this.dgvConsultaEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEdit.Location = new System.Drawing.Point(12, 94);
            this.dgvConsultaEdit.Name = "dgvConsultaEdit";
            this.dgvConsultaEdit.Size = new System.Drawing.Size(765, 309);
            this.dgvConsultaEdit.TabIndex = 0;
            // 
            // btnConsulSair
            // 
            this.btnConsulSair.Location = new System.Drawing.Point(690, 415);
            this.btnConsulSair.Name = "btnConsulSair";
            this.btnConsulSair.Size = new System.Drawing.Size(75, 23);
            this.btnConsulSair.TabIndex = 1;
            this.btnConsulSair.Text = "Voltar";
            this.btnConsulSair.UseVisualStyleBackColor = true;
            this.btnConsulSair.Click += new System.EventHandler(this.btnConsulSair_Click);
            // 
            // ConsultaEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsulSair);
            this.Controls.Add(this.dgvConsultaEdit);
            this.Name = "ConsultaEditora";
            this.Text = "ConsultaEditora";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsulSair;
        public System.Windows.Forms.DataGridView dgvConsultaEdit;
    }
}