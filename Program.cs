using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary.Add("Пакет", "Бумажный сверток, упаковка с чем-нибудь");
        dictionary.Add("Извечный", "С давних времен существующий");
        dictionary.Add("Издержки", "Израсходованная на что-н. сумма, затраты");
        dictionary.Add("Имя", "Личное название человека,даваемое при рождении, часто вообще личное название живого существа");
        dictionary.Add("Фаска", "Отточенная сторона лезвия, скошенный край картона, стекла");
        dictionary.Add("Форт", "Отдельное долговременное укрепление в системе крепостных сооружений");
        dictionary.Add("Казна", "Деньги, имущество, принадлежащие государству или общине, организации");
        dictionary.Add("Набросать", "Бросить куда-нибудь в каком-нибудь количестве, в несколько приемов");
        dictionary.Add("Счастье", "Чувство и состояние полного, высшего удовлетворения");

        AddDictionary(dictionary);

        FindWord(dictionary);
    }

    static void FindWord(Dictionary<string, string> dictionary)
    {
        bool isFindWord = false;

        while (isFindWord == false)
        {
            Console.Write("Введите слово, значение которого хотите найти: ");
            string userWord = Console.ReadLine();

            if (dictionary.ContainsKey(userWord))
            {
                Console.Write(dictionary[userWord]);
                isFindWord = true;
            }
            else
            {
                Console.WriteLine("Данного слова нет в нашем словаре");
            }
        }
    }

    static void AddDictionary(Dictionary<string, string> dictionary)
    {
        bool isFindWord = false;
        string wordDesignation;

        while (isFindWord == false)
        {
            Console.Write("Введите слово, значение которого хотите добавить: ");
            string userWord = Console.ReadLine();

            if (dictionary.ContainsKey(userWord))
            {
                Console.WriteLine("Такое слово уже есть в словаре.");
            }
            else
            {
                Console.WriteLine("Введите описание для вашего слова: ");
                wordDesignation = Console.ReadLine();
                dictionary.Add(userWord, wordDesignation);
                isFindWord = true;
            }
        }
    }
}
