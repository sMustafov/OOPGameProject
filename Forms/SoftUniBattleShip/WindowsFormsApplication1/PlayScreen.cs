using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication1.Jedis.AsistentJedi;
using WindowsFormsApplication1.Jedis.JediKnight;
using WindowsFormsApplication1.Jedis.Masters;
using WindowsFormsApplication1.Paduins.Paduin;

namespace WindowsFormsApplication1
{
    public partial class PlayScreen : Form
    {
        private Question q;
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
            //Image beer = Image.FromFile(@"..\..\Resources\Beer.png");
            //Beer.Image = beer;
            //Beer.Height = beer.Height;
            //Beer.Width = beer.Width;

            //@"..\..\Resources\beer.jpg");
            //Beer.Image = beer;
            //Beer.Height = beer.Height;
            //Beer.Width = beer.Width;


            Image image = Image.FromFile(@"..\..\Resources\redWall.jpg");
            redWall.Image = image;
            redWall.Height = image.Height;
            redWall.Width = image.Width;
            redWall2.Image = image;
            redWall2.Height = image.Height;
            redWall2.Width = image.Width;

            Image image2 = Image.FromFile(@"..\..\Resources\redWall2.jpg");
            redWall3.Image = image2;
            redWall3.Height = image2.Height;
            redWall3.Width = image2.Width;
            redWall4.Image = image2;
            redWall4.Height = image2.Height;
            redWall4.Width = image2.Width;


            if (Jedi.FinalCharacter == 1)
            {
                JoNakov nakov = new JoNakov();
                JediImageValidation(nakov, enemyBox);
            }
            else if (Jedi.FinalCharacter == 2)
            {
                AchoUanKenobi acho = new AchoUanKenobi();
                JediImageValidation(acho, enemyBox);
            }
            else if (Jedi.FinalCharacter == 3)
            {
                RoyalSkyWalker royal = new RoyalSkyWalker();
                JediImageValidation(royal, enemyBox);
            }
            else if (Jedi.FinalCharacter == 4)
            {
                NaskoSolo nasko = new NaskoSolo();
                JediImageValidation(nasko, enemyBox);
            }
            if (Jedi.FinalAssistantCharacter == 1)
            {
                ChubiEdo edo = new ChubiEdo();
                AssistantImageValidation(edo, pictureBox1);
            }
            else if (Jedi.FinalAssistantCharacter == 2)
            {
                R2Trifon2 trifon = new R2Trifon2();
                AssistantImageValidation(trifon, pictureBox1);
            }

