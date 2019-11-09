using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuArrays
{
    class Program
    {
        static void EscribeArrayInt(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.Write(a[a.Length - 1] + "]");
        }

        static void EscribeArrayDouble(double[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.Write(a[a.Length-1] + "]");
        }  

        static void EscribeArrayString(string[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length-1; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.Write(a[a.Length-1] + "]");
        }

        static int MinArray(int[] array)
        {
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static int MaxArray(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static int[] ArrayReves(int[] a)
        {
            int[] arrayInvertido = new int[a.Length];
            int i, j;

            j = 0;
            for (i = a.Length - 1; i >= 0; i--)
            {
                arrayInvertido[j] = a[i];
                j++;
            }
            return arrayInvertido;
        }

        static int BuscaValorEnArray(int[] array, int valor)
        {
            //Devolvemos -1 si el valor no está en el array
            //Devolvemos valor del índice donde se encuentre el valor

            int resultado = -4;
            int i;

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == valor)
                {
                    resultado = i;

                }
                else
                {
                    if (!array.Contains(valor))
                    {
                        resultado = -1;
                    }
                }
            }
            return resultado;
        }

        static int ModaArray(int[] array)
        {
            int i, j;
            int moda = -1;
            int aux = 0;
            int contador = 1;

            for(i = 0; i < array.Length; i++)
            {
                for(j = i+1; j < array.Length-1; j++)
                {
                    if(array[i] == array[j])
                    {
                        contador++;
                    }
                }

                if(contador > aux)
                {
                    moda = array[i];
                }
            }

            return moda;
        }

        static void Arrays20Numeros()
        { 
            int[] numero = new int[20];
            double[] cuadrado = new double[20];
            double[] cubo = new double[20];
            int i;
            int alea = 0;
            double elevadoCuadrado = 0;
            double elevadoCubo = 0;

            Random rd = new Random();

            //Cargamos números aleatorios entre 0 y 100 en array numero
            for(i = 0; i < numero.Length; i++)
            {
                alea = rd.Next(0, 100);
                numero[i] = alea;
            }
          
            //Cargamos en cuadrado los elevados al cuadrado de cada elemento del array numero
            for (i = 0; i < numero.Length; i++)
            {
                elevadoCuadrado = Math.Pow(numero[i], 2);
                cuadrado[i] = elevadoCuadrado;
            }

            //Cargamos en cubo los elevados al cubo de cada elemento del array numero
            for (i = 0; i < numero.Length; i++)
            {
                elevadoCubo = Math.Pow(numero[i], 3);
                cubo[i] = elevadoCubo;
            }

            //Mostramos array numero
            EscribeArrayInt(numero);
            //Mostramos array cuadrado
            EscribeArrayDouble(cuadrado);
            //Mostramos array cubo
            EscribeArrayDouble(cubo);
        }

        static int AleatorioMinMax(int min, int max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }

        static int[] RotaElementosArray(int[] array)
        {
            int[] res = new int[array.Length];
        
            int ultimoNarray = array[array.Length - 1];            
            int i, j;

            j = 0;
            res[0] = ultimoNarray; //Ponemos en prmiera pos la ultima del array
            for(i = 0; i < array.Length-1; i++)
            {                
                res[i+1] = array[i]; //A partir de la pos 1 de res, vamos  metiendo los elementos de array                    
            }           
            return res;

            
        }

        static void EscribeMatriz(int[,] matriz)
        {
            int valor = 0;

            int i, j;
            for(i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("|");
                for(j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" ".PadLeft(1) + matriz[i,j].ToString().PadRight(3));
                }
                Console.WriteLine("|");
            }            
        }

        static string BusquedaMatriz(int valor, int[,] matriz)
        {
            string resultado = "";
            int i, j;

            for(i = 0; i < matriz.GetLength(0); i++)
            {
                for(j = 0; j < matriz.GetLength(1); j++)
                {
                    if(matriz[i,j] == valor)
                    {
                        resultado = $"[{i},{j}]";
                    }
                }
            }

            return resultado;
        }

        static int[,] Bidimensional6x5(int[,] matriz)
        {
            matriz = new int[6,5];
            int alea = 0;
            Random rd = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    alea = rd.Next(1, 100);
                    matriz[i, j] = alea;
                }
            }
            return matriz;


        }

        static int VecesApareceLetraEnArrayChar(char[] a, char letra)
        {
            int vecesLetra = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == letra)
                {
                    vecesLetra++;
                }
            }

            return vecesLetra;
        }

        static int VecesApareceLetraString(string cadena, char letra)
        {
            int vecesLetra = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == letra)
                {
                    vecesLetra++;
                }
            }

            return vecesLetra;
        }

        /// <summary>
        /// Función que devuelve la posición del elemento del array de string con mayor ocurrencias
        /// sobre el caracter que recibe por parámetro
        /// </summary>
        /// <param name="arrayString">Array de tipo string</param>
        /// <param name="letra">Caracter</param>
        /// <returns>Posición del elemento del array con mayor ocurrencia del caracter</returns>
        static int MayorOcurrenciaCharEnArray(string[] arrayString, char letra)
        {
            int posElementoMaxOcurrenciasArrayString = 0;
            int max;
            string trozo = "";
            int[] arrayContador = new int[arrayString.Length];

            for (int i = 0; i < arrayString.Length; i++)
            {
                //Vamos viendo por palabras las veces que aparece la letra en dicha palabra
                //Cada palabra corresponde a un elemento del array
                trozo = arrayString[i];
                arrayContador[i] = VecesApareceLetraString(trozo, letra);
            }

            //Ahora tenemos que ver qué elemento del arrayContador es mayor
            //Y ese elemento del arrayContador en su posición, marcará la misma posición
            //del elemento en arrayString ( porque los arrays son del mismo tamaño )
            //Y ahí tenemos el elemento del arrayString donde sucede el mayor número 
            //de ocurrencias de nuestra letra.

            max = arrayContador[0];
            for (int i = 0; i < arrayContador.Length; i++)
            {
                if(arrayContador[i] > max)
                {
                    max = arrayContador[i];
                    posElementoMaxOcurrenciasArrayString = i;
                }
                
            }

            return posElementoMaxOcurrenciasArrayString;
        }

        /// <summary>
        /// Función que devuelve la posición del elemento del array de string con menor ocurrencias
        /// sobre el caracter que recibe por parámetro
        /// </summary>
        /// <param name="arrayString">Array de tipo string</param>
        /// <param name="letra">Caracter</param>
        /// <returns>Posición del elemento del array con menor ocurrencia del caracter</returns>
        static int MenorOcurrenciaCharEnArray(string[] arrayString, char letra)
        {
            int posElementoConMenorOcurrencias = -1;
            int min;
            string trozo = "";
            int[] arrayContador = new int[arrayString.Length];

            for (int i = 0; i < arrayString.Length; i++)
            {
                trozo = arrayString[i];
                arrayContador[i] = VecesApareceLetraString(trozo, letra);
            }

            min = arrayContador[0];
            for (int i = 0; i < arrayContador.Length; i++)
            {
                if(arrayContador[i] < min)
                {
                    min = arrayContador[i];
                    posElementoConMenorOcurrencias = i;
                }
            }

            return posElementoConMenorOcurrencias;
        }

        static int[,] RellenaMatrizDatosPorParametro(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            int alea = 0;
            Random rd = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    alea = rd.Next(1, 100);
                    matriz[i, j] = alea;
                }
            }
            return matriz;
        }

        static int[,] MatrizInvertida(int[,] matriz)
        {
            int[,] matrizInvertida = new int[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizInvertida[matriz.GetLength(0)-1-i, matriz.GetLength(1)-1-j] = matriz[i, j];
                }
            }

            return matrizInvertida;
        }

        static int[,] RellenaMatriz3x3OrdenAscendente()
        {
            int[,] matriz = new int[3, 3];
            int n = 1;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = n;
                    n++;
                }
            }

            return matriz;
        }

        static int[,] SumaDosMatrices(int[,] a, int[,] b)
        {
            int[,] suma = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    suma[i, j] = a[i, j] + b[i, j];
                }
            }

            return suma;
        }

        static int[,] MultiplicaDosMatrices(int[,] a, int[,] b)
        {
            int[,] producto = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    producto[i, j] = a[i, j] * b[i, j];
                }
            }

            return producto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===========");
            Console.WriteLine("MENÚ ARRAYS");
            Console.WriteLine("===========");
            Console.WriteLine("[1] MinArray");
            Console.WriteLine("[2] ArrayReves");
            Console.WriteLine("[3] BuscaValorEnArray");
            Console.WriteLine("[4] ModaArray");
            Console.WriteLine("[5] Arrays20Numeros");
            Console.WriteLine("[6] RotaElementosArray");
            Console.WriteLine("[7] Bidimensional6x5");
            Console.WriteLine("[8] OperacionesConArraysString");
            Console.WriteLine("[9] MatrizInvertida");
            Console.WriteLine("[10] SumaDosMatricesAleatorias");
            Console.WriteLine("[11] MultiplicaDosMatrices(producto entre matrices)");
            Console.WriteLine("[100] AleatorioMinMax");
            Console.WriteLine("[101] MayorOcurrenciaCharEnArray");
            Console.WriteLine("[102] MenorOcurrenciaCharEnArray");
            Console.WriteLine("[103] RellenaMatrizDatosPorParametro");
            Console.WriteLine("[104] RellenaMatriz3x3OrdenAscendente");
            Console.WriteLine("[105] SumaMatrices");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        int[] a = { 2, 3, 67, 8, 12, 100 };
                        int min = MinArray(a);

                        EscribeArrayInt(a);
                        Console.WriteLine();
                        Console.WriteLine($"El valor mínimo del array es = {min}");
                    }
                    break;
                case 2:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] invertido = ArrayReves(a);

                        EscribeArrayInt(a);
                        Console.WriteLine();
                        EscribeArrayInt(invertido);
                    }
                    break;
                case 3:
                    {
                        int[] a = { 3, 4, 5, 22, 4, 5, 6 };
                        int valorEncontrado = BuscaValorEnArray(a, 22);

                        Console.WriteLine(valorEncontrado);
                    }
                    break;
                case 4:
                    {
                        int[] a = { 2, 3, 2, 4, 5, 4, 6, 4 };
                        int moda = ModaArray(a);

                        EscribeArrayInt(a);
                        Console.WriteLine();
                        Console.WriteLine($"Moda = {moda}");
                    }
                    break;

                case 5:
                    {
                        Arrays20Numeros();
                    }
                    break;

                case 6:
                    {
                        int[] array = { 1, 2, 3, 4, 5, 6 };
                        int[] res = RotaElementosArray(array);

                        EscribeArrayInt(res);
                    }
                    break;

                case 7:
                    {
                        int[,] matriz = new int[6, 5];

                        //Montamos la matriz con aleatorios
                        matriz = Bidimensional6x5(matriz);

                        //La mostramos por consola
                        EscribeMatriz(matriz);

                        //Pedimos valor que vamos a buscar
                        Console.WriteLine("Valor que quieres buscar en la matriz = ");
                        int valor = int.Parse(Console.ReadLine());

                        string coordenadas = BusquedaMatriz(valor, matriz);

                        //Mostramos coordenadas del valor encontrado en la matriz
                        Console.WriteLine($"Las coordenadas del valor son = {coordenadas}");
                    }
                    break;

                case 8:
                    {
                        int op = -2;

                        while(op != 0)
                        {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("OPERACIONES CON ARRAYS DE STRING");
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("[1] Muestra un string con los elementos concatenados del array.");
                            Console.WriteLine("[2] Muestra un string con los elementos concatenados del array ordenados alfabéticamente.");
                            Console.WriteLine("[3] ¿Cuántas veces aparece una letra en un string?\n" +
                                                   "Mustra mayores ocurrencias y menores ocurrencias de dicha letra.");
                            Console.WriteLine("[0] SALIR");
                            Console.WriteLine();
                            Console.Write("Elige una opción: ");
                            op = int.Parse(Console.ReadLine());

                            //Pedimos al usuario el string
                            Console.WriteLine("Escribe la cadena de caracteres para nuestro array: ");
                            string cadena = Console.ReadLine();

                            //Pasamos la cadena a un string[]
                            string[] arrayStr = cadena.Split(' ');

                            switch (op)
                            {
                                case 1:
                                    {
                                        EscribeArrayString(arrayStr);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        Array.Sort(arrayStr, StringComparer.InvariantCulture);
                                        EscribeArrayString(arrayStr);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.Write("Escribe una letra: ");
                                        char letra = char.Parse(Console.ReadLine());

                                        char[] arrayChar = cadena.ToCharArray();

                                        int vecesLetra = VecesApareceLetraEnArrayChar(arrayChar, letra);

                                        //Mostramos veces que aparece esa letra
                                        Console.WriteLine($"La letra \"{letra}\" aparece {vecesLetra} veces.");

                                        //Posición del array de string donde existe mayor ocurrencias de la letra que pasamos 
                                        //por parámetro

                                        int maxOcurrencias = MayorOcurrenciaCharEnArray(arrayStr, letra);
                                        Console.WriteLine($"Posición del elemento con mayor ocurrencia del caracter \"{letra}\" = {maxOcurrencias}");

                                        //Posición del array de string donde existe menor ocurrencias de la letra que pasamos 
                                        //por parámetro

                                        int minOcurrencias = MenorOcurrenciaCharEnArray(arrayStr, letra);
                                        Console.WriteLine($"Posición del elemento con menor ocurrencias del caracter \"{letra}\" = {minOcurrencias}");

                                    }
                                    break;
                                default: break;
                            }
                        }
                        break;
                    }

                case 9:
                    {
                        //Solicita al usuario dimensiones de la matriz
                        Console.Write("Escribe tamaño de filas: ");
                        int filas = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Escribe tamaño de columnas: ");
                        int columnas = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        //Rellena matriz con números aleatorios

                        //Muestra matriz reverse ( filas serán columnas - columnas serán filas )
                    }
                    break;

                case 10:
                    {
                        //Generamos dos matrices de 3x3 con datos enteros aleatorios
                        int[,] a = RellenaMatrizDatosPorParametro(3, 3);
                        int[,] b = RellenaMatrizDatosPorParametro(3, 3);

                        //Mostramos las matrices
                        EscribeMatriz(a);
                        Console.WriteLine();
                        EscribeMatriz(b);
                        Console.WriteLine();

                        //Sumamos las matrices a y b
                        int[,] suma = SumaDosMatrices(a, b);

                        //Mostramos la suma de las matrices 
                        EscribeMatriz(suma);
                    }
                    break;

                case 11:
                    {
                        //Generamos dos matrices de 3x3 con datos enteros aleatorios
                        int[,] a = RellenaMatrizDatosPorParametro(3, 3);
                        int[,] b = RellenaMatrizDatosPorParametro(3, 3);

                        //Mostramos las matrices
                        EscribeMatriz(a);
                        Console.WriteLine();
                        EscribeMatriz(b);
                        Console.WriteLine();

                        //Sumamos las matrices a y b
                        int[,] producto = MultiplicaDosMatrices(a, b);

                        //Mostramos la suma de las matrices 
                        EscribeMatriz(producto);
                    }
                    break;

                case 100:
                    {
                        //Aleatorio entre un mínimo y un máximo
                        int alea = AleatorioMinMax(10, 20);

                        Console.WriteLine(alea);
                    }
                    break;

                case 101:
                    {                        
                        string[] arrayString = { "pata", "pataa", "pataaaaaa", "pa", "p" };
                        int posMaxOcurrencias = MayorOcurrenciaCharEnArray(arrayString, 'a');

                        Console.WriteLine(posMaxOcurrencias);
                    }
                    break;

                case 102:
                    {
                        string[] arrayString = { "pata", "pataa", "pataaaaaa", "pa", "paaaaaaaaaaaaa" };
                        int posMinOcurrencias = MenorOcurrenciaCharEnArray(arrayString, 'a');

                        Console.WriteLine(posMinOcurrencias);
                    }
                    break;

                case 103:
                    {
                        int[,] matriz = RellenaMatrizDatosPorParametro(3, 3);
                        EscribeMatriz(matriz);
                    }
                    break;

                case 200:
                    {
                        int[,] a = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
                        int[,] b = { { 2, 3, 4 }, { 5, 6, 7 }, { 8, 9, 10} };

                        int[,] c = MultiplicaDosMatrices(a, b);

                        EscribeMatriz(a);
                        Console.WriteLine("==================");
                        EscribeMatriz(b);
                        Console.WriteLine("==================");

                        EscribeMatriz(c);

                        
                    }
                    break;
                default:break;
            }
            Console.ReadKey();
        }
    }
}


