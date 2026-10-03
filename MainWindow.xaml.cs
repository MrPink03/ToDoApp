using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDOApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int textColoumn = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (newtaskbox.Visibility == Visibility.Visible
                && addbutton.Visibility == Visibility.Visible)
            {
                newtaskbox.Visibility = Visibility.Hidden;
                addbutton.Visibility = Visibility.Hidden;
            }
            else
            {
                newtaskbox.Visibility = Visibility.Visible;
                addbutton.Visibility = Visibility.Visible;
            }
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            textColoumn++;
            var texbox = new TextBox();
            texbox.Text = newtaskbox.Text;
            Grid.SetColumn(texbox, textColoumn);
            Grid.SetRow(texbox, 2);
            MessageBox.Show(texbox.Text);
            myGrid.Children.Add(texbox);
        }
    }
}