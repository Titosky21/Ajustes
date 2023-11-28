using System;

namespace AjustesProcesos{
    abstract class Ajustes{
        private string[] idProceso;
        private int[] tiempoLlegada;
        private int[] tiempoEjecucion;
        private int[] pesoProceso;
        private int[] memoria = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        public Ajustes(string[] idProceso, int[] tiempoLlegada, int[] tiempoEjecucion, int[] pesoProceso){
            this.idProceso = idProceso;
            this.tiempoLlegada = tiempoLlegada;
            this.tiempoEjecucion = tiempoEjecucion;
            this.pesoProceso = pesoProceso;
        }

        public int[] ObtenerMemoria{
            get{return memoria;}
        }
        public string[] IdProceso{
            get{return idProceso;}
            set{this.idProceso = value;}
        }

        public int[] TiempoLlegada{
            get{return tiempoLlegada;}
            set{this.tiempoLlegada = value;}
        }

        public int[] TiempoEjecucion{
            get{return tiempoEjecucion;}
            set{this.tiempoEjecucion = value;}
        }

        public int[] PesoProceso{
            get{return pesoProceso;}
            set{this.pesoProceso = value;}
        }

        public abstract void MostrarInformacion();
    }
}
