using System.Drawing;

namespace OOP_Monorails_Base.Entities
{
    /// <summary>
    /// Класс-сущность "Монорельс"
    /// </summary>
    public class EntityMonorail
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; init; }

        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; init; }

        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color BodyColor { get; private set; }

        /// <summary>
        /// Шаг перемещения монорельса
        /// </summary>
        public virtual double Step => (double)Speed * 100 / Weight;

        /// <summary>
        /// Конструктор для инициализации полей монорельса
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Цвет корпуса</param>
        public EntityMonorail(int speed, double weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
        }

        public void SetBodyColor(Color color)
        {
            BodyColor = color;
        }
    }
}
