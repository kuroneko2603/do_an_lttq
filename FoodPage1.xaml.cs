using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
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
    /// Interaction logic for FoodPage1.xaml
    /// </summary>
    public partial class FoodPage1 : UserControl
    {
        public FoodPage1()
        {
            InitializeComponent();
        }

        private void Btnadd1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openFileDialog.ShowDialog();
            string a;
            a = openFileDialog.FileName;
            ImgAdd1.Source = new BitmapImage(new Uri(@a, UriKind.RelativeOrAbsolute));
            btnadd1.Content = "Order Now";
        }
    }
}
