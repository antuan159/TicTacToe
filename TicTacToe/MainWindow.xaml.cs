using System.Windows;

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

        private void buttonNewGame_Click(object sender, RoutedEventArgs e)
        {
            ClearFild();
        }

        public string xAndO { get; set; }
        public int counter { get; set; } 

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (button1.Content == "")
            {
                NewSymbol();
                button1.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (button2.Content == "")
            {
                NewSymbol();
                button2.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (button3.Content == "")
            {
                NewSymbol();
                button3.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (button4.Content == "")
            {
                NewSymbol();
                button4.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (button5.Content == "")
            {
                NewSymbol();
                button5.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (button6.Content == "")
            {
                NewSymbol();
                button6.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (button7.Content == "")
            {
                NewSymbol();
                button7.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (button8.Content == "")
            {
                NewSymbol();
                button8.Content = xAndO;
                WinOrFalse();
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (button9.Content == "")
            {
                NewSymbol();
                button9.Content = xAndO;
                WinOrFalse();
            }
        }

        public void NewSymbol()
        {
            if (string.IsNullOrEmpty(xAndO))
            {
                
                xAndO = "X";
                label.Content = "Ходит O";
                return;
            }
            if (xAndO == "O")
            {
                
                xAndO = "X";
                label.Content = "Ходит O";
                return;
            }
            else
            {
                label.Content = "Ходит X";
                xAndO = "O";
                return;
            }
        }// изменение Х или О
        private void ClearFild()
        {
            counter = 0;
            xAndO = "";
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
            label.Content = "Ходит X";
        }// очистка поля начало новой игры
        private void Win(bool b)
        {
            if (counter == 9&&b)
            {
                MessageBox.Show($"Игра закончилась в ничью!!");
                ClearFild();
                return;
            }
            MessageBox.Show($"поздравляем победитель  {xAndO}");
            ClearFild();
        }//вывод в лейбу победителя
        private void WinOrFalse()
        {
            bool win = false;
            counter++;
            if (button1.Content == button2.Content && button1.Content == button3.Content)//1 line
            {
                if(button1.Content=="")
                    return;
                Win(win);
            }
            if (button4.Content == button5.Content && button4.Content == button6.Content)// 2 line
            {
                if (button4.Content == "")
                    return;
                Win(win);
            }
            if (button7.Content == button8.Content && button7.Content == button9.Content)//3 line
            {
                if (button7.Content == "")
                    return;
                Win(win);
            }
            if (button1.Content == button4.Content && button1.Content == button7.Content)//4 line
            {
                if (button1.Content == "")
                    return;
                Win(win);
            }
            if (button2.Content == button5.Content && button2.Content == button8.Content)//5 line
            {
                if (button2.Content == "")
                    return;
                Win(win);
            }
            if (button3.Content == button6.Content && button3.Content == button9.Content)//5 line
            {
                if (button3.Content == "")
                    return;
                Win(win);
            }
            if (button1.Content == button5.Content && button1.Content == button9.Content)//7 line
            {
                if (button1.Content == "")
                    return;
                Win(win);
            }
            if (button3.Content == button5.Content && button3.Content == button7.Content)//8 line
            {
                if (button3.Content == "")
                    return;
                Win(win);
            }
            
            if (counter == 9)
            {
                win = true;
                Win(win);
            }
        }// проверки на выигрыш по линиям
    }
}
