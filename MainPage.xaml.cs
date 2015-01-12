using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace StatsHypoyhesis
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            if ((Visibility)Resources["PhoneLightThemeVisibility"] == Visibility.Visible)
            {
                DarkTheme();
            }

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ChiTestStandard.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ChiTestVariance.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PopulationProportion.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ZTestMeanDiff.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ZTestError.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ZTestMeanDiff.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConfidenceLeftEnd.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_7(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConfidenceRightEnd.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_8(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LeftEndPoint.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_9(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RightEndPoint.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_10(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PopulationVarianceTest.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_11(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ProportionTest.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_12(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PTest.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_13(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TTest.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_14(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ZTest.xaml", UriKind.Relative));
        }
        private void DarkTheme()
        {
            ((SolidColorBrush)Resources["PhoneRadioCheckBoxCheckBrush"]).Color = ((SolidColorBrush)Resources["PhoneRadioCheckBoxBorderBrush"]).Color = ((SolidColorBrush)Resources["PhoneForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneContrastForegroundBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneContrastBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneDisabledBrush"]).Color = Color.FromArgb(0x66, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneProgressBarBackgroundBrush"]).Color = Color.FromArgb(0x19, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextCaretBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneTextBoxBrush"]).Color = Color.FromArgb(0xBF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxForegroundBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneTextBoxEditBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxReadOnlyBrush"]).Color = Color.FromArgb(0x77, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneSubtleBrush"]).Color = Color.FromArgb(0x99, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxSelectionForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneButtonBasePressedForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextHighContrastBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextMidContrastBrush"]).Color = Color.FromArgb(0x99, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextLowContrastBrush"]).Color = Color.FromArgb(0x73, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneSemitransparentBrush"]).Color = Color.FromArgb(0xAA, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneChromeBrush"]).Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);

            ((SolidColorBrush)Resources["PhoneInactiveBrush"]).Color = Color.FromArgb(0x33, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneInverseInactiveBrush"]).Color = Color.FromArgb(0xFF, 0xCC, 0xCC, 0xCC);
            ((SolidColorBrush)Resources["PhoneInverseBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneBorderBrush"]).Color = Color.FromArgb(0xBF, 0xFF, 0xFF, 0xFF);
        }
    }
}