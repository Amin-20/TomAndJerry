using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TomAndJerry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Properties.Resources.clipart25985701.GetHicon());
        }

        private void bunnyBtn_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
            }

            Button newBunnyBtn= new Button();
            newBunnyBtn.BackgroundImage = new Bitmap(Properties.Resources.Bunny1);
            newBunnyBtn.BackColor= Color.Transparent;
            newBunnyBtn.FlatStyle= FlatStyle.Flat;
            newBunnyBtn.Size=bunnyBtn.Size;
            newBunnyBtn.FlatAppearance.BorderSize = bunnyBtn.FlatAppearance.BorderSize;
            newBunnyBtn.FlatAppearance.BorderColor = bunnyBtn.FlatAppearance.BorderColor;
            newBunnyBtn.FlatAppearance.MouseOverBackColor= System.Drawing.Color.Transparent;
            newBunnyBtn.FlatAppearance.MouseDownBackColor= System.Drawing.Color.Transparent;
            Random random= new Random();
            int x=random.Next(100,800);
            int y = random.Next(100, 600);
            newBunnyBtn.Location= new Point(x,y);   
            newBunnyBtn.AutoSize=true;
            newBunnyBtn.MouseHover += bunnyBtn_MouseHover;
            this.Controls.Add(newBunnyBtn);


        }

       
    }
}
