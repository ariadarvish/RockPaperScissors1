using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureboxrock_Click(object sender, EventArgs e)
        {
            pictureboxplayer.BackgroundImage = pictureboxrock.BackgroundImage;
            Random rand = new Random();
            int randnumber = rand.Next(100, 4000);
            int computerchoice = (randnumber % 3) + 1;
            #region chooserock

            switch (computerchoice)
            {
                case 1:
                    pictureboxcomputer.BackgroundImage = pictureboxrock.BackgroundImage;
                    listBox1.Items.Add("مساوی");
                    listBox1.Items.Add("\n");
                    break;
                case 2:
                    pictureboxcomputer.BackgroundImage = pictureboxpaper.BackgroundImage;
                    listBox1.Items.Add("کامپیوتر برنده شد");
                    listBox1.Items.Add("\n");

                    break;
                case 3:
                    pictureboxcomputer.BackgroundImage = pictureboxscissors.BackgroundImage;
                    listBox1.Items.Add("شما برنده شدید");
                    listBox1.Items.Add("\n");
                    break;
            }
            #endregion

        }

        private void pictureboxpaper_Click(object sender, EventArgs e)
        {
            pictureboxplayer.BackgroundImage = pictureboxpaper.BackgroundImage;
            Random rand = new Random();
            int randnumber = rand.Next(100, 4000);
            int computerchoice = (randnumber % 3) + 1;
            #region choosepaper
            switch (computerchoice)
            {
                case 1:
                    pictureboxcomputer.BackgroundImage = pictureboxpaper.BackgroundImage;
                    listBox1.Items.Add("مساوی");
                    listBox1.Items.Add("\n");
                    break;
                case 2:
                    pictureboxcomputer.BackgroundImage = pictureboxscissors.BackgroundImage;
                    listBox1.Items.Add("کامپیوتر برنده شد");
                    listBox1.Items.Add("\n");

                    break;
                case 3:
                    pictureboxcomputer.BackgroundImage = pictureboxrock.BackgroundImage;
                    listBox1.Items.Add("شما برنده شدید");
                    listBox1.Items.Add("\n");
                    break;
            }
        }
        #endregion

        private void pictureboxscissors_Click(object sender, EventArgs e)
        {
            pictureboxplayer.BackgroundImage = pictureboxscissors.BackgroundImage;
            Random rand = new Random();
            int randnumber = rand.Next(100, 4000);
            int computerchoice = (randnumber % 3) + 1;
            #region choosescissors
            switch (computerchoice)
            {
                case 1:
                    pictureboxcomputer.BackgroundImage = pictureboxscissors.BackgroundImage;
                    listBox1.Items.Add("مساوی");
                    listBox1.Items.Add("\n");
                    break;
                case 2:
                    pictureboxcomputer.BackgroundImage = pictureboxrock.BackgroundImage;
                    listBox1.Items.Add("کامپیوتر برنده شد");
                    listBox1.Items.Add("\n");

                    break;
                case 3:
                    pictureboxcomputer.BackgroundImage = pictureboxpaper.BackgroundImage;
                    listBox1.Items.Add("شما برنده شدید");
                    listBox1.Items.Add("\n");
                    break;

            }
        }
        #endregion
    }
}


