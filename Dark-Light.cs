using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_Eats
{
    public class Dark_Light : Button
    {
        public bool darkOn = false;
        public Dark_Light()
        {
            this.MinimumSize = new Size(36, 31);
        }
        //public void ToggleDark(Button b)
        //{

        //    if (darkOn)
        //    {
        //        darkOn = false;
        //        t.BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
        //        b.BackgroundImage = global::Egypt_Eats.Properties.Resources.Nighmode;
        //        b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
        //        b.BackColor = System.Drawing.Color.WhiteSmoke;
        //        b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //        b.Cursor = System.Windows.Forms.Cursors.Hand;
        //        b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        //        b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        //        b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        b.ForeColor = System.Drawing.Color.White;
        //        b.Location = new System.Drawing.Point(591, 12);
        //        b.Name = "button1";
        //        b.Size = new System.Drawing.Size(36, 31);
        //        b.TabIndex = 0;
        //        b.UseVisualStyleBackColor = false;
        //        //b.Click += new System.EventHandler(this.ToggleDark);
        //    }
        //    else
        //    {
        //        darkOn = true;
        //        this.BackColor = Color.Black;
        //        b.BackgroundImage = global::Egypt_Eats.Properties.Resources.Lightmode;
        //        b.BackColor = System.Drawing.Color.Transparent;
        //        b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //        b.Cursor = System.Windows.Forms.Cursors.Hand;
        //        b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        //        b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        //        b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        b.ForeColor = System.Drawing.Color.White;
        //        b.Location = new System.Drawing.Point(591, 12);
        //        b.Size = new System.Drawing.Size(36, 31);
        //        b.TabIndex = 0;
        //        b.UseVisualStyleBackColor = false;
        //        b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        //    }
        //}

    }
}
