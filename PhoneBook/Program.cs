using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            while (true)
            {
                var input = Console.ReadKey().KeyChar;
                Console.Clear();
                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);
                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.WriteLine("Страница отсутстыует!");
                }
                else
                {
                    switch (pageNumber)
                    {
                        case 1:
                            var pageContent = phoneBook.Take(2);
                            var sort = pageContent.OrderBy(s => s.Name).ThenBy(s => s.LastName);
                            foreach (var item in sort)
                            {
                                Console.WriteLine(item.Name + " " + item.LastName + " - " + item.PhoneNumber + ", " + item.Email);
                            }
                            break;
                        case 2:
                            pageContent = phoneBook.Skip(2).Take(2);
                            sort = pageContent.OrderBy(s => s.Name).ThenBy(s => s.LastName);
                            foreach (var item in sort)
                            {
                                Console.WriteLine(item.Name + " " + item.LastName + " - " + item.PhoneNumber + ", " + item.Email);
                            }
                            break;
                        case 3:
                            pageContent = phoneBook.Skip(4).Take(2);
                            sort = pageContent.OrderBy(s => s.Name).ThenBy(s => s.LastName);
                            foreach (var item in sort)
                            {
                                Console.WriteLine(item.Name + " " + item.LastName + " - " + item.PhoneNumber + ", " + item.Email);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
