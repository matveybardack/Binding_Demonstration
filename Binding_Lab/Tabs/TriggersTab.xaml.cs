using System.Windows;
using System.Windows.Controls;

namespace Binding_Lab.Tabs
{
    /// <summary>
    /// Логика взаимодействия для TriggersTab.xaml
    /// </summary>
    public partial class TriggersTab : UserControl
    {
        public TriggersTab()
        {
            InitializeComponent();
        }

        private void ApplyExplicitButton_Click(object sender, RoutedEventArgs e)
        {
            // Принудительно обновляем привязку с UpdateSourceTrigger=Explicit
            var binding = System.Windows.Data.BindingOperations.GetBindingExpression(
                ExplicitTextBox, TextBox.TextProperty);
            binding?.UpdateSource();
        }
    }
}
