using PlaginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Shapes;

namespace MyPaint
{

    public partial class CanvasForm : Form
    {
        public bool hasChanged = false;
        bool clicked = false;
        private Bitmap bmp;
        Point from;
        Point to;
    
        public int height = 0;
        public int width = 0;
        public string filename = null;

        public static bool newDoc = false;

        //новый док
        public CanvasForm()
        {
            InitializeComponent();
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            
            CanvasHeight = (int)260;
            height = CanvasHeight;
            width = CanvasWidth;
            pictureBox1.Image = bmp;
            newDoc = true;
        }

        //открываем сохраненный
        public CanvasForm(String FileName)
        {
            InitializeComponent();
            newDoc = false;
            filename = FileName;
            Image imageFile = Image.FromFile(FileName);
            bmp = new Bitmap(imageFile);
            Graphics g = Graphics.FromImage(imageFile);

            g.DrawImage(bmp, new Point(0, 0));
            height = imageFile.Height;
            width = imageFile.Width;
            pictureBox1.Width = imageFile.Width;
            pictureBox1.Height = imageFile.Height;
            pictureBox1.Image = bmp;
        }

        
        public int CanvasWidth
        {
            get
            {
                return pictureBox1.Width;
            }
            set
            {
                pictureBox1.Width = value;
                Bitmap tbmp = new Bitmap(value, pictureBox1.Width);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }
        public int CanvasHeight
        {
            get
            {
                return pictureBox1.Height;
            }
            set
            {
                pictureBox1.Height = value;
                Bitmap tbmp = new Bitmap(pictureBox1.Width, value);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }

        #region сохранение/закрытие
        public void SaveAs()
        {
            
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg) | *.jpg";
                ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg };
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(dlg.FileName, ff[dlg.FilterIndex - 1]);
                    this.Text = dlg.FileName;
                    hasChanged = false;
                    newDoc = false;
                }
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                string filepath = dlg.FileName;
                Bitmap tbmp = bmp;
                hasChanged = false;
                Close();
                tbmp.Save(filepath);
                newDoc = false;
            }
        }
        public void Save()
        {
            if (newDoc == true)
            {
                SaveAs();
            }
            
            else if (newDoc == false)
            {
                bmp.Save(filename);
                hasChanged = false;
                notEnableSaving();
            }
            else if (hasChanged == true)
            {
                bmp.Save(this.Text);
                hasChanged = false;
                notEnableSaving();
            }
            
        }
        public void EnableSaving()
        {
            MainForm parent = (MainForm)ParentForm;
            parent.EnableSaving();
            hasChanged = true;
        }
        public void EnableSavingAs()
        {
            MainForm parent = (MainForm)ParentForm;
            parent.EnableSavingAs();
            hasChanged = true;
        }
        public void notEnableSaving()
        {
            MainForm parent = (MainForm)ParentForm;
            parent.notEnableSaving();
            hasChanged = false;
        }
        public void notEnableSavingAs()
        {
            MainForm parent = (MainForm)ParentForm;
            parent.notEnableSavingAs();
        }


        private void CanvasForm_Load(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)ParentForm;
            parent.EnableSavingAs();
            parent.notEnableSaving();
        }
        private void CanvasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (hasChanged == true)
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                result = MessageBox.Show($"Вы хотите сохранить изменения в файле {this.Text}?", "", buttons);

                if (result == DialogResult.Yes)
                {
                    Save();
                   
                    if (hasChanged == true)
                        e.Cancel = true;
                }

                else if (result == DialogResult.No)
                { 
                    e.Cancel = false;
                }

                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
                
            }
            
        }
        #endregion


        #region рисование
        private PointF[] starPoints;
        private PointF[] starPointsFunc()
        {
            int n = MainForm.star_N;                         // число вершин
            double r = Math.Abs(from.X - to.X), R = r / 2;   // радиусы
            double alpha = 0;                                // поворот
            if (n == 5)
            {
                alpha = 0.94;
            }
            double x0 = (from.X + to.X) / 2, y0 = (from.Y + to.Y) / 2; // центр

            starPoints = new PointF[2 * n + 1];
            double a = alpha;
            double da = Math.PI / n;
            double l;

            for (int k = 0; k < 2 * n + 1; k++)
            {
                l = k % 2 == 0 ? r : R;
                starPoints[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                a += da;
            }
            return starPoints;
        }

        private int count = 0;
        public int currScale = 100;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                if (MainForm.instrument == "pen")
                {
                   // pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    Graphics g = Graphics.FromImage(bmp);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(new Pen(MainForm.CurrentColor, MainForm.CurWidth), from, e.Location);
                    from = e.Location;
                }
                if (MainForm.instrument == "rubber")
                {
                    Graphics g = Graphics.FromImage(bmp);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(new Pen(Color.White, MainForm.CurWidth), from, e.Location);
                    from = e.Location;
                }
            }

            to = e.Location;
            MainForm parent = (MainForm)ParentForm;
            parent.SetStatusText($"X: {e.X} Y: {e.Y}");
            

            pictureBox1.Invalidate();
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);

            clicked = false;
            to = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                //pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                switch (MainForm.instrument)
                {
                    case "line":
                        
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.DrawLine(new Pen(MainForm.CurrentColor, MainForm.CurWidth), from, to);
                        break;

                    case "circle":
                        
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.DrawEllipse(new Pen(MainForm.CurrentColor, MainForm.CurWidth), from.X, from.Y, to.X - from.X, to.Y - from.Y);
                        break;

                    case "star":
                     
                        starPointsFunc();
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.DrawLines(new Pen(MainForm.CurrentColor, MainForm.CurWidth), starPoints);
                        break;
                }
                EnableSaving();
            }

            pictureBox1.Invalidate();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm parent = (MainForm)ParentForm;
            int sizeAdd = 100;
            
            if (e.Button == MouseButtons.Left)
            {
                from = e.Location;
                clicked = true;
                
                switch (MainForm.instrument)
                {
                    case "scale+":

                       // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (currScale < 200)
                        {
                            pictureBox1.Height += (int)Math.Round(pictureBox1.Height * 0.25);
                            pictureBox1.Width += (int)Math.Round(pictureBox1.Width * 0.25);
                            
                            currScale += 25;
                            count++;
                            parent.SetScaleText($"{currScale}");
                        }
                        else
                        {
                            pictureBox1.Height = height;
                            pictureBox1.Width = width;
                            currScale = 100;
                            count = 0;
                            parent.SetScaleText($"{currScale}");
                        }
                        pictureBox1.BringToFront();
                        break;

                    case "scale-":
                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (currScale > 50)
                        {
                            pictureBox1.Height -= (int)Math.Round(pictureBox1.Height * 0.25);
                            pictureBox1.Width -= (int)Math.Round(pictureBox1.Width * 0.25);
                            currScale -= 25;
                            count--;
                            parent.SetScaleText($"{currScale}");

                        }
                        else
                        {
                            pictureBox1.Height = height;
                            pictureBox1.Width = width;
                            count = 0;
                            currScale = 100;
                            parent.SetScaleText($"{currScale}");
                        }
                        pictureBox1.BringToFront();
                        break;
                }
                //pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
        public void NormalScale()
        {
            MainForm parent = (MainForm)ParentForm;
            pictureBox1.Height = height;
            pictureBox1.Width = width;
            count = 0;
            currScale = 100;
            parent.SetScaleText($"{currScale}");
            pictureBox1.BringToFront();
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)ParentForm;
            parent.SetStatusText(string.Empty);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (MainForm.instrument)
            {
                case "line":
                    if (clicked == true)
                        e.Graphics.DrawLine(new Pen(MainForm.CurrentColor, MainForm.CurWidth), from, to);
                    break;

                case "circle":
                    if (clicked == true)
                        g.DrawEllipse(new Pen(MainForm.CurrentColor, MainForm.CurWidth), from.X, from.Y, to.X - from.X, to.Y - from.Y);
                    break;

                case "star":
                    if (clicked == true)
                    {
                        starPointsFunc();
                        g.DrawLines(new Pen(MainForm.CurrentColor, MainForm.CurWidth), starPoints);
                    }
                    break;
            }

        }
        #endregion


        public void ChangeImage(IPlugin plugin)
        {
            var m = plugin.GetType().GetMethod("Transform");
            m.Invoke(plugin, new object[] { (Bitmap)pictureBox1.Image });
            hasChanged = true;
            EnableSaving();
            EnableSavingAs();
            //plugin.Transform((Bitmap)pictureBox1.Image);
            pictureBox1.Refresh();
        }

        private void CanvasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm parent = (MainForm)ParentForm;
            parent.NoOpenCanvas();
        }
    }
}