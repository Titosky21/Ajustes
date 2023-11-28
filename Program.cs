using System;
using System.IO;

namespace AjustesProcesos{
    public class Program{
        public static void Main(string[] args){
        string rutaArchivo = "Procesos.txt";    
        string rutaArchivo2 = "Procesos1.txt";
        string file = " ";
        string[] vectorNombreProceso = new string[100];  
        int[] vectorTiempoLlegada = new int[100];
        int[] vectorTiempoEjecucion = new int[100];
        int[] vectorPesoProceso = new int[100];
        
        bool flag = true;
        int opcion = 0;
        while(flag){
            System.Console.WriteLine($"Procesos.txt funciona para Primer Ajuste");
            System.Console.WriteLine($"Procesos1.txt funciona para Peor Ajuste");
            System.Console.WriteLine("¿Que archivo desea abrir?:");
            System.Console.WriteLine("1) Procesos.txt 2) Procesos1.txt");
            System.Console.Write("Opcion:");
            
            
            opcion = System.Convert.ToInt32(System.Console.ReadLine());
            if(opcion != 1 || opcion != 2){
                flag = true;
            }
            if(opcion == 1){
                file = rutaArchivo;
                flag = false;
            }
            if(opcion == 2){
                file = rutaArchivo2;
                flag = false;
            }
            if(opcion == 3){
                System.Console.WriteLine("Cerrando Programa...");
                flag = false;
            }
        
            try{

                int indice = 0;  
                using (StreamReader sr = new StreamReader(file)){
                    string linea;

                    while ((linea = sr.ReadLine()) != null){
                        string[] columnas = linea.Split(',');

                        vectorNombreProceso[indice] = columnas[0];
                        vectorTiempoLlegada[indice] = int.Parse(columnas[1]);
                        vectorTiempoEjecucion[indice] = int.Parse(columnas[2]);
                        vectorPesoProceso[indice] = int.Parse(columnas[3]);

                        indice++;
                    }
                }

                for (int i = 0; i < indice; i++){
                    Console.WriteLine($"Proceso: {vectorNombreProceso[i]}, Llegada: {vectorTiempoLlegada[i]}, Ejecución: {vectorTiempoEjecucion[i]}, Peso: {vectorPesoProceso[i]}kb");
                }
            }
            catch (Exception e){
                Console.WriteLine($"Error al leer el archivo: {e.Message}");
            }

            if(opcion == 1){
                PrimerAjuste PrimerA = new PrimerAjuste(vectorNombreProceso, vectorTiempoLlegada, vectorTiempoEjecucion, vectorPesoProceso);
                PrimerA.GenerarAjuste();

                System.Console.WriteLine("1) Procesos.txt 2) Procesos1.txt");
                System.Console.Write("Probar Otro Archivo:");
                opcion = System.Convert.ToInt32(System.Console.ReadLine());
                if(opcion == 3){
                    System.Console.WriteLine("Cerrando Programa...");
                    flag = false;
                }
            }
            if(opcion == 2){
                PeorAjuste PeorA = new PeorAjuste(vectorNombreProceso, vectorTiempoLlegada, vectorTiempoEjecucion, vectorPesoProceso);
                PeorA.GenerarAjuste();

                System.Console.WriteLine("1) Procesos.txt 2) Procesos1.txt");
                System.Console.Write("Probar Otro Archivo:");
                opcion = System.Convert.ToInt32(System.Console.ReadLine());
                if(opcion == 3){
                    System.Console.WriteLine("Cerrando Programa...");
                    flag = false;
                }
            }
        }
        }
    }
}

