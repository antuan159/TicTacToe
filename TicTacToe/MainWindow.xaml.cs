using System.Windows;
using System.Windows.Controls;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BntNewGame_Click(object sender, RoutedEventArgs e)
        {
            ClearFild();
        }
        public string XandO { get; set; }
        public int Counter { get; set; }
        private void BtnClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && string.IsNullOrEmpty(btn.Content as string))
            {
                btn.Content = XandO;
                if (!IsWin())
                {
                    NewSymbol();
                }
            }
        }
        public void NewSymbol()
        {
            if (XandO == "X")
            {
                XandO = "O";
                label.Content = "Ходит O";
            }
            else
            {
                XandO = "X";
                label.Content = "Ходит X";
            }
        }// изменение Х или О
        private void ClearFild()
        {
            Counter = 0;
            XandO = "X";
            BtnLeftTop.Content = null;
            BtnMiddleTop.Content = null;
            BtnRightTop.Content = null;
            BtnMiddleleft.Content = null;
            BtnMiddle.Content = null;
            BtnMiddleRight.Content = null;
            BtnBottomLeft.Content = null;
            BtnBottomMiddle.Content = null;
            BtnBottomRight.Content = null;
            label.Content = "Ходит X";
        }// очистка поля начало новой игры
        private void Win(bool b)
        {
            if (Counter == 9 && b)
            {
                MessageBox.Show($"Игра закончилась в ничью!!");
                ClearFild();
                return;
            }
            MessageBox.Show($"поздравляем победитель  {XandO}");
            ClearFild();
        }//вывод в лейбу победителя
        private bool IsWin()
        {
            Counter++;
            if (AreEquals(BtnLeftTop.Content, BtnMiddleTop.Content, BtnRightTop.Content) ||
               AreEquals(BtnMiddleleft.Content, BtnMiddle.Content, BtnMiddleRight.Content) ||
               AreEquals(BtnBottomLeft.Content, BtnBottomMiddle.Content, BtnBottomRight.Content) ||
               AreEquals(BtnLeftTop.Content, BtnMiddleleft.Content, BtnBottomLeft.Content) ||
               AreEquals(BtnMiddleTop.Content, BtnMiddle.Content, BtnBottomMiddle.Content) ||
               AreEquals(BtnRightTop.Content, BtnMiddleRight.Content, BtnBottomRight.Content) ||
               AreEquals(BtnLeftTop.Content, BtnMiddle.Content, BtnBottomRight.Content) ||
               AreEquals(BtnRightTop.Content, BtnMiddle.Content, BtnBottomLeft.Content))
            {
                Win(false);
                return true;
            }
            if (Counter == 9)
            {
                Win(true);
                return true;
            }
            return false;
        }// проверки на выигрыш по линиям
        public bool AreEquals<T>(params T[] objects)
        {
            if (objects.Length == 1)
            {
                return objects[0] != null;
            }

            if (objects.Length == 2)
            {
                return objects[0] != null && objects[1] != null &&
                    objects[0].Equals(objects[1]);
            }

            var first = objects[0];

            if (first == null)
            {
                return false;
            }

            for (int i = 1; i < objects.Length; i++)
            {
                if (objects[i] == null || !first.Equals(objects[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
