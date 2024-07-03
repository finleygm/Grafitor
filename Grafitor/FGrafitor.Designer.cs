namespace Grafitor
{
    partial class FGrafitor
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
            this.picLienzo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLienzo
            // 
            this.picLienzo.BackColor = System.Drawing.Color.White;
            this.picLienzo.Location = new System.Drawing.Point(82, 75);
            this.picLienzo.Name = "picLienzo";
            this.picLienzo.Size = new System.Drawing.Size(757, 521);
            this.picLienzo.TabIndex = 0;
            this.picLienzo.TabStop = false;
            this.picLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLienzo_MouseDown);
            this.picLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picLienzo_MouseMove);
            this.picLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picLienzo_MouseUp);
            // 
            // FGrafitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 708);
            this.Controls.Add(this.picLienzo);
            this.Name = "FGrafitor";
            this.Text = "Grafitor";
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLienzo;
    }
}

