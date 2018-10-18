using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flygplats
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl1.Location = new Point(-1000, -1000);
            lbl2.Location = new Point(-1000, -1000);

            Form1 Myform = new Form1();
            this.Hide();
            Myform.ShowDialog();
            this.Close();
        }



        private void tbx2_TextChanged(object sender, EventArgs e)
        {
            string oldText = string.Empty;

            if (tbx2.Text.All(chr => char.IsNumber(chr)))
            {

                oldText = tbx2.Text;
                tbx2.Text = oldText;

                tbx2.BackColor = System.Drawing.Color.White;
                tbx2.ForeColor = System.Drawing.Color.Black;

                if (tbx2.Text.Length == 10)
                {
                    tbx2.Enabled = false;
                    MessageBox.Show("If you have typed the wrong personal number, please click on the new button. It will clear your personal number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn3.Location = new Point(280, 163);
                }
            }
            else
            {
                tbx2.Text = oldText;
                tbx2.BackColor = System.Drawing.Color.Red;
                tbx2.ForeColor = System.Drawing.Color.Black;
                tbx2.SelectionStart = tbx2.Text.Length;
            }
        }



        private void tbx1_TextChanged(object sender, EventArgs e)
        {
            string oldText = string.Empty;

            if (tbx1.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = tbx1.Text;
                tbx1.Text = oldText;

                tbx1.BackColor = System.Drawing.Color.White;
                tbx1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbx1.Text = oldText;
                tbx1.BackColor = System.Drawing.Color.Red;
                tbx1.ForeColor = System.Drawing.Color.Black;
                tbx1.SelectionStart = tbx1.Text.Length;
            }

        }



        private void btn1_Click(object sender, EventArgs e)
        {
            

            if (tbx1.Text == "")
            {
                MessageBox.Show("You need to enter your firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx4.Text == "")
            {
                MessageBox.Show("You need to enter your lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx2.Text.Length < 10 || tbx2.Text.Length > 10)
            {
                MessageBox.Show("You need to have 10 digits on your personal number, don't include '-' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx3.Text == "")
            {
                MessageBox.Show("You need to enter your package weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbx1.SelectedIndex == -1)
            {
                MessageBox.Show("You need to enter your flightclass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                int vikt = int.Parse(tbx3.Text);

                if (vikt > 20 && cbx1.SelectedIndex == 0)
                {
                    lbl1.Location = new Point(118, 291);
                    lbl2.Location = new Point(237, 291);
                    lbl2.Text = "3000Kr";
                }
                else if (vikt <= 20 && cbx1.SelectedIndex == 0)
                {
                    lbl1.Location = new Point(118, 291);
                    lbl2.Location = new Point(237, 291);
                    lbl2.Text = "2000Kr";
                }
                else if (vikt > 20 && cbx1.SelectedIndex == 1)
                {
                    lbl1.Location = new Point(118, 291);
                    lbl2.Location = new Point(237, 291);
                    lbl2.Text = "5000Kr";
                }
                else if (vikt <= 20 && cbx1.SelectedIndex == 1)
                {
                    lbl1.Location = new Point(118, 291);
                    lbl2.Location = new Point(237, 291);
                    lbl2.Text = "4000Kr";
                }
            }
        } 

        private void btn3_Click(object sender, EventArgs e)
        {
            tbx2.Enabled = true;
            tbx2.Text = "";
            btn3.Location = new Point(-1000, -1000);
        }

        private void tbx3_TextChanged(object sender, EventArgs e)
        {
            string oldText = string.Empty;

            if (tbx3.TextLength == 3)
            {
             
             DialogResult dialogResult = MessageBox.Show("Now don't be silly... But if your weight really is over 3 digits then press yes", "Ehm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    tbx3.Text = "";
                    tbx3.Location = new Point(-1000, -1000);
                    tbx5.Location = new Point(108, 204);
                }
                else if (dialogResult == DialogResult.No)
                {
                    tbx3.Text = "";
                }
                 /* Fan att detta inte fungerade );
                  * if (tbx3.TextLength == 3)
                    {
                       DialogResult Ahop = MessageBox.Show("You said your weight was under 3 digits... If you want to change your mind then do so but you need to restart the applikation then", "omg...", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                        if (Ahop == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                        else if (Ahop == DialogResult.Cancel)
                        {
                            MessageBox.Show("Don't do the same misstake again ok?", "Learn from your mistakes.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbx3.Text = "";
                            if (tbx3.TextLength == 3)
                            {
                                Environment.Exit(0);
                            }
                        
                    }
                }*/
            }
            else if (tbx3.Text.All(chr => char.IsNumber(chr)))
            {
                oldText = tbx3.Text;
                tbx3.Text = oldText;

                tbx3.BackColor = System.Drawing.Color.White;
                tbx3.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbx3.Text = oldText;
                tbx3.BackColor = System.Drawing.Color.Red;
                tbx3.ForeColor = System.Drawing.Color.Black;
                tbx3.SelectionStart = tbx3.Text.Length;
            }
        }

        private void tbx4_TextChanged(object sender, EventArgs e)
        {
            string oldText = string.Empty;

            if (tbx4.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = tbx4.Text;
                tbx4.Text = oldText;

                tbx4.BackColor = System.Drawing.Color.White;
                tbx4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbx4.Text = oldText;
                tbx4.BackColor = System.Drawing.Color.Red;
                tbx4.ForeColor = System.Drawing.Color.Black;
                tbx4.SelectionStart = tbx4.Text.Length;
            }
        }

        private void tbx5_TextChanged(object sender, EventArgs e)
        {
            string oldText = string.Empty;

            if (tbx5.Text.All(chr => char.IsNumber(chr)))
            {
                oldText = tbx5.Text;
                tbx5.Text = oldText;

                tbx5.BackColor = System.Drawing.Color.White;
                tbx5.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbx5.Text = oldText;
                tbx5.BackColor = System.Drawing.Color.Red;
                tbx5.ForeColor = System.Drawing.Color.Black;
                tbx5.SelectionStart = tbx5.Text.Length;
            }
        }

        private void cbx1_TextChanged(object sender, EventArgs e)
        {
            cbx1.Text = "";
        }
    }
}
