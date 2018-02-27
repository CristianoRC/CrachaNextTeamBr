namespace Cracha_NextTeamBr
{
    partial class Frm_Motorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Motorista));
            this.Pic_Motorista = new System.Windows.Forms.PictureBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Txt_NomeCompleto = new System.Windows.Forms.TextBox();
            this.Txt_Admicao = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Motorista)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Motorista
            // 
            this.Pic_Motorista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Motorista.BackColor = System.Drawing.Color.Gainsboro;
            this.Pic_Motorista.Location = new System.Drawing.Point(166, 193);
            this.Pic_Motorista.Name = "Pic_Motorista";
            this.Pic_Motorista.Size = new System.Drawing.Size(199, 240);
            this.Pic_Motorista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Motorista.TabIndex = 1;
            this.Pic_Motorista.TabStop = false;
            this.Pic_Motorista.Click += new System.EventHandler(this.Pic_Motorista_Click);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_Nome.Location = new System.Drawing.Point(248, 496);
            this.Txt_Nome.Multiline = true;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(218, 30);
            this.Txt_Nome.TabIndex = 0;
            this.Txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Nome_KeyDown);
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cidade.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_Cidade.Location = new System.Drawing.Point(185, 593);
            this.Txt_Cidade.Multiline = true;
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(281, 22);
            this.Txt_Cidade.TabIndex = 2;
            this.Txt_Cidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Cidade_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Txt_NomeCompleto
            // 
            this.Txt_NomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NomeCompleto.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_NomeCompleto.Location = new System.Drawing.Point(185, 552);
            this.Txt_NomeCompleto.Multiline = true;
            this.Txt_NomeCompleto.Name = "Txt_NomeCompleto";
            this.Txt_NomeCompleto.Size = new System.Drawing.Size(281, 22);
            this.Txt_NomeCompleto.TabIndex = 1;
            this.Txt_NomeCompleto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NomeCompleto_KeyDown);
            // 
            // Txt_Admicao
            // 
            this.Txt_Admicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Admicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Admicao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Admicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_Admicao.Location = new System.Drawing.Point(356, 639);
            this.Txt_Admicao.Multiline = true;
            this.Txt_Admicao.Name = "Txt_Admicao";
            this.Txt_Admicao.Size = new System.Drawing.Size(116, 23);
            this.Txt_Admicao.TabIndex = 3;
            this.Txt_Admicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Admicao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Admicao_KeyDown);
            // 
            // Frm_Motorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 737);
            this.Controls.Add(this.Txt_Admicao);
            this.Controls.Add(this.Txt_NomeCompleto);
            this.Controls.Add(this.Txt_Cidade);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Pic_Motorista);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Motorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorista";
            this.DoubleClick += new System.EventHandler(this.Frm_Motorista_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Motorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Motorista;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Txt_NomeCompleto;
        private System.Windows.Forms.TextBox Txt_Admicao;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}