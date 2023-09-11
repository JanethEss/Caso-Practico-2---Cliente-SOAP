﻿namespace ClienteSOAP_ConversorMoneda
{
    partial class ConvertirUSDa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertirUSDa));
            this.btn_EUR = new System.Windows.Forms.Button();
            this.btn_COP = new System.Windows.Forms.Button();
            this.lblPrefijo = new System.Windows.Forms.Label();
            this.txt_Res = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_MXN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bandera = new System.Windows.Forms.PictureBox();
            this.ingresarUSD = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandera)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EUR
            // 
            this.btn_EUR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_EUR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EUR.Location = new System.Drawing.Point(137, 201);
            this.btn_EUR.Name = "btn_EUR";
            this.btn_EUR.Size = new System.Drawing.Size(170, 23);
            this.btn_EUR.TabIndex = 26;
            this.btn_EUR.Text = "EUR (Euro)";
            this.btn_EUR.UseVisualStyleBackColor = false;
            this.btn_EUR.Click += new System.EventHandler(this.btn_EUR_Click);
            // 
            // btn_COP
            // 
            this.btn_COP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_COP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_COP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_COP.Location = new System.Drawing.Point(138, 172);
            this.btn_COP.Name = "btn_COP";
            this.btn_COP.Size = new System.Drawing.Size(171, 23);
            this.btn_COP.TabIndex = 25;
            this.btn_COP.Text = "COP (Peso Colombiano)";
            this.btn_COP.UseVisualStyleBackColor = false;
            this.btn_COP.Click += new System.EventHandler(this.btn_COP_Click);
            // 
            // lblPrefijo
            // 
            this.lblPrefijo.AutoSize = true;
            this.lblPrefijo.BackColor = System.Drawing.Color.Transparent;
            this.lblPrefijo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefijo.Location = new System.Drawing.Point(367, 78);
            this.lblPrefijo.Name = "lblPrefijo";
            this.lblPrefijo.Size = new System.Drawing.Size(0, 19);
            this.lblPrefijo.TabIndex = 24;
            // 
            // txt_Res
            // 
            this.txt_Res.Location = new System.Drawing.Point(261, 77);
            this.txt_Res.Name = "txt_Res";
            this.txt_Res.ReadOnly = true;
            this.txt_Res.Size = new System.Drawing.Size(100, 20);
            this.txt_Res.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btn_MXN
            // 
            this.btn_MXN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_MXN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MXN.Location = new System.Drawing.Point(138, 143);
            this.btn_MXN.Name = "btn_MXN";
            this.btn_MXN.Size = new System.Drawing.Size(170, 23);
            this.btn_MXN.TabIndex = 21;
            this.btn_MXN.Text = "MXN (Peso Mexicano)";
            this.btn_MXN.UseVisualStyleBackColor = false;
            this.btn_MXN.Click += new System.EventHandler(this.btn_MXN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "USD";
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(41, 77);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(100, 20);
            this.txtUSD.TabIndex = 19;
            this.txtUSD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtUSD_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Convertir dolar estadounidense a:";
            // 
            // bandera
            // 
            this.bandera.BackColor = System.Drawing.Color.Transparent;
            this.bandera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bandera.Image = ((System.Drawing.Image)(resources.GetObject("bandera.Image")));
            this.bandera.Location = new System.Drawing.Point(365, 12);
            this.bandera.Name = "bandera";
            this.bandera.Size = new System.Drawing.Size(57, 38);
            this.bandera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bandera.TabIndex = 17;
            this.bandera.TabStop = false;
            // 
            // ConvertirUSDa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 242);
            this.Controls.Add(this.btn_EUR);
            this.Controls.Add(this.btn_COP);
            this.Controls.Add(this.lblPrefijo);
            this.Controls.Add(this.txt_Res);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_MXN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bandera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertirUSDa";
            this.Text = "ConvertirUSDa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EUR;
        private System.Windows.Forms.Button btn_COP;
        private System.Windows.Forms.Label lblPrefijo;
        private System.Windows.Forms.TextBox txt_Res;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_MXN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bandera;
        private System.Windows.Forms.ToolTip ingresarUSD;
    }
}