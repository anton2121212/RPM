using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM_2lb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаем коллекцию с хэш-таблицами
            Dictionary<int, string> hashTable = new Dictionary<int, string>();

            // Добавляем элементы в хэш-таблицу
            hashTable.Add(1, "Адин");
            hashTable.Add(2, "Два");
            hashTable.Add(3, "треи");
            hashTable.Add(4, "патру");
            hashTable.Add(5, "Пятерочка");

            // Производим поиск по ключу
            while (true)
            {
                Console.WriteLine("Для выхода с кода пропишите 999");
                Console.Write("Введите значения для проверки: ");
                int keyToSearch = int.Parse(Console.ReadLine());
                if (hashTable.ContainsKey(keyToSearch))
                {
                    Console.WriteLine($"Значение для ключа {keyToSearch} : {hashTable[keyToSearch]}");
                    Console.WriteLine(" ");
                }
                else if(keyToSearch==999)
                {
                    
                    Console.WriteLine("Вы вышли с кода\nНажмите любую клавишу для закрытия консоли...");
                    break;
                }
                else
                {
                    Console.WriteLine($"Ключ {keyToSearch} не найден в хэш-таблице.");
                    Console.WriteLine(" ");
                }
                
            }
            Console.ReadKey();
        }
    }
}
