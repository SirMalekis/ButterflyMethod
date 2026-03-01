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

        private void buttonSCR_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"С://";
            sfd.RestoreDirectory = true;
            sfd.FileName = "Скриншот результата работы программы";
            sfd.DefaultExt = "JPG";
            sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics graph = Graphics.FromImage(bitmap))
                    {
                        graph.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }
                    //bitmap.Save("C://screen.jpg", ImageFormat.Jpeg);
                    bitmap.Save(sfd.FileName);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int chisl1, chisl2, znam1, znam2, chisl, znam;

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
