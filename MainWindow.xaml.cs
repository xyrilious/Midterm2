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

namespace XyrilleAnnMamalateo.Midterm2
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            int v1 = int.Parse(txtFrom.Text);
            int v2 = int.Parse(txtTo.Text);
            int v3;
            int v4 = v1;
            int v5 = v1;
            for (v3 = v2 - v1; v3 != 0; --v3)
            {
                ++v4;
                v5 = v4 + v5;
            }
            lblResult.Content = v5.ToString();
        }
    }
}