            if (ChooseCategoryScreen.FinalCategory == 1)
            {
                string path = @"..\..\Resources\Csharp.png";
                CategoryValidation(path);
            }
            else if (ChooseCategoryScreen.FinalCategory == 2)
            {
                string path = @"..\..\Resources\Java.png";
                CategoryValidation(path);
            }
            else if (ChooseCategoryScreen.FinalCategory == 3)
            {
                string path = @"..\..\Resources\Cplusplus.png";
                CategoryValidation(path);
            }
            else if (ChooseCategoryScreen.FinalCategory == 4)
            {
                string path = @"..\..\Resources\Oop.png";
                CategoryValidation(path);
            }
            if (Paduin.FinalPaduinCharacter == 1)
            {
                CountSevgin sevgin = new CountSevgin();
                PaduinImageValidation(sevgin, paduin);
            }
            else if (Paduin.FinalPaduinCharacter == 2)
            {
                Karnobatman karnobatman = new Karnobatman();
                PaduinImageValidation(karnobatman, paduin);
            }
            else if (Paduin.FinalPaduinCharacter == 3)
            {
                SashoFett sasho = new SashoFett();
                PaduinImageValidation(sasho, paduin);
            }
            else if (Paduin.FinalPaduinCharacter == 4)
            {
                WightJan jan = new WightJan();
                PaduinImageValidation(jan, paduin);
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
            if (Score >= 100 || Drunk >= 100)
            {
                Score = 100;
            }

            paduinKnowledge.Text = String.Format("Paduin Knowledge : {0} %", Score);
            jediDrunk.Text = String.Format("Jedi Drunk : {0} %", Drunk);


            if (Score == 100 || Drunk == 100)
            {
                timer.Stop();
            }

            //if (Beer.Bounds.IntersectsWith(pictureBox2.Bounds))
            //{
            //    Drunk++;
            //}
            //if (Beer.Bounds.IntersectsWith(enemyBox.Bounds))
            //{
            //   Drunk++;
            //}


            if (pictureBox3.Bounds.IntersectsWith(paduin.Bounds))
            {
                timer.Stop();
                q = new Question();
                q.ShowDialog();

                if (Question.PlayerAnswer == 1)
                {
                    directionCategory1 = Direction.None;
                    pictureBox3.Hide();
                    pictureBox3.Location = new Point(pictureBox3.Location.X - paduin.Location.X + 60,
                        pictureBox3.Location.Y);
                    timer.Start();
                }
                else if (Question.PlayerAnswer == 2 || Question.PlayerAnswer == 3 || Question.PlayerAnswer == 4)
                {
                    
                    directionCategory1 = Direction.None;
                    pictureBox3.Hide();
                    pictureBox3.Location = new Point(pictureBox3.Location.X - paduin.Location.X + 60,
                        pictureBox3.Location.Y);
                    Score += 30;
                    timer.Start();
                }
            }
            if (pictureBox4.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                directionCategory2 = Direction.None;
                pictureBox4.Hide();
                pictureBox4.Location = new Point(pictureBox4.Location.X - paduin.Location.X + 60,
                        pictureBox4.Location.Y);
            }
            if (pictureBox5.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                directionCategory3 = Direction.None;
                pictureBox5.Hide();
                pictureBox5.Location = new Point(pictureBox5.Location.X - paduin.Location.X + 60,
                        pictureBox5.Location.Y);
            }
            if (pictureBox6.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                directionCategory4 = Direction.None;
                pictureBox6.Hide();
                pictureBox6.Location = new Point(pictureBox6.Location.X - paduin.Location.X + 60,
                        pictureBox6.Location.Y);
            }
            if (pictureBox7.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                directionCategory5 = Direction.None;
                pictureBox7.Hide();
                pictureBox7.Location = new Point(pictureBox7.Location.X - paduin.Location.X + 60,
                        pictureBox7.Location.Y);
            }
            if (pictureBox8.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                directionCategory6 = Direction.None;
                pictureBox8.Hide();
                pictureBox8.Location = new Point(pictureBox8.Location.X - paduin.Location.X + 60,
                        pictureBox8.Location.Y);
            }
            if (pictureBox9.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                directionCategory7 = Direction.None;
                pictureBox9.Hide();
                pictureBox9.Location = new Point(pictureBox9.Location.X - paduin.Location.X + 60,
                        pictureBox9.Location.Y);
            }
            if (pictureBox10.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
                directionCategory8 = Direction.None;
                pictureBox10.Hide();
                pictureBox10.Location = new Point(pictureBox10.Location.X - paduin.Location.X + 60,
                        pictureBox10.Location.Y);
            }


            //First Category
            if (enemyBox.Location.Y == pictureBox3.Location.Y)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                directionCategory1 = Direction.Right;
            }
            if (pictureBox3.Left >= 750)
            {
                directionCategory1 = Direction.None;
                pictureBox3.Hide();
                pictureBox3.Location = new Point(pictureBox3.Location.X - 730,
                        pictureBox3.Location.Y);
            }

            //Second Category
            if (enemyBox.Location.Y == pictureBox4.Location.Y)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                directionCategory2 = Direction.Right;
            }
            if (pictureBox4.Left >= 750)
            {
                directionCategory2 = Direction.None;
                pictureBox4.Hide();
                pictureBox4.Location = new Point(pictureBox4.Location.X - 730,
                        pictureBox4.Location.Y);
            }

            //Third Category
            if (enemyBox.Location.Y == pictureBox5.Location.Y)
            {
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                directionCategory3 = Direction.Right;
            }
            if (pictureBox5.Left >= 750)
            {
                directionCategory3 = Direction.None;
                pictureBox5.Hide();
                pictureBox5.Location = new Point(pictureBox5.Location.X - 730,
                        pictureBox5.Location.Y);
            }


