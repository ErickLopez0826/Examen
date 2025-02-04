using System;
using System.Threading.Tasks.Dataflow;

public class RegistraVenta(){
public int Tacos, Tortas, TotalDeTacos, TotalDeTortas;
    public void RegistroVenta(){
        TotalDeTacos = Tacos + TotalDeTacos;
        Console.WriteLine($"Total de tacos vendidos hasta ahora: {TotalDeTacos}");
        TotalDeTortas = Tortas + TotalDeTortas;
        Console.WriteLine($"Total de tortas vendidas hasta ahora: {TotalDeTortas}");
    }
    public void CuantosTacos(){
        Console.WriteLine($"Total de tacos vendidos este dia: {TotalDeTacos}");
    }
    public void CuantasTortas(){
        Console.WriteLine($"Total de tortas vendidos este dia: {TotalDeTortas}");
    }
    public void VendiElTripleDeTacos(){
        Console.WriteLine("¿Los tacos superaron el triple de las tortas?");
        if(TotalDeTacos * 3 > TotalDeTortas){
            Console.WriteLine("SI");
        }
        else{
            Console.WriteLine("NO");
        }
    }
}

class CochinitaFeliz{
    static void Main(){
        RegistraVenta VentaCliente = new RegistraVenta();
        Console.WriteLine("<----------------------------------------------------------------->");
        Console.WriteLine("Ingresa una de las siguientes opciones:\n");
        Console.WriteLine("Opcion 1: Ingresar venta de tacos y tortas");
        Console.WriteLine("Opcion 2: Mostrar cuantos tacos totales vendieron");
        Console.WriteLine("Opcion 3: Mostrar cuantas tortas totales vendieron");
        Console.WriteLine("Opcion 4: Mostrar si vendio el triple de tacos o no");
        Console.WriteLine("Opcion 5: Salir");
        Console.WriteLine("<----------------------------------------------------------------->");
        int Opcion = int.Parse(Console.ReadLine());
        while(Opcion != 5){
            if(Opcion == 1){
                Console.WriteLine("¿A cuantos clientes vendio?");
                int VentaTotal = int.Parse(Console.ReadLine());
                for (int i = 1; i == VentaTotal; i++){
                    Console.WriteLine("Ingresa la cantidad de tacos vendidos al cliente:");
                    VentaCliente.Tacos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la cantidad de tortas vendidas al cliente:");
                    VentaCliente.Tortas = int.Parse(Console.ReadLine());
                    VentaCliente.RegistroVenta();
                    return;
                }
            }else if (Opcion == 2){
                VentaCliente.CuantosTacos();
                return;
            }else if (Opcion == 3){
                VentaCliente.CuantasTortas();
                return;
            }else if(Opcion == 4){
                VentaCliente.VendiElTripleDeTacos();
                return;
            }else{
                Console.WriteLine("Fin del programa");
            }
        }
    }
}

/*
Propiedades: Tacos, Tortas, Total de tacos, Total de tortas

-Se necesita saber que es lo que mas se vende entre tacos y tortas
-Se necesita saber la cantidad de tacos y tortas
-Se requiere saber si los tacos vendidos son el triple o mas que de tortas

-Metodo de regitro de venta el cual incluira los datos de los tacos y la torta
-Agregar metodo para las salidas CuantosTacos y CuantasTortas
-Metodo VendiElTripleDeTacos con el texto SI o NO
-El metodo debe llevar la cuenta de cuantos datos y cuantas tortas se vendieron
-----Menu con while----
-Preguntar por cliente cantidad de tacos y tortas
-Despues de finalizar, preguntar por si hay mas venta que agregar

------------------------
En el registro de venta ingresara los valores de cada uno de los pedidos en donde
se almacenara los datos

En cuantos tacos y tortas se mostrara la cantidad de ventas de manera acumulativa

En triple de tacos si se vendio el triple o no
*/