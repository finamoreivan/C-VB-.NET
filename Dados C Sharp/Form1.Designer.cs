
namespace Dados_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dado1 = new System.Windows.Forms.PictureBox();
            this.Cubilete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dado2 = new System.Windows.Forms.PictureBox();
            this.Dado4 = new System.Windows.Forms.PictureBox();
            this.Dado3 = new System.Windows.Forms.PictureBox();
            this.Dado5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cubilete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado5)).BeginInit();
            this.SuspendLayout();
            // 
            // Dado1
            // 
            this.Dado1.Image = global::Dados_C_Sharp.Properties.Resources.dado1;
            this.Dado1.Location = new System.Drawing.Point(103, 128);
            this.Dado1.Name = "Dado1";
            this.Dado1.Size = new System.Drawing.Size(94, 95);
            this.Dado1.TabIndex = 0;
            this.Dado1.TabStop = false;
            // 
            // Cubilete
            // 
            this.Cubilete.BackColor = System.Drawing.Color.Transparent;
            this.Cubilete.Location = new System.Drawing.Point(464, 7);
            this.Cubilete.Name = "Cubilete";
            this.Cubilete.Size = new System.Drawing.Size(329, 292);
            this.Cubilete.TabIndex = 1;
            this.Cubilete.TabStop = false;
            this.Cubilete.Click += new System.EventHandler(this.Cubilete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(166, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click en el cubilete para tirar >>>>>";
            // 
            // Dado2
            // 
            this.Dado2.Image = global::Dados_C_Sharp.Properties.Resources.dado1;
            this.Dado2.Location = new System.Drawing.Point(244, 98);
            this.Dado2.Name = "Dado2";
            this.Dado2.Size = new System.Drawing.Size(94, 95);
            this.Dado2.TabIndex = 3;
            this.Dado2.TabStop = false;
            // 
            // Dado4
            // 
            this.Dado4.Image = global::Dados_C_Sharp.Properties.Resources.dado1;
            this.Dado4.Location = new System.Drawing.Point(322, 221);
            this.Dado4.Name = "Dado4";
            this.Dado4.Size = new System.Drawing.Size(94, 95);
            this.Dado4.TabIndex = 4;
            this.Dado4.TabStop = false;
            // 
            // Dado3
            // 
            this.Dado3.Image = global::Dados_C_Sharp.Properties.Resources.dado1;
            this.Dado3.Location = new System.Drawing.Point(122, 246);
            this.Dado3.Name = "Dado3";
            this.Dado3.Size = new System.Drawing.Size(94, 95);
            this.Dado3.TabIndex = 5;
            this.Dado3.TabStop = false;
            // 
            // Dado5
            // 
            this.Dado5.Image = global::Dados_C_Sharp.Properties.Resources.dado1;
            this.Dado5.Location = new System.Drawing.Point(225, 343);
            this.Dado5.Name = "Dado5";
            this.Dado5.Size = new System.Drawing.Size(94, 95);
            this.Dado5.TabIndex = 6;
            this.Dado5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dados_C_Sharp.Properties.Resources.mesa;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dado5);
            this.Controls.Add(this.Dado3);
            this.Controls.Add(this.Dado4);
            this.Controls.Add(this.Dado2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cubilete);
            this.Controls.Add(this.Dado1);
            this.Name = "Form1";
            this.Text = "Generala C#";
            ((System.ComponentModel.ISupportInitialize)(this.Dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cubilete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Tirar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Dado1;
        private System.Windows.Forms.PictureBox Cubilete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Dado2;
        private System.Windows.Forms.PictureBox Dado4;
        private System.Windows.Forms.PictureBox Dado3;
        private System.Windows.Forms.PictureBox Dado5;
    }
}

