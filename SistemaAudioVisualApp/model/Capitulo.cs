using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAudioVisualApp.model
{
    public class ICapitulo
    {
        public string capitulo { get; set; }
        public int nroCapitulo { get; set; }
        public int duracion { get; set; }

        public ICapitulo(string capitulo, int nroCapitulo, int duracion)
        {
            this.capitulo = capitulo;
            this.nroCapitulo = nroCapitulo;
            this.duracion = duracion;
        }

        public int calcularDuracion()
        {
            return duracion;
        }
    }
}
