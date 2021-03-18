using System;

namespace Entregable3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable boolean permite salir del menu
            Boolean salir = false;
            do
            {
                Console.WriteLine("Que ejercicio desea ejecutar: " +
                                  "\n1- Ejericio 1" +
                                  "\n2- Ejericio 2" +
                                  "\n3- Ejercicio 3" +
                                  "\n4- Salir");
                int opcion  = Int32.Parse(Console.ReadLine());
                //se valida que ejercicio se quiere ejecutar
                switch (opcion)
                {
                    case 1:
                        //si se ingresa 1 se ejecuta el metodo ejercicio 1
                        ejercicio1();
                        //se detiene la operacion
                    break;
                    case 2:
                        //si se ingresa 2 se ejecuta el metodo ejercicio 2
                        ejercicio2();
                    //se detiene la operacion
                    break;
                    case 3:
                        //si se ingresa 3 se ejecuta el metodo ejercicio 3
                        ejercicio3();
                    //se detiene la operacion
                    break;
                    default: 
                        //con esto rompermos el ciclo
                        salir = true; 
                    break;
                    
                }

            } while (salir != true);
        }
        //validacion si el numero que se le da es impar o no
        public static bool EsImpar(int numero)
        {
            //si es impar retorna un false
            return Convert.ToBoolean((numero % 2 == 0 ? true : false));
        }

        public static void ejercicio1()
        {
            //variables que se usan en el ejercicio
            int sumaTotal = 0;
            int multiplicacion = 1;
            Console.Write("Escriba un numero impar: ");
            int entrada = Int32.Parse(Console.ReadLine());
            //validamos que el numero este dentro de un rango
            if (entrada > 0 && entrada <= 19)
            {
                //si es impar ==false se realiza la operacion
                if (EsImpar(entrada) == false)
                {
                    Console.WriteLine("<<<--- LA SERIE EVALUADA --->>> ");
                    //ciclo quela suma y multiplicacion de la secuencia
                    //aumentamos de 2 en 2 para que se cumpla el 1 + 3 + 5 + n
                    for (int i = 1; i <= entrada; i += 2)
                    {
                        Console.Write(i + " ");
                        //sumamos a la variable suma total el nuevo valor de i
                        sumaTotal += i;
                        //se guarda el valor que habia en la variable mas la nueva multiplicacion
                        multiplicacion *= i;
                    }
                    //imprime los resultados en pantalla
                    Console.WriteLine("\nLa suma de la serie es: " + sumaTotal);
                    Console.WriteLine("La multiplicacion de la serie es: " + multiplicacion);
                }
            }
        }

        public static void ejercicio2()
        {
            Console.WriteLine("Introduzca un numero entero Positivo");
            //declaracion de variables
            int serie = Int32.Parse(Console.ReadLine());
            double sumatoria = 0;
            //ciclo que hace la suma de la serie 
            for (int i = 1; i <= serie; i++)
            {
                /*sumatoria sera igual a 1 entre 2, elevado a la potencia dependiente de la iteracion que este en i
                 e i se detiene hasta el valor de n ingresado al inicio
                 */
                sumatoria += (1 / Math.Pow(2,i));
            }
            //imprimimos el valor de la suma en deciaml
            Console.WriteLine("La suma de la secuencia es de : "+sumatoria);
        }

        public static void ejercicio3()
        {
            /*ponemos un rango para buscar el valor del libro, en este caso desde -500 hasta +500 y que vaya de 0.10 en 0.10*/
            for (double x = -500; x <= 500; x += 0.10) 
            {
                /*cuando el valor de x del ciclo este entre el rango de la ecuacion y se cumplan ambas condiciones de estar entre
                 un rango definido por la ecuaicion que entre
                 */
                if (349.99 - x < ((5 * (400 - x)) / 6) && ((5 * (400 - x)) / 6) < 350.09 - x)
                {
                    //como ya se cumplio la condicion entonces contramos el valor y se imprime
                    Console.WriteLine("El precion del libro es de: " + x);
                    //se cierra el ciclo por que si no se repetira varias veces
                    break;
                }
            }
            
            /*para saber la edad de la mama de martha fijamos otro rango de edades, y ya que las edades las medimos en entreos
             se incrementara de uno en uno*/
            for (double x = -100; x <= 100; x++) 
            {
                //cuando 15 que es la edad de martha por el triple   sea igual a x entramos
                if (15 * 3 == x)
                {
                    //si se cumple ausmimos que tenemos la edad asi que la imprimos
                    Console.WriteLine("La edad es: " + x);
                    //cerramos el ciclo
                    break;
                }
            } 
        }
    }
}

/*Algorirmo ejercicio 1
 
 se debe leer un numero por consola
 evaluar que el numero este entre 1 y 19
 evaluar que el numero sea impar
 calcular la suma de la serie de numeros impares hasta el numero dado
 calcular la multiplicacion de la serie de numeros impares hasta n
 impriir en pantalla ambos resultados
 
 */
 
 /* Algoritmo ejercicio 2
  
  pedir un numero por consola.
  leer el numero y parsearlo a int
  realizar la serie con un ciclo for
  con ayuda de los metodos pow de c# elevaremos a una potencia el numero 2
  el 2 lo dejamos fijo y le pasamos una iteacion como exponente
  guardar la suma como decimal en una variable double
  imprimir el resultado
  
  */
  
  /* Algoritmo ejercicio 3
  
  matematicamente es muy facil resolver, asi que con ayuda de busqueda exahustiva realizamos este ejercicio
  con un ciclo fijamos un intervalo para las edades que se buscaran
  cuando se cumpla la condicion de que el valor de la iteacion sea el producto de 15 * 3
  imprimimos el valor de x
  
  
  para el segundo caso, usamos busqueda exahustiva nuevamente,
  hacemos uso de otro ciclo entre un intervalo
  matematicamente se tiene que cuando 350-x = 5/6*(400-x) habremos encontrado el resultado
  esa ecuacion se traduce al lenguaje y cuando se encuentre se imrpime el valor del resultado en pantalla.
   
  */