using System;
using System.Drawing;
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
        private Direction directionCategory9 = Direction.None;
        private Direction directionCategory10 = Direction.None;
        private Direction directionCategory11 = Direction.None;


        public PlayScreen()
        {
            InitializeComponent();

            this.x = 1;
            this.y = 1;
            this.directionCharacter = Direction.Down;
            this.directionAssistant = Direction.Up;
            this.directionPaduin = Direction.None;
            this.directionBeer = Direction.None;

            this.directionCategory1 = Direction.None;
            this.directionCategory2 = Direction.None;
            this.directionCategory3 = Direction.None;
            this.directionCategory4 = Direction.None;
            this.directionCategory5 = Direction.None;
            this.directionCategory6 = Direction.None;
            this.directionCategory7 = Direction.None;
            this.directionCategory8 = Direction.None;
            this.directionCategory9 = Direction.None;
            this.directionCategory10 = Direction.None;
            this.directionCategory11 = Direction.None;

            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = false;
            this.pictureBox6.Visible = false;
            this.pictureBox7.Visible = false;
            this.pictureBox8.Visible = false;
            this.pictureBox9.Visible = false;
            this.pictureBox10.Visible = false;
            this.pictureBox11.Visible = false;
            this.pictureBox12.Visible = false;
            this.pictureBox13.Visible = false;

            //Beer.Visible = false;


            this.timer.Interval = 15;
            this.timer.Tick += timerCharacter_Tick;
            this.timer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {

            if (Jedi.FinalCharacter == 1)
            {
                JoNakov nakov = new JoNakov();
                Image image = Image.FromFile(nakov.CharacterImage);

                this.enemyBox.Image = image;
                this.enemyBox.Height = image.Height;
                this.enemyBox.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 2)
            {
                AchoUanKenobi acho = new AchoUanKenobi();
                Image image = Image.FromFile(acho.CharacterImage);

                this.enemyBox.Image = image;
                this.enemyBox.Height = image.Height;
                this.enemyBox.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 3)
            {
                RoyalSkyWalker royal = new RoyalSkyWalker();
                Image image = Image.FromFile(royal.CharacterImage);

                this.enemyBox.Image = image;
                this.enemyBox.Height = image.Height;
                this.enemyBox.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 4)
            {
                NaskoSolo nasko = new NaskoSolo();
                Image image = Image.FromFile(nasko.CharacterImage);

                this.enemyBox.Image = image;
                this.enemyBox.Height = image.Height;
                this.enemyBox.Width = image.Width;
            }

            if (Jedi.FinalAssistantCharacter == 1)
            {
                ChubiEdo edo = new ChubiEdo();
                Image image = Image.FromFile(edo.CharacterImage);

                ////Beer pictur incert
                //this.image = Image.FromFile(@"..\..\Resources\Beer.png");
                //Picture(this.image);

                this.pictureBox1.Image = image;
                this.pictureBox1.Height = image.Height;
                this.pictureBox1.Width = image.Width;
            }
            else if (Jedi.FinalAssistantCharacter == 2)
            {
                R2Trifon2 trifon = new R2Trifon2();
                Image image = Image.FromFile(trifon.CharacterImage);

                ////Beer pictur incert
                //this.image = Image.FromFile(@"..\..\Resources\Beer.png");
                //Picture(this.image);

                this.pictureBox1.Image = image;
                this.pictureBox1.Height = image.Height;
                this.pictureBox1.Width = image.Width;
            }

            if (ChooseCategoryScreen.FinalCategory == 1)
            {
                this.image = Image.FromFile(@"..\..\Resources\Csharp.png");
                Picture(this.image);
            }
            else if (ChooseCategoryScreen.FinalCategory == 2)
            {
                this.image = Image.FromFile(@"..\..\Resources\Java.png");
                Picture(this.image);
            }
            else if (ChooseCategoryScreen.FinalCategory == 3)
            {
                this.image = Image.FromFile(@"..\..\Resources\Cplusplus.png");
                Picture(this.image);
            }
            else if (ChooseCategoryScreen.FinalCategory == 4)
            {
                this.image = Image.FromFile(@"..\..\Resources\Oop.png");
                Picture(this.image);
            }

            

            if (Paduin.FinalPaduinCharacter == 1)
            {
                CountSevgin sevgin = new CountSevgin();
                Image image = Image.FromFile(sevgin.CharacterImage);

                this.paduin.Image = image;
                this.paduin.Height = image.Height;
                this.paduin.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 2)
            {
                Karnobatman karnobatman = new Karnobatman();
                Image image = Image.FromFile(karnobatman.CharacterImage);

                this.paduin.Image = image;
                this.paduin.Height = image.Height;
                this.paduin.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 3)
            {
                SashoFett sasho = new SashoFett();
                Image image = Image.FromFile(sasho.CharacterImage);

                this.paduin.Image = image;
                this.paduin.Height = image.Height;
                this.paduin.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 4)
            {
                WightJan jan = new WightJan();
                Image image = Image.FromFile(jan.CharacterImage);

                this.paduin.Image = image;
                this.paduin.Height = image.Height;
                this.paduin.Width = image.Width;
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
            this.paduinKnowledge.Text = String.Format("Paduin Knowledge : {0} %", this.Score);
            this.jediDrunk.Text = String.Format("Jedi Drunk : {0} %", this.Drunk);

            if (this.Score == 100 || this.Drunk == 100)
            {
                this.timer.Stop();
            }

            //if (Beer.Bounds.IntersectsWith(pictureBox13.Bounds))
            //{
            //    Drunk++;
            //}
            //if (Beer.Bounds.IntersectsWith(enemyBox.Bounds))
            //{
            //   Drunk++;
            //}


            if (this.pictureBox3.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.timer.Stop();
                this.q = new Question();
                this.q.ShowDialog();

                if (Question.FinalAnswer == 1)
                {
                    this.directionCategory1 = Direction.None;
                    this.pictureBox3.Hide();
                    this.pictureBox3.Location = new Point(this.pictureBox3.Location.X - this.paduin.Location.X + 60, this.pictureBox3.Location.Y);
                    this.timer.Start();
                }
                else if (Question.FinalAnswer == 2 || Question.FinalAnswer == 3 || Question.FinalAnswer == 4)
                {
                    this.directionCategory1 = Direction.None;
                    this.pictureBox3.Hide();
                    this.pictureBox3.Location = new Point(this.pictureBox3.Location.X - this.paduin.Location.X + 60, this.pictureBox3.Location.Y);
                    this.Score += 30;
                    this.timer.Start();
                }
            }

            if (this.pictureBox4.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory2 = Direction.None;
                this.pictureBox4.Hide();
                this.pictureBox4.Location = new Point(this.pictureBox4.Location.X - this.paduin.Location.X + 60, this.pictureBox4.Location.Y);
            }

            if (this.pictureBox5.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory3 = Direction.None;
                this.pictureBox5.Hide();
                this.pictureBox5.Location = new Point(this.pictureBox5.Location.X - this.paduin.Location.X + 60, this.pictureBox5.Location.Y);
            }

            if (this.pictureBox6.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory4 = Direction.None;
                this.pictureBox6.Hide();
                this.pictureBox6.Location = new Point(this.pictureBox6.Location.X - this.paduin.Location.X + 60, this.pictureBox6.Location.Y);
            }

            if (this.pictureBox7.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory5 = Direction.None;
                this.pictureBox7.Hide();
                this.pictureBox7.Location = new Point(this.pictureBox7.Location.X - this.paduin.Location.X + 60, this.pictureBox7.Location.Y);
            }

            if (this.pictureBox8.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory6 = Direction.None;
                this.pictureBox8.Hide();
                this.pictureBox8.Location = new Point(this.pictureBox8.Location.X - this.paduin.Location.X + 60, this.pictureBox8.Location.Y);
            }

            if (this.pictureBox9.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory7 = Direction.None;
                this.pictureBox9.Hide();
                this.pictureBox9.Location = new Point(this.pictureBox9.Location.X - this.paduin.Location.X + 60, this.pictureBox9.Location.Y);
            }

            if (this.pictureBox10.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory8 = Direction.None;
                this.pictureBox10.Hide();
                this.pictureBox10.Location = new Point(this.pictureBox10.Location.X - this.paduin.Location.X + 60, this.pictureBox10.Location.Y);
            }

            if (this.pictureBox11.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory9 = Direction.None;
                this.pictureBox11.Hide();
                this.pictureBox11.Location = new Point(this.pictureBox11.Location.X - this.paduin.Location.X - 60, this.pictureBox11.Location.Y);
            }

            if (this.pictureBox12.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory10 = Direction.None;
                this.pictureBox12.Hide();
                this.pictureBox12.Location = new Point(this.pictureBox12.Location.X - this.paduin.Location.X - 60, this.pictureBox12.Location.Y);
            }

            if (this.pictureBox13.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.Score++;
                this.directionCategory11 = Direction.None;
                this.pictureBox13.Hide();
                this.pictureBox13.Location = new Point(this.pictureBox13.Location.X - this.paduin.Location.X - 60, this.pictureBox13.Location.Y);
            }
            //First Category
            if (this.enemyBox.Location.Y == this.pictureBox3.Location.Y)
            {
                this.pictureBox3.Visible = true;
                this.pictureBox3.Location = new Point(this.pictureBox3.Location.X, this.pictureBox3.Location.Y);
                this.directionCategory1 = Direction.Right;
            }
            if (this.pictureBox3.Left >= 600)
            {
                this.directionCategory1 = Direction.None;
                this.pictureBox3.Hide();
                this.pictureBox3.Location = new Point(this.pictureBox3.Location.X - 580, this.pictureBox3.Location.Y);
            }

            //Second Category
            if (this.enemyBox.Location.Y == this.pictureBox4.Location.Y)
            {
                this.pictureBox4.Visible = true;
                this.pictureBox4.Location = new Point(this.pictureBox4.Location.X, this.pictureBox4.Location.Y);
                this.directionCategory2 = Direction.Right;
            }
            if (this.pictureBox4.Left >= 600)
            {
                this.directionCategory2 = Direction.None;
                this.pictureBox4.Hide();
                this.pictureBox4.Location = new Point(this.pictureBox4.Location.X - 580, this.pictureBox4.Location.Y);
            }

            //Third Category
            if (this.enemyBox.Location.Y == this.pictureBox5.Location.Y)
            {
                this.pictureBox5.Visible = true;
                this.pictureBox5.Location = new Point(this.pictureBox5.Location.X, this.pictureBox5.Location.Y);
                this.directionCategory3 = Direction.Right;
            }
            if (this.pictureBox5.Left >= 600)
            {
                this.directionCategory3 = Direction.None;
                this.pictureBox5.Hide();
                this.pictureBox5.Location = new Point(this.pictureBox5.Location.X - 580, this.pictureBox5.Location.Y);
            }


            //Forth Category 
            if (this.enemyBox.Location.Y == this.pictureBox6.Location.Y)
            {
                this.pictureBox6.Visible = true;
                this.pictureBox6.Location = new Point(this.pictureBox6.Location.X, this.pictureBox6.Location.Y);
                this.directionCategory4 = Direction.Right;
            }
            if (this.pictureBox6.Left >= 600)
            {
                this.directionCategory4 = Direction.None;
                this.pictureBox6.Hide();
                this.pictureBox6.Location = new Point(this.pictureBox6.Location.X - 580, this.pictureBox6.Location.Y);
            }

            //Fifth Category
            if (this.enemyBox.Location.Y == this.pictureBox7.Location.Y)
            {
                this.pictureBox7.Visible = true;
                this.pictureBox7.Location = new Point(this.pictureBox7.Location.X, this.pictureBox7.Location.Y);
                this.directionCategory5 = Direction.Right;
            }
            if (this.pictureBox7.Left >= 600)
            {
                this.directionCategory5 = Direction.None;
                this.pictureBox7.Hide();
                this.pictureBox7.Location = new Point(this.pictureBox7.Location.X - 580, this.pictureBox7.Location.Y);
            }

            //Sixth Category
            if (this.enemyBox.Location.Y == this.pictureBox8.Location.Y)
            {
                this.pictureBox8.Visible = true;
                this.pictureBox8.Location = new Point(this.pictureBox8.Location.X, this.pictureBox8.Location.Y);
                this.directionCategory6 = Direction.Right;
            }
            if (this.pictureBox8.Left >= 600)
            {
                this.directionCategory6 = Direction.None;
                this.pictureBox8.Hide();
                this.pictureBox8.Location = new Point(this.pictureBox8.Location.X - 580, this.pictureBox8.Location.Y);
            }

            //Seventh Category
            if (this.enemyBox.Location.Y == this.pictureBox9.Location.Y)
            {
                this.pictureBox9.Visible = true;
                this.pictureBox9.Location = new Point(this.pictureBox9.Location.X, this.pictureBox9.Location.Y);
                this.directionCategory7 = Direction.Right;
            }
            if (this.pictureBox9.Left >= 600)
            {
                this.directionCategory7 = Direction.None;
                this.pictureBox9.Hide();
                this.pictureBox9.Location = new Point(this.pictureBox9.Location.X - 580, this.pictureBox9.Location.Y);
            }

            //Eight Category
            if (this.enemyBox.Location.Y == this.pictureBox10.Location.Y)
            {
                this.pictureBox10.Visible = true;
                this.pictureBox10.Location = new Point(this.pictureBox10.Location.X, this.pictureBox10.Location.Y);
                this.directionCategory8 = Direction.Right;
            }
            if (this.pictureBox10.Left >= 600)
            {
                this.directionCategory8 = Direction.None;
                this.pictureBox10.Hide();
                this.pictureBox10.Location = new Point(this.pictureBox10.Location.X - 580, this.pictureBox10.Location.Y);
            }

            //BeerOne Category
            if (this.enemyBox.Location.Y == this.pictureBox11.Location.Y)
            {
                this.pictureBox11.Visible = true;
                this.pictureBox11.Location = new Point(this.pictureBox11.Location.X, this.pictureBox11.Location.Y);
                this.directionCategory9 = Direction.Right;
            }
            if (this.pictureBox11.Left >= 1000)
            {
                this.directionCategory9 = Direction.None;
                this.pictureBox11.Hide();
                this.pictureBox11.Location = new Point(this.pictureBox11.Location.X + 580, this.pictureBox11.Location.Y);
            }

            //BeerTwo Category
            if (this.enemyBox.Location.Y == this.pictureBox12.Location.Y)
            {
                this.pictureBox12.Visible = true;
                this.pictureBox12.Location = new Point(this.pictureBox11.Location.X, this.pictureBox11.Location.Y);
                this.directionCategory10 = Direction.Right;
            }
            if (this.pictureBox12.Left >= 1000)
            {
                this.directionCategory10 = Direction.None;
                this.pictureBox13.Hide();
                this.pictureBox13.Location = new Point(this.pictureBox12.Location.X + 580, this.pictureBox12.Location.Y);
            }

            //BeerThree Category
            if (this.enemyBox.Location.Y == this.pictureBox13.Location.Y)
            {
                this.pictureBox13.Visible = true;
                this.pictureBox13.Location = new Point(this.pictureBox13.Location.X, this.pictureBox13.Location.Y);
                this.directionCategory11 = Direction.Right;
            }
            if (this.pictureBox13.Left >= 1000)
            {
                this.directionCategory11 = Direction.None;
                this.pictureBox13.Hide();
                this.pictureBox13.Location = new Point(this.pictureBox13.Location.X + 580, this.pictureBox13.Location.Y);
            }

            //Paduins Direction
            if (this.directionPaduin == Direction.Right)
            {
                this.paduin.Left += 3;
                if (this.paduin.Left >= 750)
                {
                    this.paduin.Left = 700;
                    this.directionPaduin = Direction.Left;
                }
            }
            if (this.directionPaduin == Direction.Left)
            {
                this.paduin.Left -= 3;
                if (this.paduin.Left <= 100)
                {
                    this.paduin.Left = 150;
                    this.directionPaduin = Direction.Right;
                }
            }
            if (this.directionPaduin == Direction.Up)
            {
                this.paduin.Top -= 3;
                if (this.paduin.Top <= 10)
                {
                    this.paduin.Top = 50;
                    this.directionPaduin = Direction.Down;
                }
            }
            if (this.directionPaduin == Direction.Down)
            {
                this.paduin.Top += 3;
                if (this.paduin.Top >= 280)
                {
                    this.paduin.Top = 230;
                    this.directionPaduin = Direction.Up;
                }
            }


            //Category direction - only Right

            if (this.directionCategory1 == Direction.Right)
            {
                this.pictureBox3.Left += 4;
            }

            if (this.directionCategory2 == Direction.Right)
            {
                this.pictureBox4.Left += 4;
            }

            if (this.directionCategory3 == Direction.Right)
            {
                this.pictureBox5.Left += 4;
            }

            if (this.directionCategory4 == Direction.Right)
            {
                this.pictureBox6.Left += 4;
            }

            if (this.directionCategory5 == Direction.Right)
            {
                this.pictureBox7.Left += 4;
            }

            if (this.directionCategory6 == Direction.Right)
            {
                this.pictureBox8.Left += 4;
            }

            if (this.directionCategory7 == Direction.Right)
            {
                this.pictureBox9.Left += 4;
            }

            if (this.directionCategory8 == Direction.Right)
            {
                this.pictureBox10.Left += 4;
            }

            if (this.directionCategory9 == Direction.Right)
            {
                this.pictureBox10.Left += 4;
            }

            if (this.directionCategory10 == Direction.Right)
            {
                this.pictureBox10.Left += 4;
            }

            if (this.directionCategory11 == Direction.Right)
            {
                this.pictureBox10.Left += 4;
            }

            //Jedi Character direction - only Up and Down
            if (this.directionCharacter == Direction.Up)
            {
                this.enemyBox.Top -= 1;
                if (this.enemyBox.Top == 20)
                {
                    this.directionCharacter = Direction.Down;
                }
            }
            if (this.directionCharacter == Direction.Down)
            {
                this.enemyBox.Top += 1;
                if (this.enemyBox.Top == 280)
                {
                    this.directionCharacter = Direction.Up;
                }
            }

            //Assistant direction - only Up and Down
            if (this.directionAssistant == Direction.Up)
            {
                this.pictureBox1.Top -= 1;
                if (this.pictureBox1.Top == 20)
                {
                    this.directionAssistant = Direction.Down;
                }
            }

            if (this.directionAssistant == Direction.Down)
            {
                this.pictureBox1.Top += 1;
                if (this.pictureBox1.Top == 280)
                {
                    this.directionAssistant = Direction.Up;
                }
            }

            //Beer direction
            if (this.directionBeer == Direction.Right)
            {
                //Beer.Left += 5;
            }
            else if (this.directionBeer == Direction.Left)
            {
                //Beer.Left -= 5;
            }

            Invalidate();
        }

        private void PlayScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.directionPaduin = Direction.Down;
            }
            if (e.KeyCode == Keys.Up)
            {
                this.directionPaduin = Direction.Up;
            }
            if (e.KeyCode == Keys.Left)
            {
                this.directionPaduin = Direction.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                this.directionPaduin = Direction.Right;
            }
            if (e.KeyCode == Keys.Space)
            {
                //Beer = new PictureBox();
                //Beer.Location = new Point(paduin.Location.X, paduin.Location.Y);
                //Beer.Visible = true;
                if (this.directionPaduin == Direction.Right)
                {
                    this.directionBeer = Direction.Right;
                }
                else if (this.directionPaduin == Direction.Left)
                {
                    this.directionBeer = Direction.Left;
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
            this.pictureBox3.Image = image;
            this.pictureBox3.Height = image.Height;
            this.pictureBox3.Width = image.Width;
            this.pictureBox4.Image = image;
            this.pictureBox4.Height = image.Height;
            this.pictureBox4.Width = image.Width;
            this.pictureBox5.Image = image;
            this.pictureBox5.Height = image.Height;
            this.pictureBox5.Width = image.Width;
            this.pictureBox6.Image = image;
            this.pictureBox6.Height = image.Height;
            this.pictureBox6.Width = image.Width;
            this.pictureBox7.Image = image;
            this.pictureBox7.Height = image.Height;
            this.pictureBox7.Width = image.Width;
            this.pictureBox8.Image = image;
            this.pictureBox8.Height = image.Height;
            this.pictureBox8.Width = image.Width;
            this.pictureBox9.Image = image;
            this.pictureBox9.Height = image.Height;
            this.pictureBox9.Width = image.Width;
            this.pictureBox10.Image = image;
            this.pictureBox10.Height = image.Height;
            this.pictureBox10.Width = image.Width;
            this.pictureBox11.Image = image;
            this.pictureBox11.Height = image.Height;
            this.pictureBox11.Width = image.Width;
            this.pictureBox12.Image = image;
            this.pictureBox12.Height = image.Height;
            this.pictureBox12.Width = image.Width;
            this.pictureBox13.Image = image;
            this.pictureBox13.Height = image.Height;
            this.pictureBox13.Width = image.Width;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}