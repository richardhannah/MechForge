using System.Windows.Forms;
using Newtonsoft.Json;

namespace MechForge.UserControls
{
    public class ChassisDesignerControlSet : UserControl, IDesignable
    {
        public string JsonData { get; set; }


        private TextField textField1;
        private Label ChassisDesignerLabel;

        public ChassisDesignerControlSet()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ChassisDesignerLabel = new System.Windows.Forms.Label();
            this.textField1 = new MechForge.UserControls.TextField();
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
            // textField1
            // 
            this.textField1.Location = new System.Drawing.Point(38, 19);
            this.textField1.Name = "textField1";
            this.textField1.Size = new System.Drawing.Size(155, 29);
            this.textField1.TabIndex = 1;
            // 
            // ChassisDesignerControlSet
            // 
            this.Controls.Add(this.textField1);
            this.Controls.Add(this.ChassisDesignerLabel);
            this.Name = "ChassisDesignerControlSet";
            this.Size = new System.Drawing.Size(724, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}