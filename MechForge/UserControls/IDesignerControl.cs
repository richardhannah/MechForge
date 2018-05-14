using System.Windows.Forms;

namespace MechForge.UserControls
{
    public interface IDesignerControl
    {
        UserControl ControlSet { get; }
    }
}