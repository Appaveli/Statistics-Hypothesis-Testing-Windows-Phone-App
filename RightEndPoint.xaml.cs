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
    public partial class RightEndPoint : PhoneApplicationPage
    {
        public RightEndPoint()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double s = Convert.ToDouble(txtS.Text);
                double value = Convert.ToDouble(txtValue.Text);
                double right = Convert.ToDouble(txtRight.Text);
                double total = HypothesisOne.RightEndPoint(s, value, right);
                tbResult.Text = "Right End Point: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtS.Text = "";
            txtRight.Text = "";
            txtValue.Text = "";
            tbResult.Text = "";
        }
    }
}