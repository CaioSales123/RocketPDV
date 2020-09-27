using RocketPDV.View.panelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketPDV.View
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pdvView myForm = new pdvView();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelWindow.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
