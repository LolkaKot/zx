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
using System.Windows.Shapes;

namespace кнопки3._4
{
    /// <summary>
    /// Логика взаимодействия для tasks.xaml
    /// </summary>
    public partial class tasks : Window
    {
        public tasks()
        {
            InitializeComponent();
        }
        public double rx()
        {
            int x = new Random().Next(0, 5);
            return x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            task1.Visibility = Visibility.Visible;
            task1_1.Visibility = Visibility.Visible;
            task1_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            task2.Visibility = Visibility.Visible;
            task2_1.Visibility = Visibility.Visible;
            task2_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            task3.Visibility = Visibility.Visible;
            task3_1.Visibility = Visibility.Visible;
            task3_2.Visibility = Visibility.Visible;
        }

        private void task1_Click(object sender, RoutedEventArgs e)
        {
            double u, y;
            u = Math.Sin(rx());

            if (u + rx() > -0.5)
            {
                y = (Math.Pow((2 * u + 1), 2)) / (7 * Math.PI + rx());
                MessageBox.Show($"y = {y}");
                task1.Visibility = Visibility.Collapsed;
            }
            else if (-0.5 <= u + rx() && u + rx() >= Math.Pow(10, -3))
            {
                y = Math.Pow((Math.Sin(u)), 2) - Math.Sin(4 / 3);
                MessageBox.Show($"y = {y}");
                task1.Visibility = Visibility.Collapsed;
            }
            else if (u + rx() > Math.Pow(10, -3))
            {
                y = (Math.Log(4 + rx()) - Math.Pow(Math.E, rx())) / (3.5 * rx());
                MessageBox.Show($"y = {y}");
                task1.Visibility = Visibility.Collapsed;
            }
        }

