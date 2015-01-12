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
    public partial class PopulationProportion : PhoneApplicationPage
    {
        public PopulationProportion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(txtX1.Text);
                double x2 = Convert.ToDouble(txtX2.Text);
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN1.Text);
                double total = HypothesisTwo.Population_Proportion(x1, x2, n1,n2);
                tbResult.Text = "Population Proportion: " + total.ToString();
            }
            catch (Exception ex)
            {
                tbResult.Text = "Please Enter Data";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtX1.Text = "";
            txtX2.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            tbResult.Text = "";
        }
    }
}