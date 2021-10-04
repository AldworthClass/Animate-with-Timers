using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animate_with_Timers
{
    public partial class FormAnimate : Form
    {
        int hSpeed, vSpeed;
        public FormAnimate()
        {
            InitializeComponent();
        }

        private void FormAnimate_Load(object sender, EventArgs e)
        {
            hSpeed = 5;
            vSpeed = 5;
        }

        private void tmrMoveBoat_Tick(object sender, EventArgs e)
        {
            imgBoat.Left += hSpeed;
            // imgBoat.Location = new Point(imgBoat.Location.X + hSpeed, imgBoat.Location.Y);  

            if (imgBoat.Right >= this.ClientSize.Width || imgBoat.Left <= 0)
            {
                hSpeed *= -1;
            }

            imgBoat.Top += vSpeed;
            // imgBoat.Location = new Point(imgBoat.Location.X, imgBoat.Location.Y + vSpeed);  

            if (imgBoat.Top <= 0 || imgBoat.Bottom >= this.ClientSize.Height)
            {
                vSpeed *= -1;
            }

        }
    }
}
