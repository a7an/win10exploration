using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Win10Exploration
{
    public sealed partial class MainPage : Page
    {
        int itemsToAddCount = 8;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            ContentItemsContainer?.Items?.Clear();
            EdgeUIItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
        }
        private void NoTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            AddDeleteItemsContainer?.Items?.Clear();
            ContentItemsContainer?.Items?.Clear();
            EdgeUIItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();

            for (var i = 0; i < itemsToAddCount; i++)
            {
                //NoTransitionItemsContainer?.Items?.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
                NoTransitionItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(0, 0, 10, 10)
                    });
            }
        }

        private void AddDeleteTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            ContentItemsContainer?.Items?.Clear();
            EdgeUIItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();

            for (var i = 0; i < itemsToAddCount; i++)
            {
                //AddDeleteItemsContainer?.Items?.Add(new Rectangle() { Fill = new SolidColorBrush(Colors.Red), Margin = new Thickness(10), Height = 100, Width = 100 });
                AddDeleteItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        }, Margin = new Thickness(0,0,10,10)
                    });
            }
        }

        private void ContentTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EdgeUIItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();

            for (var i = 0; i < itemsToAddCount; i++)
            {
                ContentItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(0, 0, 10, 10)
                    });
            }
        }

        private void EdgeUITransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            ContentItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();

            for (var i = 0; i < itemsToAddCount; i++)
            {
                EdgeUIItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(0, 0, 10, 10)
                    });
            }
        }

        private void EntranceTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            ContentItemsContainer?.Items?.Clear();
            EdgeUIItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();

            for (var i = 0; i < itemsToAddCount; i++)
            {
                EntranceItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(0, 0, 10, 10)
                    });
            }
        }

        private void ReorderTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            ContentItemsContainer?.Items?.Clear();
            EdgeUIItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();

            for (var i = 0; i < itemsToAddCount; i++)
            {
                ReorderItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(0, 0, 10, 10)
                    });
            }
        }

        private void RepositionTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            ContentItemsContainer?.Items?.Clear();
            EdgeUIItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();

            for (var i = 0; i < itemsToAddCount; i++)
            {
                RepositionItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(0, 0, 10, 10)
                    });
            }
        }
    }
}
