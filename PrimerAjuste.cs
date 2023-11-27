using System;


namespace AjustesProcesos{
    class PrimerAjuste : Ajustes{
        public PrimerAjuste(string[] idProceso, int[] tiempoLlegada, int[] tiempoEjecucion, int[] pesoProceso) : base(idProceso, tiempoLlegada, tiempoEjecucion, pesoProceso){

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
        
            while(tiempo <= 10){
                switch(tiempo){
                    case 1:
                        System.Console.WriteLine("Tiempo 1");

                        for(int i = 0; i < 4; i ++){
                            System.Console.WriteLine($"Llega proceso: {nombresP[i]}");
                        }

                        memoria[0] = pesosP[0];
                        memoria[1] = pesosP[1] / 2;
                        memoria[2] = pesosP[1] / 2;
                        memoria[3] = pesosP[2] / 3;
                        memoria[4] = pesosP[2] / 3;
                        memoria[5] = pesosP[2] / 3;
                        memoria[6] = pesosP[3] / 2;
                        memoria[7] = pesosP[3] / 2;

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
                        System.Console.WriteLine($"Termina proceso: {nombresP[0]}");
                        System.Console.WriteLine($"Termina proceso: {nombresP[3]}");
                        System.Console.WriteLine($"Llega proceso: {nombresP[4]}");

                        memoria[0] = 0;
                        memoria[6] = 0;
                        memoria[7] = 0;
                        memoria[6] = pesosP[4] / 2;
                        memoria[7] = pesosP[4] / 2;
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
                        System.Console.WriteLine($"Termina proceso: {nombresP[1]}");
                        System.Console.WriteLine($"Termina proceso: {nombresP[2]}");
                        System.Console.WriteLine($"Llega proceso: {nombresP[5]}");

                        memoria[1] = 0;
                        memoria[2] = 0;
                        memoria[3] = 0;
                        memoria[4] = 0;
                        memoria[5] = 0;
                        memoria[0] = pesosP[5] / 4;
                        memoria[1] = pesosP[5] / 4;
                        memoria[2] = pesosP[5] / 4;
                        memoria[3] = pesosP[5] / 4;

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
                        System.Console.WriteLine($"Llega proceso: {nombresP[6]}");
                        memoria[4] = pesosP[6] / 2;
                        memoria[5] = pesosP[6] / 2;

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
                        System.Console.WriteLine($"Termina proceso: {nombresP[5]}");
                        System.Console.WriteLine($"Llega proceso: {nombresP[7]}");

                        memoria[0] = 0;
                        memoria[1] = 0;
                        memoria[2] = 0;
                        memoria[3] = 0;
                        memoria[0] = pesosP[7] / 4;
                        memoria[1] = pesosP[7] / 4;
                        memoria[2] = pesosP[7] / 4;
                        memoria[3] = pesosP[7] / 4;

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
                        System.Console.WriteLine($"Llega proceso: {nombresP[8]}");
                        memoria[8] = pesosP[8];
                        
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
                        System.Console.WriteLine($"Termina proceso: {nombresP[7]}");
                        System.Console.WriteLine($"Termina proceso: {nombresP[8]}");

                        memoria[0] = 0;
                        memoria[1] = 0;
                        memoria[2] = 0;
                        memoria[3] = 0;
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
                    case 8:
                        System.Console.WriteLine("Tiempo 8");
                        System.Console.WriteLine($"Termina proceso: {nombresP[4]}");

                        memoria[6] = 0;
                        memoria[7] = 0;

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
                        System.Console.WriteLine($"Termina proceso: {nombresP[6]}");
                        memoria[4] = 0;
                        memoria[5] = 0;

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
