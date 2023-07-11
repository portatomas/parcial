namespace parcial_tm2
{
    internal class Program
    {
        private static double l;

        static void Main(string[] args)
        {
            int  l, l2;
            double h,arista;
            Console.Write("ingrese un lado");
            l=int.Parse(Console.ReadLine());
            Console.Write(" ingrese otro lado");
            l2 = int.Parse(Console.ReadLine());

            var area=calculararea(h,l);
             var volumen=calcularvolumen(h,l2);   
        }

        private static object calcularvolumen(double h, int l2)
        {
            return (Math.PI * Math.Pow(l, 2) * h) / 3;
        }

        private static object calculararea(double h, int l)
        {
           return l*(l+Math.Sqrt(4))
        }
    }
}