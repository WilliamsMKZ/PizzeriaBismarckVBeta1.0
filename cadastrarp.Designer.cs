namespace PizzeriaCrud
{
    partial class cadastrarp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarp));
            this.tstId = new System.Windows.Forms.Label();
            this.tst = new System.Windows.Forms.Label();
            this.txtSABORP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTAMANHOP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarp = new System.Windows.Forms.PictureBox();
            this.mskPreçop = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tstId
            // 
            this.tstId.AutoSize = true;
            this.tstId.BackColor = System.Drawing.Color.Transparent;
            this.tstId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstId.ForeColor = System.Drawing.Color.White;
            this.tstId.Location = new System.Drawing.Point(21, 103);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(31, 25);
            this.tstId.TabIndex = 1;
            this.tstId.Text = "ID";
            this.tstId.Click += new System.EventHandler(this.tstId_Click);
            // 
            // tst
            // 
            this.tst.AutoSize = true;
            this.tst.BackColor = System.Drawing.Color.Transparent;
            this.tst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst.ForeColor = System.Drawing.Color.White;
            this.tst.Location = new System.Drawing.Point(21, 164);
            this.tst.Name = "tst";
            this.tst.Size = new System.Drawing.Size(148, 25);
            this.tst.TabIndex = 2;
            this.tst.Text = "Sabor Da Pizza";
            // 
            // txtSABORP
            // 
            this.txtSABORP.Location = new System.Drawing.Point(26, 192);
            this.txtSABORP.Name = "txtSABORP";
            this.txtSABORP.Size = new System.Drawing.Size(140, 20);
            this.txtSABORP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamanho Da Pizza";
            // 
            // txtTAMANHOP
            // 
            this.txtTAMANHOP.Location = new System.Drawing.Point(26, 252);
            this.txtTAMANHOP.Name = "txtTAMANHOP";
            this.txtTAMANHOP.Size = new System.Drawing.Size(140, 20);
            this.txtTAMANHOP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço Da Pizza";
            // 
            // btnCadastrarp
            // 
            this.btnCadastrarp.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarp.BackgroundImage")));
            this.btnCadastrarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrarp.Location = new System.Drawing.Point(26, 409);
            this.btnCadastrarp.MaximumSize = new System.Drawing.Size(140, 54);
            this.btnCadastrarp.MinimumSize = new System.Drawing.Size(140, 54);
            this.btnCadastrarp.Name = "btnCadastrarp";
            this.btnCadastrarp.Size = new System.Drawing.Size(140, 54);
            this.btnCadastrarp.TabIndex = 8;
            this.btnCadastrarp.TabStop = false;
            this.btnCadastrarp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mskPreçop
            // 
            this.mskPreçop.Location = new System.Drawing.Point(26, 316);
            this.mskPreçop.Mask = "$00.00";
            this.mskPreçop.Name = "mskPreçop";
            this.mskPreçop.Size = new System.Drawing.Size(140, 20);
            this.mskPreçop.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(26, 132);
            this.txtID.Mask = "00000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 20);
            this.txtID.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(190, 409);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(140, 54);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(140, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 54);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(357, 409);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(140, 54);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(140, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 54);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // cadastrarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(925, 521);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.mskPreçop);
            this.Controls.Add(this.btnCadastrarp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTAMANHOP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSABORP);
            this.Controls.Add(this.tst);
            this.Controls.Add(this.tstId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(941, 559);
            this.MinimumSize = new System.Drawing.Size(941, 559);
            this.Name = "cadastrarp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pedido";
            this.Load += new System.EventHandler(this.cadastrarp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tstId;
        private System.Windows.Forms.Label tst;
        private System.Windows.Forms.TextBox txtSABORP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTAMANHOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnCadastrarp;
        private System.Windows.Forms.MaskedTextBox mskPreçop;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}