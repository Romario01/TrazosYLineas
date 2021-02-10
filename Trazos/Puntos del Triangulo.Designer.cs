
namespace Trazos
{
    partial class Puntos_del_Triangulo
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
            this.panel = new System.Windows.Forms.Panel();
            this.lblPunto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(374, 195);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // lblPunto
            // 
            this.lblPunto.AutoSize = true;
            this.lblPunto.Location = new System.Drawing.Point(53, 225);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(35, 13);
            this.lblPunto.TabIndex = 1;
            this.lblPunto.Text = "label1";
            // 
            // Puntos_del_Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 289);
            this.Controls.Add(this.lblPunto);
            this.Controls.Add(this.panel);
            this.Name = "Puntos_del_Triangulo";
            this.Text = "Puntos_del_Triangulo";
            this.Load += new System.EventHandler(this.Puntos_del_Triangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblPunto;
    }
}