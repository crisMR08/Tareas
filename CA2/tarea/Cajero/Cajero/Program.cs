using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    
    class Program
    {
        static int monto = 0;
        static int deposito = 0;
        static int retiro = 0;
        static int opcion = 0;  //switch
        static float tipoC = 512; //tipo cambio
        static float montoCa = 0; //monto cambio
        static int moneda = 0;


        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Indique que desea hacer,");
                Console.WriteLine("1.Deposito de dinero");
                Console.WriteLine("2.Retiro de dinero");
                Console.WriteLine("3.Recibir monedas");
                Console.WriteLine("4.Tipo cambio");
                Console.WriteLine("0.Salir");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    
                    case 0:
                        break;
                    case 1:
                        {
                            Console.WriteLine("Dijite la cantidad a depositar");
                            deposito = int.Parse(Console.ReadLine());
                            monto = deposito + monto;
                            Console.WriteLine("Su cuenta tiene un monto de: " + monto);
                            Console.ReadKey();
                        } break;

                    case 2:
                        {
                            if (monto == 0)
                            {
                                Console.WriteLine("La cuenta esta vacia, deposite dinero");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Dijite el monto de dinero a retirar");
                                retiro = int.Parse(Console.ReadLine());


                                if (retiro > monto) { 
                                Console.WriteLine("Su cuenta no tiene los fondos suficientes");
                                    Console.ReadKey();
                            }
                                else{
                                monto = monto-retiro;
                                    Console.WriteLine("Su cuenta tiene un monto de: " + monto);
                                    Console.ReadKey();
                            }

                            }

                            
                        }break;

                    case 3:
                        {
                            Console.WriteLine("Sin programacion");

                        }break;

                    case 4:
                        {
                            Console.WriteLine("Dijite cantidad de dinero en dolares");
                            moneda= int.Parse(Console.ReadLine());
                            montoCa = moneda * tipoC;
                            Console.WriteLine("la conversion a colones es de: " + montoCa);
                            Console.ReadKey();


                        }break;
                        





                }

            } while (opcion != 0);

           
        }
        static int CalcBilletes()
        {
            //Calcular los billetes por cifras 

            return 0; } 
    }
}
