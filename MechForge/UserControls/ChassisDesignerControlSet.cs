using System.Windows.Forms;

namespace MechForge.UserControls
{
    public class ChassisDesignerControlSet : UserControl
    {
        private Label ChassisDesignerLabel;

        public ChassisDesignerControlSet()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ChassisDesignerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChassisDesignerLabel
            // 
            this.ChassisDesignerLabel.AutoSize = true;
            this.ChassisDesignerLabel.Location = new System.Drawing.Point(121, 102);
            this.ChassisDesignerLabel.Name = "ChassisDesignerLabel";
            this.ChassisDesignerLabel.Size = new System.Drawing.Size(111, 13);
            this.ChassisDesignerLabel.TabIndex = 0;
            this.ChassisDesignerLabel.Text = "ChassisDesignerLabel";
            // 
            // ChassisDesignerControlSet
            // 
            this.Controls.Add(this.ChassisDesignerLabel);
            this.Name = "ChassisDesignerControlSet";
            this.Size = new System.Drawing.Size(724, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}