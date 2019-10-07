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

namespace mp3pj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FoodPage p1 = new FoodPage();
        FoodPage1 p2 = new FoodPage1();
        FoodPage2 p3 = new FoodPage2();
        EventPage p4 = new EventPage();
        OrderPage p5 = new OrderPage();
        public MainWindow()
        {
            InitializeComponent();
            GridMain.Children.Add(new FoodPage());
            
        }
        
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveMenu(index);
            switch(index)
            {
                case 0:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(p1);
                    break;
                case 1:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(p2);
                    break;
                case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(p3);
                    break;
                case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(p4);
                    break;
                case 4:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(p5);
                    break;

                case 5:
                    GridMain.Children.Clear();
                    LoginWindow f = new LoginWindow();
                    f.ShowDialog();
                    if (f.LogButton.IsPressed)
                        GridMain.Children.Add(new EventPage());
                    
                    break;

            }
        }

        private void MoveMenu(int index)
        {
            TrContent.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }
    }
}
