using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
namespace Microsoft.VSModalDialog
{
    /// <summary>
    /// Interaction logic for OnestopSettings.xaml
    /// </summary>
    public partial class OnestopSettings
    {
        public OnestopSettings()
        {
            InitializeComponent();
        }

        private void AcmeRoot_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AcmeRootBrowse_Click(object sender, RoutedEventArgs e)
        {
            var o = new OpenFileDialog();
            o.ShowDialog();
        }

        private void AcmeRoot_OnLoaded(object sender, RoutedEventArgs e)
        {
            AcmeRoot.Text = "Hello World";
        }

        private void SettingsCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
// ReSharper restore InconsistentNaming
// ReSharper restore CheckNamespace
