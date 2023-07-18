using Task;


List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  Age = 20,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  Age = 20,  EduType = "Python", Payment = 2200000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  Age = 16,  EduType = "SMM", Payment = 1500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  Age = 17,  EduType = "Dizayn", Payment = 2000000 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  Age = 23,  EduType = "SMM", Payment = 1500000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  Age = 22,  EduType = "Dizayn", Payment = 1700000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  Age = 19,  EduType = "Python", Payment = 2200000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  Age = 20,  EduType = "Dizayn", Payment = 1700000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  Age = 19,  EduType = "Python", Payment = 2200000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  Age = 16,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  Age = 24,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  Age = 21,  EduType = "Python", Payment = 2200000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  Age = 25,  EduType = "SMM", Payment = 1600000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  Age = 16,  EduType = "Dizayn", Payment = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  Age = 23,  EduType = "DotNET", Payment = 2400000 },
};



/*Console.WriteLine("DotNet talabalari: ");
foreach (var item in student)
{
if (item.EduType.ToLower() == "dotnet")
{
    Console.WriteLine($"{item.Id} - {item.FullName}   {item.Age} yosh");
}
}
*/
vvv:

Console.WriteLine("1-Talabalar ro'yhati\n2-To'lovlar");
var choose = Console.ReadKey().KeyChar;
Console.Clear();

switch (choose)
{
    case '1':
        {
        abc:
            Console.WriteLine("1-DotNet\n2-SMM\n3-Python\n4-Dizayn\n5-Jami talabalar ro'yhati\n0-Back to menu");
            char num = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            Console.Clear();

            switch (num)
            {
                case '0':
                    {
                        goto vvv;
                    }
                case '5':
                    {
                        Console.WriteLine("Jami talabalar ro'yhati: ");
                        foreach (var item in student)
                            Console.WriteLine($"{item.Id} - {item.FullName}   {item.Age} yosh");
                        Console.WriteLine("\n");
                        goto abc;
                    }
                case '1':
                    {
                        Console.WriteLine("DotNet talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "dotnet")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.Age} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }

                case '2':
                    {
                        Console.WriteLine("SMM talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "smm")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.Age} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }

                case '3':
                    {
                        Console.WriteLine("Python talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "python")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.Age} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }
                case '4':
                    {
                        Console.WriteLine("Dizayn talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "dizayn")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.Age} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }
                default: 
                    Console.Write("Xato menu tanlandi!\nIltimos qaytadan kiriting:\n");
                    goto abc;
            }
        }
    case '2':
        {
            Console.WriteLine("Tolovlar");
        }
        break;

}