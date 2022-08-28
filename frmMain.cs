using Egypt_Eats.Forms;
using Egypt_Eats.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_Eats
{
    public partial class frmMain : Form
    {
        //Members

        private Button currentButton;
        private Form activeForm;
        internal bool white;
        private FileStream fs;
        private StreamWriter sw;
        private StreamReader sr;
        public event EventHandler ButtonDarkToggleClicked;
        public frmMain()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        internal void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        internal void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void frmMainUpgraded_Load(object sender, EventArgs e)
        {
            fs = new FileStream("Clientinfo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sr = new StreamReader(fs);
            sw = new StreamWriter(fs);
            fs.Seek(0, SeekOrigin.Begin);
            if (sr.ReadLine() == "1")
                white = false;
            else
                white = true;

            toggleDarkOn(!white); //because I dont want the load toggling anything(changing the color state) at load.
            sr.DiscardBufferedData();
            btnHome_Click(btnHome, e);
        }
        internal void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    switchMode(currentButton);
                    currentButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelOptions.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 10.86792F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesk.Controls.Add(childForm);
            this.pnlDesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        internal void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmHome(this, btnHome), sender);
        }

        internal void btnDeals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmDeals(this, btnDeals), sender);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmOrders(this, btnOrders), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSettings(this, btnSettings), sender);
        }
        internal void switchMode(Button btn)
        {

            switch (btn.Name)
            {
                case ("btnHome"):
                    if (white) //On white mode
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome_LightOn));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings));
                    }
                    else //On dark mode
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome_DarkOn));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_DarkActive));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders_DarkActive));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings_DarkActive));
                    }
                    break;
                case "btnDeals":
                    if (white)
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_LightOn));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings));
                    }
                    else
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome_DarkActive));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_DarkOn));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders_DarkActive));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings_DarkActive));
                    }
                    break;
                case "btnOrders":
                    if (white)
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders_LightOn));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings));
                    }
                    else
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome_DarkActive));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_DarkActive));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders_DarkOn));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings_DarkActive));
                    }
                    break;
                case "btnSettings":
                    if (white)
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings_LightOn));
                    }
                    else
                    {
                        btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome_DarkActive));
                        btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_DarkActive));
                        btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders_DarkActive));
                        btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings_DarkOn));

                    }
                    break;
            }

        }

        void darkToggle_Click(object sender, EventArgs e)
        {
            ButtonDarkToggleClicked?.Invoke(sender, e);
            if (white)
                toggleDarkOn(true);
            else
                toggleDarkOn(false);

            switchMode(currentButton);
        }

        internal void toggleDarkOn(bool isWhite)
        {
            if (isWhite) //means current state is white and we want to toggle to dark
            {
                fs.Seek(0, SeekOrigin.Begin);
                sw.WriteLine("1");
                sw.Flush();
                white = false;
                //------------------------/
                darkToggle.Image = global::Egypt_Eats.Properties.Resources.Lightmode_v1;
                darkToggle.BackColor = System.Drawing.Color.Transparent;
                darkToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                darkToggle.ForeColor = System.Drawing.Color.White;
                //darkToggle.Name = "button1";
                darkToggle.Size = new System.Drawing.Size(36, 31);
                darkToggle.TabIndex = 0;
                darkToggle.UseVisualStyleBackColor = false;
                darkToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
                this.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));

                //Buttons
                btnHome.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
                btnDeals.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
                btnOrders.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
                btnSettings.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
                panelOptions.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));

                btnHome.ForeColor = Color.White;
                btnOrders.ForeColor = Color.White;
                btnDeals.ForeColor = Color.White;
                btnSettings.ForeColor = Color.White;

                //Text Color
                this.ForeColor = Color.White;
                panelOptions.ForeColor = Color.White;
                lblTitle.ForeColor = Color.White;

                //Buttons Image
                btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome_DarkActive));
                btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_DarkActive));
                btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders_DarkActive));
                btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings_DarkActive));
            }
            else
            {
                fs.Seek(0, SeekOrigin.Begin);
                sw.WriteLine("0");
                sw.Flush();
                white = true;
                //----------------------/
                darkToggle.Image = Properties.Resources.Nightmode;
                darkToggle.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                darkToggle.BackColor = Color.Transparent;
                darkToggle.BackColor = Color.Transparent;
                this.BackColor = Color.White;
                //Buttons
                btnHome.BackColor = Color.White;
                btnDeals.BackColor = Color.White;
                btnOrders.BackColor = Color.White;
                btnSettings.BackColor = Color.White;
                panelOptions.BackColor = Color.White;

                btnHome.ForeColor = System.Drawing.Color.Black;
                btnDeals.ForeColor = System.Drawing.Color.Black;
                btnOrders.ForeColor = System.Drawing.Color.Black;
                btnSettings.ForeColor = System.Drawing.Color.Black;
                //Text Color
                this.ForeColor = Color.Black;
                panelOptions.ForeColor = Color.Black;
                lblTitle.ForeColor = Color.Black;



                //Button Image
                btnHome.Image = ((System.Drawing.Image)(Properties.Resources.btnHome));
                btnDeals.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals));
                btnOrders.Image = ((System.Drawing.Image)(Properties.Resources.btnOrders));
                btnSettings.Image = ((System.Drawing.Image)(Properties.Resources.btnSettings));
            }

        }

        private void darkToggle_MouseEnter(object sender, EventArgs e)
        {
            if (!white)
            {
                darkToggle.Image = (System.Drawing.Image)(Properties.Resources.Lightmode_v1Hover);
            }
            else
            {
                darkToggle.Image = (System.Drawing.Image)(Properties.Resources.Nightmode_onHover);
                darkToggle.FlatAppearance.BorderColor = Color.FromArgb(13, 17, 24);
            }
        }

        private void darkToggle_MouseLeave(object sender, EventArgs e)
        {
            if (!white)
            {
                darkToggle.Image = (Properties.Resources.Lightmode_v1);
                darkToggle.FlatAppearance.MouseDownBackColor = Color.Transparent;
                darkToggle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
            else
            {
                darkToggle.Image = (Properties.Resources.Nightmode);
                darkToggle.FlatAppearance.MouseDownBackColor = Color.Transparent;
                darkToggle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }

        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.titlebutton_close_hover;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.titlebutton_close;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.titlebutton_minimize_hover;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.titlebutton_minimize;
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                btnMaximize.Image = Resources.titlebutton_unmaximize_hover;
            else
            {
                btnMaximize.Image = Resources.titlebutton_maximize_hover;
                btnMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.Image = Resources.titlebutton_maximize;
        }

        private void darkToggle_MouseUp(object sender, MouseEventArgs e)
        {
            //if(white)
            //{
            //    //darkToggle.Image = Properties.Resources.Nightmode_onHover;
            //}
            //else
            //{
            //    //darkToggle.Image = Properties.Resources.Lightmode_v1Hover;
            //}
        }
    }
}

