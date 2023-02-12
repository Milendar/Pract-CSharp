Console.WriteLine("Введите число");
            string x = Console.ReadLine();
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr.GetType);
            string x2 = new String(arr);
            if (x == x2) Console.WriteLine("да");
            else Console.WriteLine("нет");