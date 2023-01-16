using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_Interface_com_Animais
{
        class Animal
        {
            public string Nome { get; set; }
            public string DataDeNasc { get; set; }
            public char Sexo { get; set; }
            public int Idade { get; set; }

            public void Movimentar()
            {
                Console.WriteLine("Eu consigo me movimentar");
            }
            public void Comunicar()
            {
                Console.WriteLine("Eu consigo me comunicar");
            }
            public void Alimentar()
            {
                Console.WriteLine("Eu consigo me alimentar");
            }
            public bool Carnivoro()
            {
                return true;
            }
            public bool Peçonhento()
            {
                return false;
            }
        }

        internal class Mamifero : Animal
        {
            public int QtdDeMamas { get; set; }
            public bool Pelos { get; set; }
            public string CorDoPelo { get; set; }
            public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Amamentar()
            {
                Console.WriteLine("Eu amamento");
            }

        }
        abstract class Reptil : Animal
        {
            public bool TemEscamas { get; set; }
            public bool TemCasco { get; set; }
            public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        abstract class Ave : Animal
        {
            public bool Rapina { get; set; }
            public bool CorPena { get; set; }
            public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Ciscar()
            {
                Console.WriteLine("Eu cisco");
            }

        }
 }


