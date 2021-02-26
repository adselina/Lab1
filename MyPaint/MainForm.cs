using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaginInterface;

namespace MyPaint
{

    public partial class MainForm : Form
    {
        public static Color CurrentColor { get; set; }
        
        public static int CurWidth = 3;
        public static int star_N = 4;
        public static CanvasForm activeForm = null;
        public static string instrument = "pen";
        private string message = "";
        private bool message_shown = false;


        public MainForm()
        {
            InitializeComponent();
            CurrentColor = Color.Black;
            curColorLabel.Text = null;
            toolStripStatusLabel1.Text = null;
            toolStripScale.Text = null;
            сохранитьToolStripMenuItem.Enabled = false;
            сохранитьКакToolStripMenuItem.Enabled = false;
            размерХолстаToolStripMenuItem.Enabled = false;

            //-------
            //FindPlugins();
            ExistFilters();
            CreateMenu();
        }

        private int doumentCounter = 1;
        //новый документ
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanvasForm d = new CanvasForm();
            d.Text = $"Документ {doumentCounter++}";
            d.MdiParent = this;
            d.Show();
            curColorLabel.BackColor = CurrentColor;
            фильтрыToolStripMenuItem.Enabled = true;
            enableFilters();
            
        }

        

        #region расположение окон
        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new AboutBox1();
            f.ShowDialog();
        }
        private void сверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void упорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion

        public void SetStatusText(string text)
        {
            toolStripStatusLabel1.Text = text;
        }
        public void SetScaleText(string text)
        {
            toolStripScale.Text = $"Масштаб:{text} %";
        }
        

        #region Выбор цвета
        private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
            curColorLabel.BackColor = CurrentColor;
        }
        private void зеленыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
            curColorLabel.BackColor = CurrentColor;
        }
        private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
            curColorLabel.BackColor = CurrentColor;
        }
        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();

            if (d.ShowDialog() == DialogResult.OK)
                CurrentColor = d.Color;
            curColorLabel.BackColor = CurrentColor;

        }
        #endregion


        //изменение размера холста
        private void размерХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = (CanvasForm)ActiveMdiChild;
            CanvasSizeForm d = new CanvasSizeForm();
            d.Show();
        }
        
        //блокировка изменения холста
        private void рисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            размерХолстаToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        //изменение толщины кисти
        private void brashSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurWidth = int.Parse(brashSize.Text);
            }
            catch
            {
                MessageBox.Show("Значение должно быть целым числом.",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        #region сохранить/закрыть

        public void notEnableSavingAs()
        {
            сохранитьКакToolStripMenuItem.Enabled = false;
        }
        public void notEnableSaving()
        {
            сохранитьToolStripMenuItem.Enabled = false;
        }
        public void EnableSaving()
        {
            сохранитьToolStripMenuItem.Enabled = true;
        }
        public void EnableSavingAs()
        {
            сохранитьКакToolStripMenuItem.Enabled = true;
        }

        
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = (CanvasForm)ActiveMdiChild;
            activeForm.SaveAs();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg|Все файлы ()*.*|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CanvasForm frmChild = new CanvasForm(dlg.FileName);
                
                frmChild.Text = Path.GetFileNameWithoutExtension(dlg.FileName);
                frmChild.MdiParent = this;
                frmChild.Show();

                enableFilters();
                EnableSavingAs();
                curColorLabel.BackColor = CurrentColor;
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = (CanvasForm)ActiveMdiChild;
            activeForm.Save();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }
        #endregion

        
        #region instruments
        private void CheckedButton(ToolStripButton button)
        {
            foreach (var item in toolStrip1.Items)
            {
                Type k = item.GetType();
                if (k.Name == "ToolStripButton")
                {
                    ((ToolStripButton)item).Checked = false;
                }
            }
            if (button.Checked == true)
            {
                button.Checked = false;
            }
            else
            {
                button.Checked = true;
            }
            if (scaleMinusButton.Checked == false && scalePlusButton.Checked == false)
            {
                CanvasForm child = (CanvasForm)ActiveMdiChild;
                child.NormalScale();
            }
        }
        
        private void lineButton_Click(object sender, EventArgs e)
        {
            instrument = "line";
            CheckedButton(lineButton);
            
        }
        private void circleButton_Click(object sender, EventArgs e)
        {
            instrument = "circle";
            CheckedButton(circleButton);
            
        }
        private void starButton_Click(object sender, EventArgs e)
        {
            instrument = "star";
            CheckedButton(starButton);
            

        }
        private void penButton_Click(object sender, EventArgs e)
        {
            instrument = "pen";
            CheckedButton(penButton);
            
        }
        private void Nstar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                star_N = int.Parse(Nstar.Text);  
            }
            catch
            {
                MessageBox.Show("Значение должно быть целым числом.",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void scalePlusButton_Click(object sender, EventArgs e)
        {
            instrument = "scale+";
            CheckedButton(scalePlusButton);
            
          
        }
        private void scaleMinusButton_Click(object sender, EventArgs e)
        {
            instrument = "scale-";
            CheckedButton(scaleMinusButton);
            
        }
        private void rubberButton_Click(object sender, EventArgs e)
        {
            CheckedButton(rubberButton);
            instrument = "rubber";
            
        }

        #endregion

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
                if (((CanvasForm)this.ActiveMdiChild).hasChanged == true)
                
                    EnableSaving();  
        }
        public bool NoOpenCanvas() 
        {
            if (this.MdiChildren.Length == 1)
            {
                notEnableFilters();
                
                //окноToolStripMenuItem.Enabled = false;
                сохранитьToolStripMenuItem.Enabled = false;
                сохранитьКакToolStripMenuItem.Enabled = false;
                return true;
            }
            return false;

        }

        //--------PLUGINS---------


        public Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();
        void FindPlugins()
        {
            // папка с плагинами
            string folder = System.AppDomain.CurrentDomain.BaseDirectory;
            
            // dll-файлы в этой папке
            string[] files = Directory.GetFiles(folder, "*.dll");
            string added_plugins = "Загружены следующие фильтры:\n";
            foreach (string file in files)
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);
                    
                    foreach (Type type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("PlaginInterface.IPlugin");

                        if (iface != null)
                        {
                            AssemblyName assemName = assembly.GetName();
                            IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                            added_plugins += $"{plugin.Name},   Разработчик: {plugin.Author},   Версия: {assemName.Version.Major}.{assemName.Version.Minor}\n";

                            plugins.Add(plugin.Name, plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }
            message = added_plugins;
        }
        private void CreateMenu()
        {
            foreach(IPlugin plugin in plugins.Values)
            {
                var i = new ToolStripMenuItem(plugin.Name);
                i.Click += OnPluginClick;
                фильтрыToolStripMenuItem.DropDownItems.Add(i);
                
            }
            notEnableFilters();
        }
        private void OnPluginClick(object sender, EventArgs args)
        {
            IPlugin plugin = plugins[((ToolStripMenuItem)sender).Text];
            CanvasForm activeChildForm = (CanvasForm)ActiveMdiChild;
            activeChildForm.ChangeImage(plugin);
        }

        private void фильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (message_shown == false)
            { 
                MessageBox.Show(message);
                message_shown = true;
            }
            if (NoOpenCanvas())
            {
                enableFilters();
            }
        }
        private void enableFilters()
        {
            foreach (var item in окноToolStripMenuItem.DropDownItems)
            {
                ToolStripItem temp = (ToolStripItem)item;
                temp.Enabled = true;
            }
            foreach (var item in фильтрыToolStripMenuItem.DropDownItems)
            {
                ToolStripItem temp = (ToolStripItem)item;
                temp.Enabled = true;
            }
        }
        private void notEnableFilters()
        {
            foreach (var item in окноToolStripMenuItem.DropDownItems)
            {
                ToolStripItem temp = (ToolStripItem)item;
                temp.Enabled = false;
            }
            foreach (var item in фильтрыToolStripMenuItem.DropDownItems)
            {
                ToolStripItem temp = (ToolStripItem)item;
                temp.Enabled = false;
            }
        }

        private void ExistFilters()
        {
            if (ConfigurationManager.AppSettings.Get("automode") == "Auto") { FindPlugins(); return; }
            if (ConfigurationManager.AppSettings.Count == 1) { FindPlugins(); return; }

            List<string> pluginsLoad = new List<string>();
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                if (key == "auto") continue;
                pluginsLoad.Add(ConfigurationManager.AppSettings.Get(key));
            }
            FindPlugins(pluginsLoad);
        }
        void FindPlugins(List<string> pluginsLoad)
        {
            // папка с плагинами
            string folder = System.AppDomain.CurrentDomain.BaseDirectory;
                                 
            string added_plugins = "Загружены следующие фильтры:\n";
            foreach (string filename in pluginsLoad)
            {
                string[] files = Directory.GetFiles(folder, filename);
                foreach (string file in files)
                    try
                    {
                        Assembly assembly = Assembly.LoadFile(file);

                        foreach (Type type in assembly.GetTypes())
                        {
                            Type iface = type.GetInterface("PlaginInterface.IPlugin");

                            if (iface != null)
                            {
                                AssemblyName assemName = assembly.GetName();
                                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                                added_plugins += $"{plugin.Name},   Разработчик: {plugin.Author},   Версия: {assemName.Version.Major}.{assemName.Version.Minor}\n";

                                plugins.Add(plugin.Name, plugin);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                    }
            }
            message = added_plugins;
        }

    }
}
