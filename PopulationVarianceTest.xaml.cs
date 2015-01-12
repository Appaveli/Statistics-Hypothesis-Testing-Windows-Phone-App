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
    public partial class PopulationVarianceTest : PhoneApplicationPage
    {
        public PopulationVarianceTest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(txtN.Text);
                double s = Convert.ToDouble(txtS.Text);
                double value = Convert.ToDouble(txtValue.Text);
                double total = HypothesisOne.PopulationVarianceTest(n, s, value);
                tbResult.Text = "Population Variance Test: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtS.Text = "";
            txtN.Text = "";
            txtValue.Text = "";
            tbResult.Text = "";
        }
    }
}