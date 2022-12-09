Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());


    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Палиндром");
            }
            else 
            Console.WriteLine("Не палиндром");
            
    }
    else
    Console.WriteLine("Введино неверное число!");

 
