using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OOP_Monorails_Base.Drawnings;

namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Реализация интерфейса IMoveableObject с адаптацией под DrawingMonorail
    /// </summary>
    public class MoveableAdapterMonorail : IMoveableObject
    {
        /// <summary>
        /// Поле-объект класса прорисовки монорельса
        /// </summary>
        private readonly DrawingMonorail _monorail;

        /// <summary>
        /// Конструктор адаптера
        /// </summary>
        /// <param name="monorail">Объект монорельса</param>
        public MoveableAdapterMonorail(DrawingMonorail monorail)
        {
            _monorail = monorail;
        }

        /// <summary>
        /// Получение текущих координат и границ монорельса
        /// </summary>
        public ObjectCoordinates? ObjectCoordinates
        {
            get
            {
                if (_monorail == null || !_monorail.PosX.HasValue || !_monorail.PosY.HasValue)
                {
                    return null;
                }
                // Создаем объект координат, используя данные из класса прорисовки
                return new ObjectCoordinates(_monorail.PosX.Value, _monorail.PosY.Value,
                    _monorail.DrawingWidth, _monorail.DrawingHeight);
            }
        }

        /// <summary>
        /// Шаг перемещения монорельса
        /// </summary>
        public int ObjectStep => (int)(_monorail?.Step ?? 0);

        /// <summary>
        /// Передача команды на перемещение в объект прорисовки
        /// </summary>
        public void MoveObject(MovementDirection direction)
        {
            switch (direction)
            {
                case MovementDirection.Left:
                    _monorail?.MoveLeft();
                    break;
                case MovementDirection.Up:
                    _monorail?.MoveUp();
                    break;
                case MovementDirection.Right:
                    _monorail?.MoveRight();
                    break;
                case MovementDirection.Down:
                    _monorail?.MoveDown();
                    break;
            }
        }

        /// <summary>
        /// Установка позиции монорельса
        /// </summary>
        public void SetObjectPosition(int x, int y) => _monorail?.SetPosition(x, y);

        /// <summary>
        /// Вызов отрисовки монорельса
        /// </summary>
        public void DrawObject(Graphics graphics) => _monorail?.DrawTransport(graphics);
    }
}
