using System.Windows.Forms;
using MechForge.Domain;

namespace MechForge.UserControls
{
    public class WeaponDesignerControlSet : UserControl
    {
        private Label label1;

        public WeaponDesignerControlSet()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WeaponDesignerLabel";
            // 
            // WeaponDesignerControlSet
            // 
            this.Controls.Add(this.label1);
            this.Name = "WeaponDesignerControlSet";
            this.Size = new System.Drawing.Size(736, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}