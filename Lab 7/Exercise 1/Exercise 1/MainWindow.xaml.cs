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

namespace Exercise_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainGrid.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_click;
                }
            }
 
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            Array.Clear();
            ODD.Clear();
            int num;
            if (int.TryParse(ArraySIZE.Text, out num))
            {
                if (num > 0)
                {
                    int temp;
                    int[] x = new int[Convert.ToInt32(ArraySIZE.Text)];
                    Random ran = new Random();
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = ran.Next(0, 99);
                    }
                    for (int i = 0; i < x.Length; i++)
                    {
                        for (int j = i + 1; j < x.Length; j++)
                        {
                            if (x[i] > x[j])
                            {
                                temp = x[i];
                                x[i] = x[j];
                                x[j] = temp;
                            }
                        }
                    }

                    for (int i = 0; i < x.Length; i++)
                    {
                        Array.Text += $"{x[i]} ";
                    }

                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 != 0)
                        {
                            ODD.Text += $"{x[i]} ";
                        }
                    }

                    int maxValue = x.Max<int>();
                    MAX.Text = Convert.ToString(maxValue);

                    int minValue = x.Min<int>();
                    MIN.Text = Convert.ToString(minValue);

                    int sum = 0;
                    for (int i = 0; i < x.Length; i++)
                    {
                        sum += x[i];
                    }
                    SUM.Text = Convert.ToString(sum);

                    int avg = 0;
                    avg = sum / Convert.ToInt32(ArraySIZE.Text);
                    AVG.Text = Convert.ToString(avg);

                }
                else if(num >= 20)
                {
                    MainLABEL.Content = "Много чисел!!";
                    ArraySIZE.Clear();
                }
                else
                {
                    MainLABEL.Content = "Нужно ввести положительное число";
                    ArraySIZE.Clear();
                }
            }
            else
            {
                MainLABEL.Content = "Поле пустое!!";
                ArraySIZE.Clear();
            }



        }
    }
}