            //Forth Category 
            if (enemyBox.Location.Y == pictureBox6.Location.Y)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                directionCategory4 = Direction.Right;
            }
            if (pictureBox6.Left >= 750)
            {
                directionCategory4 = Direction.None;
                pictureBox6.Hide();
                pictureBox6.Location = new Point(pictureBox6.Location.X - 730,
                        pictureBox6.Location.Y);
            }

            //Fifth Category
            if (enemyBox.Location.Y == pictureBox7.Location.Y)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                directionCategory5 = Direction.Right;
            }
            if (pictureBox7.Left >= 750)
            {
                directionCategory5 = Direction.None;
                pictureBox7.Hide();
                pictureBox7.Location = new Point(pictureBox7.Location.X - 730,
                        pictureBox7.Location.Y);
            }

            //Sixth Category
            if (enemyBox.Location.Y == pictureBox8.Location.Y)
            {
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y);
                directionCategory6 = Direction.Right;
            }
            if (pictureBox8.Left >= 750)
            {
                directionCategory6 = Direction.None;
                pictureBox8.Hide();
                pictureBox8.Location = new Point(pictureBox8.Location.X - 730,
                        pictureBox8.Location.Y);
            }

            //Seventh Category
            if (enemyBox.Location.Y == pictureBox9.Location.Y)
            {
                pictureBox9.Visible = true;
                pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                directionCategory7 = Direction.Right;
            }
            if (pictureBox9.Left >= 750)
            {
                directionCategory7 = Direction.None;
                pictureBox9.Hide();
                pictureBox9.Location = new Point(pictureBox9.Location.X - 730,
                        pictureBox9.Location.Y);
            }

            //Eight Category
            if (enemyBox.Location.Y == pictureBox10.Location.Y)
            {
                pictureBox10.Visible = true;
                pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                directionCategory8 = Direction.Right;
            }
            if (pictureBox10.Left >= 750)
            {
                directionCategory8 = Direction.None;
                pictureBox10.Hide();
                pictureBox10.Location = new Point(pictureBox10.Location.X - 730,
                        pictureBox10.Location.Y);
            }
            //Paduins Direction
            if (directionPaduin == Direction.Right)
            {
                paduin.Left += 3;
                if (paduin.Left >= 750)
                {
                    paduin.Left = 700;
                    directionPaduin = Direction.Left;
                }
            }
            if (directionPaduin == Direction.Left)
            {
                paduin.Left -= 3;
                if (paduin.Left <= 100)
                {
                    paduin.Left = 150;
                    directionPaduin = Direction.Right;
                }
            }
            if (directionPaduin == Direction.Up)
            {
                paduin.Top -= 3;
                if (paduin.Top <= 45)
                {
                    paduin.Top = 70;
                    directionPaduin = Direction.Down;
                }
            }
            if (directionPaduin == Direction.Down)
            {
                paduin.Top += 3;
                if (paduin.Top >= 280)
                {
                    paduin.Top = 230;
                    directionPaduin = Direction.Up;
                }
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

        private void Picture(Image image)
        {
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
        private void PaduinImageValidation(Paduins.Paduin.Paduin paduinCharacter, PictureBox paduin)
        {
            try
            {
                image = Image.FromFile(paduinCharacter.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The path of " + paduinCharacter.GetType().Name + " is not in the correct format !");
            }
        }
        private void JediImageValidation(Jedis.Jedi jediCharacter, PictureBox paduin)
        {
            try
            {
                image = Image.FromFile(jediCharacter.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The path of " + jediCharacter.GetType().Name + " is not in the correct format !");
            }
        }
        private void AssistantImageValidation(Jedis.AsistentJedi.Assistant assistantCharacter, PictureBox paduin)
        {
            try
            {
                image = Image.FromFile(assistantCharacter.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The path of " + assistantCharacter.GetType().Name + " is not in the correct format !");
            }
        }

        private void CategoryValidation(string path)
        {
            try
            {
                image = Image.FromFile(path);

                Picture(image);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The category path is not in the correct format !");
            }
        }

        private void redWall_Click(object sender, EventArgs e)
        {

        }

        private void redWall2_Click(object sender, EventArgs e)
        {

        }

        private void redWall3_Click(object sender, EventArgs e)
        {

        }

        private void redWall4_Click(object sender, EventArgs e)
        {

        }
    }
}