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

            int capacidadMemoria = 100;
            int capacidadRestante = 0;
            int suma = 0;
            int tiempo = 1;
        
            while(tiempo <= 10){
                switch(tiempo){
                    case 1:
                        System.Console.WriteLine("Tiempo 1");

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
                        System.Console.WriteLine("Restantes:" + capacidadRestante);

                        suma = 0;
                        capacidadRestante = 0;
                        Mostrar(memoria);
                        break;
                    case 2:
                        System.Console.WriteLine("Tiempo 2");
                        memoria[0] = 0;
                        memoria[6] = 0;
                        memoria[7] = 0;
                        memoria[6] = pesosP[4] / 2;
                        memoria[7] = pesosP[4] / 2;
                        for(int i = 0; i < memoria.Length; i ++){
                           suma = suma + memoria[i];
                        }
                        capacidadRestante = capacidadMemoria - suma;
                        System.Console.WriteLine("Restantes:" + capacidadRestante);
                        Mostrar(memoria);
                        break;
                    case 3:
                        System.Console.WriteLine("Tiempo 3");
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
                        System.Console.WriteLine("Restantes:" + capacidadRestante);
                        Mostrar(memoria);
                        break;
                    case 4:
                        System.Console.WriteLine("Tiempo 4");

                } 
                tiempo = tiempo + 1;
            }

        }

        private void Mostrar(int[] vector){
            System.Console.Write("[ ");
            for(int i = 0; i < vector.Length; i++){
                System.Console.Write($"{vector[i]}  ");
            }
            System.Console.WriteLine("]");
        }
    }
}
