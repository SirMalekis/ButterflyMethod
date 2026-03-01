using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButterFly
{
    public partial class ButterflyMethod : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        public ButterflyMethod()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastpoint;

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем пустую картинку размером с наше окно
                Bitmap bmp = new Bitmap(this.Width, this.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Получаем контекст графики и просим Windows "сфотографировать" окно по его хэндлу
                    IntPtr hdc = g.GetHdc();
                    PrintWindow(this.Handle, hdc, 0); // 0 означает захват всего окна вместе с рамками
                    g.ReleaseHdc(hdc);
                }

                // Диалог сохранения файла
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    sfd.Title = "Сохранить скриншот метода Бабочки";
                    sfd.FileName = "Butterfly_Screenshot.png";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // Определяем формат в зависимости от расширения
                        System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
                        if (sfd.FileName.EndsWith("jpg")) format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        else if (sfd.FileName.EndsWith("bmp")) format = System.Drawing.Imaging.ImageFormat.Bmp;

                        // Сохраняем
                        bmp.Save(sfd.FileName, format);
                        MessageBox.Show("Скриншот успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении скриншота: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int chisl1, chisl2, znam1, znam2, chisl, znam;

                if (string.IsNullOrWhiteSpace(Chisl1.Text) || string.IsNullOrWhiteSpace(Znam1.Text) ||
                    string.IsNullOrWhiteSpace(Chisl2.Text) || string.IsNullOrWhiteSpace(Znam2.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля (числители и знаменатели).", 
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Znam1.Text == "0" || Znam2.Text == "0")
                {
                    MessageBox.Show("Знаменатель не может быть равен нулю!", "Ошибка математики",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                chisl1 = Convert.ToInt32(Chisl1.Text);
                znam1 = Convert.ToInt32(Znam1.Text);

                chisl2 = Convert.ToInt32(Chisl2.Text);
                znam2 = Convert.ToInt32(Znam2.Text);

                Head1.Text = Convert.ToString(chisl1 * znam2);
                Head2.Text = Convert.ToString(chisl2 * znam1);
                Tail.Text = Convert.ToString(znam1 * znam2);

                Sign.Text = Convert.ToString("+");
                SignHead.Text = Convert.ToString("+");

                chisl = Convert.ToInt32(chisl1 * znam2 + chisl2 * znam1);
                Chisl.Text = Convert.ToString(chisl);

                znam = Convert.ToInt32(znam1 * znam2);
                Znam.Text = Convert.ToString(znam);
            }
            catch
            {

            }
        }

        private void subtr_Click(object sender, EventArgs e)
        {
            try
            {
                int chisl1, chisl2, znam1, znam2, chisl, znam;

                if (string.IsNullOrWhiteSpace(Chisl1.Text) || string.IsNullOrWhiteSpace(Znam1.Text) || 
                    string.IsNullOrWhiteSpace(Chisl2.Text) || string.IsNullOrWhiteSpace(Znam2.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля (числители и знаменатели).",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Znam1.Text == "0" || Znam2.Text == "0")
                {
                    MessageBox.Show("Знаменатель не может быть равен нулю!", "Ошибка математики",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                chisl1 = Convert.ToInt32(Chisl1.Text);
                znam1 = Convert.ToInt32(Znam1.Text);

                chisl2 = Convert.ToInt32(Chisl2.Text);
                znam2 = Convert.ToInt32(Znam2.Text);

                Head1.Text = Convert.ToString(chisl1 * znam2);
                Head2.Text = Convert.ToString(chisl2 * znam1);
                Tail.Text = Convert.ToString(znam1 * znam2);

                Sign.Text = Convert.ToString("-");
                SignHead.Text = Convert.ToString("-");

                chisl = Convert.ToInt32(chisl1 * znam2 - chisl2 * znam1);
                Chisl.Text = Convert.ToString(chisl);

                znam = Convert.ToInt32(znam1 * znam2);
                Znam.Text = Convert.ToString(znam);
            }
            catch
            {

            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Chisl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsDigit(S) && S != 8)
                e.Handled = true;
        }

        private void Znam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsDigit(S) && S != 8)
                e.Handled = true;
        }

        private void Chisl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsDigit(S) && S != 8)
                e.Handled = true;
        }

        private void Znam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsDigit(S) && S != 8)
                e.Handled = true;
        }
    }
}
