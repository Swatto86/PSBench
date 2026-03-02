using System.Windows.Controls;

namespace PSBench.UI.Controls;

/// <summary>
/// Code-behind for CommandPreviewControl.
/// All display logic is handled via XAML data binding to CmdletViewModel.CommandPreview.
/// </summary>
public partial class CommandPreviewControl : UserControl
{
    public CommandPreviewControl()
    {
        InitializeComponent();
    }
}
