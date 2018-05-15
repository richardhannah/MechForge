using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechForge.UserControls
{
    public partial class TextField : UserControl
    {
        [Category("TextField Properties")]
        [Description("TextField Label")]
        public Label Label
        {
            get { return this.label; }
            set { this.label = value; }
        }

        [Category("TextField Properties")]
        [Description("TextField TextBox")]
        public TextBox TextBox
        {
            get { return this.textBox; }
            set { this.textBox = value; }
        }

        [Category("TextField Properties")]
        [Description("LabelText")]
        public string LabelText
        {
            get { return this.label.Text; }
            set { this.label.Text = value; }
        }

        [Category("TextField Properties")]
        [Description("Text")]
        public string TextFieldText
        {
            get { return this.textBox.Text; }
            set { this.textBox.Text = value; }
        }

        private const int WS_EX_TRANSPARENT = 0x20;
        

        private int opacity = 75;
        [DefaultValue(75)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                this.opacity = value;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }



        public TextField()
        {
            SetStyle(ControlStyles.Opaque, true);
            InitializeComponent();
        }
    }
}
