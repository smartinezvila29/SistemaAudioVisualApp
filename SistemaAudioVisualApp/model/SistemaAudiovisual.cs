using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAudioVisualApp.model
{
    public class SistemaAudiovisual
    {
        public List<IAudiovisual> lstAudiovisual { get; set; }

        public bool agregarAudiovisual(string codAudiovisual, string audiovisual, int anio, bool estreno, string genero, int duracion)
        {
            lstAudiovisual.Add(new Pelicula(codAudiovisual, audiovisual, anio, estreno, genero, duracion));
            return true;
        }

        public bool agregarAudiovisual(string codAudiovisual, string audiovisual, int anio, bool estreno, string genero, bool capitulosUnitarios)
        {
            lstAudiovisual.Add(new Serie(codAudiovisual, audiovisual, anio, estreno, genero, capitulosUnitarios));
            return true;
        }
        public bool agregarCapitulo(string capitulo, int nroCapitulo, int duracion, Serie serie)
        {
            Serie _serie = (Serie)traerAudiovisual(serie.codAudiovisual);
            _serie.lstCapitulos.Add(new ICapitulo(capitulo, nroCapitulo, duracion));
            return true;
        }

        public IAudiovisual traerAudiovisual(string audiovisual)
        {
            return lstAudiovisual.Where(x => x.codAudiovisual.Equals(audiovisual)).FirstOrDefault();
        }

    }
}
