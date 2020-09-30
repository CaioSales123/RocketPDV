using RocketPDV.View.panelViews;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RocketPDV.View
{
    public partial class MenuView : Form
    {
        public MenuView()
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
