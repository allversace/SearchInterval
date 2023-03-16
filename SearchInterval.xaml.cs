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

namespace WpfApp8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultMinutes.IsReadOnly = true;
            resultHours.IsReadOnly = true;
            hours.MaxLength = 2;
            minets.MaxLength = 3;
            interval.MaxLength = 3;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int convertHours = Convert.ToInt32(hours.Text);
            int convertMinets = Convert.ToInt32(minets.Text);
            int convertInterval = Convert.ToInt32(interval.Text);
            int midelResult, totalResult;

            if (convertHours <= 59 && convertMinets <= 59 && convertInterval <= 59)
            {
                midelResult = (convertHours * 60) + convertMinets + convertInterval;

                if(convertHours < 60)
                {
                    totalResult = convertHours / 60;


                    if(convertMinets >= 60)
                    {
                        convertHours++;
                        convertMinets = 0;
                    }
                    resultHours.Text = convertHours.ToString();
                    resultMinutes.Text = convertMinets.ToString();
                }
                else
                {
                    MessageBox.Show("Error2");
                }
            }
            else
            {
                MessageBox.Show("Error1");
            }
        }

        private void hours_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void minets_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void interval_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
// searchResult = searchMinutes + convertMinets + convertInterval;
// totalResult = searchResult / 60;
// result.Text = totalResult.ToString();
