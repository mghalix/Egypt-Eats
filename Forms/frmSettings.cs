using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_Eats.Forms
{
    public partial class frmSettings : Form
    {
        private bool white;
        private frmMain mainForm;
        private Button b;
        public frmSettings(frmMain mainForm, Button b)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            this.BackColor = mainForm.BackColor;
            this.ForeColor = mainForm.ForeColor;
            this.white = mainForm.white;
            this.b = b;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            mainForm.ButtonDarkToggleClicked += Toggles;

        }
        void toggle()
        {
            if (white)
            {
                b.BackColor = Color.Red;
                this.BackColor = Color.FromArgb(13, 17, 23);
                this.ForeColor = Color.White;
                b.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_DarkOn));
                white = false;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                b.Image = ((System.Drawing.Image)(Properties.Resources.btnDeals_LightOn));
                white = true;
            }
        }
        void Toggles(object s, EventArgs args)
        {
            toggle();
            mainForm.ActivateButton(b);
        }
    }
}
