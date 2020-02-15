﻿/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Article, содержащий следующие закрытые поля: 
• название товара; 
• название магазина, в котором продается товар; 
• стоимость товара в рублях. 
Создать класс Store, содержащий закрытый массив элементов типа Article.  
Обеспечить следующие возможности: 
• вывод информации о товаре по номеру с помощью индекса; 
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
Написать программу, вывода на экран информацию о товаре. 
*/
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store;
            Console.Write("В нашем каталоге имеются (предмет / индекс):\nСтол / 1914\nТелевизор / 1571\nМонитор / 1433\n\nНайдем магазин побизости, лишь введите название или индекс предмета = ");
            string result = Console.ReadLine();
            store = new Store(result);

            store.UstanovkaAndVivodNaEkran();
            Console.ReadKey();
        }
    }
}
