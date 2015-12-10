using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Jedis.AsistentJedi;
using WindowsFormsApplication1.Jedis.JediKnight;
using WindowsFormsApplication1.Jedis.Masters;
using WindowsFormsApplication1.Paduins.Paduin;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class PlayScreen : Form
    {
        private PlayScreen playScreen;
        private int x;
        private int y;

        private Timer timer = new Timer();
        private Direction directionCharacter;
        private Direction directionAssistant;
        private Direction directionPaduin;
        private Direction directionBeer;
        private Image image;

        private Direction directionCategory1 = Direction.None;
        private Direction directionCategory2 = Direction.None;
        private Direction directionCategory3 = Direction.None;
        private Direction directionCategory4 = Direction.None;
        private Direction directionCategory5 = Direction.None;
        private Direction directionCategory6 = Direction.None;
        private Direction directionCategory7 = Direction.None;
        private Direction directionCategory8 = Direction.None;

        public PlayScreen()
        {
            InitializeComponent();

            x = 1;
            y = 1;
            directionCharacter = Direction.Down;
            directionAssistant = Direction.Up;
            directionPaduin = Direction.None;
            directionBeer = Direction.None;

            directionCategory1 = Direction.None;
            directionCategory2 = Direction.None;
            directionCategory3 = Direction.None;
            directionCategory4 = Direction.None;
            directionCategory5 = Direction.None;
            directionCategory6 = Direction.None;
            directionCategory7 = Direction.None;
            directionCategory8 = Direction.None;

            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            //Beer.Visible = false;


            timer.Interval = 15;
            timer.Tick += timerCharacter_Tick;
            timer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {
            Image beer =
                Image.FromFile(
<<<<<<< HEAD
                    @"..\..\Resources\Beer.png");
            //Beer.Image = beer;
            //Beer.Height = beer.Height;
            //Beer.Width = beer.Width;
=======
                    @"..\..\Resources\beer.jpg");
            Beer.Image = beer;
//            Beer.Height = beer.Height;
//            Beer.Width = beer.Width;

>>>>>>> 41e3390ba63fe82cd2c17f9c66bd648be15b4dc5
            if (Jedi.FinalCharacter == 1)
            {
                JoNakov nakov = new JoNakov();
                Image image = Image.FromFile(nakov.CharacterImage);

                enemyBox.Image = image;
                enemyBox.Height = image.Height;
                enemyBox.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 2)
            {
                AchoUanKenobi acho = new AchoUanKenobi();
                Image image = Image.FromFile(acho.CharacterImage);

                enemyBox.Image = image;
                enemyBox.Height = image.Height;
                enemyBox.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 3)
            {
                RoyalSkyWalker royal = new RoyalSkyWalker();
                Image image = Image.FromFile(royal.CharacterImage);

                enemyBox.Image = image;
                enemyBox.Height = image.Height;
                enemyBox.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 4)
            {
                NaskoSolo nasko = new NaskoSolo();
                Image image = Image.FromFile(nasko.CharacterImage);

                enemyBox.Image = image;
                enemyBox.Height = image.Height;
                enemyBox.Width = image.Width;
            }
            if (Jedi.FinalAssistantCharacter == 1)
            {
                ChubiEdo edo = new ChubiEdo();
                Image image = Image.FromFile(edo.CharacterImage);

                pictureBox1.Image = image;
                pictureBox1.Height = image.Height;
                pictureBox1.Width = image.Width;
            }
            else if (Jedi.FinalAssistantCharacter == 2)
            {
                R2Trifon2 trifon = new R2Trifon2();
                Image image = Image.FromFile(trifon.CharacterImage);

                pictureBox1.Image = image;
                pictureBox1.Height = image.Height;
                pictureBox1.Width = image.Width;
            }

            if (ChooseCategoryScreen.FinalCategory == 1)
            {
<<<<<<< HEAD
                image = Image.FromFile(@"..\..\Resources\Csharp.png");
=======
                image = Image.FromFile(@"..\..\Resources\csharp.png");
>>>>>>> 41e3390ba63fe82cd2c17f9c66bd648be15b4dc5
                pictureBox3.Image = image;
                pictureBox3.Height = image.Height;
                pictureBox3.Width = image.Width;
                pictureBox4.Image = image;
                pictureBox4.Height = image.Height;
                pictureBox4.Width = image.Width;
                pictureBox5.Image = image;
                pictureBox5.Height = image.Height;
                pictureBox5.Width = image.Width;
                pictureBox6.Image = image;
                pictureBox6.Height = image.Height;
                pictureBox6.Width = image.Width;
                pictureBox7.Image = image;
                pictureBox7.Height = image.Height;
                pictureBox7.Width = image.Width;
                pictureBox8.Image = image;
                pictureBox8.Height = image.Height;
                pictureBox8.Width = image.Width;
                pictureBox9.Image = image;
                pictureBox9.Height = image.Height;
                pictureBox9.Width = image.Width;
                pictureBox10.Image = image;
                pictureBox10.Height = image.Height;
                pictureBox10.Width = image.Width;
            }
            else if (ChooseCategoryScreen.FinalCategory == 2)
            {
<<<<<<< HEAD
                image = Image.FromFile(@"..\..\Resources\Java.png");
=======
                image = Image.FromFile(@"..\..\Resources\java.jpg");
>>>>>>> 41e3390ba63fe82cd2c17f9c66bd648be15b4dc5
                pictureBox3.Image = image;
                pictureBox3.Height = image.Height;
                pictureBox3.Width = image.Width;
                pictureBox4.Image = image;
                pictureBox4.Height = image.Height;
                pictureBox4.Width = image.Width;
                pictureBox5.Image = image;
                pictureBox5.Height = image.Height;
                pictureBox5.Width = image.Width;
                pictureBox6.Image = image;
                pictureBox6.Height = image.Height;
                pictureBox6.Width = image.Width;
                pictureBox7.Image = image;
                pictureBox7.Height = image.Height;
                pictureBox7.Width = image.Width;
                pictureBox8.Image = image;
                pictureBox8.Height = image.Height;
                pictureBox8.Width = image.Width;
                pictureBox9.Image = image;
                pictureBox9.Height = image.Height;
                pictureBox9.Width = image.Width;
                pictureBox10.Image = image;
                pictureBox10.Height = image.Height;
                pictureBox10.Width = image.Width;
            }
            else if (ChooseCategoryScreen.FinalCategory == 3)
            {
<<<<<<< HEAD
                image = Image.FromFile(@"..\..\Resources\Cplusplus.png");
=======
                image = Image.FromFile(@"..\..\Resources\cplusplus.jpg");
>>>>>>> 41e3390ba63fe82cd2c17f9c66bd648be15b4dc5
                pictureBox3.Image = image;
                pictureBox3.Height = image.Height;
                pictureBox3.Width = image.Width;
                pictureBox4.Image = image;
                pictureBox4.Height = image.Height;
                pictureBox4.Width = image.Width;
                pictureBox5.Image = image;
                pictureBox5.Height = image.Height;
                pictureBox5.Width = image.Width;
                pictureBox6.Image = image;
                pictureBox6.Height = image.Height;
                pictureBox6.Width = image.Width;
                pictureBox7.Image = image;
                pictureBox7.Height = image.Height;
                pictureBox7.Width = image.Width;
                pictureBox8.Image = image;
                pictureBox8.Height = image.Height;
                pictureBox8.Width = image.Width;
                pictureBox9.Image = image;
                pictureBox9.Height = image.Height;
                pictureBox9.Width = image.Width;
                pictureBox10.Image = image;
                pictureBox10.Height = image.Height;
                pictureBox10.Width = image.Width;
            }
            else if (ChooseCategoryScreen.FinalCategory == 4)
            {
<<<<<<< HEAD
                image = Image.FromFile(@"..\..\Resources\Oop.png");
=======
                image = Image.FromFile(@"..\..\Resources\oop.png");
>>>>>>> 41e3390ba63fe82cd2c17f9c66bd648be15b4dc5
                pictureBox3.Image = image;
                pictureBox3.Height = image.Height;
                pictureBox3.Width = image.Width;
                pictureBox4.Image = image;
                pictureBox4.Height = image.Height;
                pictureBox4.Width = image.Width;
                pictureBox5.Image = image;
                pictureBox5.Height = image.Height;
                pictureBox5.Width = image.Width;
                pictureBox6.Image = image;
                pictureBox6.Height = image.Height;
                pictureBox6.Width = image.Width;
                pictureBox7.Image = image;
                pictureBox7.Height = image.Height;
                pictureBox7.Width = image.Width;
                pictureBox8.Image = image;
                pictureBox8.Height = image.Height;
                pictureBox8.Width = image.Width;
                pictureBox9.Image = image;
                pictureBox9.Height = image.Height;
                pictureBox9.Width = image.Width;
                pictureBox10.Image = image;
                pictureBox10.Height = image.Height;
                pictureBox10.Width = image.Width;
            }
            if (Paduin.FinalPaduinCharacter == 1)
            {
                CountSevgin sevgin = new CountSevgin();
                Image image = Image.FromFile(sevgin.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 2)
            {
                Karnobatman karnobatman = new Karnobatman();
                Image image = Image.FromFile(karnobatman.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 3)
            {
                SashoFett sasho = new SashoFett();
                Image image = Image.FromFile(sasho.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 4)
            {
                WightJan jan = new WightJan();
                Image image = Image.FromFile(jan.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private int Score = 0;
        private int Drunk = 0;
        private void timerCharacter_Tick(object sender, EventArgs e)
        {
            paduinKnowledge.Text = String.Format("Paduin Knowledge : {0} %", Score);
            jediDrunk.Text = String.Format("Jedi Drunk : {0} %", Drunk);

            if (Score == 100 || Drunk == 100)
            {
                timer.Stop();
            }

<<<<<<< HEAD
            //if (Beer.Bounds.IntersectsWith(pictureBox2.Bounds))
            //{
            //    Drunk++;
            //}
=======
            if (Beer.Bounds.IntersectsWith(enemyBox.Bounds))
            {
                Drunk++;
            }
>>>>>>> 41e3390ba63fe82cd2c17f9c66bd648be15b4dc5


            if (pictureBox3.Bounds.IntersectsWith(paduin.Bounds))
            {
                //Question question = new Question();
                //question.ShowDialog();
                
                Score++;
                pictureBox3.Hide();
            }
            if (pictureBox4.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                pictureBox4.Hide();
            }
            if (pictureBox5.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                pictureBox5.Hide();
            }
            if (pictureBox6.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                pictureBox6.Hide();
            }
            if (pictureBox7.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                pictureBox7.Hide();
            }
            if (pictureBox8.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                pictureBox8.Hide();
            }
            if (pictureBox9.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                pictureBox9.Hide();
            }
            if (pictureBox10.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                pictureBox10.Hide();
            }


            //First Category
            if (enemyBox.Location.Y == pictureBox3.Location.Y)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                directionCategory1 = Direction.Right;
            }
            if (pictureBox3.Left == 600)
            {
                pictureBox3.Visible = false;
                directionCategory1 = Direction.None;
                pictureBox3.Left -= 580;
            }

            //Second Category
            if (enemyBox.Location.Y == pictureBox4.Location.Y)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                directionCategory2 = Direction.Right;
            }
            if (pictureBox4.Left == 600)
            {
                pictureBox4.Visible = false;
                directionCategory2 = Direction.None;
                pictureBox4.Left -= 580;
            }

            //Third Category
            if (enemyBox.Location.Y == pictureBox5.Location.Y)
            {
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                directionCategory3 = Direction.Right;
            }
            if (pictureBox5.Left == 600)
            {
                pictureBox5.Visible = false;
                directionCategory3 = Direction.None;
                pictureBox5.Left -= 580;
            }

<<<<<<< HEAD
            //Forth Category
            if (pictureBox2.Location.Y == pictureBox6.Location.Y)
=======
            //Forth Category 
            if (enemyBox.Location.Y == pictureBox6.Location.Y)
>>>>>>> 41e3390ba63fe82cd2c17f9c66bd648be15b4dc5
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                directionCategory4 = Direction.Right;
            }
            if (pictureBox6.Left == 600)
            {
                pictureBox6.Visible = false;
                directionCategory4 = Direction.None;
                pictureBox6.Left -= 580;
            }

            //Fifth Category
            if (enemyBox.Location.Y == pictureBox7.Location.Y)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                directionCategory5 = Direction.Right;
            }
            if (pictureBox7.Left == 600)
            {
                pictureBox7.Visible = false;
                directionCategory5 = Direction.None;
                pictureBox7.Left -= 580;
            }

            //Sixth Category
            if (enemyBox.Location.Y == pictureBox8.Location.Y)
            {
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y);
                directionCategory6 = Direction.Right;
            }
            if (pictureBox8.Left == 600)
            {
                pictureBox8.Visible = false;
                directionCategory6 = Direction.None;
                pictureBox8.Left -= 580;
            }

            //Seventh Category
            if (enemyBox.Location.Y == pictureBox9.Location.Y)
            {
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                directionCategory7 = Direction.Right;
            }
            if (pictureBox9.Left == 600)
            {
                pictureBox9.Visible = false;
                directionCategory7 = Direction.None;
                pictureBox9.Left -= 580;
            }

            //Eight Category
            if (enemyBox.Location.Y == pictureBox10.Location.Y)
            {
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                directionCategory8 = Direction.Right;
            }
            if (pictureBox10.Left == 600)
            {
                pictureBox10.Visible = false;
                directionCategory8 = Direction.None;
                pictureBox10.Left -= 580;
            }
            //Paduins Direction
            if (directionPaduin == Direction.Right)
            {
                paduin.Left += 3;
            }
            if (directionPaduin == Direction.Left)
            {
                paduin.Left -= 3;
            }
            if (directionPaduin == Direction.Up)
            {
                paduin.Top -= 3;
            }
            if (directionPaduin == Direction.Down)
            {
                paduin.Top += 3;
            }


            //Category direction - only Right
            if (directionCategory1 == Direction.Right)
            {
                pictureBox3.Left += 4;
            }
            if (directionCategory2 == Direction.Right)
            {
                pictureBox4.Left += 4;
            }
            if (directionCategory3 == Direction.Right)
            {
                pictureBox5.Left += 4;
            }
            if (directionCategory4 == Direction.Right)
            {
                pictureBox6.Left += 4;
            }
            if (directionCategory5 == Direction.Right)
            {
                pictureBox7.Left += 4;
            }
            if (directionCategory6 == Direction.Right)
            {
                pictureBox8.Left += 4;
            }
            if (directionCategory7 == Direction.Right)
            {
                pictureBox9.Left += 4;
            }
            if (directionCategory8 == Direction.Right)
            {
                pictureBox10.Left += 4;
            }

            //Jedi Character direction - only Up and Down
            if (directionCharacter == Direction.Up)
            {
                enemyBox.Top -= 1;
                if (enemyBox.Top == 20)
                {
                    directionCharacter = Direction.Down;
                }
            }
            if (directionCharacter == Direction.Down)
            {
                enemyBox.Top += 1;
                if (enemyBox.Top == 280)
                {
                    directionCharacter = Direction.Up;
                }
            }


            //Paduin direction
            //?????

            //Assistant direction - only Up and Down
            if (directionAssistant == Direction.Up)
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Top == 20)
                {
                    directionAssistant = Direction.Down;
                }
            }

            if (directionAssistant == Direction.Down)
            {
                pictureBox1.Top += 1;
                if (pictureBox1.Top == 280)
                {
                    directionAssistant = Direction.Up;
                }
            }

            //Beer direction
            if (directionBeer == Direction.Right)
            {
                //Beer.Left += 5;
            }
            else if (directionBeer == Direction.Left)
            {
                //Beer.Left -= 5;
            }

            Invalidate();
        }

        private void PlayScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                directionPaduin = Direction.Down;
            }
            if (e.KeyCode == Keys.Up)
            {
                directionPaduin = Direction.Up;
            }
            if (e.KeyCode == Keys.Left)
            {
                directionPaduin = Direction.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                directionPaduin = Direction.Right;
            }
            if (e.KeyCode == Keys.Space)
            {
                //Beer = new PictureBox();
                //Beer.Location = new Point(paduin.Location.X, paduin.Location.Y);
                //Beer.Visible = true;
                if (directionPaduin == Direction.Right)
                {
                    directionBeer = Direction.Right;
                }
                else if (directionPaduin == Direction.Left)
                {
                    directionBeer = Direction.Left;
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void paduin_Click(object sender, EventArgs e)
        {

        }

        private void paduinKnowledge_Click(object sender, EventArgs e)
        {

        }

        private void jediDrunk_Click(object sender, EventArgs e)
        {

        }

        private void Beer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }
    }
}