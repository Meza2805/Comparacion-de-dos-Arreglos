internal class Program
{
    private static void Main(string[] args)
    {
        int[] x = new int[20];
        int[] y = new int[20];
        int[] z = new int[20];
        int mayor=0, menor=0, igual=0;
        Console.WriteLine("PROGRAMA PARA MEDIR DOS ARREGLOS");
        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA COMENZAR...");
    
        Console.ReadKey();
         Console.Clear();
        Console.WriteLine("INGRESE 20 NUMEROS PARA EL PRIMER ARREGLO: ");
        for (int i=0; i<20;i++)
        {
            Console.WriteLine("INSERTE EL NUMERO DE LA POSICION: "+ (i+1));
            x[i]= Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("DATOS INSERTADOS");
        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("INGRESE 20 NUMEROS PARA EL SEGUNDO ARREGLO: ");
        for (int i=0; i<20;i++)
        {
            Console.WriteLine("INSERTE EL NUMERO DE LA POSICION: "+ (i+1));
            y[i]= Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("TODOS LOS DATOS INSERTADOS");
        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA REALIZAR EL CALCULO...");
        Console.ReadKey();
        Console.Clear();
         for (int i=0; i<20;i++)
        {
            if (x[i] > y[i])
            {
                 z[i]= 1; 
                 mayor++;
            }
            else if (x[i] < y[i])
            {
                 z[i]= -1; 
                 menor++;
            }
             else if (x[i] == y[i])
            {
                 z[i]= 0;
                 igual++; 
            }
        }
        Console.Clear();
        Console.WriteLine("CALCULANDO....");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("==========TABLA===========");
         Console.WriteLine("==========================");
        Console.WriteLine("X"+"\t"+"Y"+"\t"+"Z");

        Console.WriteLine("==========================");
         for (int i=0; i<20;i++)
        {
            Console.WriteLine(x[i]+"\t"+y[i]+"\t"+z[i]);
        }
         
         Console.WriteLine("==========================");
         Console.WriteLine("CANTIDAD DE VECES EN DONDE X ES MAYOR QUE Y: "+mayor);
         Console.WriteLine("CANTIDAD DE VECES EN DONDE X ES MENOR QUE Y: "+menor);
         Console.WriteLine("CANTIDAD DE VECES EN DONDE X ES IGUAL QUE Y: "+igual);
    }
}