
namespace MyPaint
{
    partial class CanvasSizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.MaskedTextBox();
            this.hightBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(13, 40);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(75, 20);
            this.width.TabIndex = 0;
            this.width.Text = "Ширина: ";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(234, 39);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(74, 20);
            this.height.TabIndex = 1;
            this.height.Text = "Высота: ";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(94, 37);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 26);
            this.widthBox.TabIndex = 2;
            this.widthBox.Text = "300";
            this.widthBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // hightBox
            // 
            this.hightBox.Location = new System.Drawing.Point(306, 37);
            this.hightBox.Name = "hightBox";
            this.hightBox.Size = new System.Drawing.Size(100, 26);
            this.hightBox.TabIndex = 3;
            this.hightBox.Text = "300";
            this.hightBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(199, 94);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(92, 35);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "ОК";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(314, 94);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CanvasSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 146);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.hightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DocumentSizeForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DocumentSizeForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.MaskedTextBox widthBox;
        private System.Windows.Forms.MaskedTextBox hightBox;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}