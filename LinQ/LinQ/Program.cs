using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//-----------------------------------------------------------------------
namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"https://randomuser.me/api/?format=xml&results=10");

            //1 Получить всех женщин
            //var query = from user in root.Elements()
            //            where user.Element("gender")?.Value == "female"
            //            select user;

            //foreach (var item in query.Elements())
            //{
            //    if (item.Element("first")?.Value != null)
            //    {
            //        Console.WriteLine($"Name: {item.Element("first")?.Value}");
            //        Console.WriteLine($"Surname: {item.Element("last")?.Value}");
            //        Console.WriteLine($"Gender: {item.Parent.Element("gender")?.Value}");
            //        Console.WriteLine();
            //    }
            //}

            //foreach (var item in query)
            //{
            //if (item.Element("name").Element("first")?.Value != null)
            //{
            //    Console.WriteLine($"Name: {item.Element("name").Element("first")?.Value}");
            //    Console.WriteLine($"Surname: {item.Element("name").Element("last")?.Value}");
            //    Console.WriteLine($"Gender: {item.Element("gender")?.Value}");
            //    Console.WriteLine();
            //}
            //}
            //-----------------------------------------------------------------------
            //2 Получить всех немцев
            //var query = from user in root.Elements()
            //            where user.Element("nat")?.Value == "DE"
            //            select user;

            //foreach (var item in query.Elements())
            //{
            //    if (item.Element("first")?.Value != null)
            //    {
            //        Console.WriteLine($"Name: {item.Element("first")?.Value}");
            //        Console.WriteLine($"Surname: {item.Element("last")?.Value}");
            //        Console.WriteLine($"Nat: {item.Parent.Element("nat")?.Value}");
            //        Console.WriteLine();
            //    }
            //}
            //-----------------------------------------------------------------------
            //3 Получить всех людей с именем на букву А
            //var query = from user in root.Elements()
            //            where user.Element("name").Element("first")?.Value[0] == 'a'
            //            select user;

            //foreach (var item in query.Elements())
            //{
            //    if (item.Element("first")?.Value != null)
            //    {
            //        Console.WriteLine($"Name: {item.Element("first")?.Value}");
            //        Console.WriteLine($"Surname: {item.Element("last")?.Value}");
            //        Console.WriteLine();
            //    }
            //}
            //-----------------------------------------------------------------------
            //4 Отсортировать людей по дате регистрации
            //var query = from user in root.Elements()
            //            where user.Element("name")?.Value != null
            //            orderby int.Parse(user.Element("registered").Value.Substring(0, 4)), 
            //            int.Parse(user.Element("registered").Value.Substring(5, 2)), 
            //            int.Parse(user.Element("registered").Value.Substring(8, 2))
            //            select user;

            //foreach (var item in query.Elements())
            //{
            //    if (item.Element("first")?.Value != null)
            //    {
            //        Console.WriteLine($"Name: {item.Element("first")?.Value}");
            //        Console.WriteLine($"Surname: {item.Element("last")?.Value}");
            //        Console.WriteLine($"Registered: {item.Parent.Element("registered")?.Value.ToString()}");
            //        Console.WriteLine();
            //    }
            //}
            //-----------------------------------------------------------------------
            //5 Получить человека с самым длинным именем
            var query = (from user in root.Elements()
                        where user.Element("name")?.Value != null
                        orderby user.Element("name").Element("first")?.Value.Length descending
                        select user).First();

            foreach (var item in query.Elements())
            {
                if (item.Element("first")?.Value != null)
                {
                    Console.WriteLine($"Name: {item.Element("first")?.Value}");
                    Console.WriteLine($"Surname: {item.Element("last")?.Value}");
                    break;
                }
            }
            //-----------------------------------------------------------------------
            //6 Сгрупировать и вывести людей по национальности
            //var query = from user in root.Elements()
            //            where user.Element("name")?.Value != null
            //            orderby user.Element("nat")?.Value 
            //            select user;

            //foreach (var item in query.Elements())
            //{
            //    if (item.Element("first")?.Value != null)
            //    {
            //        Console.WriteLine($"Name: {item.Element("first")?.Value}");
            //        Console.WriteLine($"Surname: {item.Element("last")?.Value}");
            //        Console.WriteLine($"Nat: {item.Parent.Element("nat")?.Value}");
            //        Console.WriteLine();
            //    }
            //}
            //-----------------------------------------------------------------------
            //7* Вывести страну проживания каждого человека
            //-----------------------------------------------------------------------

        }
    }
}
//-----------------------------------------------------------------------