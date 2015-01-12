using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace StatsHypoyhesis
{
    public partial class LeftEndPoint : PhoneApplicationPage
    {
        public LeftEndPoint()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double s = Convert.ToDouble(txtS.Text);
                double value = Convert.ToDouble(txtValue.Text);
                double left = Convert.ToDouble(txtLeft.Text);
                double total = HypothesisOne.LeftEndPoint(s, value, left);
                tbResult.Text = "Left End Point: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtS.Text = "";
            txtLeft.Text = "";
            txtValue.Text = "";
            tbResult.Text = "";
        }
    }
}