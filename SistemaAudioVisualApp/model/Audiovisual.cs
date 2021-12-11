using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAudioVisualApp.model
{
        public abstract class IAudiovisual
        {
            public string codAudiovisual
            {
                get
                {
                    return codAudiovisual;
                }
                set
                {
                    char[] cod = value.ToCharArray();
                    int sumPosImp = (cod[0] + cod[2] + cod[4]) * 3;
                    int sumPosPar = cod[1] + cod[3] + cod[5];
                    int total = sumPosImp + sumPosPar;
                    int i = 0;
                    var aux = total;
                    while (aux % 10 != 0)
                    {
                        aux = total;
                        i++;
                        aux = aux + i;
                    }
                    if (cod[6] != i) { throw new Exception("El codigo verificador no es igual"); }
                }
            }
            public string titulo { get; set; }
            public int anio { get; set; }
            public bool estreno { get; set; }
            public string genero { get; set; }
        }
}
