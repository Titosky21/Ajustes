using System;


namespace AjustesProcesos{
    class PeorAjuste : Ajustes{
        public PeorAjuste(string[] idProceso, int[] tiempoLlegada, int[] tiempoEjecucion, int[] pesoProceso) : base(idProceso, tiempoLlegada, tiempoEjecucion, pesoProceso){

        } 

        public override void MostrarInformacion(){
            System.Console.WriteLine("sss");
        }

        public void GenerarAjuste(){
            int[] memoria = base.ObtenerMemoria;
            int[] tiempoLL = base.TiempoLlegada;
            int[] tiempoE = base.TiempoEjecucion;
            int[] pesosP = base.PesoProceso;
            string[] nombresP = base.IdProceso;

            int capacidadMemoria = 100;
            int capacidadRestante = 0;
            int suma = 0;
            int tiempo = 1;
        
            while(tiempo <= 14){
                switch(tiempo){
                    case 1:
                        System.Console.WriteLine("Tiempo 1");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[0]}");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[1]}");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[2]}");
                        memoria[0] = pesosP[0] / 4;
                        memoria[1] = pesosP[0] / 4;
                        memoria[2] = pesosP[0] / 4;
                        memoria[3] = pesosP[0] / 4;
                        memoria[4] = pesosP[1] / 2;
                        memoria[5] = pesosP[1] / 2;
                        memoria[6] = pesosP[2] / 4;
                        memoria[7] = pesosP[2] / 4;
                        memoria[8] = pesosP[2] / 4;
                        memoria[9] = pesosP[2] / 4;
                        for(int i = 0; i < memoria.Length; i ++){
                            suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");

                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 2:
                        System.Console.WriteLine("Tiempo 2");
                        System.Console.WriteLine($"Termina el proceso: {nombresP[0]}");

                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 3:
                        System.Console.WriteLine("Tiempo 3");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[3]}");
                        memoria[0] = 0;
                        memoria[1] = 0;
                        memoria[2] = 0;
                        memoria[3] = 0;
                        memoria[0] = pesosP[3];
                        
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 4:
                        System.Console.WriteLine("Tiempo 4");
                        System.Console.WriteLine($"Termina el poceso: {nombresP[3]}");
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 5:
                        System.Console.WriteLine("Tiempo 5");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[4]}");
                        System.Console.WriteLine($"Termina el proceso: {nombresP[1]}");
                        memoria[0] = 0;
                        memoria[0] = pesosP[4] / 4;
                        memoria[1] = pesosP[4] / 4;
                        memoria[2] = pesosP[4] / 4;
                        memoria[3] = pesosP[4] / 4;
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 6:
                        System.Console.WriteLine("Tiempo 6");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[5]}");
                        System.Console.WriteLine($"Termina el proceso: {nombresP[2]}");
                        memoria[4] = 0;
                        memoria[5] = 0;
                        memoria[4] = pesosP[5];
                        
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 7:
                        System.Console.WriteLine("Tiempo 7");
                        System.Console.WriteLine($"Llega le proceso: {nombresP[6]}");
                        System.Console.WriteLine($"Termina el proceso: {nombresP[4]}");
                        memoria[0] = pesosP[4] / 4;
                        memoria[1] = pesosP[4] / 4;
                        memoria[2] = pesosP[4] / 4;
                        memoria[3] = pesosP[4] / 4;
                        memoria[5] = pesosP[6] / 4;
                        memoria[6] = pesosP[6] / 4;
                        memoria[7] = pesosP[6] / 4;
                        memoria[8] = pesosP[6] / 4;
                        memoria[9] = 0;

                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 8:
                        System.Console.WriteLine("Tiempo 8");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[7]}");
                        memoria[0] = 0;
                        memoria[1] = 0;
                        memoria[2] = 0;
                        memoria[3] = 0; 
                        memoria[0] = pesosP[7] / 2;
                        memoria[1] = pesosP[7] / 2;

                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 9:
                        System.Console.WriteLine("Tiempo 9");
                        System.Console.WriteLine($"Termina el proceso: {nombresP[7]}");
                        System.Console.WriteLine($"Termina le proceso: {nombresP[5]}");

                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 10:
                        System.Console.WriteLine("Tiempo 10");
                        System.Console.WriteLine($"Llega el proceso: {nombresP[8]}");
                        memoria[0] = pesosP[8] / 4;
                        memoria[1] = pesosP[8] / 4;
                        memoria[2] = pesosP[8] / 4;
                        memoria[3] = pesosP[8] / 4;
                        memoria[4] = 0;
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 11:
                        System.Console.WriteLine("Tiempo 11");
                        System.Console.WriteLine($"Termina el proceso: {nombresP[6]}");
                        memoria[5] = 0;
                        memoria[6] = 0;
                        memoria[7] = 0;
                        memoria[8] = 0;

                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 12:
                        System.Console.WriteLine("Tiempo 12");
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 13:
                        System.Console.WriteLine("Tiempo 13");
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 14:
                        System.Console.WriteLine("Tiempo 14");
                        System.Console.WriteLine($"Termina el proceso: {nombresP[8]}");
                        memoria[0] = 0;
                        memoria[1] = 0;
                        memoria[2] = 0;
                        memoria[3] = 0;

                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Memoria Restante:" + capacidadRestante + " kb");
                        System.Console.WriteLine(" ");
                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                } 
                tiempo = tiempo + 1;
            }
            System.Console.WriteLine("Todos los Procesos Terminaron Correctamente.");
        }

        private void Mostrar(int[] vector){
            System.Console.Write("[ ");
            for(int i = 0; i < vector.Length; i++){
                System.Console.Write($"{vector[i]}  ");
            }
            System.Console.WriteLine("]");
            System.Console.WriteLine(" ");
        }
    }
}
