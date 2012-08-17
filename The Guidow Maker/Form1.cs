using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace The_Guidow_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Text="Generate";
            this.button2.Text = "Copy";
            this.label1.Text = "";
            this.Text = "The Guidow Maker";
            //this.Icon = "Icon1.ico";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = Guid.NewGuid().ToString();
            Point tmplocation = label1.Location;
            tmplocation.X = this.Width / 2 - this.label1.Width / 2;
            label1.Location = tmplocation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "")
            {
                try
                {
                    Clipboard.SetText(label1.Text);
                }
                catch (System.Runtime.InteropServices.ExternalException) { }
            }
        }
    }
}
