using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DataContext is ViewModel.MainVM vm)
            {
                vm.SaveOnApplicationClose();
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ViewModel.MainVM vm)
            {
                vm.LoadOnApplicationStart();
            }
        }
    }
}