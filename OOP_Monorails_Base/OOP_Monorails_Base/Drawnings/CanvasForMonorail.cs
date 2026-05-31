using System.Drawing;

namespace OOP_Monorails_Base.Drawnings
{
    /// <summary>
    /// Класс-полотно для размещения и отрисовки монорельса
    /// </summary>
    public class CanvasForMonorail
    {
        private DrawingMonorail? _monorail;
        private int? _canvasWidth;
        private int? _canvasHeight;

        /// <summary>
        /// Конструктор (Лабораторная 2: заменяет SetPictureSize)
        /// </summary>
        public CanvasForMonorail(int width, int height)
        {
            _canvasWidth = width;
            _canvasHeight = height;
        }

        /// <summary>
        /// Свойство для доступа к текущему объекту (нужно для адаптера движения)
        /// </summary>
        public DrawingMonorail? DrawingMonorail => _monorail;

        /// <summary>
        /// Размещение объекта на полотне
        /// </summary>
        public bool InsertMonorail(DrawingMonorail monorail)
        {
            if (!_canvasWidth.HasValue || !_canvasHeight.HasValue) return false;

            // Проверка: поместится ли объект вообще в такие границы
            if (monorail.DrawingWidth > _canvasWidth || monorail.DrawingHeight > _canvasHeight)
            {
                return false;
            }

            _monorail = monorail;
            return true;
        }

        /// <summary>
        /// Установка позиции с проверкой границ
        /// </summary>
        public void SetMonorailPosition(int x, int y)
        {
            if (_monorail == null || !_canvasWidth.HasValue || !_canvasHeight.HasValue) return;

            // Если координаты выходят за рамки, прижимаем объект к краю
            int correctedX = x < 0 ? 0 : (x + _monorail.DrawingWidth > _canvasWidth ? _canvasWidth.Value - _monorail.DrawingWidth : x);
            int correctedY = y < 0 ? 0 : (y + _monorail.DrawingHeight > _canvasHeight ? _canvasHeight.Value - _monorail.DrawingHeight : y);

            _monorail.SetPosition(correctedX, correctedY);
        }

        /// <summary>
        /// Отрисовка полотна
        /// </summary>
        public Bitmap? DrawCanvas()
        {
            if (!_canvasWidth.HasValue || !_canvasHeight.HasValue) return null;

            Bitmap bmp = new Bitmap(_canvasWidth.Value, _canvasHeight.Value);
            Graphics g = Graphics.FromImage(bmp);
            _monorail?.DrawTransport(g);

            return bmp;
        }

        public int Width => _canvasWidth ?? 0;
        public int Height => _canvasHeight ?? 0;
    }
}
