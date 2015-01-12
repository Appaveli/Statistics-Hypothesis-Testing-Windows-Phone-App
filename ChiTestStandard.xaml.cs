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
    public partial class ChiTestStandard : PhoneApplicationPage
    {
        public ChiTestStandard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(txtN.Text);
                double s = Convert.ToDouble(txtS.Text);
                double a = Convert.ToDouble(txtA.Text);
                double total = HypothesisTwo.Chi_SquaureTestStandard_Dev(n, s, a);
                tbResult.Text = "Chi Square Test Standard Deviation: : " + total.ToString();
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
            txtA.Text = "";
            tbResult.Text = "";
        }
    }
}