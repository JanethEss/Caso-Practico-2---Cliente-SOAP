namespace ClienteSOAP_ConversorMoneda
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
            this.btn_mxn = new System.Windows.Forms.PictureBox();
            this.lbl_mxn = new System.Windows.Forms.Label();
            this.lbl_usd = new System.Windows.Forms.Label();
            this.btn_usd = new System.Windows.Forms.PictureBox();
            this.lbl_cop = new System.Windows.Forms.Label();
            this.btn_cop = new System.Windows.Forms.PictureBox();
            this.lbl_eur = new System.Windows.Forms.Label();
            this.btn_eur = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mxn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSOR DE MONEDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la moneda que desea convertir:";
            // 
            // btn_mxn
            // 
            this.btn_mxn.BackColor = System.Drawing.Color.Transparent;
            this.btn_mxn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mxn.Image = ((System.Drawing.Image)(resources.GetObject("btn_mxn.Image")));
            this.btn_mxn.Location = new System.Drawing.Point(50, 134);
            this.btn_mxn.Name = "btn_mxn";
            this.btn_mxn.Size = new System.Drawing.Size(115, 71);
            this.btn_mxn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_mxn.TabIndex = 2;
            this.btn_mxn.TabStop = false;
            this.btn_mxn.Click += new System.EventHandler(this.btn_mxn_Click);
            // 
            // lbl_mxn
            // 
            this.lbl_mxn.AutoSize = true;
            this.lbl_mxn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mxn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_mxn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mxn.Location = new System.Drawing.Point(52, 208);
            this.lbl_mxn.Name = "lbl_mxn";
            this.lbl_mxn.Size = new System.Drawing.Size(113, 13);
            this.lbl_mxn.TabIndex = 3;
            this.lbl_mxn.Text = "MXN (Peso Mexicano)";
            this.lbl_mxn.Click += new System.EventHandler(this.lbl_mxn_Click);
            // 
            // lbl_usd
            // 
            this.lbl_usd.AutoSize = true;
            this.lbl_usd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_usd.Location = new System.Drawing.Point(193, 208);
            this.lbl_usd.Name = "lbl_usd";
            this.lbl_usd.Size = new System.Drawing.Size(143, 13);
            this.lbl_usd.TabIndex = 5;
            this.lbl_usd.Text = "USD (Dolar Estadounidense)";
            this.lbl_usd.Click += new System.EventHandler(this.lbl_usd_Click);
            // 
            // btn_usd
            // 
            this.btn_usd.BackColor = System.Drawing.Color.Transparent;
            this.btn_usd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usd.Image = ((System.Drawing.Image)(resources.GetObject("btn_usd.Image")));
            this.btn_usd.Location = new System.Drawing.Point(209, 134);
            this.btn_usd.Name = "btn_usd";
            this.btn_usd.Size = new System.Drawing.Size(115, 71);
            this.btn_usd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_usd.TabIndex = 4;
            this.btn_usd.TabStop = false;
            this.btn_usd.Click += new System.EventHandler(this.btn_usd_Click);
            // 
            // lbl_cop
            // 
            this.lbl_cop.AutoSize = true;
            this.lbl_cop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cop.Location = new System.Drawing.Point(47, 336);
            this.lbl_cop.Name = "lbl_cop";
            this.lbl_cop.Size = new System.Drawing.Size(120, 13);
            this.lbl_cop.TabIndex = 7;
            this.lbl_cop.Text = "COP (Peso Colombiano)";
            this.lbl_cop.Click += new System.EventHandler(this.lbl_cop_Click);
            // 
            // btn_cop
            // 
            this.btn_cop.BackColor = System.Drawing.Color.Transparent;
            this.btn_cop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cop.Image = ((System.Drawing.Image)(resources.GetObject("btn_cop.Image")));
            this.btn_cop.Location = new System.Drawing.Point(50, 262);
            this.btn_cop.Name = "btn_cop";
            this.btn_cop.Size = new System.Drawing.Size(115, 71);
            this.btn_cop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cop.TabIndex = 6;
            this.btn_cop.TabStop = false;
            this.btn_cop.Click += new System.EventHandler(this.btn_cop_Click);
            // 
            // lbl_eur
            // 
            this.lbl_eur.AutoSize = true;
            this.lbl_eur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_eur.Location = new System.Drawing.Point(241, 336);
            this.lbl_eur.Name = "lbl_eur";
            this.lbl_eur.Size = new System.Drawing.Size(61, 13);
            this.lbl_eur.TabIndex = 9;
            this.lbl_eur.Text = "EUR (Euro)";
            this.lbl_eur.Click += new System.EventHandler(this.lbl_eur_Click);
            // 
            // btn_eur
            // 
            this.btn_eur.BackColor = System.Drawing.Color.Transparent;
            this.btn_eur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eur.Image = ((System.Drawing.Image)(resources.GetObject("btn_eur.Image")));
            this.btn_eur.Location = new System.Drawing.Point(209, 262);
            this.btn_eur.Name = "btn_eur";
            this.btn_eur.Size = new System.Drawing.Size(115, 71);
            this.btn_eur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_eur.TabIndex = 8;
            this.btn_eur.TabStop = false;
            this.btn_eur.Click += new System.EventHandler(this.btn_eur_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(136, 384);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(114, 23);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar conversor";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 432);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_eur);
            this.Controls.Add(this.btn_eur);
            this.Controls.Add(this.lbl_cop);
            this.Controls.Add(this.btn_cop);
            this.Controls.Add(this.lbl_usd);
            this.Controls.Add(this.btn_usd);
            this.Controls.Add(this.lbl_mxn);
            this.Controls.Add(this.btn_mxn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conversor de monedas";
            ((System.ComponentModel.ISupportInitialize)(this.btn_mxn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_usd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_mxn;
        private System.Windows.Forms.Label lbl_mxn;
        private System.Windows.Forms.Label lbl_usd;
        private System.Windows.Forms.PictureBox btn_usd;
        private System.Windows.Forms.Label lbl_cop;
        private System.Windows.Forms.PictureBox btn_cop;
        private System.Windows.Forms.Label lbl_eur;
        private System.Windows.Forms.PictureBox btn_eur;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

