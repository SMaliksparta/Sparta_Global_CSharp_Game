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
       
       
        double x = 500;
        double y = 500;


        public MainWindow()
        {
            
            DispatcherTimer timer = new DispatcherTimer();
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

            
        }

       
    }
}

    