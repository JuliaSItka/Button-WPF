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


namespace WpfApp1
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

      

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
          
            switch (Shape.SelectedIndex)
            {
                case 0:
                    {
                        Style style = this.FindResource("RoundButtonTemplate") as Style;
                        MyButton.Style = style;
                        break;
                    }
                case 1:
                    {
                       Style style = this.FindResource("Rectangle") as Style;
                        MyButton.Style = style;
                        break;
                    }
                case 2:
                    {
                        Style style = this.FindResource("Circle") as Style;
                        MyButton.Style = style;
                        break;
                    }
                case 3:
                    {
                        Style style = this.FindResource("Square") as Style;
                        MyButton.Style = style;
                        break;
                    }

            }
        }

  private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SelectColor.SelectedIndex)
            {
                case 0:
                    {
                        MyButton.Background = Brushes.Red;
                        break;
                    }
                case 1:
                    {
                        MyButton.Background = Brushes.Green;
                        break;

                    }
                case 2:
                    {
                        MyButton.Background = Brushes.Black;
                        MyButton.Foreground = Brushes.White;
                        break;
                    }
                case 3:
                    {
                        MyButton.Background = Brushes.Pink;
                        break;

                    }
            }
        }
        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi hi hi! ");
        }
    }
}
