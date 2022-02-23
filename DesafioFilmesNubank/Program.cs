using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<double> duracoes = new List<double>();

        for (int i = 0; i < n; i++)
        {
            duracoes.Add(Convert.ToDouble(Console.ReadLine()));
        }

        duracoes.Sort();

        /*for (int i = 0; i < n; i++)
        {
            Console.Write(duracoes[i] + " ");
        }*/

        Console.WriteLine(AcharMinimoDeDias(duracoes));
    }

    public static int AcharMinimoDeDias(List<double> duracoes)
    {
        int quantidadeDias = 0, indexDuracaoMaxima, indexDuracaoMinima;
        double duracaoMaxima, duracaoMinima;

        while (duracoes.Count > 0)
        {
            duracaoMaxima = duracoes.Max();
            indexDuracaoMaxima = duracoes.IndexOf(duracaoMaxima);

            duracaoMinima = duracoes.Min();
            indexDuracaoMinima = duracoes.IndexOf(duracaoMinima);

            if (duracaoMaxima + duracaoMinima > 3)
            {
                quantidadeDias++;
                ExcluirItemVetor(duracoes, indexDuracaoMaxima);
            }
            else if (duracaoMaxima + duracaoMinima <= 3)
            {
                if (duracoes.Count == 1)
                {
                    quantidadeDias++;
                    ExcluirItemVetor(duracoes, indexDuracaoMaxima);
                }
                else
                {
                    quantidadeDias++;
                    ExcluirItemVetor(duracoes, indexDuracaoMaxima, indexDuracaoMinima);
                }
            }
        }

        return quantidadeDias;
    }

    public static void ExcluirItemVetor(List<double> duracoes, int indexDuracaoMaxima)
    {
        duracoes.RemoveAt(indexDuracaoMaxima);
    }

    public static void ExcluirItemVetor(List<double> duracoes, int indexDuracaoMaxima, int indexDuracaoMinima)
    {
        duracoes.RemoveAt(indexDuracaoMaxima);
        if (duracoes.Count > 1)
        {
            duracoes.RemoveAt(indexDuracaoMinima);
        }                
    }
} 