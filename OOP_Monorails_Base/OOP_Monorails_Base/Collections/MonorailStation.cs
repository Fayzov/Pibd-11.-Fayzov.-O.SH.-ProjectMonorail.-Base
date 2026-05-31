using System.Drawing;
using OOP_Monorails_Base.Drawnings;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Реализация компании - Станция монорельсов
    /// </summary>
    public class MonorailStation : AbstractCompany
    {
        // Конструктор: задаем размеры ячейки (например, 170x100, чтобы влез монорельс 155x90)
        public MonorailStation(int pictureWidth, int pictureHeight, ICollectionGenericObjects<DrawingMonorail> collection)
            : base(pictureWidth, pictureHeight, 170, 100, collection)
        {
        }

        // Рисуем сетку (границы ячеек)
        protected override void DrawBackground(Graphics g)
        {
            Pen pen = new(Color.Black, 3);
            // Рисуем вертикальные линии
            for (int i = 0; i <= _pictureWidth / _placeSizeWidth; i++)
            {
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, _pictureHeight);
            }
            // Рисуем горизонтальные линии (ячейки)
            for (int j = 0; j <= _pictureHeight / _placeSizeHeight; j++)
            {
                g.DrawLine(pen, 0, j * _placeSizeHeight, _pictureWidth, j * _placeSizeHeight);
            }
        }

        // Расставляем монорельсы из коллекции по ячейкам
    
        protected override void DrawObjects(Graphics g)
        {
            int maxCols = _pictureWidth / _placeSizeWidth;
            for (int i = 0; i < CalcMaxCount(); i++)
            {
                var monorail = _collection.GetObject(i);
                if (monorail != null)
                {
                    // Определяем номер строки и столбца
                    int row = i / maxCols;
                    int col = i % maxCols;

                    // Расчет координат для центрирования объекта в ячейке
                    // (Размер ячейки - Размер монорельса) / 2 дает нужный отступ
                    int x = col * _placeSizeWidth + (_placeSizeWidth - monorail.DrawingWidth) / 2;
                    int y = row * _placeSizeHeight + (_placeSizeHeight - monorail.DrawingHeight) / 2;

                    // Устанавливаем позицию и рисуем
                    monorail.SetPosition(x, y, _pictureWidth, _pictureHeight);
                    monorail.DrawTransport(g);
                }
            }
        }

        private int CalcMaxCount() => (_pictureWidth / _placeSizeWidth) * (_pictureHeight / _placeSizeHeight);
    }
}