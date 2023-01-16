using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_Interface_com_Animais
{
        public abstract class Animal
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
            public bool Carnivoro(string carn)
            {
            if (carn == "sim")
            {
                return true;
            }
            return false;

            }
            public bool Peçonhento(string peç)
            {
            if (peç == "sim")
            {
                return true;
            }
            return false;

        }
    }

        public abstract class Mamifero : Animal
        {
            public int QtdDeMamas { get; set; }
            public bool Pelos { get; set; }
            public string CorDoPelo { get; set; }

            public void Amamentar()
            {
                Console.WriteLine("Eu amamento");
            }

        }
        public abstract class Reptil : Animal
        {
            public bool TemEscamas { get; set; }
            public bool TemCasco { get; set; }
        }
        public abstract class Ave : Animal
        {
            public bool Rapina { get; set; }
            public bool CorPena { get; set; }
            public void Ciscar()
            {
                Console.WriteLine("Eu cisco");
            }

        }
 }


