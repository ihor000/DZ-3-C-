Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];


 for (int i = 1; i <= N; i++)
 {
    int cubeDigit = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write(cubeDigit);
    
 }
 



 