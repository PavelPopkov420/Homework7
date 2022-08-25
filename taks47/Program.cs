Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    matrix[i, j] = new Random().Next(-5,5) + new Random().NextDouble();
      
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    matrix[i, j] = Math.Round(matrix[i,j], 3);
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i,j] + " \t");
    Console.WriteLine();
}