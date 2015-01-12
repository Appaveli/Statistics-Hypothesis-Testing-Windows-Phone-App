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
    public partial class PTest : PhoneApplicationPage
    {
        public PTest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtValue.Text);
                double sample = Convert.ToDouble(txtSample.Text);
                double mean = Convert.ToDouble(txtMean.Text);
                double n = Convert.ToDouble(txtN.Text);
                double total = HypothesisOne.P_Test(value, sample, mean, n);
                tbResult.Text = "P-Test: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtValue.Text = "";
            txtN.Text = "";
            txtSample.Text = "";
            txtMean.Text = "";
            tbResult.Text = "";
        }
    }
}