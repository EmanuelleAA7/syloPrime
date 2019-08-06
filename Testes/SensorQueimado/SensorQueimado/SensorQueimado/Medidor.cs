using System;
using System.Collections.Generic;
using System.Text;

namespace SensorQueimado
{
    class Medidor
    {
        public Medidor() { }
        public string Temperatura { get; set; }
        public string Umidade { get; set; }
        
        public Medidor(string temperatura, string umidade)
        {
            this.Temperatura = temperatura;
            this.Umidade = umidade;
        }
    }
}
