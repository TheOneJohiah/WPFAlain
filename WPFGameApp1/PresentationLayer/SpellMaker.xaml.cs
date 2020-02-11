using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFGameApp1.PresentationLayer
{
    /// <summary>
    /// Interaction logic for SpellMaker.xaml
    /// </summary>
    public partial class SpellMaker : Window
    {
        public SpellMaker()
        {
            InitializeComponent();
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Confirm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewSpell()
        {

        }


    }
}
