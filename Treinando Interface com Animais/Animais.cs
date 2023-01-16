using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_Interface_com_Animais
{
    public class Chacal : Mamifero
    {
        public Chacal(string nome, string dataDeNascimento, char sexo, string corDoPelo)
        { 
            this.Nome= nome;
            this.Peçonhento("não");
            this.DataDeNasc= dataDeNascimento;
            this.Sexo= sexo;
            this.Pelos = true;
            this.CorDoPelo = corDoPelo;
            this.Alimentar();
            this.Amamentar();
            this.Carnivoro("sim");
            this.Comunicar();
            this.Movimentar();
        }

    }

    public class Leao : Mamifero
    {
        public Leao(string nome, string dataDeNascimento, char sexo, string corDoPelo)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Pelos = true;
            this.CorDoPelo = corDoPelo;
            this.Alimentar();
            this.Amamentar();
            this.Carnivoro("sim");
            this.Comunicar();
            this.Movimentar();
        }

    }

    public class Morcego : Mamifero, IVoar
    {
        public Morcego (string nome, string dataDeNascimento, char sexo, string corDoPelo)
        {
            this.Nome = nome;
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Pelos = true;
            this.CorDoPelo = corDoPelo;
            this.Peçonhento("não");
            this.Alimentar();
            this.Amamentar();
            this.Carnivoro("não");
            this.Comunicar();
            this.Movimentar();
            this.AltitudeMaximaEmMetros = 200;
            this.VelocidadeDoVoo = 50;
        }

        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Cisne : Ave, IOviparo, IVoar, IAquatico
    {
        public Cisne(string nome, string dataDeNascimento, char sexo, bool corDaPena)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Ciscar();
            this.Alimentar();
            this.CorPena = corDaPena;
            this.Rapina = false;
            this.Carnivoro("não");
            this.Comunicar();
            this.Movimentar();
            this.AltitudeMaximaEmMetros = 150;
            this.Rapina = false;
            this.VelocidadeDoVoo= 30;
            this.ViveEmTerra = true;
            this.Mergulho = false;            
        }

        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Arara : Ave, IOviparo, IVoar
    {
        public Arara(string nome, string dataDeNascimento, char sexo, bool corDaPena)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Ciscar();
            this.Alimentar();
            this.CorPena = corDaPena;
            this.Rapina = false;
            this.Carnivoro("não");
            this.Comunicar();
            this.Movimentar();
            this.AltitudeMaximaEmMetros = 20;
            this.Rapina = false;
            this.VelocidadeDoVoo = 5;
        }

        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class DragaoDeKomodo : Reptil, IOviparo
    {
        public DragaoDeKomodo(string nome, string dataDeNascimento, char sexo)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Alimentar();
            this.Carnivoro("sim");
            this.Comunicar();
            this.Movimentar();
            this.TemCasco = false;
            this.TemEscamas= true;
        }

    }
    public class Lontra : Mamifero
    {
        public Lontra(string nome, string dataDeNascimento, char sexo, string corDoPelo)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Pelos = true;
            this.CorDoPelo = corDoPelo;
            this.Alimentar();
            this.Amamentar();
            this.Carnivoro("não");
            this.Comunicar();
            this.Movimentar();
        }

    }
    public class Pinguim : Ave, IOviparo, IAquatico
    {
        public Pinguim(string nome, string dataDeNascimento, char sexo, bool corDaPena)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Ciscar();
            this.Alimentar();
            this.CorPena = corDaPena;
            this.Rapina = false;
            this.Carnivoro("não");
            this.Comunicar();
            this.Movimentar();
            this.Rapina = false;
            this.ViveEmTerra = true;
            this.Mergulho = true;
            this.AguaDoce = false;
        }
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Coruja : Ave, IOviparo, IVoar
    {
        public Coruja(string nome, string dataDeNascimento, char sexo, bool corDaPena)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Ciscar();
            this.Alimentar();
            this.CorPena = corDaPena;
            this.Rapina = false;
            this.Carnivoro("não");
            this.Comunicar();
            this.Movimentar();
            this.AltitudeMaximaEmMetros = 80;
            this.Rapina = true;
            this.VelocidadeDoVoo = 20;
        }

        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Elefante : Mamifero
    {
        public Elefante(string nome, string dataDeNascimento, char sexo)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Pelos = false;
            this.Alimentar();
            this.Amamentar();
            this.Carnivoro("não");
            this.Comunicar();
            this.Movimentar();
        }

    }
    public class Jacare : Reptil, IOviparo
    {
        public Jacare(string nome, string dataDeNascimento, char sexo)
        {
            this.Nome = nome;
            this.Peçonhento("não");
            this.DataDeNasc = dataDeNascimento;
            this.Sexo = sexo;
            this.Alimentar();
            this.Carnivoro("sim");
            this.Comunicar();
            this.Movimentar();
            this.TemCasco = false;
            this.TemEscamas = true;
        }

    }

}
