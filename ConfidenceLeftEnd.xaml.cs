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
    public partial class ConfidenceLeftEnd : PhoneApplicationPage
    {
        public ConfidenceLeftEnd()
        {
            InitializeComponent();
        }

        private void btnConLeft_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                double s = Convert.ToDouble(txtS.Text);
                double left = Convert.ToDouble(txtLeftEnd.Text);
                double value = Convert.ToDouble(txtValue.Text);
                double total = HypothesisOne.ConfiLeftEndPoint(s, left, value);
                tbResult.Text = " Confidence Left End: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtS.Text = "";
            txtLeftEnd.Text = "";
            txtValue.Text = "";
            tbResult.Text = "";
        }
    }
}