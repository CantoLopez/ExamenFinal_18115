using System;
//Lo copie tal cual y no me dio error solo el nombre de la variable es Matriz y no matriz
class program
{
    static void Main()
    {
        int[,] Matriz = new int[3, 2];
        Matriz[0,0] = 1;
        Matriz[0,1] = 2;
        Matriz[1,0] = 3;
        Matriz[1,1] = 4;
        Matriz[2,0] = 5;
        Matriz[2,1] = 6;

        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine("Elemento en la posición [{0},{1}: {2} ",i,j, Matriz[i,j],"]");
            }
        }
        Console.ReadLine();
    }
}