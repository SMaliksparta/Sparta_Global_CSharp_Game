using System;

namespace GeometryDash
{
    public class Map1
    {
        public static void Lvl1(object sender, EventArgs e)

        {
            Rect Player1 = new Rect(Canvas.GetLeft(Player), Canvas.GetTop(Player), Player.Width, Player.Height);

            // Rect rect1 = new Rect (466, -464, 62, 990);

            Rect rect1 = new Rect(Canvas.GetLeft(TopBar), Canvas.GetTop(TopBar), TopBar.Width, TopBar.Height);

            Rect rect2 = new Rect(Canvas.GetLeft(LeftBar), Canvas.GetTop(LeftBar), LeftBar.Width, LeftBar.Height);

            Rect rect3 = new Rect(Canvas.GetLeft(BottomBar), Canvas.GetTop(BottomBar), BottomBar.Width, BottomBar.Height);

            Rect rect4 = new Rect(Canvas.GetLeft(RightBar), Canvas.GetTop(RightBar), RightBar.Width, RightBar.Height);

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
