using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Win10Exploration
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer.Items.Clear();
            AddDeleteItemsContainer.Items.Clear();
            ContentItemsContainer.Items.Clear();
            EdgeUIItemsContainer.Items.Clear();
            EntranceItemsContainer.Items.Clear();
            ReorderItemsContainer.Items.Clear();
            RepositionItemsContainer.Items.Clear();
        }
        private void AddDeleteTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                AddDeleteItemsContainer.Items.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
            }
        }

        private void ContentTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                ContentItemsContainer.Items.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
            }
        }

        private void EdgeUITransitionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                EdgeUIItemsContainer.Items.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
            }
        }

        private void EntranceTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                EntranceItemsContainer.Items.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
            }
        }

        private void ReorderTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                ReorderItemsContainer.Items.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
            }
        }

        private void RepositionTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                RepositionItemsContainer.Items.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
            }
        }

        private void NoTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                NoTransitionItemsContainer.Items.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
            }
        }
    }
}
