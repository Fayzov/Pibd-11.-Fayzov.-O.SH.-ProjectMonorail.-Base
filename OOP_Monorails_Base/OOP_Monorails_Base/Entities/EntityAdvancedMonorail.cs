namespace OOP_Monorails_Base.Entities
{
    /// <summary>
    /// Класс-сущность "Продвинутый монорельс" (с доп. деталями)
    /// </summary>
    public class EntityAdvancedMonorail : EntityMonorail
    {
        /// <summary>
        /// Дополнительный цвет (для магнитной платформы и линий)
        /// </summary>
        public Color AdditionalColor { get; private set; }

        /// <summary>
        /// Признак наличия магнитной платформы
        /// </summary>
        public bool HasMagneticPlatform { get; init; }

        /// <summary>
        /// Признак наличия контактных линий
        /// </summary>
        public bool HasContactLines { get; init; }

        /// <summary>
        /// Конструктор для продвинутого монорельса
        /// </summary>
        public EntityAdvancedMonorail(int speed, double weight, Color bodyColor,
            Color additionalColor, bool magnetic, bool lines)
            : base(speed, weight, bodyColor) // Вызов конструктора базового класса
        {
            AdditionalColor = additionalColor;
            HasMagneticPlatform = magnetic;
            HasContactLines = lines;
        }

        public void SetSecondaryColor(Color color)
        {
            AdditionalColor = color;
        }

    }
}