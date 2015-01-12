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
    public partial class ProportionTest : PhoneApplicationPage
    {
        public ProportionTest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double v1 = Convert.ToDouble(txtV1.Text);
                double v2 = Convert.ToDouble(txtV2.Text);
                double p = Convert.ToDouble(txtP.Text);
                double q = Convert.ToDouble(txtQ.Text);
                double n = Convert.ToDouble(txtN.Text);
                double total = HypothesisOne.ProportionTest(v1, v2, p,q,n);
                tbResult.Text = "Proportion Test: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtQ.Text = "";
            txtN.Text = "";
            txtV1.Text = "";
            txtV2.Text = "";
            txtP.Text = "";
            tbResult.Text = "";
        }
    }
}