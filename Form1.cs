using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PutUIElementsInPlace();
        }


        public void PutUIElementsInPlace()
        {
            //Set the buttons to the right place
            LocalGameBtn.Location = new Point(this.Size.Width / 2 - LocalGameBtn.Size.Width / 2, this.Size.Height / 6);
            LocalNetworkBtn.Location = new Point(this.Size.Width / 2 - LocalNetworkBtn.Size.Width / 2, this.Size.Height / 6 * 2);
            OnlineBtn.Location = new Point(this.Size.Width / 2 - OnlineBtn.Size.Width / 2, this.Size.Height / 6 * 3);
        }

    }



}
