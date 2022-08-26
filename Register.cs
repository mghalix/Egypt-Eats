using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_Eats
{
    public partial class frmRegister : Form
    {
        //Members
        private bool darkOn = false;
        public FileStream fs;
        public StreamWriter sw;
        public StreamReader sr;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void darkToggle_Click(object sender, EventArgs e)
        {
            if (darkOn)
            {
                darkOn = false;
                this.BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                this.ForeColor = Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169))))); ;
                darkToggle.BackgroundImage = global::Egypt_Eats.Properties.Resources.Nightmode;
                darkToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));

            }
            else
            {
                darkOn = true;
                this.ForeColor = Color.White;
                //rgb(13, 17, 23)
                this.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
                darkToggle.BackgroundImage = global::Egypt_Eats.Properties.Resources.Lightmode;
                darkToggle.BackColor = System.Drawing.Color.Transparent;
                darkToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                darkToggle.Cursor = System.Windows.Forms.Cursors.Hand;
                darkToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                darkToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                darkToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                darkToggle.ForeColor = System.Drawing.Color.White;
                darkToggle.Name = "button1";
                darkToggle.Size = new System.Drawing.Size(36, 31);
                darkToggle.TabIndex = 0;
                darkToggle.UseVisualStyleBackColor = false;
                darkToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            sw.Close();
            fs.Close();
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fs.Seek(0, SeekOrigin.Begin);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] field = line.Split('|');
                if (txtUsername.Text.ToLower() == field[2])
                {
                    MessageBox.Show("Username already exists, please choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    return;
                }
            }
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "" || txtAge.Text == "" || txtName.Text == "")
                MessageBox.Show("Registration Failed. Please fill in all fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPassword.Text == txtComPassword.Text)
            {
                fs.Seek(0, SeekOrigin.End);
                sw.WriteLine($"{txtName.Text}|{txtAge.Text}|{txtUsername.Text.ToLower()}|{txtPassword.Text}");
                sw.Close();
                fs.Close();
                label6_Click(sender, e);
                MessageBox.Show("Your Account has been Succesfully Created", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Clear();
                txtComPassword.Clear();
                txtPassword.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtComPassword.Clear();
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }
        public void ShowPassword()
        {
            txtPassword.MaxLength = 14;
            txtComPassword.MaxLength = 14;

            if (!checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            ShowPassword();
            fs = new FileStream("ClientInfo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(fs);
            sr = new StreamReader(fs);
        }

        private void frmRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
