namespace Ejercicio_01
{
    partial class rootPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rootPanel));
            this.idLbCadena = new System.Windows.Forms.Label();
            this.idLbCaracter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTbCadena = new System.Windows.Forms.TextBox();
            this.idTbResultado = new System.Windows.Forms.TextBox();
            this.cmbVocales = new System.Windows.Forms.ComboBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLbCadena
            // 
            this.idLbCadena.AutoSize = true;
            this.idLbCadena.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbCadena.Location = new System.Drawing.Point(30, 42);
            this.idLbCadena.Name = "idLbCadena";
            this.idLbCadena.Size = new System.Drawing.Size(69, 22);
            this.idLbCadena.TabIndex = 0;
            this.idLbCadena.Text = "CADENA";
            // 
            // idLbCaracter
            // 
            this.idLbCaracter.AutoSize = true;
            this.idLbCaracter.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbCaracter.Location = new System.Drawing.Point(30, 101);
            this.idLbCaracter.Name = "idLbCaracter";
            this.idLbCaracter.Size = new System.Drawing.Size(88, 22);
            this.idLbCaracter.TabIndex = 1;
            this.idLbCaracter.Text = "CARACTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESULTADO";
            // 
            // idTbCadena
            // 
            this.idTbCadena.Location = new System.Drawing.Point(161, 40);
            this.idTbCadena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTbCadena.Name = "idTbCadena";
            this.idTbCadena.Size = new System.Drawing.Size(225, 22);
            this.idTbCadena.TabIndex = 3;
            // 
            // idTbResultado
            // 
            this.idTbResultado.Location = new System.Drawing.Point(141, 211);
            this.idTbResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTbResultado.Multiline = true;
            this.idTbResultado.Name = "idTbResultado";
            this.idTbResultado.Size = new System.Drawing.Size(289, 135);
            this.idTbResultado.TabIndex = 4;
            // 
            // cmbVocales
            // 
            this.cmbVocales.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVocales.FormattingEnabled = true;
            this.cmbVocales.Items.AddRange(new object[] {
            "A",
            "E",
            "I",
            "O",
            "U",
            "a",
            "e",
            "i",
            "o",
            "u"});
            this.cmbVocales.Location = new System.Drawing.Point(161, 101);
            this.cmbVocales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVocales.Name = "cmbVocales";
            this.cmbVocales.Size = new System.Drawing.Size(121, 23);
            this.cmbVocales.TabIndex = 5;
            this.cmbVocales.Text = "Vocales";
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.Turquoise;
            this.btnContar.Location = new System.Drawing.Point(161, 155);
            this.btnContar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 24);
            this.btnContar.TabIndex = 6;
            this.btnContar.Text = "CONTAR";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Turquoise;
            this.btnEliminar.Location = new System.Drawing.Point(309, 155);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 24);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rootPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(526, 387);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.cmbVocales);
            this.Controls.Add(this.idTbResultado);
            this.Controls.Add(this.idTbCadena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLbCaracter);
            this.Controls.Add(this.idLbCadena);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rootPanel";
            this.Text = "TRABAJAR CON CADENAS";
            this.Load += new System.EventHandler(this.rootPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLbCadena;
        private System.Windows.Forms.Label idLbCaracter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTbCadena;
        private System.Windows.Forms.TextBox idTbResultado;
        private System.Windows.Forms.ComboBox cmbVocales;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

