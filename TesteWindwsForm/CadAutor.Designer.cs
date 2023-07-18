namespace WindowsFormsApplication1
{
    partial class CadAutor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAutorSobren = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutorNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarAutor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAutorSobren);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAutorNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autor";
            // 
            // txtAutorSobren
            // 
            this.txtAutorSobren.Location = new System.Drawing.Point(82, 74);
            this.txtAutorSobren.Name = "txtAutorSobren";
            this.txtAutorSobren.Size = new System.Drawing.Size(255, 20);
            this.txtAutorSobren.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // txtAutorNome
            // 
            this.txtAutorNome.Location = new System.Drawing.Point(61, 35);
            this.txtAutorNome.Name = "txtAutorNome";
            this.txtAutorNome.Size = new System.Drawing.Size(276, 20);
            this.txtAutorNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnSalvarAutor
            // 
            this.btnSalvarAutor.Location = new System.Drawing.Point(322, 195);
            this.btnSalvarAutor.Name = "btnSalvarAutor";
            this.btnSalvarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAutor.TabIndex = 2;
            this.btnSalvarAutor.Text = "Salvar";
            this.btnSalvarAutor.UseVisualStyleBackColor = true;
            this.btnSalvarAutor.Click += new System.EventHandler(this.btnSalvarAutor_Click);
            // 
            // CadAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 261);
            this.Controls.Add(this.btnSalvarAutor);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadAutor";
            this.Text = "CadAutor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAutorSobren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutorNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarAutor;
    }
}