using System.Drawing;
using OOP_Monorails_Base.Entities;

namespace OOP_Monorails_Base.Drawnings
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение обычного монорельса
    /// </summary>
    public class DrawingMonorail
    {
        // Поля доступны наследникам (protected)
        protected EntityMonorail? _entityMonorail;
        protected int? _startPosX;
        protected int? _startPosY;

        // Размеры прорисовки
        protected int _drawningWidth = 150;
        protected int _drawningHeight = 60;

        /// <summary>
        /// Конструктор для инициализации координат
        /// </summary>
        private DrawingMonorail()
        {
            _startPosX = null;
            _startPosY = null;
        }

        /// <summary>
        /// Конструктор для создания обычного монорельса
        /// </summary>
        public DrawingMonorail(int speed, double weight, Color bodyColor) : this()
        {
            _entityMonorail = new EntityMonorail(speed, weight, bodyColor);
        }

        /// <summary>
        /// Конструктор для изменения размеров (доступен только наследникам)
        /// </summary>
        protected DrawingMonorail(int width, int height) : this()
        {
            _drawningWidth = width;
            _drawningHeight = height;
        }

        public void SetPosition(int x, int y)
        {
            _startPosX = x;
            _startPosY = y;
        }

        /// <summary>
        /// Установка позиции с проверкой границ 
        /// </summary>
        /// <param name="x">Желаемая координата X</param>
        /// <param name="y">Желаемая координата Y</param>
        /// <param name="width">Ширина полотна (границы)</param>
        /// <param name="height">Высота полотна (границы)</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            // Проверка, чтобы объект не ушел за левую и верхнюю границы
            int posX = x < 0 ? 0 : x;
            int posY = y < 0 ? 0 : y;

            // Проверка правой и нижней границ с использованием твоих полей _drawningWidth и _drawningHeight
            _startPosX = posX + _drawningWidth > width ? width - _drawningWidth : posX;
            _startPosY = posY + _drawningHeight > height ? height - _drawningHeight : posY;
        }

        // Метод изменения цвета через сущность
        public void SetBodyColor(Color color)
        {
            _entityMonorail?.SetBodyColor(color);
        }

        /// <summary>
        /// Прорисовка монорельса (виртуальный метод)
        /// </summary>
        public virtual void DrawTransport(Graphics g)
        {
            if (_entityMonorail is null || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }

            int x = _startPosX.Value;
            int y = _startPosY.Value;

            // Настройки цветов и перьев
            Color bodyColor = _entityMonorail.BodyColor; // Используем цвет из сущности
            Brush bodyBrush = new SolidBrush(bodyColor);
            Brush bodyBlackBrush = new SolidBrush(Color.Black);

            Brush windowBrush = new SolidBrush(Color.LightSkyBlue);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen WindowPen = new Pen(Color.LightSkyBlue, 2);



            // Основной корпус (нижняя часть)
            g.FillRectangle(bodyBrush, x + 8, y + 22, 132, 21);
            g.DrawRectangle(blackPen, x + 8, y + 22, 132, 21);
            // самый правый часть
            g.FillRectangle(bodyBlackBrush, x + 141, y + 5, 5, 34);


            // Верхняя часть (кабина со скосом слева)
            Point[] upperBodyPoints = {
                new Point(x+15, y),       // Верхний левый угол
                new Point(x + 140, y),      // Верхний правый угол
                new Point(x + 140, y + 22), // Нижний правый (стык)
                new Point(x+8, y + 22)        // Нижний левый (начало скоса)
            };
            g.FillPolygon(bodyBrush, upperBodyPoints);
            g.DrawPolygon(blackPen, upperBodyPoints);

            // Дверь (посередине)
            g.DrawRectangle(blackPen, x + 53, y + 9, 12, 28);

            // Окна (голубые)
            // Два окна слева от двери
            g.DrawRectangle(WindowPen, x + 20, y + 5, 10, 13);

            g.DrawRectangle(WindowPen, x + 36, y + 5, 10, 13);

            // Одно окно справа
            g.DrawRectangle(WindowPen, x + 127, y + 5, 10, 13);

            //чёрные нижние вставка левая часть
            Point[] downnLeftBlackThing = {
                new Point(x+10, y+44),       // левый верхний угол
                new Point(x + 58, y+44),      // Верхний правый угол
                new Point(x + 54, y+50),      // Нижний правый угол
                new Point(x, y + 50)        // самая левая точка
            };
            g.FillPolygon(bodyBlackBrush, downnLeftBlackThing);
            g.DrawPolygon(blackPen, downnLeftBlackThing);

            //чёрные нижние вставка правая часть
            Point[] downnRightBlackThing = {
                new Point(x+88, y+44),
                new Point(x + 138, y+44),
                new Point(x + 148, y+50),
                new Point(x + 88, y + 50)
            };
            g.FillPolygon(bodyBlackBrush, downnRightBlackThing);
            g.DrawPolygon(blackPen, downnRightBlackThing);

            // 5. Колеса (белые круги)
            Brush wheelBrush = Brushes.White;
            g.FillEllipse(wheelBrush, x + 20, y + 44, 15, 15);
            g.DrawEllipse(blackPen, x + 20, y + 44, 15, 15);

            g.FillEllipse(wheelBrush, x + 47, y + 44, 15, 15);
            g.DrawEllipse(blackPen, x + 47, y + 44, 15, 15);

            g.FillEllipse(wheelBrush, x + 83, y + 44, 15, 15);
            g.DrawEllipse(blackPen, x + 83, y + 44, 15, 15);

            g.FillEllipse(wheelBrush, x + 110, y + 44, 15, 15);
            g.DrawEllipse(blackPen, x + 110, y + 44, 15, 15);

            // Очистка ресурсов
            bodyBrush.Dispose();
            windowBrush.Dispose();
            blackPen.Dispose();
        }

        // Свойства для получения данных
        public int? PosX => _startPosX;
        public int? PosY => _startPosY;
        public double? Step => _entityMonorail?.Step;
        public int DrawingWidth => _drawningWidth;
        public int DrawingHeight => _drawningHeight;

        // Методы перемещения
        public void MoveLeft() => _startPosX -= (int)(_entityMonorail?.Step ?? 0);
        public void MoveRight() => _startPosX += (int)(_entityMonorail?.Step ?? 0);
        public void MoveUp() => _startPosY -= (int)(_entityMonorail?.Step ?? 0);
        public void MoveDown() => _startPosY += (int)(_entityMonorail?.Step ?? 0);
    }
}