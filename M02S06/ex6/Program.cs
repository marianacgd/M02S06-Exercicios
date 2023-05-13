internal partial class Program
{
    private static void Main(string[] args)
    {
        //RESOLUCAO 01
        Console.WriteLine("Entre com os números:");

        List<int> lista = new List<int>() {1, 6, 2, 4, 3};
        int menor;
        int maior;

        for (int i = 0; i < lista.Count; i++)
        {
            for (int j = i; j < lista.Count; j++)
            {
                while(lista[i] > lista[j]){
                    menor = lista[j];
                    maior = lista[i];
                    lista[i] = menor;
                    lista[j] = maior;
                }
            }
        }

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        //RESOLUCAO 02
        // int[] valores = new int[] {1, 8, 4, 9, 6};

        // int menorValor = valores[0];
        // List<int> valoresInvertidos = new List<int>();

        // for (int i= 1; i < valores.Length; i++)
        // {
        //     for (int j = 1; j < valores.Length; j++)
        //     {
        //         if (valores[j] < menorValor)
        //         {
        //             menorValor = valores[j];
        //             valores.Remove(valores[j]);
        //         }
        //     }
        //     valoresInvertidos.Add(menorValor);
        // }

        // foreach (var item in valoresInvertidos)
        // {
        //     Console.Write(item + ",");
        // }
    }
}