using CardsMark3.Rename;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsMark3
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }
        private void panel_Click(object sender, EventArgs e)
        {
            #region --Modificators for btn--
            int buttonCount = panel.Controls.OfType<Button>().Count();
            Button btn = new Button
            {
                Location = new Point(10, 110 * buttonCount),

                Text = $"{buttonCount + 1}",
                Size = new Size(340, 100),
                Tag = buttonCount + 1
            };
            #endregion
            Helper.Hide();
            panel.Controls.Add(btn);
            btn.MouseUp += new MouseEventHandler(btn_MouseUp);
        }
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Создание контекстного меню
                ContextMenu contextMenu = new ContextMenu();
                MenuItem deleteItem = new MenuItem("Delete", new EventHandler(Delete));
                deleteItem.Tag = sender; // Сохранение ссылки на кнопку
                contextMenu.MenuItems.Add(deleteItem);
                MenuItem Rename = new MenuItem("rename", new EventHandler(Renamer));
                Rename.Tag = sender;
                contextMenu.MenuItems.Add(Rename);

                // Отображение контекстного меню
                contextMenu.Show((Button)sender, new System.Drawing.Point(e.X, e.Y));
            }
        }
        private void Delete(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                Button btn = menuItem.Tag as Button;
                if (btn != null)
                {
                    Controls.Remove(btn);
                    btn.Dispose();
                }
            }
        }
        private void Renamer(object sender, EventArgs e)
        {
            Form2 Rename = new Form2();
            Rename.ShowDialog();

            string nameToChange = publicComponents.Name;
            MenuItem menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                Button btn = menuItem.Tag as Button;
                if (btn != null)
                {
                    btn.Text = nameToChange;
                }
            }
        }
    }
    public class publicComponents
    {
        public static string Name {  get; set; }
    }
}
