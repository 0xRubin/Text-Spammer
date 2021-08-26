using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Spammer
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        Point lastPoint;
        public Main()
        {
            InitializeComponent();
            //Rounded Corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
        }
        //Exit Form
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Minimize Window
        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        //Draggable Form
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //Text Spammer
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (checkBox1.Checked)
                {
                    if (GetAsyncKeyState(Keys.XButton1) < 0)
                    {
                        try
                        {
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("No Text!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox2.Checked)
                            {
                                MessageBox.Show("Another spammer is active(2)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox3.Checked)
                            {
                                MessageBox.Show("Another spammer is active(3)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox4.Checked)
                            {
                                MessageBox.Show("Another spammer is active(4)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                SendKeys.SendWait(textBox1.Text + "{ENTER}");
                                Thread.Sleep(250);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                Thread.Sleep(10);

                if (checkBox2.Checked)
                {
                    if (GetAsyncKeyState(Keys.XButton1) < 0)
                    {
                        try

                        {
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("No Text!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox1.Checked)
                            {
                                MessageBox.Show("Another spammer is active(1)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox3.Checked)
                            {
                                MessageBox.Show("Another spammer is active(3)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox4.Checked)
                            {
                                MessageBox.Show("Another spammer is active(4)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                SendKeys.SendWait("{T}" + textBox1.Text + "{ENTER}");
                                Thread.Sleep(150);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                Thread.Sleep(10);

                if (checkBox3.Checked)
                {
                    if (GetAsyncKeyState(Keys.XButton1) < 0)
                    {
                        try
                        {
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("No Text!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox1.Checked)
                            {
                                MessageBox.Show("Another spammer is active(1)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox2.Checked)
                            {
                                MessageBox.Show("Another spammer is active(2)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox4.Checked)
                            {
                                MessageBox.Show("Another spammer is active(4)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                SendKeys.SendWait("{Y}" + textBox1.Text + "{ENTER}");
                                Thread.Sleep(150);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                Thread.Sleep(10);

                if (checkBox4.Checked)
                {
                    if (GetAsyncKeyState(Keys.XButton1) < 0)
                    {
                        try
                        {
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("No Text!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox1.Checked)
                            {
                                MessageBox.Show("Another spammer is active(1)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox2.Checked)
                            {
                                MessageBox.Show("Another spammer is active(2)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            };
                            if (checkBox3.Checked)
                            {
                                MessageBox.Show("Another spammer is active(3)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                SendKeys.SendWait("{ENTER}" + textBox1.Text + "{ENTER}");
                                Thread.Sleep(150);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                Thread.Sleep(10);
            }
        }

        //Credits
        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://discord.gg/xP6fw8h93P";
            var process = new System.Diagnostics.ProcessStartInfo();
            process.UseShellExecute = true;
            process.FileName = url;
            System.Diagnostics.Process.Start(process);
        }
    }
}