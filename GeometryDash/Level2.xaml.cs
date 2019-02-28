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
    /// Interaction logic for Level2.xaml
    /// </summary>
    public partial class Level2 : Window
    {
        double x = 46;
        double y = 683;
        DispatcherTimer timer = new DispatcherTimer();

        public Level2()
        {
            

                timer.Tick += new EventHandler(MovePlayer);
                timer.Tick += new EventHandler(Map2);
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
        public void Map2(object sender, EventArgs e)

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
            Rect plat15 = new Rect(Canvas.GetLeft(ob15), Canvas.GetTop(ob15), ob15.Width, ob15.Height);
            Rect plat16 = new Rect(Canvas.GetLeft(ob16), Canvas.GetTop(ob16), ob16.Width, ob16.Height);
            Rect plat17 = new Rect(Canvas.GetLeft(ob17), Canvas.GetTop(ob17), ob17.Width, ob17.Height);
            Rect plat18 = new Rect(Canvas.GetLeft(ob18), Canvas.GetTop(ob18), ob18.Width, ob18.Height);
            Rect plat19 = new Rect(Canvas.GetLeft(ob19), Canvas.GetTop(ob19), ob19.Width, ob19.Height);
            Rect plat20 = new Rect(Canvas.GetLeft(ob20), Canvas.GetTop(ob20), ob20.Width, ob20.Height);
            Rect plat21 = new Rect(Canvas.GetLeft(ob21), Canvas.GetTop(ob21), ob21.Width, ob21.Height);
            Rect plat22 = new Rect(Canvas.GetLeft(ob22), Canvas.GetTop(ob22), ob22.Width, ob22.Height);
            Rect plat23 = new Rect(Canvas.GetLeft(ob23), Canvas.GetTop(ob23), ob23.Width, ob23.Height);
            Rect plat24 = new Rect(Canvas.GetLeft(ob24), Canvas.GetTop(ob24), ob24.Width, ob24.Height);
            Rect plat25 = new Rect(Canvas.GetLeft(ob25), Canvas.GetTop(ob25), ob25.Width, ob25.Height);
            Rect plat26 = new Rect(Canvas.GetLeft(ob26), Canvas.GetTop(ob26), ob26.Width, ob26.Height);
            Rect plat27 = new Rect(Canvas.GetLeft(ob27), Canvas.GetTop(ob27), ob27.Width, ob27.Height);
            Rect plat28 = new Rect(Canvas.GetLeft(ob28), Canvas.GetTop(ob28), ob28.Width, ob28.Height);
            Rect plat29 = new Rect(Canvas.GetLeft(ob29), Canvas.GetTop(ob29), ob29.Width, ob29.Height);
            Rect plat30 = new Rect(Canvas.GetLeft(ob30), Canvas.GetTop(ob30), ob30.Width, ob30.Height);
            Rect plat31 = new Rect(Canvas.GetLeft(ob31), Canvas.GetTop(ob31), ob31.Width, ob31.Height);
            Rect plat32 = new Rect(Canvas.GetLeft(ob32), Canvas.GetTop(ob32), ob32.Width, ob32.Height);
            Rect plat33 = new Rect(Canvas.GetLeft(ob33), Canvas.GetTop(ob33), ob33.Width, ob33.Height);
            Rect plat34 = new Rect(Canvas.GetLeft(ob34), Canvas.GetTop(ob34), ob34.Width, ob34.Height);
            Rect plat35 = new Rect(Canvas.GetLeft(ob35), Canvas.GetTop(ob35), ob35.Width, ob35.Height);
            Rect plat36 = new Rect(Canvas.GetLeft(ob36), Canvas.GetTop(ob36), ob36.Width, ob36.Height);
            Rect plat37 = new Rect(Canvas.GetLeft(ob37), Canvas.GetTop(ob37), ob37.Width, ob37.Height);
            Rect plat38 = new Rect(Canvas.GetLeft(ob38), Canvas.GetTop(ob38), ob38.Width, ob38.Height);
            Rect plat39 = new Rect(Canvas.GetLeft(ob39), Canvas.GetTop(ob39), ob39.Width, ob39.Height);
            Rect plat40 = new Rect(Canvas.GetLeft(ob40), Canvas.GetTop(ob40), ob40.Width, ob40.Height);
            Rect plat41 = new Rect(Canvas.GetLeft(ob41), Canvas.GetTop(ob41), ob41.Width, ob41.Height);
            Rect plat42 = new Rect(Canvas.GetLeft(ob42), Canvas.GetTop(ob42), ob42.Width, ob42.Height);
            Rect plat43 = new Rect(Canvas.GetLeft(ob43), Canvas.GetTop(ob43), ob43.Width, ob43.Height);
            Rect plat44 = new Rect(Canvas.GetLeft(ob44), Canvas.GetTop(ob44), ob44.Width, ob44.Height);
            Rect plat45 = new Rect(Canvas.GetLeft(ob45), Canvas.GetTop(ob45), ob45.Width, ob45.Height);
            Rect plat46 = new Rect(Canvas.GetLeft(ob46), Canvas.GetTop(ob46), ob46.Width, ob46.Height);




            // Border Game over 
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
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                Close();
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
            if (plat15.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat16.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat17.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat18.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat19.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat20.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat21.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat22.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat23.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat24.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat25.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat26.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat27.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat28.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat29.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat30.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat31.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat32.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat33.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat34.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat35.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat36.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat37.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat38.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat39.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat40.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat41.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat42.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat43.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat44.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat45.IntersectsWith(Player1))

            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (plat46.IntersectsWith(Player1))
            {
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }



            

            //Goal

            Rect goal = new Rect(Canvas.GetLeft(Goal), Canvas.GetTop(Goal), Goal.Width, Goal.Height);

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
