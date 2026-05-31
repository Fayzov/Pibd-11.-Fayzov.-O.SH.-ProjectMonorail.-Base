using System.Collections.Generic;
using System.Linq;
using OOP_Monorails_Base.Drawnings;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Класс-хранилище для станций (компаний)
    /// </summary>
    public class StorageCompanies
    {
        // Словарь для хранения станций по их именам
        private readonly Dictionary<string, AbstractCompany> _companies;

        // Размеры области рисования (PictureBox)
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;

        public StorageCompanies(int pictureWidth, int pictureHeight)
        {
            _companies = new Dictionary<string, AbstractCompany>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        // Возвращаем список всех имен станций для отображения в списке на форме
        public List<string> StorageKeys => _companies.Keys.ToList();

        // Добавление новой станции в хранилище
        public void AddCompany(string name, CollectionType collectionType)
        {
            name = $"{collectionType}: {name}";
            if (_companies.ContainsKey(name)) return;
            ICollectionGenericObjects<DrawingMonorail> collection = collectionType switch
            {
                CollectionType.Massive => new MassiveGenericObjects<DrawingMonorail>(),
                CollectionType.List => new ListGenericObjects<DrawingMonorail>(),
                CollectionType.LinkedList => new LinkedListGenericObjects<DrawingMonorail>(),
                _ => new MassiveGenericObjects<DrawingMonorail>()
            };

            // Создаем станцию и добавляем в словарь
            var station = new MonorailStation(_pictureWidth, _pictureHeight, collection);
            _companies.Add(name, station);
        }

        // Удаление станции по имени
        public void DelCompany(string name)
        {
            if (_companies.ContainsKey(name))
            {
                _companies.Remove(name);
            }
        }

        // ИНДЕКСАТОР: позволяет писать storage[name] для получения станции
        public AbstractCompany? this[string name]
        {
            get
            {
                if (_companies.ContainsKey(name))
                {
                    return _companies[name];
                }
                return null;
            }
        }
    }
}
