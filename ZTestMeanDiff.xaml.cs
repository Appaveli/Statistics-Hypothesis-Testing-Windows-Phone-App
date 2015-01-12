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
    public partial class ZTestMeanDiff : PhoneApplicationPage
    {
        public ZTestMeanDiff()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(txtD.Text);
                double m = Convert.ToDouble(txtM.Text);
                double sd = Convert.ToDouble(txtSD.Text);
                double n = Convert.ToDouble(txtN.Text);
                double total = HypothesisTwo.zTest_Mean_Difference(d, m, sd, n);
                tbResult.Text = "Z Test Mean Difference: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtD.Text = "";
            txtM.Text = "";
            txtSD.Text = "";
            txtN.Text = "";
            tbResult.Text = "";
        }
    }
}