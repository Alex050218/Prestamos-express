
namespace Amortización
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.vistaImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarImg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpRegistro = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblInteres = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tblAmortizacion = new System.Windows.Forms.DataGridView();
            this.grpTabla = new System.Windows.Forms.Panel();
            this.btnGuardarD = new System.Windows.Forms.Button();
            this.lblTACuota = new System.Windows.Forms.Label();
            this.lblTInteres = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblnteresFinal = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.vistaImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAmortizacion)).BeginInit();
            this.grpTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.Nuevo_dato);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(21, 89);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(229, 20);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextChanged += new System.EventHandler(this.Nuevo_dato);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto a solicitar";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(21, 139);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(229, 20);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.TextChanged += new System.EventHandler(this.Nuevo_dato);
            // 
            // vistaImg
            // 
            this.vistaImg.Image = ((System.Drawing.Image)(resources.GetObject("vistaImg.Image")));
            this.vistaImg.Location = new System.Drawing.Point(264, 12);
            this.vistaImg.Name = "vistaImg";
            this.vistaImg.Size = new System.Drawing.Size(176, 194);
            this.vistaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vistaImg.TabIndex = 10;
            this.vistaImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prestamos express";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agregarImg
            // 
            this.agregarImg.Location = new System.Drawing.Point(21, 180);
            this.agregarImg.Name = "agregarImg";
            this.agregarImg.Size = new System.Drawing.Size(237, 24);
            this.agregarImg.TabIndex = 12;
            this.agregarImg.Text = "Agregar foto";
            this.agregarImg.UseVisualStyleBackColor = true;
            this.agregarImg.Click += new System.EventHandler(this.agregarImg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(33, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plazos disponibles";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(114, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(70, 17);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.Text = "72 meses";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.Plazos);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(114, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 17);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.Text = "48 meses";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.Plazos);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.Text = "36 meses";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Plazos);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.Text = "12 meses";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.Plazos);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "24 meses";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Plazos);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "6 meses";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Plazos);
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.txtMonto);
            this.grpRegistro.Controls.Add(this.btnContinuar);
            this.grpRegistro.Controls.Add(this.label4);
            this.grpRegistro.Controls.Add(this.txtTelefono);
            this.grpRegistro.Controls.Add(this.agregarImg);
            this.grpRegistro.Controls.Add(this.label3);
            this.grpRegistro.Controls.Add(this.txtNombre);
            this.grpRegistro.Controls.Add(this.groupBox1);
            this.grpRegistro.Controls.Add(this.label2);
            this.grpRegistro.Controls.Add(this.vistaImg);
            this.grpRegistro.Controls.Add(this.lblInteres);
            this.grpRegistro.Location = new System.Drawing.Point(6, 52);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(465, 316);
            this.grpRegistro.TabIndex = 14;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(267, 243);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(173, 49);
            this.btnContinuar.TabIndex = 15;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.CambiarVentana);
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(264, 227);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(100, 13);
            this.lblInteres.TabIndex = 14;
            this.lblInteres.Text = "Taza de interes: 0%";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tblAmortizacion
            // 
            this.tblAmortizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAmortizacion.Location = new System.Drawing.Point(28, 73);
            this.tblAmortizacion.Name = "tblAmortizacion";
            this.tblAmortizacion.Size = new System.Drawing.Size(422, 161);
            this.tblAmortizacion.TabIndex = 15;
            // 
            // grpTabla
            // 
            this.grpTabla.Controls.Add(this.btnGuardarD);
            this.grpTabla.Controls.Add(this.lblTACuota);
            this.grpTabla.Controls.Add(this.lblTInteres);
            this.grpTabla.Controls.Add(this.btnRegresar);
            this.grpTabla.Controls.Add(this.lblnteresFinal);
            this.grpTabla.Controls.Add(this.lblPlazo);
            this.grpTabla.Controls.Add(this.lblMonto);
            this.grpTabla.Controls.Add(this.lblNombre);
            this.grpTabla.Controls.Add(this.tblAmortizacion);
            this.grpTabla.Location = new System.Drawing.Point(-1, 52);
            this.grpTabla.Name = "grpTabla";
            this.grpTabla.Size = new System.Drawing.Size(489, 312);
            this.grpTabla.TabIndex = 16;
            // 
            // btnGuardarD
            // 
            this.btnGuardarD.Location = new System.Drawing.Point(377, 243);
            this.btnGuardarD.Name = "btnGuardarD";
            this.btnGuardarD.Size = new System.Drawing.Size(70, 49);
            this.btnGuardarD.TabIndex = 23;
            this.btnGuardarD.Text = "Guardar datos";
            this.btnGuardarD.UseVisualStyleBackColor = true;
            this.btnGuardarD.Click += new System.EventHandler(this.Escribir_txt);
            // 
            // lblTACuota
            // 
            this.lblTACuota.AutoSize = true;
            this.lblTACuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTACuota.Location = new System.Drawing.Point(37, 272);
            this.lblTACuota.Name = "lblTACuota";
            this.lblTACuota.Size = new System.Drawing.Size(70, 15);
            this.lblTACuota.TabIndex = 22;
            this.lblTACuota.Text = "Total cuota:";
            // 
            // lblTInteres
            // 
            this.lblTInteres.AutoSize = true;
            this.lblTInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTInteres.Location = new System.Drawing.Point(37, 249);
            this.lblTInteres.Name = "lblTInteres";
            this.lblTInteres.Size = new System.Drawing.Size(90, 15);
            this.lblTInteres.TabIndex = 21;
            this.lblTInteres.Text = "Total Intereses:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(303, 243);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(68, 49);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.CambiarVentana);
            // 
            // lblnteresFinal
            // 
            this.lblnteresFinal.AutoSize = true;
            this.lblnteresFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnteresFinal.Location = new System.Drawing.Point(300, 12);
            this.lblnteresFinal.Name = "lblnteresFinal";
            this.lblnteresFinal.Size = new System.Drawing.Size(51, 16);
            this.lblnteresFinal.TabIndex = 19;
            this.lblnteresFinal.Text = "Interes:";
            this.lblnteresFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(300, 44);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(45, 16);
            this.lblPlazo.TabIndex = 18;
            this.lblPlazo.Text = "Plazo:";
            this.lblPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(38, 43);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(48, 16);
            this.lblMonto.TabIndex = 17;
            this.lblMonto.Text = "Monto:";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.grpTabla);
            this.MaximumSize = new System.Drawing.Size(499, 415);
            this.MinimumSize = new System.Drawing.Size(499, 415);
            this.Name = "Usuario";
            this.Text = "Registro | Prestamos express";
            ((System.ComponentModel.ISupportInitialize)(this.vistaImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAmortizacion)).EndInit();
            this.grpTabla.ResumeLayout(false);
            this.grpTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.PictureBox vistaImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel grpRegistro;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView tblAmortizacion;
        private System.Windows.Forms.Panel grpTabla;
        private System.Windows.Forms.Label lblnteresFinal;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTACuota;
        private System.Windows.Forms.Label lblTInteres;
        private System.Windows.Forms.Button btnGuardarD;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

