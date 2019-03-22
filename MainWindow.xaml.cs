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

namespace _312576targetCanvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer Cleartimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0,0,0,0,45);
            timer.Start();

            Cleartimer.Tick += Cleartimer_tick;
            Cleartimer.Interval = new TimeSpan(0, 0, 0, 1);
            Cleartimer.Start();

            //timer.Interval(0,0,0,);

            for (int j=50; j>0; j--)
            {
                    Ellipse w = new Ellipse();
                    w.Height = j*10;
                    w.Width = j*10;
                if (j % 4 == 0)
                {
                    w.Fill = Brushes.Red;
                }
                else if (j % 3 == 0)
                {
                    w.Fill = Brushes.Purple;
                }
                else if (j % 7 == 0)
                {
                    w.Fill = Brushes.Blue;
                }
                else if (j % 5 == 0)
                {
                    w.Fill = Brushes.Yellow;
                }
                else
                {
                    w.Fill = Brushes.LimeGreen;
                }
                canvas.Children.Add(w);
                Canvas.SetTop(w, 250 - (w.Width / 2));
                Canvas.SetLeft(w, 250 - (w.Width / 2));                
            }

           
        }
        private void timer_tick(object sender, EventArgs e)
        {
            x++;
            if (x % 2 == 0)
            {
                for (int j = 50; j > 0; j--)
                {
                    Ellipse w = new Ellipse();
                    w.Height = j * 10;
                    w.Width = j * 10;
                    if (j % 4 == 0)
                    {
                        w.Fill = Brushes.Blue;
                    }
                    else if (j % 3 == 0)
                    {
                        w.Fill = Brushes.Red;
                    }
                    else if (j % 7 == 0)
                    {
                        w.Fill = Brushes.Purple;
                    }
                    else if (j % 5 == 0)
                    {
                        w.Fill = Brushes.LimeGreen;
                    }
                    else
                    {
                        w.Fill = Brushes.Yellow;
                    }
                    canvas.Children.Add(w);
                    Canvas.SetTop(w, 250 - (w.Width / 2));
                    Canvas.SetLeft(w, 250 - (w.Width / 2));
                }
            }
            else if (x % 2 == 1)
            {
                for (int j = 50; j > 0; j--)
                {
                    Ellipse w = new Ellipse();
                    w.Height = j * 10;
                    w.Width = j * 10;
                    if (j % 4 == 0)
                    {
                        w.Fill = Brushes.Red;
                    }
                    else if (j % 3 == 0)
                    {
                        w.Fill = Brushes.Purple;
                    }
                    else if (j % 7 == 0)
                    {
                        w.Fill = Brushes.Blue;
                    }
                    else if (j % 5 == 0)
                    {
                        w.Fill = Brushes.Yellow;
                    }
                    else
                    {
                        w.Fill = Brushes.LimeGreen;
                    }
                    canvas.Children.Add(w);
                    Canvas.SetTop(w, 250 - (w.Width / 2));
                    Canvas.SetLeft(w, 250 - (w.Width / 2));
                }
            }
        }

        private void Cleartimer_tick(object sender, EventArgs e)
        {
            canvas.Children.Clear();
        }
    }
}
