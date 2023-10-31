namespace BuscaDeSalto.App.Algoritmos
{
    public static class AlgoritmoBuscaLinear
    {
        public static int FazerBuscaLinearIterativa(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}