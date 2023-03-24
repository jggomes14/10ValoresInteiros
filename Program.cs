namespace _10ValoresInteiros
{
    internal class Program
    {
        static void CalcularOsValoresMaioresEMenores(int[] valores, int tamanho)
        {

            int maiorValor = valores[0];
            int menorValor = valores[0];
            int soma = valores[0];
            int ValorMedio;
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                }
                if (valores[i] < menorValor)
                {
                    menorValor = valores[i];
                }
            }
            for (int i = 1; i < valores.Length; i++)
            {
                soma = soma + valores[i];
            }
            ValorMedio = soma / tamanho;
            Console.WriteLine($"O Maior Valor da Sequência é {maiorValor}");
            Console.WriteLine($"O Menor Valor da Sequência é {menorValor}");
            Console.WriteLine($"O Valor Médio da Sequência é {ValorMedio}");

        }
        static void PuxarOsValoresNegativos(int[] valores, int tamanho)
        {
            int qtdNegativos = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < 0)
                {
                    qtdNegativos++;
                }
            }


            int[] ValoresNegativos = new int[qtdNegativos];

            int posicao1 = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < 0)
                {
                    ValoresNegativos[posicao1] = valores[i];
                    posicao1++;
                }
            }
            for (int i = 0; i < qtdNegativos; i++)
            {
                Console.WriteLine($"Os Valores Negativos são {ValoresNegativos[i]}");
            }
        }
        static void PuxarOsTresMaioresValores (int[] valores)
        {
            int[] TresMaioresValores = new int[3];
            Array.Sort(valores);
            Array.Reverse(valores);

            for (int i = 0; i < 3; i++)
            {
                TresMaioresValores[i] = valores[i];
            }

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
            for (int i = 0; i < TresMaioresValores.Length; i++)
            {
                Console.WriteLine($"Os Três Maiores Valores são {TresMaioresValores[i]}");
            }

        }
        static void ItemRemovidoDaSequencia(int[] valores)
        {
            int tamanhoNovoArrayComUmAMenos = valores.Length - 1;
            int[] valoresRemovidos = new int[tamanhoNovoArrayComUmAMenos];
            int posicao2 = 0;
            for (int i = 0; i < tamanhoNovoArrayComUmAMenos; i++)
            {
                valoresRemovidos[posicao2] = valores[i];
                posicao2++;
            }
            for (int i = 0; i < tamanhoNovoArrayComUmAMenos; i++)
            {
                Console.WriteLine($"Os Valores do Array com um a menos são {valoresRemovidos[i]}");

            }

        }
        static void Main(string[] args)
        {
            int[] valores = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
            int tamanho = valores.Length;
            CalcularOsValoresMaioresEMenores(valores, tamanho);
            PuxarOsTresMaioresValores(valores);
            PuxarOsValoresNegativos(valores, tamanho);
            ItemRemovidoDaSequencia(valores);
        }
    }
}