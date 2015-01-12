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
    public partial class ZTest : PhoneApplicationPage
    {
        public ZTest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtX.Text);
                double n = Convert.ToDouble(txtN.Text);
                double p = Convert.ToDouble(txtP.Text);
                double q = Convert.ToDouble(txtQ.Text);
                double total = HypothesisOne.zTest(x, n, p, q);
                tbResult.Text = "Z-Test: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtX.Text = "";
            txtN.Text = "";
            txtP.Text = "";
            txtQ.Text = "";
            tbResult.Text = "";
        }
    }
}