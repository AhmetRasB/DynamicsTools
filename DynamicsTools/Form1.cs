using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicsTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point();
            btn.Location = btnkonum;
            btn.Name = "buton1";
            btn.Text = "tıkla";
            btn.Size = new Size(150, 100);
            btn.BackColor = Color.Green;
            Label lbl = new Label();
            Point lblkonum = new Point(300,25);
            lbl.Location = lblkonum;
            lbl.Name = "Label1,";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Blue;
            this.Controls.Add(lbl);
            this.Controls.Add(btn);
            lbl.AutoSize = true;    


        }
    }
}
