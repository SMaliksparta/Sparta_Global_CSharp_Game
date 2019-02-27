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
        double x = 500;
        double y = 500;

        public Level1()
        {
            DispatcherTimer timer = new DispatcherTimer();
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

            Rect rect1 = new Rect(Canvas.GetLeft(TopBar), Canvas.GetTop(TopBar), TopBar.Width, TopBar.Height);

            Rect rect2 = new Rect(Canvas.GetLeft(LeftBar), Canvas.GetTop(LeftBar), LeftBar.Width, LeftBar.Height);

            Rect rect3 = new Rect(Canvas.GetLeft(BottomBar), Canvas.GetTop(BottomBar), BottomBar.Width, BottomBar.Height);

            Rect rect4 = new Rect(Canvas.GetLeft(RightBar), Canvas.GetTop(RightBar), RightBar.Width, RightBar.Height);

            // Game over 
            if (rect1.IntersectsWith(Player1))

            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                Close();
            }
            if (rect2.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                Close();
            }
            if (rect3.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                Close();
            }
            if (rect4.IntersectsWith(Player1))
            {
                // The two elements overlap
                MessageBoxResult mbr = MessageBox.Show("GAME OVER");
                Close();
            }
        }
    }
}
