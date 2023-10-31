namespace BuscaDeSalto.App.Algoritmos
{
    public static class AlgoritmoBuscaSalto
    {
        public static int FazerBuscaDeSaltoEmComplexidadeDeRaizQuadradaDeTempo(int[] arr, int x, int n)
        {
            int salto = (int)Math.Sqrt(n);
            int saltoAnterior = 0;
            while (arr[Math.Min(salto, n) - 1] < x)
            {
                saltoAnterior = salto;
                salto += (int)Math.Sqrt(n);
                if (saltoAnterior >= n)
                {
                    return -1;
                }
            }
            while (arr[saltoAnterior] < x)
            {
                saltoAnterior++;
                if (saltoAnterior == Math.Min(salto, n))
                {
                    return -1;
                }
            }
            if (arr[saltoAnterior] == x)
            {
                return saltoAnterior;
            }
            return -1;
        }
    }
}