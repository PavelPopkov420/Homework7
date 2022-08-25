Console.WriteLine("Введите число строк: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,]matrix =new int [n, m];

int sum = 0;
float middle = 0;
        for (int i=0; i < n; i++)
        {
            for(int j=0; j<m; j++)
            {
                    matrix[i, j] = new Random().Next(0, 5);
                    sum += matrix[i, j];
                    middle = sum /( m*n);

                Console.Write(matrix [i, j] + "\t");


            }
            Console.WriteLine();

        }
        Console.WriteLine("среднее арефметическое столбцов: " + middle);