        private void task1_1_Click(object sender, RoutedEventArgs e)
        {
            double u1, y1;
            u1 = Math.Cos(rx());

            if (u1 + rx() > -0.5)
            {
                y1 = (Math.Pow((2 * u1 + 1), 2)) / (7 * Math.PI + rx());
                MessageBox.Show($"y = {y1}");
                task1_1.Visibility = Visibility.Collapsed;
            }
            else if (-0.5 <= u1 + rx() && u1 + rx() >= Math.Pow(10, -3))
            {
                y1 = Math.Pow((Math.Sin(u1)), 2) - Math.Sin(4 / 3);
                MessageBox.Show($"y = {y1}");
                task1_1.Visibility = Visibility.Collapsed;
            }
            else if (u1 + rx() > Math.Pow(10, -3))
            {
                y1 = (Math.Log(4 + rx()) - Math.Pow(Math.E, rx())) / (3.5 * rx());
                MessageBox.Show($"y = {y1}");
                task1_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task1_2_Click(object sender, RoutedEventArgs e)
        {
            double u1_2, y1_2;
            u1_2 = Math.Tan(rx());

            if (u1_2 + rx() > -0.5)
            {
                y1_2 = (Math.Pow((2 * u1_2 + 1), 2)) / (7 * Math.PI + rx());
                MessageBox.Show($"y = {y1_2}");
                task1_2.Visibility = Visibility.Collapsed;
            }
            else if (-0.5 <= u1_2 + rx() && u1_2 + rx() >= Math.Pow(10, -3))
            {
                y1_2 = Math.Pow((Math.Sin(u1_2)), 2) - Math.Sin(4 / 3);
                MessageBox.Show($"y = {y1_2}");
                task1_2.Visibility = Visibility.Collapsed;
            }
            else if (u1_2 + rx() > Math.Pow(10, -3))
            {
                y1_2 = (Math.Log(4 + rx()) - Math.Pow(Math.E, rx())) / (3.5 * rx());
                MessageBox.Show($"y = {y1_2}");
                task1_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task2_Click(object sender, RoutedEventArgs e)
        {
            double a = 0.4, b = 2.3, z = Math.Pow((Math.E), 2 * rx()), y2;

            if (rx() < 3.5 * a)
            {
                y2 = a * b * rx() - Math.Pow((Math.Cos(z * rx())), 2);
                MessageBox.Show($"y = {y2}");
                task2.Visibility = Visibility.Collapsed;
            }
            else if (3.5 * a <= rx() && rx() <= b)
            {
                y2 = Math.Pow((a - rx()), 2) - Math.Log(z + rx());
                MessageBox.Show($"y = {y2}");
                task2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b)
            {
                y2 = Math.Sqrt(b * rx() - a + z * Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y2}");
                task2.Visibility = Visibility.Collapsed;
            }
        }

        private void task2_1_Click(object sender, RoutedEventArgs e)
        {
            double a2 = 0.2, b2 = 0.8, z2 = Math.Pow((Math.E), rx()), y2_1;

            if (rx() < 3.5 * a2)
            {
                y2_1 = a2 * b2 * rx() - Math.Pow((Math.Cos(z2 * rx())), 2);
                MessageBox.Show($"y = {y2_1}");
                task2_1.Visibility = Visibility.Collapsed;
            }
            else if (3.5 * a2 <= rx() && rx() <= b2)
            {
                y2_1 = Math.Pow((a2 - rx()), 2) - Math.Log(z2 + rx());
                MessageBox.Show($"y = {y2_1}");
                task2_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b2)
            {
                y2_1 = Math.Sqrt(b2 * rx() - a2 + z2 * Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y2_1}");
                task2_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task2_2_Click(object sender, RoutedEventArgs e)
        {
            double a2_1 = 0.7, b2_1 = 8.1, z2_1 = 0.8, y2_2;

            if (rx() < 3.5 * a2_1)
            {
                y2_2 = a2_1 * b2_1 * rx() - Math.Pow((Math.Cos(z2_1 * rx())), 2);
                MessageBox.Show($"y = {y2_2}");
                task2_2.Visibility = Visibility.Collapsed;
            }
            else if (3.5 * a2_1 <= rx() && rx() <= b2_1)
            {
                y2_2 = Math.Pow((a2_1 - rx()), 2) - Math.Log(z2_1 + rx());
                MessageBox.Show($"y = {y2_2}");
                task2_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b2_1)
            {
                y2_2 = Math.Sqrt(b2_1 * rx() - a2_1 + z2_1 * Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y2_2}");
                task2_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task3_Click(object sender, RoutedEventArgs e)
        {
            double b3 = -1.6, m = 0.9, n = -1.4, y3;

            if (Math.Abs(b3 * m) > Math.Pow(rx(), 2))
            {
                y3 = Math.Sin(b3 * m + Math.Cos(n * rx()));
                MessageBox.Show($"y = {y3}");
                task3.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(b3 * m) < Math.Pow(rx(), 2))
            {
                y3 = Math.Cos(b3 * m - Math.Sin(rx()));
                MessageBox.Show($"y = {y3}");
                task3.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(b3 * m) == Math.Pow(rx(), 2))
            {
                y3 = Math.Sqrt(Math.Pow((Math.E), Math.Abs(Math.Cos(rx()))) + Math.Sqrt(Math.Abs(b3 * m * rx())));
                MessageBox.Show($"y = {y3}");
                task3.Visibility = Visibility.Collapsed;
            }

        }

        private void task3_1_Click(object sender, RoutedEventArgs e)
        {
            double b3_1 = 4.5, m1 = -2, n1 = 2.2, y3_1;

            if (Math.Abs(b3_1 * m1) > Math.Pow(rx(), 2))
            {
                y3_1 = Math.Sin(b3_1 * m1 + Math.Cos(n1 * rx()));
                MessageBox.Show($"y = {y3_1}");
                task3_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(b3_1 * m1) < Math.Pow(rx(), 2))
            {
                y3_1 = Math.Cos(b3_1 * m1 - Math.Sin(rx()));
                MessageBox.Show($"y = {y3_1}");
                task3_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(b3_1 * m1) == Math.Pow(rx(), 2))
            {
                y3_1 = Math.Sqrt(Math.Pow((Math.E), Math.Abs(Math.Cos(rx()))) + Math.Sqrt(Math.Abs(b3_1 * m1 * rx())));
                MessageBox.Show($"y = {y3_1}");
                task3_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task3_2_Click(object sender, RoutedEventArgs e)
        {
            double b3_2 = -4.5, m1_1 = 0.5, n1_1 = -1.5, y3_2;

            if (Math.Abs(b3_2 * m1_1) > Math.Pow(rx(), 2))
            {
                y3_2 = Math.Sin(b3_2 * m1_1 + Math.Cos(n1_1 * rx()));
                MessageBox.Show($"y = {y3_2}");
                task3_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(b3_2 * m1_1) < Math.Pow(rx(), 2))
            {
                y3_2 = Math.Cos(b3_2 * m1_1 - Math.Sin(rx()));
                MessageBox.Show($"y = {y3_2}");
                task3_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(b3_2 * m1_1) == Math.Pow(rx(), 2))
            {
                y3_2 = Math.Sqrt(Math.Pow((Math.E), Math.Abs(Math.Cos(rx()))) + Math.Sqrt(Math.Abs(b3_2 * m1_1 * rx())));
                MessageBox.Show($"y = {y3_2}");
                task3_2.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            task4.Visibility = Visibility.Visible;
            task4_1.Visibility = Visibility.Visible;
            task4_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            task5.Visibility = Visibility.Visible;
            task5_1.Visibility = Visibility.Visible;
            task5_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            task6.Visibility = Visibility.Visible;
            task6_1.Visibility = Visibility.Visible;
            task6_2.Visibility = Visibility.Visible;
        }

        private void task4_Click(object sender, RoutedEventArgs e)
        {
            double y4, a4 = 0.2, b4 = 0.5, z4 = Math.Pow((Math.E), a4 * rx());

            if (rx() < -Math.Log(a4))
            {
                y4 = a4 * Math.Pow((Math.Sin(rx())), 2) + b4 * Math.Cos(z4 * rx());
                MessageBox.Show($"y = {y4}");
                task4.Visibility = Visibility.Collapsed;
            }
            else if (-Math.Log(a4) <= rx() && rx() <= b4)
            {
                y4 = Math.Pow(a4, b4) - Math.Pow((Math.Cos(a4 + z4 * rx())), 3);
                MessageBox.Show($"y = {y4}");
                task4.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b4)
            {
                y4 = Math.Sqrt(2.5 * Math.Pow(a4, 3) + Math.Pow((b4 - z4 * Math.Pow(rx(), 2)), 6));
                MessageBox.Show($"y = {y4}");
                task4.Visibility = Visibility.Collapsed;
            }
        }

        private void task4_1_Click(object sender, RoutedEventArgs e)
        {
            double y4_1, a4_1 = 0.15, b4_1 = 0.2, z4_1 = Math.Pow((Math.E), 2 * a4_1 * rx());

            if (rx() < -Math.Log(a4_1))
            {
                y4_1 = a4_1 * Math.Pow((Math.Sin(rx())), 2) + b4_1 * Math.Cos(z4_1 * rx());
                MessageBox.Show($"y = {y4_1}");
                task4_1.Visibility = Visibility.Collapsed;
            }
            else if (-Math.Log(a4_1) <= rx() && rx() <= b4_1)
            {
                y4_1 = Math.Pow(a4_1, b4_1) - Math.Pow((Math.Cos(a4_1 + z4_1 * rx())), 3);
                MessageBox.Show($"y = {y4_1}");
                task4_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b4_1)
            {
                y4_1 = Math.Sqrt(2.5 * Math.Pow(a4_1, 3) + Math.Pow((b4_1 - z4_1 * Math.Pow(rx(), 2)), 6));
                MessageBox.Show($"y = {y4_1}");
                task4_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task4_2_Click(object sender, RoutedEventArgs e)
        {
            double y4_2, a4_2 = 0.9, b4_2 = 5, z4_2 = Math.Pow((Math.E), 2.5 * a4_2 * rx());

            if (rx() < -Math.Log(a4_2))
            {
                y4_2 = a4_2 * Math.Pow((Math.Sin(rx())), 2) + b4_2 * Math.Cos(z4_2 * rx());
                MessageBox.Show($"y = {y4_2}");
                task4_2.Visibility = Visibility.Collapsed;
            }
            else if (-Math.Log(a4_2) <= rx() && rx() <= b4_2)
            {
                y4_2 = Math.Pow(a4_2, b4_2) - Math.Pow((Math.Cos(a4_2 + z4_2 * rx())), 3);
                MessageBox.Show($"y = {y4_2}");
                task4_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b4_2)
            {
                y4_2 = Math.Sqrt(2.5 * Math.Pow(a4_2, 3) + Math.Pow((b4_2 - z4_2 * Math.Pow(rx(), 2)), 6));
                MessageBox.Show($"y = {y4_2}");
                task4_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task5_Click(object sender, RoutedEventArgs e)
        {
            double a5 = 4.2, b5 = 5.3, c5 = 1.5, y5;
            if (Math.Pow((Math.E), a5 + b5) > Math.Pow((Math.E), rx()))
            {
                y5 = Math.Sin(Math.Pow((Math.E), a5 + b5)) + Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y5}");
                task5.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow((Math.E), a5 + b5) == Math.Pow((Math.E), rx()))
            {
                y5 = Math.Tanh(a5 * b5 * c5) + Math.Pow(rx(), 1 / 3);
                MessageBox.Show($"y = {y5}");
                task5.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow((Math.E), a5 + b5) < Math.Pow((Math.E), rx()))
            {
                y5 = Math.Cos(Math.Sqrt(Math.Abs(rx() + a5 * b5 * c5)));
                MessageBox.Show($"y = {y5}");
                task5.Visibility = Visibility.Collapsed;
            }
        }

        private void task5_1_Click(object sender, RoutedEventArgs e)
        {
            double a5_1 = -0.35, b5_1 = 1.8, c5_1 = -1.8, y5_1;
            if (Math.Pow((Math.E), a5_1 + b5_1) > Math.Pow((Math.E), rx()))
            {
                y5_1 = Math.Sin(Math.Pow((Math.E), a5_1 + b5_1)) + Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y5_1}");
                task5_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow((Math.E), a5_1 + b5_1) == Math.Pow((Math.E), rx()))
            {
                y5_1 = Math.Tanh(a5_1 * b5_1 * c5_1) + Math.Pow(rx(), 1 / 3);
                MessageBox.Show($"y = {y5_1}");
                task5_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow((Math.E), a5_1 + b5_1) < Math.Pow((Math.E), rx()))
            {
                y5_1 = Math.Cos(Math.Sqrt(Math.Abs(rx() + a5_1 * b5_1 * c5_1)));
                MessageBox.Show($"y = {y5_1}");
                task5_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task5_2_Click(object sender, RoutedEventArgs e)
        {
            double a5_2 = 2.8, b5_2 = -0.6, c5_2 = 2, y5_2;
            if (Math.Pow((Math.E), a5_2 + b5_2) > Math.Pow((Math.E), rx()))
            {
                y5_2 = Math.Sin(Math.Pow((Math.E), a5_2 + b5_2)) + Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y5_2}");
                task5_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow((Math.E), a5_2 + b5_2) == Math.Pow((Math.E), rx()))
            {
                y5_2 = Math.Tanh(a5_2 * b5_2 * c5_2) + Math.Pow(rx(), 1 / 3);
                MessageBox.Show($"y = {y5_2}");
                task5_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow((Math.E), a5_2 + b5_2) < Math.Pow((Math.E), rx()))
            {
                y5_2 = Math.Cos(Math.Sqrt(Math.Abs(rx() + a5_2 * b5_2 * c5_2)));
                MessageBox.Show($"y = {y5_2}");
                task5_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task6_Click(object sender, RoutedEventArgs e)
        {
            double y6, a6 = -5, b6 = 2.5, z6 = Math.Log(Math.Abs(b6 * Math.Pow((rx()), 3)));

            if (rx() < a6)
            {
                y6 = 2.8 * Math.Pow((Math.Sin(a6)), 2) * rx() - b6 * Math.Pow(rx(), 3) * z6;
                MessageBox.Show($"y = {y6}");
                task6.Visibility = Visibility.Collapsed;
            }
            else if (a6 <= rx() && rx() <= Math.Pow(b6, 2))
            {
                y6 = z6 * Math.Pow((Math.Cos(a6 * rx() + b6)), 2) + Math.Log(z6);
                MessageBox.Show($"y = {y6}");
                task6.Visibility = Visibility.Collapsed;
            }
            if (rx() > Math.Pow(b6, 2))
            {
                y6 = Math.Pow((Math.E), 2.5 * a6 * rx()) + z6 * a6 * b6 * rx();
                MessageBox.Show($"y = {y6}");
                task6.Visibility = Visibility.Collapsed;
            }
        }

        private void task6_1_Click(object sender, RoutedEventArgs e)
        {
            double y6_1, a6_1 = 3, b6_1 = 5, z6_1 = Math.Log(Math.Abs(b6_1 * rx()));

            if (rx() < a6_1)
            {
                y6_1 = 2.8 * Math.Pow((Math.Sin(a6_1)), 2) * rx() - b6_1 * Math.Pow(rx(), 3) * z6_1;
                MessageBox.Show($"y = {y6_1}");
                task6_1.Visibility = Visibility.Collapsed;
            }
            else if (a6_1 <= rx() && rx() <= Math.Pow(b6_1, 2))
            {
                y6_1 = z6_1 * Math.Pow((Math.Cos(a6_1 * rx() + b6_1)), 2) + Math.Log(z6_1);
                MessageBox.Show($"y = {y6_1}");
                task6_1.Visibility = Visibility.Collapsed;
            }
            if (rx() > Math.Pow(b6_1, 2))
            {
                y6_1 = Math.Pow((Math.E), 2.5 * a6_1 * rx()) + z6_1 * a6_1 * b6_1 * rx();
                MessageBox.Show($"y = {y6_1}");
                task6_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task6_2_Click(object sender, RoutedEventArgs e)
        {
            double y6_2, a6_2 = -10, b6_2 = 3, z6_2 = Math.Log(Math.Abs(b6_2 * Math.Pow((rx()), 2)));

            if (rx() < a6_2)
            {
                y6_2 = 2.8 * Math.Pow((Math.Sin(a6_2)), 2) * rx() - b6_2 * Math.Pow(rx(), 3) * z6_2;
                MessageBox.Show($"y = {y6_2}");
                task6_2.Visibility = Visibility.Collapsed;
            }
            else if (a6_2 <= rx() && rx() <= Math.Pow(b6_2, 2))
            {
                y6_2 = z6_2 * Math.Pow((Math.Cos(a6_2 * rx() + b6_2)), 2) + Math.Log(z6_2);
                MessageBox.Show($"y = {y6_2}");
                task6_2.Visibility = Visibility.Collapsed;
            }
            if (rx() > Math.Pow(b6_2, 2))
            {
                y6_2 = Math.Pow((Math.E), 2.5 * a6_2 * rx()) + z6_2 * a6_2 * b6_2 * rx();
                MessageBox.Show($"y = {y6_2}");
                task6_2.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            task7.Visibility = Visibility.Visible;
            task7_1.Visibility = Visibility.Visible;
            task7_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            task8.Visibility = Visibility.Visible;
            task8_1.Visibility = Visibility.Visible;
            task8_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            task9.Visibility = Visibility.Visible;
            task9_1.Visibility = Visibility.Visible;
            task9_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            task10.Visibility = Visibility.Visible;
            task10_1.Visibility = Visibility.Visible;
            task10_2.Visibility = Visibility.Visible;
        }

        private void task7_Click(object sender, RoutedEventArgs e)
        {
            double y7, a7 = 3.2, b7 = -0.7, c7 = 2.2;

            if (Math.Abs(1 - Math.Pow(rx(), 2)) == a7 + c7)
            {
                y7 = rx() * Math.Pow((Math.E), a7) + Math.Pow((Math.E), Math.Abs(b7 * Math.E));
                MessageBox.Show($"y = {y7}");
                task7.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) > a7 + c7)
            {
                y7 = Math.Pow((Math.Sin(a7)), 2) * rx() + Math.Cos(b7 * c7);
                MessageBox.Show($"y = {y7}");
                task7.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) < a7 + c7)
            {
                y7 = Math.Sqrt(a7 * Math.Pow(b7, 4) * Math.Pow(c7 * Math.Pow(rx(), 2), 1 / 5));
                MessageBox.Show($"y = {y7}");
                task7.Visibility = Visibility.Collapsed;
            }
        }
        private void task7_1_Click(object sender, RoutedEventArgs e)
        {
            double y7_1, a7_1 = 10.5, b7_1 = -2.5, c7_1 = 5.6;

            if (Math.Abs(1 - Math.Pow(rx(), 2)) == a7_1 + c7_1)
            {
                y7_1 = rx() * Math.Pow((Math.E), a7_1) + Math.Pow((Math.E), Math.Abs(b7_1 * Math.E));
                MessageBox.Show($"y = {y7_1}");
                task7_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) > a7_1 + c7_1)
            {
                y7_1 = Math.Pow((Math.Sin(a7_1)), 2) * rx() + Math.Cos(b7_1 * c7_1);
                MessageBox.Show($"y = {y7_1}");
                task7_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) < a7_1 + c7_1)
            {
                y7_1 = Math.Sqrt(a7_1 * Math.Pow(b7_1, 4) * Math.Pow(c7_1 * Math.Pow(rx(), 2), 1 / 5));
                MessageBox.Show($"y = {y7_1}");
                task7_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task7_2_Click(object sender, RoutedEventArgs e)
        {
            double y7_2, a7_2 = 5.4, b7_2 = 3, c7_2 = 2.6;

            if (Math.Abs(1 - Math.Pow(rx(), 2)) == a7_2 + c7_2)
            {
                y7_2 = rx() * Math.Pow((Math.E), a7_2) + Math.Pow((Math.E), Math.Abs(b7_2 * Math.E));
                MessageBox.Show($"y = {y7_2}");
                task7_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) > a7_2 + c7_2)
            {
                y7_2 = Math.Pow((Math.Sin(a7_2)), 2) * rx() + Math.Cos(b7_2 * c7_2);
                MessageBox.Show($"y = {y7_2}");
                task7_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) < a7_2 + c7_2)
            {
                y7_2 = Math.Sqrt(a7_2 * Math.Pow(b7_2, 4) * Math.Pow(c7_2 * Math.Pow(rx(), 2), 1 / 5));
                MessageBox.Show($"y = {y7_2}");
                task7_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task8_Click(object sender, RoutedEventArgs e)
        {
            double y8, k8 = 3.1, m8 = 5.15, n8 = -1.15;

            if (Math.Pow(rx(), 2) > m8 + n8)
            {
                y8 = Math.Log(Math.Abs(m8 * rx() + n8));
                MessageBox.Show($"y = {y8}");
                task8.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow(rx(), 2) == m8 + n8)
            {
                y8 = Math.Pow(Math.E, Math.Cos(Math.Abs(m8 * rx() - n8)));
                MessageBox.Show($"y = {y8}");
                task8.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow(rx(), 2) < m8 + n8)
            {
                y8 = Math.Pow((Math.Pow(k8, 2) + Math.Pow(Math.Cos(rx()), 2)), 1 / 3);
                MessageBox.Show($"y = {y8}");
                task8.Visibility = Visibility.Collapsed;
            }
        }

        private void task8_1_Click(object sender, RoutedEventArgs e)
        {
            double y8_1, k8_1 = 0.78, m8_1 = -2.4, n8_1 = 4.36;

            if (Math.Pow(rx(), 2) > m8_1 + n8_1)
            {
                y8_1 = Math.Log(Math.Abs(m8_1 * rx() + n8_1));
                MessageBox.Show($"y = {y8_1}");
                task8_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow(rx(), 2) == m8_1 + n8_1)
            {
                y8_1 = Math.Pow(Math.E, Math.Cos(Math.Abs(m8_1 * rx() - n8_1)));
                MessageBox.Show($"y = {y8_1}");
                task8_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow(rx(), 2) < m8_1 + n8_1)
            {
                y8_1 = Math.Pow((Math.Pow(k8_1, 2) + Math.Pow(Math.Cos(rx()), 2)), 1 / 3);
                MessageBox.Show($"y = {y8_1}");
                task8_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task8_2_Click(object sender, RoutedEventArgs e)
        {
            double y8_2, k8_2 = 1.1, m8_2 = 0.8, n8_2 = 0.41;

            if (Math.Pow(rx(), 2) > m8_2 + n8_2)
            {
                y8_2 = Math.Log(Math.Abs(m8_2 * rx() + n8_2));
                MessageBox.Show($"y = {y8_2}");
                task8_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow(rx(), 2) == m8_2 + n8_2)
            {
                y8_2 = Math.Pow(Math.E, Math.Cos(Math.Abs(m8_2 * rx() - n8_2)));
                MessageBox.Show($"y = {y8_2}");
                task8_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Pow(rx(), 2) < m8_2 + n8_2)
            {
                y8_2 = Math.Pow((Math.Pow(k8_2, 2) + Math.Pow(Math.Cos(rx()), 2)), 1 / 3);
                MessageBox.Show($"y = {y8_2}");
                task8_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task9_Click(object sender, RoutedEventArgs e)
        {
            double y9, a9 = 1.2, b9 = 7.2, z9 = Math.Pow(Math.E, rx());

            if (rx() < Math.Pow(a9, 3))
            {
                y9 = a9 * Math.Pow((Math.Sin(rx())), 2) + b9 * Math.Cos(z9 * rx() + a9);
                MessageBox.Show($"y = {y9}");
                task9.Visibility = Visibility.Collapsed;
            }

            else if (Math.Pow(a9, 3) <= rx() && rx() <= b9)
            {
                y9 = Math.Pow((a9 + b9 * rx()), 2) - Math.Sin(a9 + z9 * rx());
                MessageBox.Show($"y = {y9}");
                task9.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b9)
            {
                y9 = Math.Sqrt(rx() - (Math.Sin(b9 * rx() + z9)));
                MessageBox.Show($"y = {y9}");
                task9.Visibility = Visibility.Collapsed;
            }
        }

        private void task9_1_Click(object sender, RoutedEventArgs e)
        {
            double y9_1, a9_1 = -1.5, b9_1 = 3.2, z9_1 = Math.Pow(Math.E, 2 * rx());

            if (rx() < Math.Pow(a9_1, 3))
            {
                y9_1 = a9_1 * Math.Pow((Math.Sin(rx())), 2) + b9_1 * Math.Cos(z9_1 * rx() + a9_1);
                MessageBox.Show($"y = {y9_1}");
                task9_1.Visibility = Visibility.Collapsed;
            }

            else if (Math.Pow(a9_1, 3) <= rx() && rx() <= b9_1)
            {
                y9_1 = Math.Pow((a9_1 + b9_1 * rx()), 2) - Math.Sin(a9_1 + z9_1 * rx());
                MessageBox.Show($"y = {y9_1}");
                task9_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b9_1)
            {
                y9_1 = Math.Sqrt(rx() - (Math.Sin(b9_1 * rx() + z9_1)));
                MessageBox.Show($"y = {y9_1}");
                task9_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task9_2_Click(object sender, RoutedEventArgs e)
        {
            double y9_2, a9_2 = 1.7, b9_2 = 5.5, z9_2 = Math.Pow(Math.E, 3);

            if (rx() < Math.Pow(a9_2, 3))
            {
                y9_2 = a9_2 * Math.Pow((Math.Sin(rx())), 2) + b9_2 * Math.Cos(z9_2 * rx() + a9_2);
                MessageBox.Show($"y = {y9_2}");
                task9_2.Visibility = Visibility.Collapsed;
            }

            else if (Math.Pow(a9_2, 3) <= rx() && rx() <= b9_2)
            {
                y9_2 = Math.Pow((a9_2 + b9_2 * rx()), 2) - Math.Sin(a9_2 + z9_2 * rx());
                MessageBox.Show($"y = {y9_2}");
                task9_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b9_2)
            {
                y9_2 = Math.Sqrt(rx() - (Math.Sin(b9_2 * rx() + z9_2)));
                MessageBox.Show($"y = {y9_2}");
                task9_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task10_Click(object sender, RoutedEventArgs e)
        {
            double y10, a10 = 0.1, b10 = 9.8, c10 = 11.12;

            if (Math.Log(a10) < rx())
            {
                y10 = Math.Pow((Math.Pow(b10, 2)) + Math.Sqrt(Math.Abs(rx() + c10)), 1.0 / 3.0);
                MessageBox.Show($"y = {y10}");
                task10.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a10) == rx())
            {
                y10 = Math.Cos(rx() - b10 - c10);
                MessageBox.Show($"y = {y10}");
                task10.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a10) > rx())
            {
                y10 = Math.Cos(rx() - b10 - c10);
                MessageBox.Show($"y = {y10}");
                task10.Visibility = Visibility.Collapsed;
            }
        }

        private void task10_1_Click(object sender, RoutedEventArgs e)
        {
            double y10_1, a10_1 = 10, b10_1 = 10.05, c10_1 = 6.2;

            if (Math.Log(a10_1) < rx())
            {
                y10_1 = Math.Pow((Math.Pow(b10_1, 2)) + Math.Sqrt(Math.Abs(rx() + c10_1)), 1.0 / 3.0);
                MessageBox.Show($"y = {y10_1}");
                task10_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a10_1) == rx())
            {
                y10_1 = Math.Cos(rx() - b10_1 - c10_1);
                MessageBox.Show($"y = {y10_1}");
                task10_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a10_1) > rx())
            {
                y10_1 = Math.Cos(rx() - b10_1 - c10_1);
                MessageBox.Show($"y = {y10_1}");
                task10_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task10_2_Click(object sender, RoutedEventArgs e)
        {
            double y10_2, a10_2 = 100, b10_2 = 3.03, c10_2 = 7.12;

            if (Math.Log(a10_2) < rx())
            {
                y10_2 = Math.Pow((Math.Pow(b10_2, 2)) + Math.Sqrt(Math.Abs(rx() + c10_2)), 1.0 / 3.0);
                MessageBox.Show($"y = {y10_2}");
                task10_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a10_2) == rx())
            {
                y10_2 = Math.Cos(rx() - b10_2 - c10_2);
                MessageBox.Show($"y = {y10_2}");
                task10_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a10_2) > rx())
            {
                y10_2 = Math.Cos(rx() - b10_2 - c10_2);
                MessageBox.Show($"y = {y10_2}");
                task10_2.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            task11.Visibility = Visibility.Visible;
            task11_1.Visibility = Visibility.Visible;
            task11_2.Visibility = Visibility.Visible;
        }

        private void task11_Click(object sender, RoutedEventArgs e)
        {
            double y11, a11 = -1, b11 = 3.4, z11 = Math.Tan(b11 * rx());

            if (rx() < a11)
            {
                y11 = Math.Pow(Math.E, a11 * rx()) - 3.5 * Math.Pow((Math.Cos(z11 + b11 * rx())), 2);
                MessageBox.Show($"y = {y11}");
                task11.Visibility = Visibility.Collapsed;
            }
            else if (a11 <= rx() && rx() <= Math.Pow(b11, 3.5))
            {
                y11 = a11 + Math.Log(Math.Abs(a11 + b11 * rx())) - 2 * rx();
                MessageBox.Show($"y = {y11}");
                task11.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b11, 3.5))
            {
                y11 = a11 * Math.Pow((Math.Cos(a11 + b11 * rx() * z11)), 3.5);
                MessageBox.Show($"y = {y11}");
                task11.Visibility = Visibility.Collapsed;
            }
        }

        private void task11_1_Click(object sender, RoutedEventArgs e)
        {
            double y11_1, a11_1 = -3.2, b11_1 = 5.5, z11_1 = Math.Tan(b11_1 * Math.Pow(rx(), 2));

            if (rx() < a11_1)
            {
                y11_1 = Math.Pow(Math.E, a11_1 * rx()) - 3.5 * Math.Pow((Math.Cos(z11_1 + b11_1 * rx())), 2);
                MessageBox.Show($"y = {y11_1}");
                task11_1.Visibility = Visibility.Collapsed;
            }
            else if (a11_1 <= rx() && rx() <= Math.Pow(b11_1, 3.5))
            {
                y11_1 = a11_1 + Math.Log(Math.Abs(a11_1 + b11_1 * rx())) - 2 * rx();
                MessageBox.Show($"y = {y11_1}");
                task11_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b11_1, 3.5))
            {
                y11_1 = a11_1 * Math.Pow((Math.Cos(a11_1 + b11_1 * rx() * z11_1)), 3.5);
                MessageBox.Show($"y = {y11_1}");
                task11_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task11_2_Click(object sender, RoutedEventArgs e)
        {
            double y11_2, a11_2 = -5.2, b11_2 = 7.2, z11_2 = Math.Tan(b11_2 * Math.Pow(rx(), 3));

            if (rx() < a11_2)
            {
                y11_2 = Math.Pow(Math.E, a11_2 * rx()) - 3.5 * Math.Pow((Math.Cos(z11_2 + b11_2 * rx())), 2);
                MessageBox.Show($"y = {y11_2}");
                task11_2.Visibility = Visibility.Collapsed;
            }
            else if (a11_2 <= rx() && rx() <= Math.Pow(b11_2, 3.5))
            {
                y11_2 = a11_2 + Math.Log(Math.Abs(a11_2 + b11_2 * rx())) - 2 * rx();
                MessageBox.Show($"y = {y11_2}");
                task11_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b11_2, 3.5))
            {
                y11_2 = a11_2 * Math.Pow((Math.Cos(a11_2 + b11_2 * rx() * z11_2)), 3.5);
                MessageBox.Show($"y = {y11_2}");
                task11_2.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            task12.Visibility = Visibility.Visible;
            task12_1.Visibility = Visibility.Visible;
            task12_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            task13.Visibility = Visibility.Visible;
            task13_1.Visibility = Visibility.Visible;
            task13_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            task14.Visibility = Visibility.Visible;
            task14_1.Visibility = Visibility.Visible;
            task14_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            task15.Visibility = Visibility.Visible;
            task15_1.Visibility = Visibility.Visible;
            task15_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            task16.Visibility = Visibility.Visible;
            task16_1.Visibility = Visibility.Visible;
            task16_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            task17.Visibility = Visibility.Visible;
            task17_1.Visibility = Visibility.Visible;
            task17_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            task18.Visibility = Visibility.Visible;
            task18_1.Visibility = Visibility.Visible;
            task18_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            task19.Visibility = Visibility.Visible;
            task19_1.Visibility = Visibility.Visible;
            task19_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            task20.Visibility = Visibility.Visible;
            task20_1.Visibility = Visibility.Visible;
            task20_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            task21.Visibility = Visibility.Visible;
            task21_1.Visibility = Visibility.Visible;
            task21_2.Visibility = Visibility.Visible;
        }

        private void task12_Click(object sender, RoutedEventArgs e)
        {
            double y12, k12 = 4, m12 = -14.7, n12 = -0.6;

            if (3 * rx() > Math.Abs(m12 + n12))
            {
                y12 = Math.Log(Math.Abs(Math.Log(k12 * rx() + m12 * n12)));
                MessageBox.Show($"y = {y12}");
                task12.Visibility = Visibility.Collapsed;
            }
            else if (3 * rx() == Math.Abs(m12 + n12))
            {
                y12 = Math.Sin(k12 * m12 * rx()) + Math.Sqrt(Math.Abs(n12 * rx()));
                MessageBox.Show($"y = {y12}");
                task12.Visibility = Visibility.Collapsed;
            }
            else if (3 * rx() < Math.Abs(m12 + n12))
            {
                y12 = Math.Pow(Math.E, Math.Cos(rx())) + Math.Pow(Math.E, m12 + n12);
                MessageBox.Show($"y = {y12}");
                task12.Visibility = Visibility.Collapsed;
            }
        }

        private void task12_1_Click(object sender, RoutedEventArgs e)
        {
            double y12_1, k12_1 = 3, m12_1 = 6.5, n12_1 = 3.15;

            if (3 * rx() > Math.Abs(m12_1 + n12_1))
            {
                y12_1 = Math.Log(Math.Abs(Math.Log(k12_1 * rx() + m12_1 * n12_1)));
                MessageBox.Show($"y = {y12_1}");
                task12_1.Visibility = Visibility.Collapsed;
            }
            else if (3 * rx() == Math.Abs(m12_1 + n12_1))
            {
                y12_1 = Math.Sin(k12_1 * m12_1 * rx()) + Math.Sqrt(Math.Abs(n12_1 * rx()));
                MessageBox.Show($"y = {y12_1}");
                task12_1.Visibility = Visibility.Collapsed;
            }
            else if (3 * rx() < Math.Abs(m12_1 + n12_1))
            {
                y12_1 = Math.Pow(Math.E, Math.Cos(rx())) + Math.Pow(Math.E, m12_1 + n12_1);
                MessageBox.Show($"y = {y12_1}");
                task12_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task12_2_Click(object sender, RoutedEventArgs e)
        {
            double y12_2, k12_2 = 5, m12_2 = -12, n12_2 = 0.45;

            if (3 * rx() > Math.Abs(m12_2 + n12_2))
            {
                y12_2 = Math.Log(Math.Abs(Math.Log(k12_2 * rx() + m12_2 * n12_2)));
                MessageBox.Show($"y = {y12_2}");
                task12_2.Visibility = Visibility.Collapsed;
            }
            else if (3 * rx() == Math.Abs(m12_2 + n12_2))
            {
                y12_2 = Math.Sin(k12_2 * m12_2 * rx()) + Math.Sqrt(Math.Abs(n12_2 * rx()));
                MessageBox.Show($"y = {y12_2}");
                task12_2.Visibility = Visibility.Collapsed;
            }
            else if (3 * rx() < Math.Abs(m12_2 + n12_2))
            {
                y12_2 = Math.Pow(Math.E, Math.Cos(rx())) + Math.Pow(Math.E, m12_2 + n12_2);
                MessageBox.Show($"y = {y12_2}");
                task12_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task13_Click(object sender, RoutedEventArgs e)
        {
            double y13, k13 = 1.33, r13 = 0.85, s13 = 3.5;

            if (Math.Cos(rx()) == Math.Cos(r13 * rx()))
            {
                y13 = Math.Pow(rx(), 2) * Math.Pow(Math.E, 2 * k13) + Math.Log(Math.Abs(r13 * rx()));
                MessageBox.Show($"y = {y13}");
                task13.Visibility = Visibility.Collapsed;
            }
            else if (Math.Cos(rx()) > Math.Cos(r13 * rx()))
            {
                y13 = Math.Pow(Math.Pow(rx(), 2), 1 / 3) + Math.Sqrt(Math.Abs(k13 + r13 * s13 * rx()));
                MessageBox.Show($"y = {y13}");
                task13.Visibility = Visibility.Collapsed;
            }
            else if (Math.Cos(rx()) < Math.Cos(r13 * rx()))
            {
                y13 = Math.Atan(k13 * rx() + r13 * s13);
                MessageBox.Show($"y = {y13}");
                task13.Visibility = Visibility.Collapsed;
            }
        }

        private void task13_1_Click(object sender, RoutedEventArgs e)
        {
            double y13_1, k13_1 = 0.9, r13_1 = 3.3, s13_1 = 1.2;

            if (Math.Cos(rx()) == Math.Cos(r13_1 * rx()))
            {
                y13_1 = Math.Pow(rx(), 2) * Math.Pow(Math.E, 2 * k13_1) + Math.Log(Math.Abs(r13_1 * rx()));
                MessageBox.Show($"y = {y13_1}");
                task13_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Cos(rx()) > Math.Cos(r13_1 * rx()))
            {
                y13_1 = Math.Pow(Math.Pow(rx(), 2), 1 / 3) + Math.Sqrt(Math.Abs(k13_1 + r13_1 * s13_1 * rx()));
                MessageBox.Show($"y = {y13_1}");
                task13_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Cos(rx()) < Math.Cos(r13_1 * rx()))
            {
                y13_1 = Math.Atan(k13_1 * rx() + r13_1 * s13_1);
                MessageBox.Show($"y = {y13_1}");
                task13_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task13_2_Click(object sender, RoutedEventArgs e)
        {
            double y13_2, k13_2 = 1.57, r13_2 = 0.75, s13_2 = 2.15;

            if (Math.Cos(rx()) == Math.Cos(r13_2 * rx()))
            {
                y13_2 = Math.Pow(rx(), 2) * Math.Pow(Math.E, 2 * k13_2) + Math.Log(Math.Abs(r13_2 * rx()));
                MessageBox.Show($"y = {y13_2}");
                task13_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Cos(rx()) > Math.Cos(r13_2 * rx()))
            {
                y13_2 = Math.Pow(Math.Pow(rx(), 2), 1 / 3) + Math.Sqrt(Math.Abs(k13_2 + r13_2 * s13_2 * rx()));
                MessageBox.Show($"y = {y13_2}");
                task13_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Cos(rx()) < Math.Cos(r13_2 * rx()))
            {
                y13_2 = Math.Atan(k13_2 * rx() + r13_2 * s13_2);
                MessageBox.Show($"y = {y13_2}");
                task13_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task14_Click(object sender, RoutedEventArgs e)
        {
            double y14, a14 = 0.5, b14 = 4.5, z14 = Math.Pow(Math.E, a14 * rx());

            if (rx() <= 5 * a14)
            {
                y14 = 2.5 * Math.Pow(b14, 2) + a14 * rx() - 4.5 * Math.Cos(rx()) * z14;
                MessageBox.Show($"y = {y14}");
                task14.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b14)
            {
                y14 = Math.Pow((Math.Pow(a14, 2) - 5.4 * rx()), 3) + Math.Log(rx() * z14);
                MessageBox.Show($"y = {y14}");
                task14.Visibility = Visibility.Collapsed;
            }
            else if (5 * a14 < rx() && rx() <= b14)
            {
                y14 = Math.Sqrt(6.5 * Math.Pow(b14, 2) + (a14 * Math.Pow(rx(), 3) * z14));
                MessageBox.Show($"y = {y14}");
                task14.Visibility = Visibility.Collapsed;
            }
        }

        private void task14_1_Click(object sender, RoutedEventArgs e)
        {
            double y14_1, a14_1 = 0.5, b14_1 = 3.7, z14_1 = Math.Pow(Math.E, 2 * a14_1 * rx());

            if (rx() <= 5 * a14_1)
            {
                y14_1 = 2.5 * Math.Pow(b14_1, 2) + a14_1 * rx() - 4.5 * Math.Cos(rx()) * z14_1;
                MessageBox.Show($"y = {y14_1}");
                task14_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b14_1)
            {
                y14_1 = Math.Pow((Math.Pow(a14_1, 2) - 5.4 * rx()), 3) + Math.Log(rx() * z14_1);
                MessageBox.Show($"y = {y14_1}");
                task14_1.Visibility = Visibility.Collapsed;
            }
            else if (5 * a14_1 < rx() && rx() <= b14_1)
            {
                y14_1 = Math.Sqrt(6.5 * Math.Pow(b14_1, 2) + (a14_1 * Math.Pow(rx(), 3) * z14_1));
                MessageBox.Show($"y = {y14_1}");
                task14_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task14_2_Click(object sender, RoutedEventArgs e)
        {
            double y14_2, a14_2 = 0.5, b14_2 = 2.7, z14_2 = Math.Pow(Math.E, 2.5 * a14_2 * rx());

            if (rx() <= 5 * a14_2)
            {
                y14_2 = 2.5 * Math.Pow(b14_2, 2) + a14_2 * rx() - 4.5 * Math.Cos(rx()) * z14_2;
                MessageBox.Show($"y = {y14_2}");
                task14_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b14_2)
            {
                y14_2 = Math.Pow((Math.Pow(a14_2, 2) - 5.4 * rx()), 3) + Math.Log(rx() * z14_2);
                MessageBox.Show($"y = {y14_2}");
                task14_2.Visibility = Visibility.Collapsed;
            }
            else if (5 * a14_2 < rx() && rx() <= b14_2)
            {
                y14_2 = Math.Sqrt(6.5 * Math.Pow(b14_2, 2) + (a14_2 * Math.Pow(rx(), 3) * z14_2));
                MessageBox.Show($"y = {y14_2}");
                task14_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task15_Click(object sender, RoutedEventArgs e)
        {
            double y15, a15 = 3.5, b15 = -0.73, c15 = 2.5;

            if (Math.Abs(1 - Math.Pow(rx(), 2)) == a15 + c15)
            {
                y15 = Math.Sqrt(Math.Abs(a15 * rx() - Math.Pow(Math.Cos(Math.Pow(b15, 3)), 2) * rx() + 5.1 * Math.Pow(c15, 2))); ;
                MessageBox.Show($"y = {y15}");
                task15.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) > a15 + c15)
            {
                y15 = Math.Exp(0.04 * rx()) + Math.Log(Math.Abs(Math.Pow(b15, 5) * Math.Cos(rx())));
                MessageBox.Show($"y = {y15}");
                task15.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) < a15 + c15)
            {
                y15 = Math.Pow(Math.Cos(Math.Pow(b15, 3) * Math.Pow(rx(), 2)), 2) + Math.Log(Math.Abs(b15 * rx() - Math.Pow(a15, 2)));
                MessageBox.Show($"y = {y15}");
                task15.Visibility = Visibility.Collapsed;
            }
        }

        private void task15_1_Click(object sender, RoutedEventArgs e)
        {
            double y15_1, a15_1 = 15.4, b15_1 = -5.6, c15_1 = 3.5;

            if (Math.Abs(1 - Math.Pow(rx(), 2)) == a15_1 + c15_1)
            {
                y15_1 = Math.Sqrt(Math.Abs(a15_1 * rx() - Math.Pow(Math.Cos(Math.Pow(b15_1, 3)), 2) * rx() + 5.1 * Math.Pow(c15_1, 2))); ;
                MessageBox.Show($"y = {y15_1}");
                task15_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) > a15_1 + c15_1)
            {
                y15_1 = Math.Exp(0.04 * rx()) + Math.Log(Math.Abs(Math.Pow(b15_1, 5) * Math.Cos(rx())));
                MessageBox.Show($"y = {y15_1}");
                task15_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) < a15_1 + c15_1)
            {
                y15_1 = Math.Pow(Math.Cos(Math.Pow(b15_1, 3) * Math.Pow(rx(), 2)), 2) + Math.Log(Math.Abs(b15_1 * rx() - Math.Pow(a15_1, 2)));
                MessageBox.Show($"y = {y15_1}");
                task15_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task15_2_Click(object sender, RoutedEventArgs e)
        {
            double y15_2, a15_2 = 15.4, b15_2 = -5.6, c15_2 = 3.5;

            if (Math.Abs(1 - Math.Pow(rx(), 2)) == a15_2 + c15_2)
            {
                y15_2 = Math.Sqrt(Math.Abs(a15_2 * rx() - Math.Pow(Math.Cos(Math.Pow(b15_2, 3)), 2) * rx() + 5.1 * Math.Pow(c15_2, 2))); ;
                MessageBox.Show($"y = {y15_2}");
                task15_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) > a15_2 + c15_2)
            {
                y15_2 = Math.Exp(0.04 * rx()) + Math.Log(Math.Abs(Math.Pow(b15_2, 5) * Math.Cos(rx())));
                MessageBox.Show($"y = {y15_2}");
                task15_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(1 - Math.Pow(rx(), 2)) < a15_2 + c15_2)
            {
                y15_2 = Math.Pow(Math.Cos(Math.Pow(b15_2, 3) * Math.Pow(rx(), 2)), 2) + Math.Log(Math.Abs(b15_2 * rx() - Math.Pow(a15_2, 2)));
                MessageBox.Show($"y = {y15_2}");
                task15_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task16_Click(object sender, RoutedEventArgs e)
        {
            double y16, a16 = 0.1, b16 = 0.5, z16 = Math.Pow(Math.E, 2.5 * a16 * rx());

            if (rx() <= a16)
            {
                y16 = 3.5 * Math.Pow(Math.Sin(b16 * rx() + z16), 2) - Math.Exp(3.5 * a16);
                MessageBox.Show($"y = {y16}");
                task16.Visibility = Visibility.Collapsed;
            }
            else if (a16 < rx() && rx() <= Math.Pow(b16, 2.5))
            {
                y16 = Math.Log(a16 + Math.Pow(b16, 3) * rx()) + a16;
                MessageBox.Show($"y = {y16}");
                task16.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b16, 2.5))
            {
                y16 = Math.Pow(Math.Cos(Math.Pow(a16, b16) * rx() + z16), 2) + Math.Pow(a16, 2);
                MessageBox.Show($"y = {y16}");
                task16.Visibility = Visibility.Collapsed;
            }
        }

        private void task16_1_Click(object sender, RoutedEventArgs e)
        {
            double y16_1, a16_1 = 1.2, b16_1 = 2.5, z16_1 = Math.Pow(Math.E, 2.5 * a16_1 * rx());

            if (rx() <= a16_1)
            {
                y16_1 = 3.5 * Math.Pow(Math.Sin(b16_1 * rx() + z16_1), 2) - Math.Exp(3.5 * a16_1);
                MessageBox.Show($"y = {y16_1}");
                task16_1.Visibility = Visibility.Collapsed;
            }
            else if (a16_1 < rx() && rx() <= Math.Pow(b16_1, 2.5))
            {
                y16_1 = Math.Log(a16_1 + Math.Pow(b16_1, 3) * rx()) + a16_1;
                MessageBox.Show($"y = {y16_1}");
                task16_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b16_1, 2.5))
            {
                y16_1 = Math.Pow(Math.Cos(Math.Pow(a16_1, b16_1) * rx() + z16_1), 2) + Math.Pow(a16_1, 2);
                MessageBox.Show($"y = {y16_1}");
                task16_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task16_2_Click(object sender, RoutedEventArgs e)
        {
            double y16_2, a16_2 = 2.5, b16_2 = 1.2, z16_2 = Math.Pow(Math.E, 2.5 * a16_2 * rx());

            if (rx() <= a16_2)
            {
                y16_2 = 3.5 * Math.Pow(Math.Sin(b16_2 * rx() + z16_2), 2) - Math.Exp(3.5 * a16_2);
                MessageBox.Show($"y = {y16_2}");
                task16_2.Visibility = Visibility.Collapsed;
            }
            else if (a16_2 < rx() && rx() <= Math.Pow(b16_2, 2.5))
            {
                y16_2 = Math.Log(a16_2 + Math.Pow(b16_2, 3) * rx()) + a16_2;
                MessageBox.Show($"y = {y16_2}");
                task16_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b16_2, 2.5))
            {
                y16_2 = Math.Pow(Math.Cos(Math.Pow(a16_2, b16_2) * rx() + z16_2), 2) + Math.Pow(a16_2, 2);
                MessageBox.Show($"y = {y16_2}");
                task16_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task17_Click(object sender, RoutedEventArgs e)
        {
            double y17, a17 = -1.2, b17 = 0.75, z17 = Math.Log(Math.Abs(b17 * rx()));

            if (rx() <= a17)
            {
                y17 = a17 + Math.Sin(b17 * rx()) + Math.Cos(Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y17}");
                task17.Visibility = Visibility.Collapsed;
            }
            else if (a17 < rx() && rx() < Math.Log(b17))
            {
                y17 = Math.Sqrt(a17 + b17 * rx()) + Math.Sin(z17 * rx());
                MessageBox.Show($"y = {y17}");
                task17.Visibility = Visibility.Collapsed;
            }
            else if (rx() >= Math.Log(b17))
            {
                y17 = Math.Log(a17 + b17 * rx() + z17);
                MessageBox.Show($"y = {y17}");
                task17.Visibility = Visibility.Collapsed;
            }
        }

        private void task17_1_Click(object sender, RoutedEventArgs e)
        {
            double y17_1, a17_1 = 0.4, b17_1 = 2.4, z17_1 = Math.Log(Math.Abs(b17_1 * rx()));

            if (rx() <= a17_1)
            {
                y17_1 = a17_1 + Math.Sin(b17_1 * rx()) + Math.Cos(Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y17_1}");
                task17_1.Visibility = Visibility.Collapsed;
            }
            else if (a17_1 < rx() && rx() < Math.Log(b17_1))
            {
                y17_1 = Math.Sqrt(a17_1 + b17_1 * rx()) + Math.Sin(z17_1 * rx());
                MessageBox.Show($"y = {y17_1}");
                task17_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() >= Math.Log(b17_1))
            {
                y17_1 = Math.Log(a17_1 + b17_1 * rx() + z17_1);
                MessageBox.Show($"y = {y17_1}");
                task17_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task17_2_Click(object sender, RoutedEventArgs e)
        {
            double y17_2, a17_2 = 1.1, b17_2 = 6.1, z17_2 = Math.Log(Math.Abs(b17_2 * rx()));

            if (rx() <= a17_2)
            {
                y17_2 = a17_2 + Math.Sin(b17_2 * rx()) + Math.Cos(Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y17_2}");
                task17_2.Visibility = Visibility.Collapsed;
            }
            else if (a17_2 < rx() && rx() < Math.Log(b17_2))
            {
                y17_2 = Math.Sqrt(a17_2 + b17_2 * rx()) + Math.Sin(z17_2 * rx());
                MessageBox.Show($"y = {y17_2}");
                task17_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() >= Math.Log(b17_2))
            {
                y17_2 = Math.Log(a17_2 + b17_2 * rx() + z17_2);
                MessageBox.Show($"y = {y17_2}");
                task17_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task18_Click(object sender, RoutedEventArgs e)
        {
            double y18, a18 = 6, b18 = 3.2, z18 = Math.Exp(1.5 * a18 * rx());

            if (rx() < -Math.Log(a18))
            {
                y18 = Math.Pow(3.5 * a18 - 7.3 * b18 * rx() + Math.Sin(z18 * rx()), 3);
                MessageBox.Show($"y = {y18}");
                task18.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a18) <= rx() && rx() < b18)
            {
                y18 = Math.Pow(a18, b18) - Math.Pow(Math.Cos(a18 + z18 * rx()), 3);
                MessageBox.Show($"y = {y18}");
                task18.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b18)
            {
                y18 = Math.Sqrt(Math.Abs(Math.Tan(a18) - rx())) - Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y18}");
                task18.Visibility = Visibility.Collapsed;
            }
        }

        private void task18_1_Click(object sender, RoutedEventArgs e)
        {
            double y18_1, a18_1 = 3, b18_1 = 6, z18_1 = Math.Exp(1.5 * a18_1 * rx());

            if (rx() < -Math.Log(a18_1))
            {
                y18_1 = Math.Pow(3.5 * a18_1 - 7.3 * b18_1 * rx() + Math.Sin(z18_1 * rx()), 3);
                MessageBox.Show($"y = {y18_1}");
                task18_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a18_1) <= rx() && rx() < b18_1)
            {
                y18_1 = Math.Pow(a18_1, b18_1) - Math.Pow(Math.Cos(a18_1 + z18_1 * rx()), 3);
                MessageBox.Show($"y = {y18_1}");
                task18_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b18_1)
            {
                y18_1 = Math.Sqrt(Math.Abs(Math.Tan(a18_1) - rx())) - Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y18_1}");
                task18_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task18_2_Click(object sender, RoutedEventArgs e)
        {
            double y18_2, a18_2 = 2.7, b18_2 = 1.8, z18_2 = Math.Exp(1.5 * a18_2 * rx());

            if (rx() < -Math.Log(a18_2))
            {
                y18_2 = Math.Pow(3.5 * a18_2 - 7.3 * b18_2 * rx() + Math.Sin(z18_2 * rx()), 3);
                MessageBox.Show($"y = {y18_2}");
                task18_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Log(a18_2) <= rx() && rx() < b18_2)
            {
                y18_2 = Math.Pow(a18_2, b18_2) - Math.Pow(Math.Cos(a18_2 + z18_2 * rx()), 3);
                MessageBox.Show($"y = {y18_2}");
                task18_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b18_2)
            {
                y18_2 = Math.Sqrt(Math.Abs(Math.Tan(a18_2) - rx())) - Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y18_2}");
                task18_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task19_Click(object sender, RoutedEventArgs e)
        {
            double y19, a19 = 2.2, b19 = 2.4, c19 = Math.Log(b19 * rx());

            if (rx() < a19)
            {
                y19 = c19 * Math.Sin(Math.Pow(b19, rx())) + b19 * Math.Log(c19 * rx() + a19);
                MessageBox.Show($"y = {y19}");
                task19.Visibility = Visibility.Collapsed;
            }
            else if (a19 < rx() && rx() < b19)
            {
                y19 = a19 + Math.Log(b19 * rx()) - Math.Pow(Math.Sin(a19 + c19 * rx()), 2);
                MessageBox.Show($"y = {y19}");
                task19.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b19)
            {
                y19 = Math.Sqrt(Math.Abs(Math.Cos(a19 + b19 * rx()) + c19 * Math.Pow(rx(), 2)));
                MessageBox.Show($"y = {y19}");
                task19.Visibility = Visibility.Collapsed;
            }
        }

        private void task19_1_Click(object sender, RoutedEventArgs e)
        {
            double y19_1, a19_1 = 1.6, b19_1 = 1.7, c19_1 = Math.Log(b19_1 * rx());

            if (rx() < a19_1)
            {
                y19_1 = c19_1 * Math.Sin(Math.Pow(b19_1, rx())) + b19_1 * Math.Log(c19_1 * rx() + a19_1);
                MessageBox.Show($"y = {y19_1}");
                task19_1.Visibility = Visibility.Collapsed;
            }
            else if (a19_1 < rx() && rx() < b19_1)
            {
                y19_1 = a19_1 + Math.Log(b19_1 * rx()) - Math.Pow(Math.Sin(a19_1 + c19_1 * rx()), 2);
                MessageBox.Show($"y = {y19_1}");
                task19_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b19_1)
            {
                y19_1 = Math.Sqrt(Math.Abs(Math.Cos(a19_1 + b19_1 * rx()) + c19_1 * Math.Pow(rx(), 2)));
                MessageBox.Show($"y = {y19_1}");
                task19_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task19_2_Click(object sender, RoutedEventArgs e)
        {
            double y19_2, a19_2 = 1.3, b19_2 = 4.2, c19_2 = Math.Log(Math.Pow(b19_2, 2) * rx());

            if (rx() < a19_2)
            {
                y19_2 = c19_2 * Math.Sin(Math.Pow(b19_2, rx())) + b19_2 * Math.Log(c19_2 * rx() + a19_2);
                MessageBox.Show($"y = {y19_2}");
                task19_2.Visibility = Visibility.Collapsed;
            }
            else if (a19_2 < rx() && rx() < b19_2)
            {
                y19_2 = a19_2 + Math.Log(b19_2 * rx()) - Math.Pow(Math.Sin(a19_2 + c19_2 * rx()), 2);
                MessageBox.Show($"y = {y19_2}");
                task19_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b19_2)
            {
                y19_2 = Math.Sqrt(Math.Abs(Math.Cos(a19_2 + b19_2 * rx()) + c19_2 * Math.Pow(rx(), 2)));
                MessageBox.Show($"y = {y19_2}");
                task19_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task20_Click(object sender, RoutedEventArgs e)
        {
            double y20, a20 = 0.8, b20 = 2.4, f = Math.Exp(1.5 * a20 * rx());

            if (rx() < a20)
            {
                y20 = Math.Exp(a20 * rx()) + f * Math.Pow(Math.Cos(b20 * rx()), 2);
                MessageBox.Show($"y = {y20}");
                task20.Visibility = Visibility.Collapsed;
            }
            else if (a20 < rx() && rx() < Math.Pow(b20, 2))
            {
                y20 = a20 + Math.Pow(Math.Cos(b20 * rx() - Math.Log(f * rx())), 2);
                MessageBox.Show($"y = {y20}");
                task20.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b20, 2))
            {
                y20 = Math.Pow(Math.Cos(a20 + b20 * f * rx()), 2);
                MessageBox.Show($"y = {y20}");
                task20.Visibility = Visibility.Collapsed;
            }
        }

        private void task20_1_Click(object sender, RoutedEventArgs e)
        {
            double y20_1, a20_1 = 1.2, b20_1 = 4.2, f1 = Math.Exp(2 * a20_1 * rx());

            if (rx() < a20_1)
            {
                y20_1 = Math.Exp(a20_1 * rx()) + f1 * Math.Pow(Math.Cos(b20_1 * rx()), 2);
                MessageBox.Show($"y = {y20_1}");
                task20_1.Visibility = Visibility.Collapsed;
            }
            else if (a20_1 < rx() && rx() < Math.Pow(b20_1, 2))
            {
                y20_1 = a20_1 + Math.Pow(Math.Cos(b20_1 * rx() - Math.Log(f1 * rx())), 2);
                MessageBox.Show($"y = {y20_1}");
                task20_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b20_1, 2))
            {
                y20_1 = Math.Pow(Math.Cos(a20_1 + b20_1 * f1 * rx()), 2);
                MessageBox.Show($"y = {y20_1}");
                task20_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task20_2_Click(object sender, RoutedEventArgs e)
        {
            double y20_2, a20_2 = 2.4, b20_2 = 8.1, f2 = Math.Exp(3 * a20_2 * rx());

            if (rx() < a20_2)
            {
                y20_2 = Math.Exp(a20_2 * rx()) + f2 * Math.Pow(Math.Cos(b20_2 * rx()), 2);
                MessageBox.Show($"y = {y20_2}");
                task20_2.Visibility = Visibility.Collapsed;
            }
            else if (a20_2 < rx() && rx() < Math.Pow(b20_2, 2))
            {
                y20_2 = a20_2 + Math.Pow(Math.Cos(b20_2 * rx() - Math.Log(f2 * rx())), 2);
                MessageBox.Show($"y = {y20_2}");
                task20_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b20_2, 2))
            {
                y20_2 = Math.Pow(Math.Cos(a20_2 + b20_2 * f2 * rx()), 2);
                MessageBox.Show($"y = {y20_2}");
                task20_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task21_Click(object sender, RoutedEventArgs e)
        {
            double y21, a21 = 4.5, b21 = 8.4, z21 = Math.Pow(Math.Tan(b21 * rx()), 2);

            if (rx() < a21)
            {
                y21 = a21 * Math.Pow(Math.Cos(rx() + b21 * Math.Sin(z21 * rx())), 2);
                MessageBox.Show($"y = {y21}");
                task21.Visibility = Visibility.Collapsed;
            }
            else if (a21 < rx() && rx() < 4.5 * b21)
            {
                y21 = a21 * Math.Tan(a21 * rx() + z21) + Math.Pow(Math.Sin(b21 * rx()), 2);
                MessageBox.Show($"y = {y21}");
                task21.Visibility = Visibility.Collapsed;
            }
            else if (rx() > 4.5 * b21)
            {
                y21 = Math.Log(a21 * rx() - b21) + Math.Pow(z21, 2);
                MessageBox.Show($"y = {y21}");
                task21.Visibility = Visibility.Collapsed;
            }
        }

        private void task21_1_Click(object sender, RoutedEventArgs e)
        {
            double y21_1, a21_1 = 8.2, b21_1 = 15.2, z21_1 = Math.Pow(Math.Tan(b21_1 * rx()), 2);

            if (rx() < a21_1)
            {
                y21_1 = a21_1 * Math.Pow(Math.Cos(rx() + b21_1 * Math.Sin(z21_1 * rx())), 2);
                MessageBox.Show($"y = {y21_1}");
                task21_1.Visibility = Visibility.Collapsed;
            }
            else if (a21_1 < rx() && rx() < 4.5 * b21_1)
            {
                y21_1 = a21_1 * Math.Tan(a21_1 * rx() + z21_1) + Math.Pow(Math.Sin(b21_1 * rx()), 2);
                MessageBox.Show($"y = {y21_1}");
                task21_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > 4.5 * b21_1)
            {
                y21_1 = Math.Log(a21_1 * rx() - b21_1) + Math.Pow(z21_1, 2);
                MessageBox.Show($"y = {y21_1}");
                task21_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task21_2_Click(object sender, RoutedEventArgs e)
        {
            double y21_2, a21_2 = 1.7, b21_2 = 0.5, z21_2 = (Math.Tan(b21_2 * Math.Pow(rx(), 2)));

            if (rx() < a21_2)
            {
                y21_2 = a21_2 * Math.Pow(Math.Cos(rx() + b21_2 * Math.Sin(z21_2 * rx())), 2);
                MessageBox.Show($"y = {y21_2}");
                task21_2.Visibility = Visibility.Collapsed;
            }
            else if (a21_2 < rx() && rx() < 4.5 * b21_2)
            {
                y21_2 = a21_2 * Math.Tan(a21_2 * rx() + z21_2) + Math.Pow(Math.Sin(b21_2 * rx()), 2);
                MessageBox.Show($"y = {y21_2}");
                task21_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > 4.5 * b21_2)
            {
                y21_2 = Math.Log(a21_2 * rx() - b21_2) + Math.Pow(z21_2, 2);
                MessageBox.Show($"y = {y21_2}");
                task21_2.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            task22.Visibility = Visibility.Visible;
            task22_1.Visibility = Visibility.Visible;
            task22_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            task23.Visibility = Visibility.Visible;
            task23_1.Visibility = Visibility.Visible;
            task23_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            task24.Visibility = Visibility.Visible;
            task24_1.Visibility = Visibility.Visible;
            task24_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            task25.Visibility = Visibility.Visible;
            task25_1.Visibility = Visibility.Visible;
            task25_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            task26.Visibility = Visibility.Visible;
            task26_1.Visibility = Visibility.Visible;
            task26_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            task27.Visibility = Visibility.Visible;
            task27_1.Visibility = Visibility.Visible;
            task27_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            task28.Visibility = Visibility.Visible;
            task28_1.Visibility = Visibility.Visible;
            task28_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            task29.Visibility = Visibility.Visible;
            task29_1.Visibility = Visibility.Visible;
            task29_2.Visibility = Visibility.Visible;
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            task30.Visibility = Visibility.Visible;
            task30_1.Visibility = Visibility.Visible;
            task30_2.Visibility = Visibility.Visible;
        }

        private void task22_Click(object sender, RoutedEventArgs e)
        {
            double y22, a22 = 0.3, b22 = 0.9, z22 = Math.Sin(Math.Pow(rx(), 2));

            if (rx() < a22)
            {
                y22 = a22 + b22 * rx() + Math.Pow(Math.Sin(z22), 2) * Math.Pow(rx(), 3.5);
                MessageBox.Show($"y = {y22}");
                task22.Visibility = Visibility.Collapsed;
            }
            else if (a22 <= rx() && rx() <= Math.Pow(b22, 2))
            {
                y22 = a22 + Math.Log(Math.Abs(a22 * b22 - z22 * Math.Pow(rx(), 3))) + Math.Log(rx());
                MessageBox.Show($"y = {y22}");
                task22.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b22, 2))
            {
                y22 = Math.Sqrt(Math.Abs(a22 + 1 / Math.Tan(z22 * rx()))) + b22 * Math.Sin(rx());
                MessageBox.Show($"y = {y22}");
                task22.Visibility = Visibility.Collapsed;
            }
        }

        private void task22_1_Click(object sender, RoutedEventArgs e)
        {
            double y22_1, a22_1 = 4.3, b22_1 = 3.15, z22_1 = Math.Sin(Math.Pow(rx(), 3));

            if (rx() < a22_1)
            {
                y22_1 = a22_1 + b22_1 * rx() + Math.Pow(Math.Sin(z22_1), 2) * Math.Pow(rx(), 3.5);
                MessageBox.Show($"y = {y22_1}");
                task22_1.Visibility = Visibility.Collapsed;
            }
            else if (a22_1 <= rx() && rx() <= Math.Pow(b22_1, 2))
            {
                y22_1 = a22_1 + Math.Log(Math.Abs(a22_1 * b22_1 - z22_1 * Math.Pow(rx(), 3))) + Math.Log(rx());
                MessageBox.Show($"y = {y22_1}");
                task22_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b22_1, 2))
            {
                y22_1 = Math.Sqrt(Math.Abs(a22_1 + 1 / Math.Tan(z22_1 * rx()))) + b22_1 * Math.Sin(rx());
                MessageBox.Show($"y = {y22_1}");
                task22_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task22_2_Click(object sender, RoutedEventArgs e)
        {
            double y22_2, a22_2 = 6.5, b22_2 = 3.3, z22_2 = Math.Pow(Math.Sin(rx()), 2);

            if (rx() < a22_2)
            {
                y22_2 = a22_2 + b22_2 * rx() + Math.Pow(Math.Sin(z22_2), 2) * Math.Pow(rx(), 3.5);
                MessageBox.Show($"y = {y22_2}");
                task22_2.Visibility = Visibility.Collapsed;
            }
            else if (a22_2 <= rx() && rx() <= Math.Pow(b22_2, 2))
            {
                y22_2 = a22_2 + Math.Log(Math.Abs(a22_2 * b22_2 - z22_2 * Math.Pow(rx(), 3))) + Math.Log(rx());
                MessageBox.Show($"y = {y22_2}");
                task22_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b22_2, 2))
            {
                y22_2 = Math.Sqrt(Math.Abs(a22_2 + 1 / Math.Tan(z22_2 * rx()))) + b22_2 * Math.Sin(rx());
                MessageBox.Show($"y = {y22_2}");
                task22_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task23_Click(object sender, RoutedEventArgs e)
        {
            double y23, a23 = 1.5, b23 = 6.4, z23 = Math.Log(Math.Abs(b23 * Math.Pow(rx(), 3) + 1.5));

            if (Math.Pow(a23, 3) < rx() && rx() <= b23)
            {
                y23 = Math.Log(Math.Abs(b23 * rx())) + z23 * Math.Pow(a23, 2.5);
                MessageBox.Show($"y = {y23}");
                task23.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b23)
            {
                y23 = a23 * Math.Pow(rx(), 2) + b23 * Math.Pow(z23, a23) + Math.Pow(Math.Sin(z23), 2) * rx();
                MessageBox.Show($"y = {y23}");
                task23.Visibility = Visibility.Collapsed;
            }
            else if (rx() <= Math.Pow(a23, 3))
            {
                y23 = Math.Cos(a23 * rx() + b23 + Math.Log(Math.Abs(z23 * rx())));
                MessageBox.Show($"y = {y23}");
                task23.Visibility = Visibility.Collapsed;
            }
        }

        private void task23_1_Click(object sender, RoutedEventArgs e)
        {
            double y23_1, a23_1 = 1.9, b23_1 = 8.6, z23_1 = Math.Log(Math.Abs(b23_1 * Math.Pow(rx(), 3) + 3));

            if (Math.Pow(a23_1, 3) < rx() && rx() <= b23_1)
            {
                y23_1 = Math.Log(Math.Abs(b23_1 * rx())) + z23_1 * Math.Pow(a23_1, 2.5);
                MessageBox.Show($"y = {y23_1}");
                task23_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b23_1)
            {
                y23_1 = a23_1 * Math.Pow(rx(), 2) + b23_1 * Math.Pow(z23_1, a23_1) + Math.Pow(Math.Sin(z23_1), 2) * rx();
                MessageBox.Show($"y = {y23_1}");
                task23_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() <= Math.Pow(a23_1, 3))
            {
                y23_1 = Math.Cos(a23_1 * rx() + b23_1 + Math.Log(Math.Abs(z23_1 * rx())));
                MessageBox.Show($"y = {y23_1}");
                task23_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task23_2_Click(object sender, RoutedEventArgs e)
        {
            double y23_2, a23_2 = 0.6, b23_2 = 2.4, z23_2 = Math.Log(Math.Abs(b23_2 * Math.Pow(rx(), 3) + 1.8));

            if (Math.Pow(a23_2, 3) < rx() && rx() <= b23_2)
            {
                y23_2 = Math.Log(Math.Abs(b23_2 * rx())) + z23_2 * Math.Pow(a23_2, 2.5);
                MessageBox.Show($"y = {y23_2}");
                task23_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b23_2)
            {
                y23_2 = a23_2 * Math.Pow(rx(), 2) + b23_2 * Math.Pow(z23_2, a23_2) + Math.Pow(Math.Sin(z23_2), 2) * rx();
                MessageBox.Show($"y = {y23_2}");
                task23_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() <= Math.Pow(a23_2, 3))
            {
                y23_2 = Math.Cos(a23_2 * rx() + b23_2 + Math.Log(Math.Abs(z23_2 * rx())));
                MessageBox.Show($"y = {y23_2}");
                task23_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task24_Click(object sender, RoutedEventArgs e)
        {
            double y24, a24 = 8.7, b24 = 3.7, z24 = Math.Tan(b24 * rx());

            if (rx() < a24)
            {
                y24 = rx() * Math.Exp(rx()) + (z24 + 7.7 * a24 * b24 * rx());
                MessageBox.Show($"y = {y24}");
                task24.Visibility = Visibility.Collapsed;
            }
            else if (a24 <= rx() && rx() <= Math.Pow(b24, 2))
            {
                y24 = Math.Tan(a24 * rx() + z24) + Math.Cos(b24 * rx()) * Math.Cos(b24 * rx());
                MessageBox.Show($"y = {y24}");
                task24.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b24, 2))
            {
                y24 = Math.Log(Math.Sin(a24 + b24 * rx() + z24 * Math.Pow(rx(), 2)));
                MessageBox.Show($"y = {y24}");
                task24.Visibility = Visibility.Collapsed;
            }
        }

        private void task24_1_Click(object sender, RoutedEventArgs e)
        {
            double y24_1, a24_1 = 9.3, b24_1 = 3.5, z24_1 = Math.Tan(a24_1 * b24_1 * rx());

            if (rx() < a24_1)
            {
                y24_1 = rx() * Math.Exp(rx()) + (z24_1 + 7.7 * a24_1 * b24_1 * rx());
                MessageBox.Show($"y = {y24_1}");
                task24_1.Visibility = Visibility.Collapsed;
            }
            else if (a24_1 <= rx() && rx() <= Math.Pow(b24_1, 2))
            {
                y24_1 = Math.Tan(a24_1 * rx() + z24_1) + Math.Cos(b24_1 * rx()) * Math.Cos(b24_1 * rx());
                MessageBox.Show($"y = {y24_1}");
                task24_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b24_1, 2))
            {
                y24_1 = Math.Log(Math.Sin(a24_1 + b24_1 * rx() + z24_1 * Math.Pow(rx(), 2)));
                MessageBox.Show($"y = {y24_1}");
                task24_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task24_2_Click(object sender, RoutedEventArgs e)
        {
            double y24_2, a24_2 = 2.1, b24_2 = 5.7, z24_2 = Math.Tan(Math.Pow(b24_2, 2) * rx());

            if (rx() < a24_2)
            {
                y24_2 = rx() * Math.Exp(rx()) + (z24_2 + 7.7 * a24_2 * b24_2 * rx());
                MessageBox.Show($"y = {y24_2}");
                task24_2.Visibility = Visibility.Collapsed;
            }
            else if (a24_2 <= rx() && rx() <= Math.Pow(b24_2, 2))
            {
                y24_2 = Math.Tan(a24_2 * rx() + z24_2) + Math.Cos(b24_2 * rx()) * Math.Cos(b24_2 * rx());
                MessageBox.Show($"y = {y24_2}");
                task24_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > Math.Pow(b24_2, 2))
            {
                y24_2 = Math.Log(Math.Sin(a24_2 + b24_2 * rx() + z24_2 * Math.Pow(rx(), 2)));
                MessageBox.Show($"y = {y24_2}");
                task24_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task25_Click(object sender, RoutedEventArgs e)
        {
            double y25, a25 = 1.5, b25 = 5.7, z25 = Math.Log(Math.Abs(Math.Tan(b25 * rx())));

            if (rx() < a25)
            {
                y25 = a25 + z25 * Math.Pow(Math.Cos(Math.Pow((b25 * rx()), 3)), 2);
                MessageBox.Show($"y = {y25}");
                task25.Visibility = Visibility.Collapsed;
            }
            else if (a25 <= rx() && rx() <= b25)
            {
                y25 = a25 + Math.Pow(Math.Sin(Math.Pow(b25, 2)), 2) + Math.Log(z25 * rx());
                MessageBox.Show($"y = {y25}");
                task25.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b25)
            {
                y25 = Math.Pow(0.3 * b25 + Math.Sqrt(Math.Abs(a25 - Math.Pow(z25, 2) - Math.Cos(rx()))), 1.0 / 3);
                MessageBox.Show($"y = {y25}");
                task25.Visibility = Visibility.Collapsed;
            }
        }

        private void task25_1_Click(object sender, RoutedEventArgs e)
        {
            double y25_1, a25_1 = 3.7, b25_1 = 8.4, z25_1 = Math.Log(Math.Abs(Math.Tan(b25_1 * rx())));

            if (rx() < a25_1)
            {
                y25_1 = a25_1 + z25_1 * Math.Pow(Math.Cos(Math.Pow((b25_1 * rx()), 3)), 2);
                MessageBox.Show($"y = {y25_1}");
                task25_1.Visibility = Visibility.Collapsed;
            }
            else if (a25_1 <= rx() && rx() <= b25_1)
            {
                y25_1 = a25_1 + Math.Pow(Math.Sin(Math.Pow(b25_1, 2)), 2) + Math.Log(z25_1 * rx());
                MessageBox.Show($"y = {y25_1}");
                task25_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b25_1)
            {
                y25_1 = Math.Pow(0.3 * b25_1 + Math.Sqrt(Math.Abs(a25_1 - Math.Pow(z25_1, 2) - Math.Cos(rx()))), 1.0 / 3);
                MessageBox.Show($"y = {y25_1}");
                task25_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task25_2_Click(object sender, RoutedEventArgs e)
        {
            double y25_2, a25_2 = 4.4, b25_2 = 5.6, z25_2 = Math.Log(Math.Abs(Math.Tan(b25_2 * rx())));

            if (rx() < a25_2)
            {
                y25_2 = a25_2 + z25_2 * Math.Pow(Math.Cos(Math.Pow((b25_2 * rx()), 3)), 2);
                MessageBox.Show($"y = {y25_2}");
                task25_2.Visibility = Visibility.Collapsed;
            }
            else if (a25_2 <= rx() && rx() <= b25_2)
            {
                y25_2 = a25_2 + Math.Pow(Math.Sin(Math.Pow(b25_2, 2)), 2) + Math.Log(z25_2 * rx());
                MessageBox.Show($"y = {y25_2}");
                task25_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > b25_2)
            {
                y25_2 = Math.Pow(0.3 * b25_2 + Math.Sqrt(Math.Abs(a25_2 - Math.Pow(z25_2, 2) - Math.Cos(rx()))), 1.0 / 3);
                MessageBox.Show($"y = {y25_2}");
                task25_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task26_Click(object sender, RoutedEventArgs e)
        {
            double y26, z26 = Math.Asin(Math.Pow(rx(), 3));

            if (z26 > -0.5)
            {
                y26 = Math.Pow(2 * z26 + 1, 2) / (3.71 - Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y26}");
                task26.Visibility = Visibility.Collapsed;
            }
            else if (-0.5 <= z26 && z26 <= Math.Pow(10, -3))
            {
                y26 = Math.Pow(Math.Sin(z26), 3) - Math.Sin(z26 / (3 * Math.PI));
                MessageBox.Show($"y = {y26}");
                task26.Visibility = Visibility.Collapsed;
            }
            else if (z26 > Math.Pow(10, -3))
            {
                y26 = (Math.Tan(z26 + rx()) - Math.Exp(rx())) / (3.5 * rx());
                MessageBox.Show($"y = {y26}");
                task26.Visibility = Visibility.Collapsed;
            }
        }

        private void task26_1_Click(object sender, RoutedEventArgs e)
        {
            double y26_1, z26_1 = Math.Pow(Math.Acos(rx()), 2);

            if (z26_1 > -0.5)
            {
                y26_1 = Math.Pow(2 * z26_1 + 1, 2) / (3.71 - Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y26_1}");
                task26_1.Visibility = Visibility.Collapsed;
            }
            else if (-0.5 <= z26_1 && z26_1 <= Math.Pow(10, -3))
            {
                y26_1 = Math.Pow(Math.Sin(z26_1), 3) - Math.Sin(z26_1 / (3 * Math.PI));
                MessageBox.Show($"y = {y26_1}");
                task26_1.Visibility = Visibility.Collapsed;
            }
            else if (z26_1 > Math.Pow(10, -3))
            {
                y26_1 = (Math.Tan(z26_1 + rx()) - Math.Exp(rx())) / (3.5 * rx());
                MessageBox.Show($"y = {y26_1}");
                task26_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task26_2_Click(object sender, RoutedEventArgs e)
        {
            double y26_2, z26_2 = Math.Tan(rx());

            if (z26_2 > -0.5)
            {
                y26_2 = Math.Pow(2 * z26_2 + 1, 2) / (3.71 - Math.Pow(rx(), 2));
                MessageBox.Show($"y = {y26_2}");
                task26_2.Visibility = Visibility.Collapsed;
            }
            else if (-0.5 <= z26_2 && z26_2 <= Math.Pow(10, -3))
            {
                y26_2 = Math.Pow(Math.Sin(z26_2), 3) - Math.Sin(z26_2 / (3 * Math.PI));
                MessageBox.Show($"y = {y26_2}");
                task26_2.Visibility = Visibility.Collapsed;
            }
            else if (z26_2 > Math.Pow(10, -3))
            {
                y26_2 = (Math.Tan(z26_2 + rx()) - Math.Exp(rx())) / (3.5 * rx());
                MessageBox.Show($"y = {y26_2}");
                task26_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task27_Click(object sender, RoutedEventArgs e)
        {
            double y27, a27 = 0.5, b27 = 1.5, p27 = -4;

            if (Math.Abs(rx()) < 0.2)
            {
                y27 = Math.Pow(a27, 2) * Math.Pow(rx(), 3) + (Math.Sqrt(Math.Pow(b27, 4) + 1.7));
                MessageBox.Show($"y = {y27}");
                task27.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(rx()) == 0.2)
            {
                y27 = Math.Atan(Math.Pow(2, rx()) - Math.Abs(p27));
                MessageBox.Show($"y = {y27}");
                task27.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(rx()) > 0.2)
            {
                y27 = Math.Pow((Math.Log(Math.Abs(a27)) + 4.3), 1.0 / 3) + rx();
                MessageBox.Show($"y = {y27}");
                task27.Visibility = Visibility.Collapsed;
            }
        }

        private void task27_1_Click(object sender, RoutedEventArgs e)
        {
            double y27_1, a27_1 = -1, b27_1 = 0.5, p27_1 = -4;

            if (Math.Abs(rx()) < 0.2)
            {
                y27_1 = Math.Pow(a27_1, 2) * Math.Pow(rx(), 3) + (Math.Sqrt(Math.Pow(b27_1, 4) + 1.7));
                MessageBox.Show($"y = {y27_1}");
                task27_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(rx()) == 0.2)
            {
                y27_1 = Math.Atan(Math.Pow(2, rx()) - Math.Abs(p27_1));
                MessageBox.Show($"y = {y27_1}");
                task27_1.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(rx()) > 0.2)
            {
                y27_1 = Math.Pow((Math.Log(Math.Abs(a27_1)) + 4.3), 1.0 / 3) + rx();
                MessageBox.Show($"y = {y27_1}");
                task27_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task27_2_Click(object sender, RoutedEventArgs e)
        {
            double y27_2, a27_2 = -2, b27_2 = 6, p27_2 = -4;

            if (Math.Abs(rx()) < 0.2)
            {
                y27_2 = Math.Pow(a27_2, 2) * Math.Pow(rx(), 3) + (Math.Sqrt(Math.Pow(b27_2, 4) + 1.7));
                MessageBox.Show($"y = {y27_2}");
                task27_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(rx()) == 0.2)
            {
                y27_2 = Math.Atan(Math.Pow(2, rx()) - Math.Abs(p27_2));
                MessageBox.Show($"y = {y27_2}");
                task27_2.Visibility = Visibility.Collapsed;
            }
            else if (Math.Abs(rx()) > 0.2)
            {
                y27_2 = Math.Pow((Math.Log(Math.Abs(a27_2)) + 4.3), 1.0 / 3) + rx();
                MessageBox.Show($"y = {y27_2}");
                task27_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task28_Click(object sender, RoutedEventArgs e)
        {
            double y28, a28 = 7.2, b28 = -1.3, c28 = 2.5;

            if (a28 + b28 > rx())
            {
                y28 = Math.Sin(Math.Exp(a28 + b28)) + Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y28}");
                task28.Visibility = Visibility.Collapsed;
            }
            else if (a28 + b28 == rx())
            {
                y28 = Math.Atan(a28 * b28 * c28) + Math.Pow(rx(), 1.0 / 3.0);
                MessageBox.Show($"y = {y28}");
                task28.Visibility = Visibility.Collapsed;
            }
            else if (a28 + b28 < rx())
            {
                y28 = Math.Asin(Math.Pow(Math.Cos(Math.Sqrt(Math.Abs(rx()))), 2));
                MessageBox.Show($"y = {y28}");
                task28.Visibility = Visibility.Collapsed;
            }
        }

        private void task28_1_Click(object sender, RoutedEventArgs e)
        {
            double y28_1, a28_1 = 1.47, b28_1 = 3.81, c28_1 = 2.8;

            if (a28_1 + b28_1 > rx())
            {
                y28_1 = Math.Sin(Math.Exp(a28_1 + b28_1)) + Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y28_1}");
                task28_1.Visibility = Visibility.Collapsed;
            }
            else if (a28_1 + b28_1 == rx())
            {
                y28_1 = Math.Atan(a28_1 * b28_1 * c28_1) + Math.Pow(rx(), 1.0 / 3.0);
                MessageBox.Show($"y = {y28_1}");
                task28_1.Visibility = Visibility.Collapsed;
            }
            else if (a28_1 + b28_1 < rx())
            {
                y28_1 = Math.Asin(Math.Pow(Math.Cos(Math.Sqrt(Math.Abs(rx()))), 2));
                MessageBox.Show($"y = {y28_1}");
                task28_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task28_2_Click(object sender, RoutedEventArgs e)
        {
            double y28_2, a28_2 = 4.8, b28_2 = 10.6, c28_2 = 2.7;

            if (a28_2 + b28_2 > rx())
            {
                y28_2 = Math.Sin(Math.Exp(a28_2 + b28_2)) + Math.Pow(rx(), 2);
                MessageBox.Show($"y = {y28_2}");
                task28_2.Visibility = Visibility.Collapsed;
            }
            else if (a28_2 + b28_2 == rx())
            {
                y28_2 = Math.Atan(a28_2 * b28_2 * c28_2) + Math.Pow(rx(), 1.0 / 3.0);
                MessageBox.Show($"y = {y28_2}");
                task28_2.Visibility = Visibility.Collapsed;
            }
            else if (a28_2 + b28_2 < rx())
            {
                y28_2 = Math.Asin(Math.Pow(Math.Cos(Math.Sqrt(Math.Abs(rx()))), 2));
                MessageBox.Show($"y = {y28_2}");
                task28_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task29_Click(object sender, RoutedEventArgs e)
        {
            double y29, k29 = -0.3, r29 = 0.85, s29 = 3.5;

            if (rx() == r29 * s29)
            {
                y29 = Math.Atan(Math.Pow(rx(), 2) * Math.Exp(3 * k29)) + Math.Log(Math.Abs(r29 + rx()));
                MessageBox.Show($"y = {y29}");
                task29.Visibility = Visibility.Collapsed;
            }
            else if (rx() > r29 * s29)
            {
                y29 = Math.Pow(Math.Pow(rx(), 2), 1 / 5) + Math.Sqrt(Math.Abs(Math.Asin(k29)));
                MessageBox.Show($"y = {y29}");
                task29.Visibility = Visibility.Collapsed;
            }
            else if (rx() < r29 * s29)
            {
                y29 = Math.Atan(k29 * rx() + Math.Tan(r29 * s29));
                MessageBox.Show($"y = {y29}");
                task29.Visibility = Visibility.Collapsed;
            }
        }

        private void task29_1_Click(object sender, RoutedEventArgs e)
        {
            double y29_1, k29_1 = 0.9, r29_1 = 3.3, s29_1 = 1.2;

            if (rx() == r29_1 * s29_1)
            {
                y29_1 = Math.Atan(Math.Pow(rx(), 2) * Math.Exp(3 * k29_1)) + Math.Log(Math.Abs(r29_1 + rx()));
                MessageBox.Show($"y = {y29_1}");
                task29_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() > r29_1 * s29_1)
            {
                y29_1 = Math.Pow(Math.Pow(rx(), 2), 1 / 5) + Math.Sqrt(Math.Abs(Math.Asin(k29_1)));
                MessageBox.Show($"y = {y29_1}");
                task29_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() < r29_1 * s29_1)
            {
                y29_1 = Math.Atan(k29_1 * rx() + Math.Tan(r29_1 * s29_1));
                MessageBox.Show($"y = {y29_1}");
                task29_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task29_2_Click(object sender, RoutedEventArgs e)
        {
            double y29_2, k29_2 = -0.7, r29_2 = 0.75, s29_2 = 2.15;

            if (rx() == r29_2 * s29_2)
            {
                y29_2 = Math.Atan(Math.Pow(rx(), 2) * Math.Exp(3 * k29_2)) + Math.Log(Math.Abs(r29_2 + rx()));
                MessageBox.Show($"y = {y29_2}");
                task29_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() > r29_2 * s29_2)
            {
                y29_2 = Math.Pow(Math.Pow(rx(), 2), 1 / 5) + Math.Sqrt(Math.Abs(Math.Asin(k29_2)));
                MessageBox.Show($"y = {y29_2}");
                task29_2.Visibility = Visibility.Collapsed;
            }
            else if (rx() < r29_2 * s29_2)
            {
                y29_2 = Math.Atan(k29_2 * rx() + Math.Tan(r29_2 * s29_2));
                MessageBox.Show($"y = {y29_2}");
                task29_2.Visibility = Visibility.Collapsed;
            }
        }

        private void task30_Click(object sender, RoutedEventArgs e)
        {
            double y30, a30 = 1.5, b30 = 5.7, z30 = Math.Tan(Math.Abs(Math.Tan(b30 * rx())));

            if (rx() <= a30)
            {
                y30 = Math.Pow(a30, 3) + Math.Atan(Math.Pow((Math.Sin(b30 * rx())), 3));
                MessageBox.Show($"y = {y30}");
                task30.Visibility = Visibility.Collapsed;
            }
            else if (a30 < rx() && rx() < Math.Log(b30))
            {
                y30 = Math.Sqrt((a30 + b30 * z30) + 2) + Math.Sin(z30 * rx());
                MessageBox.Show($"y = {y30}");
                task30.Visibility = Visibility.Collapsed;
            }
            else if (rx() >= Math.Log(b30))
            {
                y30 = Math.Atan(a30 + b30 * rx() + z30);
                MessageBox.Show($"y = {y30}");
                task30.Visibility = Visibility.Collapsed;
            }
        }

        private void task30_1_Click(object sender, RoutedEventArgs e)
        {
            double y30_1, a30_1 = 3.7, b30_1 = 8.4, z30_1 = Math.Tan(Math.Abs(Math.Tan(b30_1 * rx())));

            if (rx() <= a30_1)
            {
                y30_1 = Math.Pow(a30_1, 3) + Math.Atan(Math.Pow((Math.Sin(b30_1 * rx())), 3));
                MessageBox.Show($"y = {y30_1}");
                task30_1.Visibility = Visibility.Collapsed;
            }
            else if (a30_1 < rx() && rx() < Math.Log(b30_1))
            {
                y30_1 = Math.Sqrt((a30_1 + b30_1 * z30_1) + 2) + Math.Sin(z30_1 * rx());
                MessageBox.Show($"y = {y30_1}");
                task30_1.Visibility = Visibility.Collapsed;
            }
            else if (rx() >= Math.Log(b30_1))
            {
                y30_1 = Math.Atan(a30_1 + b30_1 * rx() + z30_1);
                MessageBox.Show($"y = {y30_1}");
                task30_1.Visibility = Visibility.Collapsed;
            }
        }

        private void task30_2_Click(object sender, RoutedEventArgs e)
        {
            {
                double y30_2, a30_2 = 4.4, b30_2 = 5.6, z30_2 = Math.Tan(Math.Abs(Math.Tan(b30_2 * rx())));

                if (rx() <= a30_2)
                {
                    y30_2 = Math.Pow(a30_2, 3) + Math.Atan(Math.Pow((Math.Sin(b30_2 * rx())), 3));
                    MessageBox.Show($"y = {y30_2}");
                    task30_2.Visibility = Visibility.Collapsed;
                }
                else if (a30_2 < rx() && rx() < Math.Log(b30_2))
                {
                    y30_2 = Math.Sqrt((a30_2 + b30_2 * z30_2) + 2) + Math.Sin(z30_2 * rx());
                    MessageBox.Show($"y = {y30_2}");
                    task30_2.Visibility = Visibility.Collapsed;
                }
                else if (rx() >= Math.Log(b30_2))
                {
                    y30_2 = Math.Atan(a30_2 + b30_2 * rx() + z30_2);
                    MessageBox.Show($"y = {y30_2}");
                    task30_2.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            text.Visibility = Visibility.Visible;
            result.Visibility = Visibility.Visible;
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            text1.Visibility = Visibility.Visible;
            result1.Visibility = Visibility.Visible;
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            text2.Visibility = Visibility.Visible;
            result2.Visibility = Visibility.Visible;
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int b31 = random.Next(1, 15);
            int a31 = random.Next(1, 15);

            if (a31 < b31)
            {
                int z31 = b31 - a31 + 1;
                Console.WriteLine("Их кол-во: " + z31);
                for (int i = 1; i <= z31; i++)
                {
                    MessageBox.Show(a31 + " ");
                    a31++;
                    text.Visibility = Visibility.Collapsed;
                    result.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                MessageBox.Show("A > B");

            }

        }

        private void result1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int b32 = random.Next(1, 15);
            int a32 = random.Next(1, 15);
            if (a32 < b32)
            {
                     int z32 = b32 - a32;
                     Console.WriteLine("Их кол-во: " + z32);
                     for(int i = z32-1; i > 0; i--) {
                        MessageBox.Show( (a32+i) + " ");
                    text1.Visibility = Visibility.Collapsed;
                    result1.Visibility = Visibility.Collapsed;
                }
                 } else {
                MessageBox.Show("A > B");
                 }

            }

        private void result2_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int v32 = random.Next(1, 15);
            int n32 = random.Next(1, 15);
             double result = 1;
             for (int i = 0; i < n32; i++){
                result *= v32;
            }
            MessageBox.Show($"{result}");
            text2.Visibility = Visibility.Collapsed;
            result2.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            text3.Visibility = Visibility.Visible;
            result3.Visibility = Visibility.Visible;
        }

        private void result3_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n33 = random.Next(1, 15);
            int a33 = random.Next(1, 15);

            for (int i = 1; i <= n33; i++)
            {
                int power = 1;
                for (int j = 1; j <= i; j++)
                {
                    power *= a33;
                }
                MessageBox.Show($"{a33}^{i} = {power}");
                text3.Visibility = Visibility.Collapsed;
                result3.Visibility = Visibility.Collapsed;
            }
        }

        private void result4_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double a34 = random.NextDouble() * 10; 
            int n34 = random.Next(1, 15); 


            double result1 = 0;
            for (int i = 0; i <= n34; i++)
            {
                result1 += Math.Pow(a34, i);
            }
            MessageBox.Show("задача 1:" + result1);

            
            double result2 = 0;
            for (int i = 0; i <= n34; i++)
            {
                result2 += Math.Pow(-1, i) * Math.Pow(a34, i);
            }
            MessageBox.Show("задача 2: " + result2);
            text4.Visibility = Visibility.Collapsed;
            result4.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            text4.Visibility = Visibility.Visible;
            result4.Visibility = Visibility.Visible;
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            text5.Visibility = Visibility.Visible;
            result5.Visibility = Visibility.Visible;
        }

        private void Button_Click_36(object sender, RoutedEventArgs e)
        {
            text6.Visibility = Visibility.Visible;
            result6.Visibility = Visibility.Visible;
        }

        private void Button_Click_37(object sender, RoutedEventArgs e)
        {
            text7.Visibility = Visibility.Visible;
            result7.Visibility = Visibility.Visible;
        }

        private void Button_Click_38(object sender, RoutedEventArgs e)
        {
            text8.Visibility = Visibility.Visible;
            result8.Visibility = Visibility.Visible;
        }

        private void result5_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n36 = random.Next(1, 100); 
            int m36 = random.Next(2, 10); 

            int minK = -1;
            int min3K = int.MaxValue;

            for (int i = 1; i <= n36; i++)
            {
                int candidate3K = 3 * i;
                if (candidate3K > n36 && candidate3K < min3K)
                {
                    minK = i;
                    min3K = candidate3K;
                }
            }

            MessageBox.Show("минимальный K: " + minK);
            MessageBox.Show("соответствующий 3K: " + min3K);
            text5.Visibility = Visibility.Collapsed;
            result5.Visibility = Visibility.Collapsed;
        }

        private void result6_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n37 = random.Next(1, 100); 
            int m37 = random.Next(2, 10); 

            int maxK = -1;
            int max3K = -1;

            for (int i = 1; i <= n37; i++)
            {
                int candidate3K = 3 * i;
                if (candidate3K < n37 && candidate3K > max3K)
                {
                    maxK = i;
                    max3K = candidate3K;
                }
            }

            MessageBox.Show("максимальный K: " + maxK);
            MessageBox.Show("соответствующий 3K: " + max3K);
            text6.Visibility = Visibility.Collapsed;
            result6.Visibility = Visibility.Collapsed;
        }

        private void result7_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double a38 = random.NextDouble() * 10 + 1;

            int N = 1;
            double sum = 0;

            while (sum <= a38)
            {
                sum += 1.0 / N;
                N++;
            }

            MessageBox.Show("минимальный N: " + (N - 1));
            MessageBox.Show("соответствующяя сумма: " + sum);
            text7.Visibility = Visibility.Collapsed;
            result7.Visibility = Visibility.Collapsed;
        }

        private void result8_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n39 = random.Next(1, 15); 

            double product = 1.0;

            for (int i = 1; i <= n39; i++)
            {
                product *= i;
            }

            MessageBox.Show("произведение от 1 до N: " + product);
            text8.Visibility = Visibility.Collapsed;
            result8.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            text9.Visibility = Visibility.Visible;
            result9.Visibility = Visibility.Visible;
        }

        private void Button_Click_40(object sender, RoutedEventArgs e)
        {
            text10.Visibility = Visibility.Visible;
            result10.Visibility = Visibility.Visible;
        }

        private void Button_Click_41(object sender, RoutedEventArgs e)
        {
            text11.Visibility = Visibility.Visible;
            result11.Visibility = Visibility.Visible;
        }

        private void Button_Click_42(object sender, RoutedEventArgs e)
        {
            text12.Visibility = Visibility.Visible;
            result12.Visibility = Visibility.Visible;
        }

        private void Button_Click_43(object sender, RoutedEventArgs e)
        {
            text13.Visibility = Visibility.Visible;
            result13.Visibility = Visibility.Visible;
        }

        private void Button_Click_44(object sender, RoutedEventArgs e)
        {
            text14.Visibility = Visibility.Visible;
            result14.Visibility = Visibility.Visible;
        }

        private void result9_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n40 = random.Next(1, 15); 

            double product = 1.0;

            for (int i = 2; i <= n40; i++)
            {
                product *= 1.0 / i;
            }

            MessageBox.Show("произведение 2 * 1/(2) * 1/(3) * ... * 1/( N): " + product);
            text9.Visibility = Visibility.Collapsed;
            result9.Visibility = Visibility.Collapsed;
        }

        private void result10_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x41 = random.NextDouble() * 10; 
            int n41 = random.Next(1, 15); 

            double result = 0;

            for (int i = 0; i <= n41; i++)
            {
                result += Math.Pow(x41, i) / i;
            }

            MessageBox.Show("результат: " + result);
            text10.Visibility = Visibility.Collapsed;
            result10.Visibility = Visibility.Collapsed;
        }

        private void result11_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x42 = random.NextDouble() * 10; 
            int n42 = random.Next(1, 15); 

            double result = 0;

            for (int i = 0; i <= n42; i++)
            {
                result += Math.Pow(-1, i) * (Math.Pow(x42, 2 * i + 1) / (2 * i + 1));
            }

            MessageBox.Show("результат: " + result);
            text11.Visibility = Visibility.Collapsed;
            result11.Visibility = Visibility.Collapsed;
        }

        private void result12_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x43 = random.NextDouble() * 10;
            int n43 = random.Next(1, 15);

            double result = 0;

            for (int i = 0; i <= n43; i++)
            {
                result += Math.Pow(-1, i) * (Math.Pow(x43, 2 * i) / (2 * i));
            }

            MessageBox.Show("результат: " + result);
            text12.Visibility = Visibility.Collapsed;
            result12.Visibility = Visibility.Collapsed;
        }

        private void result13_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x44 = random.NextDouble(); 
            int n44 = random.Next(1, 15); 

            double result = 0;

            for (int i = 1; i <= n44; i++)
            {
                result += Math.Pow(-1, i - 1) * Math.Pow(x44, i) / i;
            }

            MessageBox.Show("результат: " + result);
            text13.Visibility = Visibility.Collapsed;
            result13.Visibility = Visibility.Collapsed;
        }

        private void result14_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x45 = random.NextDouble(); 
            int n45 = random.Next(1, 15); 

            double result = 0;

            for (int i = 0; i <= n45; i++)
            {
                result += Math.Pow(-1, i) * (Math.Pow(x45, 2 * i + 1) / (2 * i + 1));
            }

            MessageBox.Show("результат: " + result);
            text14.Visibility = Visibility.Collapsed;
            result14.Visibility = Visibility.Collapsed;
        }
    }
}
