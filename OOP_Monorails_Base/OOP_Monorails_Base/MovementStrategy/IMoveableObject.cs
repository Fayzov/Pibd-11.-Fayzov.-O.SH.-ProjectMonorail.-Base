using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Интерфейс для работы с перемещаемым объектом
    /// </summary>
    public interface IMoveableObject
    {
        /// <summary>
        /// Текущие координаты объекта
        /// </summary>
        ObjectCoordinates? ObjectCoordinates { get; }

        /// <summary>
        /// Шаг объекта (расстояние одного перемещения)
        /// </summary>
        int ObjectStep { get; }

        /// <summary>
        /// Установка позиции объекта
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        void SetObjectPosition(int x, int y);

        /// <summary>
        /// Перемещение объекта в указанном направлении
        /// </summary>
        /// <param name="direction">Направление</param>
        void MoveObject(MovementDirection direction);

        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        /// <param name="graphics">Инструмент для рисования</param>
        void DrawObject(Graphics graphics);
    }
}
