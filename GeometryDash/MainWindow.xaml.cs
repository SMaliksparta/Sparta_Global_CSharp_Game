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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
       
        double x = 133;
        double y = 478;
        DispatcherTimer timer = new DispatcherTimer();


        public MainWindow()
        {
            
            
            timer.Tick += new EventHandler(MovePlayer);
            timer.Tick += new EventHandler(Menu);
            timer.Start();
            


            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Level1 map1 = new Level1();
            map1.Show();
            this.Close();

        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Level2 map2 = new Level2();
            map2.Show();
            this.Close();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Level3 map3 = new Level3();
            map3.Show();
            this.Close();
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
        public void Menu(object sender, EventArgs e)

        {
            Rect Player1 = new Rect(Canvas.GetLeft(Player), Canvas.GetTop(Player), Player.Width, Player.Height);

            // Rect rect1 = new Rect (466, -464, 6-2, 990);

            Rect rect1 = new Rect(Canvas.GetLeft(TopBar), Canvas.GetTop(TopBar), TopBar.Width, TopBar.Height);

            Rect rect2 = new Rect(Canvas.GetLeft(LeftBar), Canvas.GetTop(LeftBar), LeftBar.Width, LeftBar.Height);

            Rect rect3 = new Rect(Canvas.GetLeft(BottomBar), Canvas.GetTop(BottomBar), BottomBar.Width, BottomBar.Height);

            Rect rect4 = new Rect(Canvas.GetLeft(RightBar), Canvas.GetTop(RightBar), RightBar.Width, RightBar.Height);

            Rect rect5 = new Rect(Canvas.GetLeft(TopBar2), Canvas.GetTop(TopBar2), TopBar2.Width, TopBar2.Height);

            Rect rect6 = new Rect(Canvas.GetLeft(LeftBar2), Canvas.GetTop(LeftBar2), LeftBar2.Width, LeftBar2.Height);

            Rect rect7 = new Rect(Canvas.GetLeft(BottomBar2), Canvas.GetTop(BottomBar2), BottomBar2.Width, BottomBar2.Height);

            Rect rect8 = new Rect(Canvas.GetLeft(RightBar2), Canvas.GetTop(RightBar2), RightBar2.Width, RightBar2.Height);

            Rect rect9 = new Rect(Canvas.GetLeft(SecretLevel), Canvas.GetTop(SecretLevel), SecretLevel.Width, SecretLevel.Height);

            //Secret Level 
            if (rect9.IntersectsWith(Player1))

            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("Nothing to see here ... Just kidding you found the Secret Level");

                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();

            }

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
            if (rect5.IntersectsWith(Player1))

            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");

                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();

            }
            if (rect6.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");

                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (rect7.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");

                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
            if (rect8.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                MainWindow menu = new MainWindow();
                menu.Show();
                timer.Stop();
                this.Close();
            }
        }

        

        //public void OnKeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    Listbox.Items.Add(e.KeyCode);
        //    StreamWriter sw = new StreamWriter(@"C:\Users\tech-w78a.LAPTOP-T9HE3QOO\Engineering26\week7\Gameweek\GeometryDash\Sparta_Global_CSharp_Game\Moves.txt");
        //    sw.Write(e.KeyCode);
        //    sw.Close();
        //}

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

    