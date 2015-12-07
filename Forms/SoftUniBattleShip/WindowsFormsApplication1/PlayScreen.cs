using System;
using System.Drawing;
using System.Windows.Forms;
using Game;

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

        public PlayScreen()
        {
            InitializeComponent();

            x = 1;
            y = 1;
            directionCharacter = Direction.Down;
            directionAssistant = Direction.Up;
            directionPaduin = Direction.None;
            directionBeer = Direction.Left;

            directionCategory1 = Direction.None;
            directionCategory2 = Direction.None;
            directionCategory3 = Direction.None;
            directionCategory4 = Direction.None;

            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            Beer.Visible = false;
            

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
                    @"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\beer.jpg");
            Beer.Image = beer;
            Beer.Height = beer.Height;
            Beer.Width = beer.Width;
            if (Jedi.FinalCharacter == 1)
            {
                JoNakov nakov = new JoNakov();
                Image image = Image.FromFile(nakov.CharacterImage);
                
                pictureBox2.Image = image;
                pictureBox2.Height = image.Height;
                pictureBox2.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 2)
            {
                AchoUanKenobi acho = new AchoUanKenobi();
                Image image = Image.FromFile(acho.CharacterImage);

                pictureBox2.Image = image;
                pictureBox2.Height = image.Height;
                pictureBox2.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 3)
            {
                RoyalSkyWalker royal = new RoyalSkyWalker();
                Image image = Image.FromFile(royal.CharacterImage);

                pictureBox2.Image = image;
                pictureBox2.Height = image.Height;
                pictureBox2.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 4)
            {
                NaskoSolo nasko = new NaskoSolo();
                Image image = Image.FromFile(nasko.CharacterImage);

                pictureBox2.Image = image;
                pictureBox2.Height = image.Height;
                pictureBox2.Width = image.Width;
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
                image = Image.FromFile(@"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\csharp.png");
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
            }
            else if (ChooseCategoryScreen.FinalCategory == 2)
            {
                image = Image.FromFile(@"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\java.jpg");
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
            }
            else if (ChooseCategoryScreen.FinalCategory == 3)
            {
                image = Image.FromFile(@"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\cplusplus.jpg");
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
            }
            else if (ChooseCategoryScreen.FinalCategory == 4)
            {
                image = Image.FromFile(@"C:\Users\pc1\Desktop\OOPGameProject\OOPGameProject\Forms\SoftUniBattleShip\WindowsFormsApplication1\Resources\oop.png");
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
            }
            if (Paduin.FinalPaduinCharacter == 1)
            {
                CountSevgin sevgin = new CountSevgin();
                Image image = Image.FromFile(sevgin.CharacterImage);

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
            if (Score == 100 || Drunk == 100)
            {
                timer.Stop();

            }
            paduinKnowledge.Text = String.Format("Paduin Knowledge : {0} %", Score);
            jediDrunk.Text = String.Format("Jedi Drunk : {0} %", Drunk);
            if (Beer.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Drunk++;
            }
            if (pictureBox3.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
            }
            //if (pictureBox4.Bounds.IntersectsWith(paduin.Bounds))
            //{
            //    Score++;
            //    timer.Stop();
            //    this.Hide();
            //    ques.Show();
                
            //}
            if (pictureBox5.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
            }
            if (pictureBox6.Bounds.IntersectsWith(paduin.Bounds))
            {
                Score++;
            }
            if (pictureBox2.Location.Y == pictureBox3.Location.Y)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                directionCategory1 = Direction.Right;
            }
            if (pictureBox3.Left == 300)
            {
                pictureBox3.Visible = false;
                directionCategory1 = Direction.None;
                pictureBox3.Left -= 280;
            }
            if (pictureBox2.Location.Y == pictureBox4.Location.Y)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                directionCategory2 = Direction.Right;
            }
            if (pictureBox4.Left == 300)
            {
                pictureBox4.Visible = false;
                directionCategory2 = Direction.None;
                pictureBox4.Left -= 280;
            }
            if (pictureBox2.Location.Y == pictureBox5.Location.Y)
            {
                pictureBox5.Visible = true;
                pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                directionCategory3 = Direction.Right;
            }
            if (pictureBox5.Left == 300)
            {
                pictureBox5.Visible = false;
                directionCategory3 = Direction.None;
                pictureBox5.Left -= 280;
            }
            if (pictureBox2.Location.Y == pictureBox6.Location.Y)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                directionCategory4 = Direction.Right;
            }
            if (pictureBox6.Left == 300)
            {
                pictureBox6.Visible = false;
                directionCategory4 = Direction.None;
                pictureBox6.Left -= 280;
            }


            if (directionPaduin == Direction.Right)
            {
                paduin.Left += 2;
            }
            if (directionPaduin == Direction.Left)
            {
                paduin.Left -= 2;
            }
            if (directionPaduin == Direction.Up)
            {
                paduin.Top -= 2;
            }
            if (directionPaduin == Direction.Down)
            {
                paduin.Top += 2;
            }



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
            if (directionCharacter == Direction.Up)
            {
                pictureBox2.Top -= 1;
                if (pictureBox2.Top == 5)
                {
                    directionCharacter = Direction.Down;
                }
            }
            if (directionAssistant == Direction.Up)
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Top == 5)
                {
                    directionAssistant = Direction.Down;
                }
            }
            if (directionCharacter == Direction.Down)
            {
                pictureBox2.Top += 1;
                if (pictureBox2.Top == 130)
                {
                    directionCharacter = Direction.Up;
                }
            }
            if (directionAssistant == Direction.Down)
            {
                pictureBox1.Top += 1;
                if (pictureBox1.Top == 130)
                {
                    directionAssistant = Direction.Up;
                }
            }
            if (directionBeer == Direction.Right)
            {
                Beer.Left += 5;
            }
            else if (directionBeer == Direction.Left)
            {
                Beer.Left -= 5;
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
            //    Beer = new PictureBox();
                Beer.Location = new Point(paduin.Location.X, paduin.Location.Y);
                Beer.Visible = true;
                if (directionPaduin == Direction.Right)
                {
                    directionBeer = Direction.Right;
                }
                else if(directionPaduin == Direction.Left)
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
    }
}