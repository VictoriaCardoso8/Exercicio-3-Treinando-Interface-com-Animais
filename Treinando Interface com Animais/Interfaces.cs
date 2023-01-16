using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_Interface_com_Animais
{
        interface IOviparo
        {
            public void Botar()
            {
                Console.WriteLine("Eu boto ovo");
            }
            public void Chocar()
            {
                Console.WriteLine("Eu choco ovo");
            }
        }
        interface IVoar
        {
            public void Voar()
            {
                {
                    Console.WriteLine("Eu consigo voar");
                }
            }
            public int AltitudeMaximaEmMetros { get; set; }
            public double VelocidadeDoVoo { get; set; }
        }
        interface IAquatico
        {
            public bool ViveEmTerra { get; set; }
            public bool Mergulho { get; set; }
            public bool AguaDoce { get; set; }
        }
 }


