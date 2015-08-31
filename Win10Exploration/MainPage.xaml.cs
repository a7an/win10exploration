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
        private const int DefaultNumItemsToAdd = 3;
        readonly Random rand = new Random();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ResetAll()
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();

            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;
            PaneUIContainer.Visibility = Visibility.Collapsed;
            ListTransitionButtonContainer.Visibility = Visibility.Collapsed;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();
        }

        private void CreateItems(ItemsControl container, int numItemsToAdd)
        {
            for (var i = 0; i < numItemsToAdd; i++)
            {
                int random = rand.Next(0, 17);

                var item = new Image
                {
                    Source = new BitmapImage
                    {
                        UriSource = new Uri("ms-appx:///Images/LandscapeImage" + random.ToString() + ".jpg", UriKind.Absolute)
                    },
                    Width = 200,
                    Height = 134
                };

                var border = new Border
                {
                    BorderBrush = new SolidColorBrush(Color.FromArgb(112, 255, 255, 255)),
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(4),
                    Child = item
                };

                container?.Items?.Add(border);
            }
        }

        private void ListTransitionsButton_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();

            ListTransitionButtonContainer.Visibility = Visibility.Visible;
        }

        private void NoTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();

            CreateItems(NoTransitionItemsContainer, DefaultNumItemsToAdd);
        }

        private void EntranceTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            RepositionItemsContainer?.Items?.Clear();
            RepositionItemsTransitionContainer?.Items?.Clear();
            ContentTransitionContainer.Visibility = Visibility.Collapsed;
            RepositionItemsGrid.Visibility = Visibility.Collapsed;

            CreateItems(EntranceItemsContainer, DefaultNumItemsToAdd);
        }

        private void AddDeleteTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();

            CreateItems(AddDeleteItemsContainer, DefaultNumItemsToAdd);
        }

        private void ContentTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();

            ContentTransitionContainer.Visibility = Visibility.Visible;
        }

        private void EdgeUITransitionButton_Click(object sender, RoutedEventArgs e)
        {
            EdgeUiItem.Margin = new Thickness(0, 0, 0, 0);
        }

        private void RepositionTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();

            RepositionItemsGrid.Visibility = Visibility.Visible;
            CreateItems(RepositionItemsContainer, 24);
            CreateItems(RepositionItemsTransitionContainer, 24);
        }

        private void ContentHost_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Replace the ContentControl's content with a new Rectangle of a random color.
            Rectangle newItem = new Rectangle
            {
                Height = 200,
                Width = 200,
                Fill = new SolidColorBrush(Color.FromArgb(255,
                    (byte) rand.Next(0, 255), (byte) rand.Next(0, 255), (byte) rand.Next(0, 255)))
            };

            var container = sender as ContentControl;
            if (container != null) container.Content = newItem;
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (RepositionItemsContainer.Items != null && RepositionItemsContainer.Items.Count > 0)
            {
                int random = rand.Next(0, RepositionItemsContainer.Items.Count);

                RepositionItemsContainer.Items.RemoveAt(random);
            }
        }

        private void RemoveItemUsingTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            if (RepositionItemsTransitionContainer.Items != null && RepositionItemsTransitionContainer.Items.Count > 0)
            {
                int random = rand.Next(0, RepositionItemsTransitionContainer.Items.Count);

                RepositionItemsTransitionContainer.Items.RemoveAt(random);
            }
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (RepositionItemsContainer.Items != null && RepositionItemsContainer.Items.Count > 0)
            {
                int itemPosition = rand.Next(0, RepositionItemsContainer.Items.Count);

                int randomImage = rand.Next(0, 17);

                var item = new Image
                {
                    Source = new BitmapImage
                    {
                        UriSource = new Uri("ms-appx:///Images/LandscapeImage" + randomImage.ToString() + ".jpg", UriKind.Absolute)
                    },
                    Width = 200,
                    Height = 134
                };

                var border = new Border
                {
                    BorderBrush = new SolidColorBrush(Color.FromArgb(112, 255, 255, 255)),
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(4),
                    Child = item
                };

                RepositionItemsContainer.Items.Insert(itemPosition, border);
            }
        }

        private void AddItemUsingTransitionButton_Click(object sender, RoutedEventArgs e)
        {
            if (RepositionItemsTransitionContainer.Items != null && RepositionItemsTransitionContainer.Items.Count > 0)
            {
                var itemPosition = rand.Next(0, RepositionItemsTransitionContainer.Items.Count);

                var random = rand.Next(0, 17);

                var item = new Image
                {
                    Source = new BitmapImage
                    {
                        UriSource = new Uri("ms-appx:///Images/LandscapeImage" + random.ToString() + ".jpg", UriKind.Absolute)
                    },
                    Width = 200,
                    Height = 134
                };

                var border = new Border
                {
                    BorderBrush = new SolidColorBrush(Color.FromArgb(112, 255, 255, 255)),
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(4),
                    Child = item
                };

                RepositionItemsTransitionContainer.Items.Insert(itemPosition, border);
            }
        }

        private void PaneEdgeUITransitionButton_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();

            PaneUIContainer.Visibility = Visibility.Visible;
        }

        private void PaneUIToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var isPaneUIOpen = (bool)PaneUIToggleButton.IsChecked;
            if (isPaneUIOpen)
            {
                PaneUiItem.Margin = new Thickness(0, 0, 0, 0);
            }
            else
            {
                PaneUiItem.Margin = new Thickness(0, 0, -400, 0);
            }
        }

        private void EdgeUIToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var isEdgeUIOpen = (bool)EdgeUIToggleButton.IsChecked;
            if (isEdgeUIOpen)
            {
                EdgeUiItem.Margin = new Thickness(0, 0, 0, 0);
            }
            else
            {
                EdgeUiItem.Margin = new Thickness(0, 0, -100, 0);
            }
        }

        private void ClearItemsButton_Click(object sender, RoutedEventArgs e)
        {
            NoTransitionItemsContainer?.Items?.Clear();
            AddDeleteItemsContainer?.Items?.Clear();
            EntranceItemsContainer?.Items?.Clear();
        }
    }
}
