// 66
Console.Write("Введите начальное число M:");
int M = Int32.Parse(Console.ReadLine());

Console.Write("Введите начальное число N:");
int N = Int32.Parse(Console.ReadLine());

void GapBtwSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapBtwSum(M, N, sum);
}

GapBtwSum(M, N, 0);

//68
int m = Inputs("M: ");
int n = Inputs("N: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int Inputs(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}