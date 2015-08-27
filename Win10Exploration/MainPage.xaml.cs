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
        int defaultNumItemsToAdd = 4;
        Random rand = new Random();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();

            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;
            ReorderItemsGrid.Visibility = Visibility.Collapsed;

            EdgeUiItem.Margin = new Thickness(0, 0, -200, 0);
            PaneUiItem.Margin = new Thickness(0, 0, -400, 0);
        }

        private void NoTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;
            ReorderItemsGrid.Visibility = Visibility.Collapsed;

            CreateItems(NoTransitionItemsContainer, defaultNumItemsToAdd);
        }

        private void CreateItems(ItemsControl container, int numItemsToAdd)
        {
            for (var i = 0; i < numItemsToAdd; i++)
            {
                int random = rand.Next(0, 17);

                var item = new Image()
                {
                    Source = new BitmapImage()
                    {
                        UriSource = new Uri("ms-appx:///Images/LandscapeImage" + random.ToString() + ".jpg", UriKind.Absolute)
                    },
                    Width = 200,
                    Height = 134
                };

                var border = new Border()
                {
                    BorderBrush = new SolidColorBrush(Color.FromArgb(112, 255, 255, 255)),
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(4)
                };
                border.Child = item;

                container?.Items?.Add(border);
            }
        }

        private void AddDeleteTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;
            ReorderItemsGrid.Visibility = Visibility.Collapsed;

            CreateItems(AddDeleteItemsContainer, defaultNumItemsToAdd);
        }

        private void ContentTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            RepositionItemsGrid.Visibility = Visibility.Collapsed;
            ReorderItemsGrid.Visibility = Visibility.Collapsed;

            ContentTransitionContainer.Visibility = Visibility.Visible;
        }

        private void EdgeUITransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;
            ReorderItemsGrid.Visibility = Visibility.Collapsed;

            EdgeUiItem.Margin = new Thickness(0, 0, 0, 0);
        }

        private void EntranceTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;
            ReorderItemsGrid.Visibility = Visibility.Collapsed;

            CreateItems(EntranceItemsContainer, defaultNumItemsToAdd);
        }

        private void ReorderTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;

            ReorderItemsGrid.Visibility = Visibility.Visible;
            CreateItems(ReorderItemsContainer, 12);
            CreateItems(ReorderItemsTransitionContainer, 12);
        }

        private void RepositionTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            ReorderItemsGrid.Visibility = Visibility.Collapsed;

            RepositionItemsGrid.Visibility = Visibility.Visible;
            CreateItems(RepositionItemsContainer, 24);
            CreateItems(RepositionItemsTransitionContainer, 24);
        }

        private void ContentHost_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Replace the ContentControl's content with a new Rectangle of a random color.
            Rectangle newItem = new Rectangle();

            newItem.Height = 200;
            newItem.Width = 200;
            newItem.Fill = new SolidColorBrush(Color.FromArgb(255,
                 (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));

            var container = sender as ContentControl;
            container.Content = newItem;
        }

        private void PaneUITransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            ReorderItemsContainer?.Items?.Clear();
            ReorderItemsTransitionContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;

            PaneUiItem.Margin = new Thickness(0, 0, 0, 0);
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (RepositionItemsContainer.Items.Count > 0)
            {
                int random = rand.Next(0, RepositionItemsContainer.Items.Count);

                RepositionItemsContainer.Items.RemoveAt(random);
            }
        }

        private void RemoveItemUsingTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            if (RepositionItemsTransitionContainer.Items.Count > 0)
            {
                int random = rand.Next(0, RepositionItemsTransitionContainer.Items.Count);

                RepositionItemsTransitionContainer.Items.RemoveAt(random);
            }
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReorderItemsContainer.Items.Count > 0)
            {
                int itemPosition = rand.Next(0, ReorderItemsContainer.Items.Count);

                int randomImage = rand.Next(0, 17);

                var item = new Image()
                {
                    Source = new BitmapImage()
                    {
                        UriSource = new Uri("ms-appx:///Images/LandscapeImage" + randomImage.ToString() + ".jpg", UriKind.Absolute)
                    },
                    Width = 200,
                    Height = 134
                };

                var border = new Border()
                {
                    BorderBrush = new SolidColorBrush(Color.FromArgb(112, 255, 255, 255)),
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(4)
                };
                border.Child = item;

                ReorderItemsContainer.Items.Insert(itemPosition, border);
            }
        }

        private void AddItemUsingTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReorderItemsTransitionContainer.Items.Count > 0)
            {
                int itemPosition = rand.Next(0, ReorderItemsTransitionContainer.Items.Count);

                int random = rand.Next(0, 17);

                var item = new Image()
                {
                    Source = new BitmapImage()
                    {
                        UriSource = new Uri("ms-appx:///Images/LandscapeImage" + random.ToString() + ".jpg", UriKind.Absolute)
                    },
                    Width = 200,
                    Height = 134
                };

                var border = new Border()
                {
                    BorderBrush = new SolidColorBrush(Color.FromArgb(112, 255, 255, 255)),
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(4)
                };
                border.Child = item;

                ReorderItemsTransitionContainer.Items.Insert(itemPosition, border);
            }
        }
    }
}
