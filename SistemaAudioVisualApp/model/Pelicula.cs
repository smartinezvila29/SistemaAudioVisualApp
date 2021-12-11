using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAudioVisualApp.model
{
    public class Pelicula : IAudiovisual
    {
        private string audiovisual { get; set; }
        private int duracion { get; set; }

        public Pelicula(string codAudiovisual, string audiovisual, int anio, bool estreno, string genero, int duracion)
        {
            this.codAudiovisual = codAudiovisual;
            this.audiovisual = audiovisual;
            this.anio = anio;
            this.estreno = estreno;
            this.genero = genero;
            this.duracion = duracion;
        }

        public int calcularDuracion()
        {
            return this.duracion;
        }
    }
}
