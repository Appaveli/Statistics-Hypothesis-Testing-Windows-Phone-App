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
    public partial class ConfidenceRightEnd : PhoneApplicationPage
    {
        public ConfidenceRightEnd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtS.Text = "";
            txtRight.Text = "";
            txtValue.Text = "";
            tbResult.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double s = Convert.ToDouble(txtS.Text);
                double left = Convert.ToDouble(txtRight.Text);
                double value = Convert.ToDouble(txtValue.Text);
                double total = HypothesisOne.ConfiRightEndPoint(s, left, value);
                tbResult.Text = " Confidence Right End: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }
    }
}