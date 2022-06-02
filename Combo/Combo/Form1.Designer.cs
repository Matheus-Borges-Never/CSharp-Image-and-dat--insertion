namespace Combo
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
            this.cmbTexto = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.btnImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTexto
            // 
            this.cmbTexto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbTexto.FormattingEnabled = true;
            this.cmbTexto.Location = new System.Drawing.Point(103, 137);
            this.cmbTexto.Name = "cmbTexto";
            this.cmbTexto.Size = new System.Drawing.Size(199, 21);
            this.cmbTexto.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(326, 76);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(127, 32);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFrase.Location = new System.Drawing.Point(103, 84);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(199, 20);
            this.txtFrase.TabIndex = 3;
            this.txtFrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrase_KeyPress);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(326, 129);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(127, 32);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // ptbImagem
            // 
            this.ptbImagem.Location = new System.Drawing.Point(103, 189);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(199, 260);
            this.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagem.TabIndex = 5;
            this.ptbImagem.TabStop = false;
            // 
            // btnImagem
            // 
            this.btnImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem.Location = new System.Drawing.Point(326, 224);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(127, 32);
            this.btnImagem.TabIndex = 6;
            this.btnImagem.Text = "Carregar Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 472);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.ptbImagem);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cmbTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTexto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox ptbImagem;
        private System.Windows.Forms.Button btnImagem;
    }
}

