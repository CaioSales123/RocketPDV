using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketPDV.View
{
    public partial class loginView : Form
    {
        public loginView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Crimson;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Silver;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Crimson;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuView menuView = new MenuView();
            menuView.Show();
            this.Hide();
        }
    }
}
