namespace Cracha_NextTeamBr
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btm_Motorista = new System.Windows.Forms.Button();
            this.Btm_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btm_Motorista
            // 
            this.Btm_Motorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btm_Motorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Motorista.Location = new System.Drawing.Point(12, 12);
            this.Btm_Motorista.Name = "Btm_Motorista";
            this.Btm_Motorista.Size = new System.Drawing.Size(129, 57);
            this.Btm_Motorista.TabIndex = 0;
            this.Btm_Motorista.Text = "Motorista";
            this.Btm_Motorista.UseVisualStyleBackColor = true;
            this.Btm_Motorista.Click += new System.EventHandler(this.Btm_Motorista_Click);
            // 
            // Btm_Admin
            // 
            this.Btm_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btm_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Admin.Location = new System.Drawing.Point(223, 15);
            this.Btm_Admin.Name = "Btm_Admin";
            this.Btm_Admin.Size = new System.Drawing.Size(129, 57);
            this.Btm_Admin.TabIndex = 1;
            this.Btm_Admin.Text = "Administrador";
            this.Btm_Admin.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 84);
            this.Controls.Add(this.Btm_Admin);
            this.Controls.Add(this.Btm_Motorista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nex Team BR";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btm_Motorista;
        private System.Windows.Forms.Button Btm_Admin;
    }
}

