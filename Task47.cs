// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double [m, n];
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        matrix[i, j] = Math.Round( new Random().NextDouble() * 100, 2);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}