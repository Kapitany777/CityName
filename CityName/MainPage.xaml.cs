using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CityName
{
    public partial class MainPage : UserControl
    {
        Varosnev v = new Varosnev();
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlockCityName.Text = v.GetVarosnev();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlockCityName.Text = v.GetVarosnev();
        }
    }
}
