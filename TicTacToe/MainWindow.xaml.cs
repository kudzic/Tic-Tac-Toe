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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    int a = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            if (a == 0)
            {
                if((sender as Label).Content == null)
                {
                    (sender as Label).Content = "X";
                    a = a + 1;
                }
            }
            else
            {
                if ((sender as Label).Content == null)
                {
                    (sender as Label).Content = "O";
                    a = a - 1;
                }

            }
            Result();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void Result()
        {
            if (lb1.Content == lb2.Content && lb1.Content == lb3.Content && lb1.Content != null && lb2.Content != null && lb3.Content != null)
            {
                MessageBox.Show($"Player:{lb1.Content} Won");
                if (lb1.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb4.Content == lb5.Content && lb4.Content == lb6.Content && lb4.Content != null && lb5.Content != null && lb6.Content != null)
            {
                MessageBox.Show($"Player:{lb4.Content} Won");
                if (lb4.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb7.Content == lb8.Content && lb7.Content == lb9.Content && lb7.Content != null && lb8.Content != null && lb9.Content != null)
            {
                MessageBox.Show($"Player:{lb7.Content} Won");
                if (lb7.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb1.Content == lb5.Content && lb1.Content == lb9.Content && lb1.Content != null && lb5.Content != null && lb9.Content != null)
            {
                MessageBox.Show($"Player:{lb1.Content} Won");
                if (lb1.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb3.Content == lb5.Content && lb3.Content == lb7.Content && lb3.Content != null && lb5.Content != null && lb7.Content != null)
            {
                MessageBox.Show($"Player:{lb3.Content} Won");
                if (lb3.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb1.Content == lb4.Content && lb1.Content == lb7.Content && lb1.Content != null && lb4.Content != null && lb7.Content != null)
            {
                MessageBox.Show($"Player:{lb1.Content} Won");
                if (lb1.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb2.Content == lb5.Content && lb2.Content == lb8.Content && lb2.Content != null && lb5.Content != null && lb8.Content != null)
            {
                MessageBox.Show($"Player:{lb2.Content} Won");
                if (lb2.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb3.Content == lb6.Content && lb3.Content == lb9.Content && lb3.Content != null && lb6.Content != null && lb9.Content != null)
            {
                MessageBox.Show($"Player:{lb3.Content} Won");
                if (lb3.Content == "X")
                {
                    int a = int.Parse(PlayerX.Content.ToString());
                    a = a + 1;
                    PlayerX.Content = a.ToString();
                }
                else
                {
                    int a = int.Parse(PlayerO.Content.ToString());
                    a = a + 1;
                    PlayerO.Content = a.ToString();
                }
                Reset();
            }
            if (lb1.Content != null && lb2.Content != null && lb3.Content != null && lb4.Content != null && lb5.Content != null && lb6.Content != null && lb7.Content != null && lb8.Content != null && lb9.Content != null)
            {
                MessageBox.Show("It was a draw");
                int a = int.Parse(Draw1.Content.ToString());
                a = a + 1;
                Draw1.Content = a.ToString();
                Reset();
            }
        }

        private void Reset()
        {
            lb1.Content = null;
            lb2.Content = null;
            lb3.Content = null;
            lb4.Content = null;
            lb5.Content = null;
            lb6.Content = null;
            lb7.Content = null;
            lb8.Content = null;
            lb9.Content = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lb1.Content = null;
            lb2.Content = null;
            lb3.Content = null;
            lb4.Content = null;
            lb5.Content = null;
            lb6.Content = null;
            lb7.Content = null;
            lb8.Content = null;
            lb9.Content = null;
        }
       
    }
}
