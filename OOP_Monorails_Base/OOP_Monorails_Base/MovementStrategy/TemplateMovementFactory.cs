using System.Collections.Generic;

namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Фабрика по созданию (выдаче) экземпляров стратегий перемещения
    /// </summary>
    public static class TemplateMovementFactory
    {
        // Словарь для хранения готовых объектов стратегий (новое в Лабе 4)
        private static readonly Dictionary<string, BaseTemplateMovement> _templates = new()
        {
            { "К центру", new MoveToCenter() },
            { "В правый нижний угол", new MoveToRightDownBorder() }
        };

        /// <summary>
        /// Список доступных ключей для ComboBox
        /// </summary>
        public static string[] Values => new List<string>(_templates.Keys).ToArray();

        /// <summary>
        /// Получение экземпляра стратегии из словаря по ключу
        /// </summary>
        /// <param name="value">Название стратегии</param>
        /// <returns>Объект стратегии</returns>
        public static BaseTemplateMovement? CreateTemplateMovement(string value)
        {
            // Пытаемся найти уже готовую стратегию в словаре
            if (_templates.TryGetValue(value, out var template))
            {
                return template;
            }
            return null;
        }
    }
}