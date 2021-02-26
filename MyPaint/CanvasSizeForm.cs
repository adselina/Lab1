using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class CanvasSizeForm : Form
    {

        public CanvasSizeForm()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            CanvasForm cs = MainForm.activeForm;
            cs.CanvasWidth = Convert.ToInt32(widthBox.Text);
            cs.width = cs.CanvasWidth;
            cs.CanvasHeight = Convert.ToInt32(hightBox.Text);
            cs.height = cs.CanvasHeight;
            this.Close();
           
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DocumentSizeForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AcceptButton = buttonAccept;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancelButton = buttonCancel;
            }
        }

        
    }
}
