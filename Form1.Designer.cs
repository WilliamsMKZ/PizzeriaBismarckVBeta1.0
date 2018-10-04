namespace PizzeriaCrud
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCadastrarpizza = new System.Windows.Forms.PictureBox();
            this.btnBuscarpizza = new System.Windows.Forms.PictureBox();
            this.btnAlterarpizza = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarpizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarpizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarpizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarpizza
            // 
            this.btnCadastrarpizza.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarpizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarpizza.BackgroundImage")));
            this.btnCadastrarpizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrarpizza.Location = new System.Drawing.Point(125, 274);
            this.btnCadastrarpizza.Name = "btnCadastrarpizza";
            this.btnCadastrarpizza.Size = new System.Drawing.Size(154, 130);
            this.btnCadastrarpizza.TabIndex = 0;
            this.btnCadastrarpizza.TabStop = false;
            this.btnCadastrarpizza.Click += new System.EventHandler(this.cadastrarpizza_Click);
            // 
            // btnBuscarpizza
            // 
            this.btnBuscarpizza.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarpizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarpizza.BackgroundImage")));
            this.btnBuscarpizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarpizza.Location = new System.Drawing.Point(379, 274);
            this.btnBuscarpizza.Name = "btnBuscarpizza";
            this.btnBuscarpizza.Size = new System.Drawing.Size(154, 130);
            this.btnBuscarpizza.TabIndex = 1;
            this.btnBuscarpizza.TabStop = false;
            this.btnBuscarpizza.Click += new System.EventHandler(this.buscarpizza_Click);
            // 
            // btnAlterarpizza
            // 
            this.btnAlterarpizza.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarpizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarpizza.BackgroundImage")));
            this.btnAlterarpizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterarpizza.Location = new System.Drawing.Point(643, 274);
            this.btnAlterarpizza.Name = "btnAlterarpizza";
            this.btnAlterarpizza.Size = new System.Drawing.Size(154, 130);
            this.btnAlterarpizza.TabIndex = 2;
            this.btnAlterarpizza.TabStop = false;
            this.btnAlterarpizza.Click += new System.EventHandler(this.alterarpizza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(855, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 41);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(920, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAlterarpizza);
            this.Controls.Add(this.btnBuscarpizza);
            this.Controls.Add(this.btnCadastrarpizza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(936, 555);
            this.MinimumSize = new System.Drawing.Size(936, 555);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria Bismarck  -  V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarpizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarpizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarpizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCadastrarpizza;
        private System.Windows.Forms.PictureBox btnBuscarpizza;
        private System.Windows.Forms.PictureBox btnAlterarpizza;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

