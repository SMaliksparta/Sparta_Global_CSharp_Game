using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Threading;
using Microsoft.Win32;
using System.IO;
using MessageBox = System.Windows.MessageBox;

namespace GeometryDash
{
    /// <summary>
    /// Interaction logic for Level1.xaml
    /// </summary>
    public partial class Level1 : Window
    {
        double x = 62;
        double y = 620;
        DispatcherTimer timer = new DispatcherTimer();


        public Level1()
        {
            
            timer.Tick += new EventHandler(MovePlayer);
            timer.Tick += new EventHandler(Map1);
            timer.Start();

            InitializeComponent();
        }

        //Controls
        private void MovePlayer(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Left))
            {
                x -= 0.1;
                Canvas.SetLeft(Player, x);
            }
            if (Keyboard.IsKeyDown(Key.Up))
            {
                y -= 0.1;
                Canvas.SetTop(Player, y);
            }
            if (Keyboard.IsKeyDown(Key.Down))
            {
                y += 0.1;
                Canvas.SetTop(Player, y);
            }
            if (Keyboard.IsKeyDown(Key.Right))
            {
                x += 0.1;
                Canvas.SetLeft(Player, x);
            }
        }

        public void Map1(object sender, EventArgs e)

        {
            // Player

            Rect Player1 = new Rect(Canvas.GetLeft(Player), Canvas.GetTop(Player), Player.Width, Player.Height);

            // Rect rect1 = new Rect (466, -464, 6-2, 990);

            //Map Boundary

            Rect rect1 = new Rect(Canvas.GetLeft(level1TopBar), Canvas.GetTop(level1TopBar), level1TopBar.Width, level1TopBar.Height);

            Rect rect2 = new Rect(Canvas.GetLeft(level1LeftBar), Canvas.GetTop(level1LeftBar), level1LeftBar.Width, level1LeftBar.Height);

            Rect rect3 = new Rect(Canvas.GetLeft(level1BottomBar), Canvas.GetTop(level1BottomBar), level1BottomBar.Width, level1BottomBar.Height);

            Rect rect4 = new Rect(Canvas.GetLeft(level1RightBar), Canvas.GetTop(level1RightBar), level1RightBar.Width, level1RightBar.Height);

            //Map Boundaries
            Rect plat1 = new Rect(Canvas.GetLeft(ob1), Canvas.GetTop(ob1), ob1.Width, ob1.Height);
            Rect plat2 = new Rect(Canvas.GetLeft(ob2), Canvas.GetTop(ob2), ob2.Width, ob2.Height);
            Rect plat3 = new Rect(Canvas.GetLeft(ob3), Canvas.GetTop(ob3), ob3.Width, ob3.Height);
            Rect plat4 = new Rect(Canvas.GetLeft(ob4), Canvas.GetTop(ob4), ob4.Width, ob4.Height);
            Rect plat5 = new Rect(Canvas.GetLeft(ob5), Canvas.GetTop(ob5), ob5.Width, ob5.Height);
            Rect plat6 = new Rect(Canvas.GetLeft(ob6), Canvas.GetTop(ob6), ob6.Width, ob6.Height);
            Rect plat7 = new Rect(Canvas.GetLeft(ob7), Canvas.GetTop(ob7), ob7.Width, ob7.Height);
            Rect plat8 = new Rect(Canvas.GetLeft(ob8), Canvas.GetTop(ob8), ob8.Width, ob8.Height);
            Rect plat9 = new Rect(Canvas.GetLeft(ob9), Canvas.GetTop(ob9), ob9.Width, ob9.Height);
            Rect plat10 = new Rect(Canvas.GetLeft(ob10), Canvas.GetTop(ob10), ob10.Width, ob10.Height);
            Rect plat11 = new Rect(Canvas.GetLeft(ob11), Canvas.GetTop(ob11), ob11.Width, ob11.Height);
            Rect plat12 = new Rect(Canvas.GetLeft(ob12), Canvas.GetTop(ob12), ob12.Width, ob12.Height);
            Rect plat13 = new Rect(Canvas.GetLeft(ob13), Canvas.GetTop(ob13), ob13.Width, ob13.Height);
            Rect plat14 = new Rect(Canvas.GetLeft(ob14), Canvas.GetTop(ob14), ob14.Width, ob14.Height);

            //Goal
            
            Rect goal = new Rect(Canvas.GetLeft(Goal), Canvas.GetTop(Goal), Goal.Width, Goal.Height);

            // Game over 
            if (rect1.IntersectsWith(Player1))

            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();

            }
            if (rect2.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");

                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (rect3.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (rect4.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }

            //Platfrom hits

            if (plat1.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat2.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat3.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat4.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat5.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat6.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat7.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat8.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat9.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat10.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat11.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat12.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat13.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat14.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }

            //Goal

            if (goal.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("YOU WIN");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }

        }
    }
}
