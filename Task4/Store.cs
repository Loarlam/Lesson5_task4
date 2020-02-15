using System;

namespace Task4
{
    class Store
    {
        Article _articles;
        readonly string _selectionFromCatalog;

        public Store(string selectionFromCatalog)
        {
            _selectionFromCatalog = selectionFromCatalog;
        }

        public void UstanovkaAndVivodNaEkran()
        {
            _articles = new Article("Стол", "Телевизор", "Монитор", "Marble", "Islor", "Krostler");

            switch (_selectionFromCatalog)
            {
                case "Стол":
                case "1914":
                    Console.WriteLine($"Ваш {_articles["Стол"]}");
                    break;
                case "Телевизор":
                case "1517":
                    Console.WriteLine($"Ваш {_articles["Телевизор"]}");
                    break;
                case "Монитор":
                case "1433":
                    Console.WriteLine($"Ваш {_articles["Монитор"]}");
                    break;
                default:
                    Console.WriteLine($"{_articles[_selectionFromCatalog]}");
                    break;
            }
        }
    }
}
