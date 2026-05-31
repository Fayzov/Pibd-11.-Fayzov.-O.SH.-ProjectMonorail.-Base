using System;
using System.Drawing;
using System.Windows.Forms;
using OOP_Monorails_Base.Drawnings;
using OOP_Monorails_Base.MovementStrategy;

namespace OOP_Monorails_Base
{
    public partial class FormMonorail : Form
    {
        // Полотно для управления объектом и границами
        private readonly CanvasForMonorail _canvas;

        // Поле для выбранной стратегии перемещения
        private BaseTemplateMovement? _templateMovement;


        // ВОТ ЭТА СТРОКА ДОЛЖНА БЫТЬ ТУТ:
        private DirectionType _checkBordersState = DirectionType.None;

        public FormMonorail()
        {
            InitializeComponent();
            // Лабораторная 2: инициализация через конструктор с размерами PictureBox [16, 17]
            _canvas = new CanvasForMonorail(pictureBoxMonorail.Width, pictureBoxMonorail.Height);
        }

        private void Draw() => pictureBoxMonorail.Image = _canvas.DrawCanvas();

        // Обработчики создания объектов [8]
        private void buttonCreateSimple_Click(object sender, EventArgs e) => CreateObject(nameof(DrawingMonorail));

        private void buttonCreateAdvanced_Click(object sender, EventArgs e) => CreateObject(nameof(DrawingAdvancedMonorail));

        // Метод для принятия объекта из другой формы
        public void SetDrawingMonorail(DrawingMonorail monorail)
        {
            // Пытаемся вставить переданный объект на полотно
            if (_canvas.InsertMonorail(monorail))
            {
                Random random = new();
                // Ставим его в случайное место
                _canvas.SetMonorailPosition(random.Next(10, 100), random.Next(10, 100));
                // Разблокируем выбор цели, как при обычном создании
                comboBoxDestination.Enabled = true;
                Draw();
            }
        }

        private void CreateObject(string type)
        {
            Random random = new();
            DrawingMonorail? monorail = null;

            if (type == nameof(DrawingMonorail))
            {
                monorail = new DrawingMonorail(random.Next(100, 300), random.Next(1000, 3000),
                    Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            }
            else if (type == nameof(DrawingAdvancedMonorail))
            {
                // Вариант 28: Продвинутый монорельс с платформами и линиями [1, 15]
                monorail = new DrawingAdvancedMonorail(random.Next(100, 300), random.Next(1000, 3000),
                    Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)), // Основной
                    Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)), // Дополнительный
                    true, true); // Включаем детали
            }

            if (monorail != null && _canvas.InsertMonorail(monorail))
            {
                _canvas.SetMonorailPosition(random.Next(10, 100), random.Next(10, 100));
                comboBoxDestination.Enabled = true;
                Draw();
            }
        }

        // Выбор стратегии движения в выпадающем списке [10, 15]
        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_canvas.DrawingMonorail == null) return;

            _templateMovement = comboBoxDestination.SelectedIndex switch
            {
                0 => new MoveToCenter(),           // Стратегия "В центр"
                1 => new MoveToRightDownBorder(),  // Стратегия "В угол"
                _ => null
            };

            if (_templateMovement != null)
            {
                // Привязка объекта к стратегии через Адаптер [14, 15]
                _templateMovement.SetData(new MoveableAdapterMonorail(_canvas.DrawingMonorail),
                    _canvas.Width, _canvas.Height);
            }
        }

        // Кнопка "Шаг" для пошагового выполнения стратегии [11, 15]
        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (_templateMovement == null) return;

            _templateMovement.MakeStep(); // Шаблонный метод шага

            if (_templateMovement.IsFinishReached)
            {
                MessageBox.Show("Цель достигнута!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxDestination.SelectedIndex = -1;
            }

            Draw();
        }

        // Ручное управление (стрелочки)
        private void btnMove_Click(object sender, EventArgs e)
        {
            var monorail = _canvas.DrawingMonorail;
            if (monorail == null) return;

            string name = ((Button)sender).Name;
            switch (name)
            {
                case "btnArrowUp": monorail.MoveUp(); break;
                case "btnArrowDown": monorail.MoveDown(); break;
                case "btnArrowLeft": monorail.MoveLeft(); break;
                case "btnArrowRight": monorail.MoveRight(); break;
            }
            Draw();
        }

        private void ButtonCheckBorders_Click(object sender, EventArgs e)
        {
            Random random = new();
            // Мы пытаемся поставить объект далеко за границы (например, -1000)
            // Но умное Полотно из Лабы №2 должно само скорректировать координаты [6, 9]
            switch (_checkBordersState)
            {
                case DirectionType.None:
                case DirectionType.Down:
                    _canvas.SetMonorailPosition(-1000, random.Next(10, 100));
                    _checkBordersState = DirectionType.Left;
                    break;
                case DirectionType.Left:
                    _canvas.SetMonorailPosition(random.Next(10, 100), -1000);
                    _checkBordersState = DirectionType.Up;
                    break;
                case DirectionType.Up:
                    _canvas.SetMonorailPosition(pictureBoxMonorail.Width + 1000, random.Next(10, 100));
                    _checkBordersState = DirectionType.Right;
                    break;
                case DirectionType.Right:
                    _canvas.SetMonorailPosition(random.Next(10, 100), pictureBoxMonorail.Height + 1000);
                    _checkBordersState = DirectionType.Down;
                    break;
            }
            Draw();
        }

        private void FormMonorail_Load(object sender, EventArgs e)
        {

        }

      
    }
}
