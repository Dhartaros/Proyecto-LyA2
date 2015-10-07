namespace MiniJava
{
    partial class Form1
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
            this.codigoStream = new System.Windows.Forms.TextBox();
            this.lexico = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.analizar = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.consola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codigoStream
            // 
            this.codigoStream.Location = new System.Drawing.Point(12, 12);
            this.codigoStream.Multiline = true;
            this.codigoStream.Name = "codigoStream";
            this.codigoStream.Size = new System.Drawing.Size(376, 297);
            this.codigoStream.TabIndex = 0;
            // 
            // lexico
            // 
            this.lexico.Enabled = false;
            this.lexico.Location = new System.Drawing.Point(520, 12);
            this.lexico.Multiline = true;
            this.lexico.Name = "lexico";
            this.lexico.Size = new System.Drawing.Size(376, 297);
            this.lexico.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 316);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // analizar
            // 
            this.analizar.Location = new System.Drawing.Point(395, 13);
            this.analizar.Name = "analizar";
            this.analizar.Size = new System.Drawing.Size(119, 23);
            this.analizar.TabIndex = 3;
            this.analizar.Text = "Analizar > >";
            this.analizar.UseVisualStyleBackColor = true;
            this.analizar.Click += new System.EventHandler(this.analizar_Click);
            // 
            // abrir
            // 
            this.abrir.Location = new System.Drawing.Point(395, 256);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(119, 23);
            this.abrir.TabIndex = 4;
            this.abrir.Text = "Abrir ...";
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(395, 285);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(119, 23);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "Guardar ...";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // consola
            // 
            this.consola.Enabled = false;
            this.consola.Location = new System.Drawing.Point(13, 345);
            this.consola.Multiline = true;
            this.consola.Name = "consola";
            this.consola.Size = new System.Drawing.Size(883, 169);
            this.consola.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 526);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.analizar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lexico);
            this.Controls.Add(this.codigoStream);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoStream;
        private System.Windows.Forms.TextBox lexico;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button analizar;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox consola;
    }
}

