using System;
using System.IO;

namespace AjustesProcesos{
    public class Program{
        public static void Main(string[] args){
        string rutaArchivo = "Procesos.txt";    
        string[] vectorNombreProceso = new string[100];  
        int[] vectorTiempoLlegada = new int[100];
        int[] vectorTiempoEjecucion = new int[100];
        int[] vectorPesoProceso = new int[100];
            try{

                int indice = 0;  
                using (StreamReader sr = new StreamReader(rutaArchivo)){
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
                    Console.WriteLine($"Proceso: {vectorNombreProceso[i]}, Llegada: {vectorTiempoLlegada[i]}, Ejecución: {vectorTiempoEjecucion[i]}, Peso: {vectorPesoProceso[i]}");
                }
            }
            catch (Exception e){
                Console.WriteLine($"Error al leer el archivo: {e.Message}");
            }

        }
    }
}
