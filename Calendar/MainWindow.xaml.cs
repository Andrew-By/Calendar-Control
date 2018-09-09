using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Calendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillCalendar();
        }

        public void FillCalendar()
        {
            var rand = new Random();
            var buff = new byte[3];
            for (int i = 0; i < 100; i++)
            {
                var people = new List<Human>();
                for (int j = 0; j < 20; j++)
                {
                    rand.NextBytes(buff);
                    var length = rand.Next(100);
                    Debug.WriteLine($"{buff[0]} {buff[1]} {buff[2]} of {length}");
                    people.Add(new Human
                    {
                        Color = new SolidColorBrush(Color.FromRgb(buff[0], buff[1], buff[2])),
                        Length = length
                    });
                }
                CalendarView.Items.Add(people);
            }
        }
    }
}
