using System.Windows.Controls;

namespace PSBench.UI.Controls;

/// <summary>
/// Code-behind for OutputGridControl.
/// All display logic is handled via XAML data binding to OutputViewModel.GridData.
/// </summary>
public partial class OutputGridControl : UserControl
{
    public OutputGridControl()
    {
        InitializeComponent();
    }
}
