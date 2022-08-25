Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double [,] matrix = new double [n, m];

for (int i = 0; i< n; i++)
{
    for (int j = 0; j < m; j++)
    matrix[i, j] = new Random().Next(0, 5);
}
for (int i = 0; i< n; i++)
{
    for (int j = 0; j < m; j++)
    Console.Write(matrix[i,j] + " \t");
    Console.WriteLine();
}
Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a > m && b > n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = matrix.GetValue(a,b);
 Console.WriteLine(c);
 }