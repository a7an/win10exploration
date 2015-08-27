using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;

namespace Win10Exploration
{
    public sealed partial class MainPage : Page
    {
        int itemsToAddCount = 4;

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
                NoTransitionItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(4)
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
                AddDeleteItemsContainer?.Items?.Add(
                    new Image()
                    {
                        Source = new BitmapImage()
                        {
                            UriSource = new Uri("ms-appx:///Images/LandscapeImage" + i.ToString() + ".jpg", UriKind.Absolute)
                        },
                        Margin = new Thickness(4),
                        Width = 200,
                        Height = 134
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

            ContentItemsContainer.Visibility = Visibility.Visible;
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
                        Margin = new Thickness(4)
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
                        Margin = new Thickness(4)
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
                        Margin = new Thickness(4)
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
                        Margin = new Thickness(4)
                    });
            }
        }

        private void ContentHost_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Replace the ContentControl's content with a new Rectangle of a random color.
            Rectangle newItem = new Rectangle();
            Random rand = new Random();

            newItem.Height = 200;
            newItem.Width = 200;
            newItem.Fill = new SolidColorBrush(Color.FromArgb(255,
                 (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));

            var container = sender as ContentControl;
            container.Content = newItem;
        }
    }
}
