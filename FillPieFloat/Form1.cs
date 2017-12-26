using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillPieFloat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void FillPieFloat(PaintEventArgs e)
        {
            // Create solid brush.
            SolidBrush redBrush = new SolidBrush(Color.Red);

            // Create location and size of ellipse.
            float x = 0.0F;
            float y = 0.0F;
            float width = 200.0F;
            float height = 100.0F;

            // Create start and sweep angles.
            float startAngle = 0.0F;
            float sweepAngle = 45.0F;

            // Fill pie to screen.
            e.Graphics.FillPie(redBrush, x, y, width, height, startAngle, sweepAngle);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            FillPieFloat(e);
        }
    }
}
