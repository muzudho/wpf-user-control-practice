namespace WpfUserControlPractice
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            frame.Source = new Uri("./Views/HomePageView.xaml", UriKind.Relative);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("./Views/HomePageView.xaml", UriKind.Relative);
        }

        private void Sample1Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("./Views/Sample1PageView.xaml", UriKind.Relative);
        }

        private void Sample2Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("./Views/Sample2PageView.xaml", UriKind.Relative);
        }

        private void Sample3Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("./Views/Sample3PageView.xaml", UriKind.Relative);
        }

        private void Sample4Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("./Views/Sample4PageView.xaml", UriKind.Relative);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("./Views/Sample5PageView.xaml", UriKind.Relative);
        }
    }
}
