using System;
using System.Drawing;
using System.Windows.Forms;
using OOP_Monorails_Base.Drawnings;

namespace OOP_Monorails_Base
{
    public partial class FormMonorailConfig : Form
    {
        private DrawingMonorail? _monorail = null;

        // Встроенный делегат для передачи объекта (Лаба 5)
        private Action<DrawingMonorail>? _eventAddMonorail;

        public FormMonorailConfig()
        {
            InitializeComponent();
            // Обработка кнопки Отмена через лямбда-выражение
            buttonCancel.Click += (sender, e) => Close();
        }

        // Метод привязки события (Лаба 5)
        public void AddEvent(Action<DrawingMonorail> ev) => _eventAddMonorail += ev;

        private void Draw()
        {
            Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
            using Graphics gr = Graphics.FromImage(bmp);
            _monorail?.SetPosition(30, 30, pictureBoxObject.Width, pictureBoxObject.Height);
            _monorail?.DrawTransport(gr);
            pictureBoxObject.Image = bmp;
        }

        // Начало Drag&Drop для типов
        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Control control)
            {
                control.DoDragDrop(control.Name, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }

        // Начало Drag&Drop для цветов
        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.DoDragDrop(panel.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }

        private void PanelObject_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что перетаскивают либо строку (тип), либо цвет
            if (e.Data!.GetDataPresent(typeof(string)) || e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PanelObject_DragDrop(object sender, DragEventArgs e)
        {
            // Получаем координаты броска относительно панели
            Point pt = panelTarget.PointToClient(new Point(e.X, e.Y));

            // Логика создания объекта (перетащили строку с именем Label)
            if (e.Data!.GetDataPresent(typeof(string)))
            {
                string name = e.Data.GetData(typeof(string))!.ToString()!;
                if (name == "labelSimple")
                {
                    _monorail = new DrawingMonorail((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value, Color.White);
                }
                else if (name == "labelAdvanced")
                {
                    _monorail = new DrawingAdvancedMonorail((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value,
                        Color.White, Color.Black, checkBoxPlatform.Checked, checkBoxLines.Checked);
                }
            }
            // Логика покраски (перетащили цвет)
            else if (e.Data.GetDataPresent(typeof(Color)) && _monorail != null)
            {
                Color color = (Color)e.Data.GetData(typeof(Color))!;

                // Если бросили в область первого лейбла - основной цвет
                if (labelBaseColor.Bounds.Contains(pt))
                {
                    _monorail.SetBodyColor(color);
                }
                // Если во второй и это продвинутый объект - дополнительный цвет
                else if (labelSecondaryColor.Bounds.Contains(pt) && _monorail is DrawingAdvancedMonorail adv)
                {
                    adv.SetSecondaryColor(color);
                }
            }
            Draw();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (_monorail != null)
            {
                _eventAddMonorail?.Invoke(_monorail);
                Close();
            }
            else
            {
                MessageBox.Show("Сначала соберите монорельс (перетащите тип и цвета)!", "Ошибка");
            }
        }

     
    }
}