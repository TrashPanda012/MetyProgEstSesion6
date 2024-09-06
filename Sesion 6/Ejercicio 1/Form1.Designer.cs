namespace Ejercicio_1
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
            this.lbnombre = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cmbnombres = new System.Windows.Forms.ComboBox();
            this.cmbnombres2 = new System.Windows.Forms.ComboBox();
            this.btnmover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(21, 44);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(87, 25);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre";
            this.lbnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.BackColor = System.Drawing.Color.Cornsilk;
            this.tbnombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbnombre.Location = new System.Drawing.Point(129, 47);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(532, 22);
            this.tbnombre.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Ejercicio_1.Properties.Resources.agregar_producto;
            this.btnagregar.Location = new System.Drawing.Point(696, 32);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(63, 55);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cmbnombres
            // 
            this.cmbnombres.FormattingEnabled = true;
            this.cmbnombres.Location = new System.Drawing.Point(129, 174);
            this.cmbnombres.Name = "cmbnombres";
            this.cmbnombres.Size = new System.Drawing.Size(532, 24);
            this.cmbnombres.TabIndex = 3;
            // 
            // cmbnombres2
            // 
            this.cmbnombres2.FormattingEnabled = true;
            this.cmbnombres2.Location = new System.Drawing.Point(129, 295);
            this.cmbnombres2.Name = "cmbnombres2";
            this.cmbnombres2.Size = new System.Drawing.Size(532, 24);
            this.cmbnombres2.TabIndex = 4;
            this.cmbnombres2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnmover
            // 
            this.btnmover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmover.Location = new System.Drawing.Point(129, 219);
            this.btnmover.Name = "btnmover";
            this.btnmover.Size = new System.Drawing.Size(532, 52);
            this.btnmover.TabIndex = 5;
            this.btnmover.Text = "Mover todos los elementos";
            this.btnmover.UseVisualStyleBackColor = true;
            this.btnmover.Click += new System.EventHandler(this.btnmover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmover);
            this.Controls.Add(this.cmbnombres2);
            this.Controls.Add(this.cmbnombres);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.lbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cmbnombres;
        private System.Windows.Forms.ComboBox cmbnombres2;
        private System.Windows.Forms.Button btnmover;
    }
}

