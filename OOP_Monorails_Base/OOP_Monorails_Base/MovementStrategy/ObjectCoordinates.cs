using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Класс для хранения и расчета координат и границ объекта
    /// </summary>
    public class ObjectCoordinates
    {
        // Поля только для чтения (задаются один раз в конструкторе)
        private readonly int _x;
        private readonly int _y;
        private readonly int _width;
        private readonly int _height;

        /// <summary>
        /// Левая граница объекта
        /// </summary>
        public int LeftBorder => _x;

        /// <summary>
        /// Верхняя граница объекта
        /// </summary>
        public int TopBorder => _y;

        /// <summary>
        /// Правая граница объекта
        /// </summary>
        public int RightBorder => _x + _width;

        /// <summary>
        /// Нижняя граница объекта
        /// </summary>
        public int DownBorder => _y + _height;

        /// <summary>
        /// Горизонтальный центр объекта
        /// </summary>
        public int ObjectMiddleHorizontal => _x + _width / 2;

        /// <summary>
        /// Вертикальный центр объекта
        /// </summary>
        public int ObjectMiddleVertical => _y + _height / 2;

        /// <summary>
        /// Конструктор координат
        /// </summary>
        public ObjectCoordinates(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
    }
}
