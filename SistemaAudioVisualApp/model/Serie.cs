using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAudioVisualApp.model
{
    public class Serie : IAudiovisual
    {
        private string audiovisual;
        public bool capitulosUnitarios { get; set; }
        public List<ICapitulo> lstCapitulos { get; set; }

        public Serie(string codAudiovisual, string audiovisual, int anio, bool estreno, string genero, bool capitulosUnitarios)
        {
            this.codAudiovisual = codAudiovisual;
            this.audiovisual = audiovisual;
            this.anio = anio;
            this.estreno = estreno;
            this.genero = genero;
            this.capitulosUnitarios = capitulosUnitarios;
        }

        public int calcularDuracion()
        {
            int suma = 0;
            foreach (var cap in lstCapitulos)
            {
                suma = suma + cap.duracion;
            }
            return suma;
        }
    }
}
