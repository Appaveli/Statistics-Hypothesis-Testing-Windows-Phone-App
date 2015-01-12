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
    public partial class ZTestDiffPro : PhoneApplicationPage
    {
        public ZTestDiffPro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double p1 = Convert.ToDouble(txtP1.Text);
                double p2 = Convert.ToDouble(txtP2.Text);
                double p = Convert.ToDouble(txtP.Text);
                double q = Convert.ToDouble(txtQ.Text);
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double total = HypothesisTwo.zTest_Difference_Proportions(p1, p2, p, q,n1,n2);
                tbResult.Text = "Z Test Differece Proportion: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtP1.Text = "";
            txtP2.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtP.Text = "";
            txtQ.Text = "";
            tbResult.Text = "";
        }
    }
}