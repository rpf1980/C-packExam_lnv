namespace Ejercicio_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTbName = new System.Windows.Forms.TextBox();
            this.idBtnAdd = new System.Windows.Forms.Button();
            this.idListBox = new System.Windows.Forms.ListBox();
            this.idBtnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(135, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(147, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA";
            // 
            // idTbName
            // 
            this.idTbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.idTbName.Location = new System.Drawing.Point(212, 23);
            this.idTbName.Margin = new System.Windows.Forms.Padding(4);
            this.idTbName.Name = "idTbName";
            this.idTbName.Size = new System.Drawing.Size(194, 25);
            this.idTbName.TabIndex = 2;
            // 
            // idBtnAdd
            // 
            this.idBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.idBtnAdd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAdd.Location = new System.Drawing.Point(423, 23);
            this.idBtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.idBtnAdd.Name = "idBtnAdd";
            this.idBtnAdd.Size = new System.Drawing.Size(77, 24);
            this.idBtnAdd.TabIndex = 3;
            this.idBtnAdd.Text = "AÑADIR";
            this.idBtnAdd.UseVisualStyleBackColor = false;
            this.idBtnAdd.Click += new System.EventHandler(this.idBtnAdd_Click);
            // 
            // idListBox
            // 
            this.idListBox.FormattingEnabled = true;
            this.idListBox.ItemHeight = 18;
            this.idListBox.Location = new System.Drawing.Point(166, 126);
            this.idListBox.Margin = new System.Windows.Forms.Padding(4);
            this.idListBox.Name = "idListBox";
            this.idListBox.Size = new System.Drawing.Size(155, 184);
            this.idListBox.TabIndex = 4;
            // 
            // idBtnDel
            // 
            this.idBtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.idBtnDel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnDel.Location = new System.Drawing.Point(172, 309);
            this.idBtnDel.Margin = new System.Windows.Forms.Padding(4);
            this.idBtnDel.Name = "idBtnDel";
            this.idBtnDel.Size = new System.Drawing.Size(81, 22);
            this.idBtnDel.TabIndex = 5;
            this.idBtnDel.Text = "ELIMINAR";
            this.idBtnDel.UseVisualStyleBackColor = false;
            this.idBtnDel.Click += new System.EventHandler(this.idBtnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Ejercicio_02.Properties.Resources.responsive;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(785, 428);
            this.Controls.Add(this.idBtnDel);
            this.Controls.Add(this.idListBox);
            this.Controls.Add(this.idBtnAdd);
            this.Controls.Add(this.idTbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ELEMENTOS LISTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTbName;
        private System.Windows.Forms.Button idBtnAdd;
        private System.Windows.Forms.ListBox idListBox;
        private System.Windows.Forms.Button idBtnDel;
    }
}

