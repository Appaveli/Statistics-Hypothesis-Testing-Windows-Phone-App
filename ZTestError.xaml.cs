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
    public partial class ZTestError : PhoneApplicationPage
    {
        public ZTestError()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(txtS1.Text);
                double s2 = Convert.ToDouble(txtS2.Text);
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN1.Text);
                double total = HypothesisTwo.zTest_StandardError(s1, s2, n1, n2);
                tbResult.Text = "Z Test Standard Error: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtS1.Text = "";
            txtS2.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            tbResult.Text = "";
        }
    }
}