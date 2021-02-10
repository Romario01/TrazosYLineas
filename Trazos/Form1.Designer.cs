
namespace Trazos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAlturas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAxisY = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtAxisX = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnSeleccionForma = new System.Windows.Forms.Button();
            this.listFiguras = new System.Windows.Forms.ListBox();
            this.rdaFigurasBasicas = new System.Windows.Forms.RadioButton();
            this.ckLinea = new System.Windows.Forms.CheckBox();
            this.rdbMouse = new System.Windows.Forms.RadioButton();
            this.rdbLineasPuntos = new System.Windows.Forms.RadioButton();
            this.txtTam = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAlturas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAncho);
            this.groupBox1.Controls.Add(this.txtAxisY);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtAxisX);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.btnSeleccionForma);
            this.groupBox1.Controls.Add(this.listFiguras);
            this.groupBox1.Controls.Add(this.rdaFigurasBasicas);
            this.groupBox1.Controls.Add(this.ckLinea);
            this.groupBox1.Controls.Add(this.rdbMouse);
            this.groupBox1.Controls.Add(this.rdbLineasPuntos);
            this.groupBox1.Location = new System.Drawing.Point(477, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ancho";
            // 
            // lblAlturas
            // 
            this.lblAlturas.AutoSize = true;
            this.lblAlturas.Location = new System.Drawing.Point(206, 120);
            this.lblAlturas.Name = "lblAlturas";
            this.lblAlturas.Size = new System.Drawing.Size(34, 13);
            this.lblAlturas.TabIndex = 15;
            this.lblAlturas.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(252, 137);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(38, 20);
            this.txtAncho.TabIndex = 12;
            // 
            // txtAxisY
            // 
            this.txtAxisY.Location = new System.Drawing.Point(161, 137);
            this.txtAxisY.Name = "txtAxisY";
            this.txtAxisY.Size = new System.Drawing.Size(38, 20);
            this.txtAxisY.TabIndex = 11;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(252, 114);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(38, 20);
            this.txtAltura.TabIndex = 10;
            // 
            // txtAxisX
            // 
            this.txtAxisX.Location = new System.Drawing.Point(161, 114);
            this.txtAxisX.Name = "txtAxisX";
            this.txtAxisX.Size = new System.Drawing.Size(38, 20);
            this.txtAxisX.TabIndex = 9;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Rojo",
            "Negro",
            "Verde",
            "Azul",
            "Cyan"});
            this.cmbColor.Location = new System.Drawing.Point(161, 65);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(129, 21);
            this.cmbColor.TabIndex = 8;
            this.cmbColor.Text = "Selecciona Color";
            // 
            // btnSeleccionForma
            // 
            this.btnSeleccionForma.Location = new System.Drawing.Point(124, 173);
            this.btnSeleccionForma.Name = "btnSeleccionForma";
            this.btnSeleccionForma.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionForma.TabIndex = 7;
            this.btnSeleccionForma.Text = "Seleccionar ";
            this.btnSeleccionForma.UseVisualStyleBackColor = true;
            this.btnSeleccionForma.Click += new System.EventHandler(this.button2_Click);
            // 
            // listFiguras
            // 
            this.listFiguras.FormattingEnabled = true;
            this.listFiguras.Items.AddRange(new object[] {
            "arcos",
            "triángulos",
            "cuadrados",
            "rectángulos"});
            this.listFiguras.Location = new System.Drawing.Point(18, 65);
            this.listFiguras.Name = "listFiguras";
            this.listFiguras.Size = new System.Drawing.Size(120, 69);
            this.listFiguras.TabIndex = 6;
            this.listFiguras.SelectedIndexChanged += new System.EventHandler(this.listFiguras_SelectedIndexChanged);
            // 
            // rdaFigurasBasicas
            // 
            this.rdaFigurasBasicas.AutoSize = true;
            this.rdaFigurasBasicas.Location = new System.Drawing.Point(18, 42);
            this.rdaFigurasBasicas.Name = "rdaFigurasBasicas";
            this.rdaFigurasBasicas.Size = new System.Drawing.Size(99, 17);
            this.rdaFigurasBasicas.TabIndex = 5;
            this.rdaFigurasBasicas.TabStop = true;
            this.rdaFigurasBasicas.Text = "Figuras Basicas";
            this.rdaFigurasBasicas.UseVisualStyleBackColor = true;
            this.rdaFigurasBasicas.CheckedChanged += new System.EventHandler(this.rdaFigurasBasicas_CheckedChanged);
            // 
            // ckLinea
            // 
            this.ckLinea.AutoSize = true;
            this.ckLinea.Location = new System.Drawing.Point(36, 276);
            this.ckLinea.Name = "ckLinea";
            this.ckLinea.Size = new System.Drawing.Size(52, 17);
            this.ckLinea.TabIndex = 4;
            this.ckLinea.Text = "Linea";
            this.ckLinea.UseVisualStyleBackColor = true;
            // 
            // rdbMouse
            // 
            this.rdbMouse.AutoSize = true;
            this.rdbMouse.Location = new System.Drawing.Point(36, 253);
            this.rdbMouse.Name = "rdbMouse";
            this.rdbMouse.Size = new System.Drawing.Size(57, 17);
            this.rdbMouse.TabIndex = 2;
            this.rdbMouse.Text = "Mouse";
            this.rdbMouse.UseVisualStyleBackColor = true;
            // 
            // rdbLineasPuntos
            // 
            this.rdbLineasPuntos.AutoSize = true;
            this.rdbLineasPuntos.Location = new System.Drawing.Point(18, 19);
            this.rdbLineasPuntos.Name = "rdbLineasPuntos";
            this.rdbLineasPuntos.Size = new System.Drawing.Size(100, 17);
            this.rdbLineasPuntos.TabIndex = 0;
            this.rdbLineasPuntos.Text = "Lineas y Puntos";
            this.rdbLineasPuntos.UseVisualStyleBackColor = true;
            this.rdbLineasPuntos.CheckedChanged += new System.EventHandler(this.rdbLineasPuntos_CheckedChanged);
            // 
            // txtTam
            // 
            this.txtTam.Location = new System.Drawing.Point(576, 16);
            this.txtTam.Name = "txtTam";
            this.txtTam.Size = new System.Drawing.Size(100, 20);
            this.txtTam.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(620, 418);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 422);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tamaño del Lapiz";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(692, 16);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "Aplicar Tamaño";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rdbMouse;
        private System.Windows.Forms.RadioButton rdbLineasPuntos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckLinea;
        private System.Windows.Forms.TextBox txtTam;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdaFigurasBasicas;
        private System.Windows.Forms.ListBox listFiguras;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnSeleccionForma;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAxisY;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtAxisX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAlturas;
    }
}

