// Показать двумерный массив размером m×n заполненный вещественными числами
void FillMatrix(double[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble()*10;
        }
    }
}
void PrintMatrix(double[,] matr)
{
   for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j].ToString("0.00")} ");
        }
        Console.WriteLine();
    } 
}
Console.WriteLine("Введите количесво строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количесво столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
double[,] matrix = new double[m,n];
FillMatrix(matrix);
PrintMatrix(matrix);
