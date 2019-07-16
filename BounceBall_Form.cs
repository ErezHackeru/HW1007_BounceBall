using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1007_BounceBall
{
    public partial class BB_Form : Form
    {
        public BB_Form()
        {
            InitializeComponent();
        }

        private int X_WINDOW_SIZE;
        private int Y_WINDOW_SIZE;
        private Point FirstBallLocation;
        private int dx, dy, NewX, NewY;
        private Random rand = new Random();
        private int NameIndex = 0;
        private List<PictureBox> AllBalls;
        
        private List<Point> BallsLocation;
        private List<int> DX, DY, NewLocationX, NewLocationY;
        private void Form1_Load(object sender, EventArgs e)
        {
            X_WINDOW_SIZE = ClientSize.Width - 140;
            Y_WINDOW_SIZE = ClientSize.Height - 140;
            BallPicBx.Location = new Point(rand.Next(X_WINDOW_SIZE), rand.Next(Y_WINDOW_SIZE));
            BallsLocation = new List<Point>();
            DX = new List<int>();
            DY = new List<int>();
            NewLocationX = new List<int>();
            NewLocationY = new List<int>();
            AllBalls = new List<PictureBox>();
        }

        private void AddBallBtn_Click(object sender, EventArgs e)
        {
            BallsLocation.Add(new Point(rand.Next(X_WINDOW_SIZE), rand.Next(Y_WINDOW_SIZE)));

            AllBalls.Add(new PictureBox
            {
                Name = "Ball" + NameIndex.ToString(),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = BallsLocation[NameIndex],
                Image = Image.FromFile(@"D:\Documents\HackerU\HW_Files\Ball_Pic.jpg")
            });
            this.Controls.Add(AllBalls[NameIndex]);

            DX.Add(1);
            DY.Add(1);
            NewLocationX.Add(FirstBallLocation.X);
            NewLocationY.Add(FirstBallLocation.Y);


            Task.Run(() =>
            {
                PlaceControl();
            });

            System.Timers.Timer timer = new System.Timers.Timer(1);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;

            NameIndex++;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < AllBalls.Count; i++)
            {
                for (int j = 0; j < AllBalls.Count; j++)
                {
                    if (i == j) continue;
                    if ((NewLocationX[i] < NewLocationX[j] + 50) && (NewLocationX[i] > NewLocationX[j] - 50) &&
                        (NewLocationY[i] < NewLocationY[j] + 50) && (NewLocationY[i] > NewLocationY[j] - 50))
                    {
                        DX[i] = -DX[i];
                        DY[i] = -DY[i];
                    }
                }
            }            
        }

        private void PlaceControl()
        {
            int BallPlaceInArray = NameIndex - 1;
            while (true)
            {
                Action a = () => { AllBalls[BallPlaceInArray].Location = new Point(NewLocationX[BallPlaceInArray], NewLocationY[BallPlaceInArray]); };
                this.BeginInvoke(a);

                NewLocationX[BallPlaceInArray] = NewLocationX[BallPlaceInArray] + DX[BallPlaceInArray];
                NewLocationY[BallPlaceInArray] = NewLocationY[BallPlaceInArray] + DY[BallPlaceInArray];


                if (NewLocationX[BallPlaceInArray] == X_WINDOW_SIZE + 1)
                {
                    DX[BallPlaceInArray] = -1;
                }
                if (NewLocationY[BallPlaceInArray] == Y_WINDOW_SIZE + 1)
                {
                    DY[BallPlaceInArray] = -1;
                }
                if (NewLocationX[BallPlaceInArray] == 1)
                {
                    DX[BallPlaceInArray] = 1;
                }
                if (NewLocationY[BallPlaceInArray] == 1)
                {
                    DY[BallPlaceInArray] = 1;
                }                

                Thread.Sleep(10);
            }
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            dx = 1;
            dy = 1;
            FirstBallLocation = BallPicBx.Location;
            NewX = FirstBallLocation.X;
            NewY = FirstBallLocation.Y;
            StartBtn.Enabled = false;

            while (true)
            {
                BallPicBx.Location = new Point(NewX, NewY);               

                await Task.Run(() => 
                {
                    DefineNewPlaceForBall();
                });
            }
            
            
        }
        private void DefineNewPlaceForBall()
        {
            NewX = NewX + dx;
            NewY = NewY + dy;


            if (NewX == X_WINDOW_SIZE + 1)
            {
                dx = -1;
            }
            if (NewY == Y_WINDOW_SIZE + 1)
            {
                dy = -1;
            }
            if (NewX == 1)
            {
                dx = 1;
            }
            if (NewY == 1)
            {
                dy = 1;
            }

            Thread.Sleep(10);
        }
        
    }
}
