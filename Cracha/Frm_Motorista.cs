using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Cracha_NextTeamBr
{
    public partial class Frm_Motorista : Form
    {
        public Frm_Motorista()
        {
            InitializeComponent();
        }

        private void Frm_Motorista_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.None;

                Point point = new Point();
                Rectangle rectangle = new Rectangle(point, this.Size);
                Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppRgb);
                this.DrawToBitmap(bitmap, rectangle);
                bitmap.Save($"Crachas/{Txt_Nome.Text}.png", ImageFormat.Png);

                this.FormBorderStyle = FormBorderStyle.Fixed3D;

                MessageBox.Show($"{Txt_Nome.Text} registrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro : {exc.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }           
        }

        private void Pic_Motorista_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pic_Motorista.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    Txt_Nome.Font = fontDialog1.Font;
                }
            }
        }

        private void Txt_NomeCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    Txt_NomeCompleto.Font = fontDialog1.Font;
                }
            }
        }

        private void Txt_Cidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    Txt_Cidade.Font = fontDialog1.Font;
                }
            }
        }

        private void Txt_Admicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    Txt_Admicao.Font = fontDialog1.Font;
                }
            }
        }
    }
}
