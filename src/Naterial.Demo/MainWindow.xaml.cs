using System.Windows;

namespace Naterial.Demo
{
    public partial class MainWindow : Window
    {
        private bool _isDark;


        public MainWindow() => InitializeComponent();


        private void SwitchTheme_OnClick(object sender, RoutedEventArgs e)
        {
            _isDark = !_isDark;

            ThemeManager.Current.SetTheme(Application.Current.Resources, _isDark ? BaseTheme.Dark : BaseTheme.Light);

        }
    }
}
