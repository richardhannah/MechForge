using System.Windows.Forms;

namespace MechForge.UserControls
{
    public interface IDesignerControl
    {
        string Json { get; set; }
        IDesignable ControlSet { get; }
    }
}