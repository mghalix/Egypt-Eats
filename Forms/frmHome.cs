using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_Eats.Forms
{

    public partial class frmHome : Form
    {
        private frmMain mainForm;
        private bool white;
        private Button b;
        public frmHome(frmMain mainForm, Button b)
        {
            InitializeComponent();
            this.white = !mainForm.white; //to not toggle and keep it the same state
            this.mainForm = mainForm;
            toggle(); // doesnt toggle to different state just to the mainform state
            this.b = b;
        }


        private void frmHome_Load(object sender, EventArgs e)
        {
            mainForm.ButtonDarkToggleClicked += Toggles;
        }

        private void frmDeals_Load(object sender, EventArgs e)
        {
            mainForm.ButtonDarkToggleClicked += Toggles;
        }

        void toggle()
        {
            if (white)
            {
                this.BackColor = Color.FromArgb(13, 17, 23);
                this.ForeColor = Color.White;
                white = false;

            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
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
