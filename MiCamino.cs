using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4TT
{
    public class ProfesionalTecnologia
    {
        public string Nombre { get; set; }
        public List<string> Habilidades { get; set; } = new List<string>();
        public List<string> Obstaculos { get; set; } = new List<string>();
        public bool EsReferente { get; protected set; }

        public virtual void Aprender(string habilidad)
        {
            Habilidades.Add(habilidad);
            Console.WriteLine($"{Nombre} ha aprendido {habilidad}.");
        }

        public virtual void EnfrentarObstaculo(string obstaculo)
        {
            Obstaculos.Add(obstaculo);
            Console.WriteLine($"{Nombre} ha enfrentado el obstáculo: {obstaculo}");
        }
    }

    public class MujerEnTecnologia : ProfesionalTecnologia
    {
        public List<string> Valores { get; set; } = new List<string>();
        public List<string> Logros { get; set; } = new List<string>();
        public List<string> GeneracionesImpactadas { get; set; } = new List<string>();

        public MujerEnTecnologia(string nombre)
        {
            Nombre = nombre;
            EsReferente = true;
        }

        public void AbrazarValor(string valor)
        {
            Valores.Add(valor);
            Console.WriteLine($"{Nombre} vive con el valor de: {valor}");
        }

        public void Lograr(string logro)
        {
            Logros.Add(logro);
            Console.WriteLine($"{Nombre} logró: {logro}");
        }

        public void Inspirar(string generacion)
        {
            GeneracionesImpactadas.Add(generacion);
            Console.WriteLine($"{Nombre} ha inspirado a: {generacion}");
        }

        public void CompartirConocimiento()
        {
            Console.WriteLine($"{Nombre} comparte su conocimiento para abrir camino a otras mujeres en tecnología.");
        }
    }

    public class MujerReferente : MujerEnTecnologia
    {
        public List<string> Miedos { get; set; } = new List<string>();
        public List<string> Inseguridades { get; set; } = new List<string>();

        public MujerReferente(string nombre) : base(nombre) { }

        public void IncorporarseAlMundoTecnologico()
        {
            Console.WriteLine($"{Nombre} decide entrar al mundo de la tecnología, motivada por su curiosidad y pasión.");
            Aprender("Conocimiento STEM");
            Aprender("Pensamiento crítico");
            Aprender("Trabajo en equipo");

            Console.WriteLine($"{Nombre} miraba a su alrededor y no veía a nadie como ella.");
            Console.WriteLine("No tenía referentes femeninos en los que reflejarse.");
            Console.WriteLine("A veces pensaba: \"¿Realmente pertenezco a este mundo? ¿Esto es para mí?\"");

            Miedos.Add("Sentirse fuera de lugar");
            Inseguridades.Add("Falta de referentes femeninos");

            EnfrentarObstaculo("Ausencia de modelos a seguir");
        }

        public void SufrirSindromeDelImpostor()
        {
            Inseguridades.Add("No soy lo suficientemente buena");
            Miedos.Add("Ser juzgada");
            Miedos.Add("No estar a la altura");

            Console.WriteLine($"{Nombre} comienza a sentir el síndrome del impostor: duda de sí misma y de su lugar en tecnología.");
        }

        public void EnfrentarMiedosEInseguridades()
        {
            Console.WriteLine($"{Nombre} reconoce sus miedos e inseguridades, pero decide enfrentarlos.");

            foreach (var miedo in Miedos)
            {
                Console.WriteLine($"Enfrenta su miedo: {miedo} y no se detiene.");
            }

            foreach (var inseguridad in Inseguridades)
            {
                Console.WriteLine($"Cuestiona su inseguridad: \"{inseguridad}\" y responde: \"¡Sí pertenezco, sí valgo, y sí puedo!\"");
            }

            Miedos.Clear();
            Inseguridades.Clear();

            AbrazarValor("Confianza");
            Lograr("Reconocer su propio valor");
        }

        public void AlzarLaVozYSerVisible()
        {
            Console.WriteLine($"{Nombre} levanta la cabeza y la voz para decir: \"¡Estoy aquí!\"");
            CompartirConocimiento();
            Inspirar("Nuevas generaciones de mujeres en tecnología");
            Lograr("Convertirse en una voz visible en la industria");
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            MujerReferente protagonista = new MujerReferente("Lucía");

            protagonista.AbrazarValor("Pasión");
            protagonista.AbrazarValor("Curiosidad");
            protagonista.AbrazarValor("Empatía");

            protagonista.IncorporarseAlMundoTecnologico();
            protagonista.SufrirSindromeDelImpostor();
            protagonista.EnfrentarMiedosEInseguridades();
            protagonista.AlzarLaVozYSerVisible();

            Console.WriteLine("\nMensaje final:");
            Console.WriteLine($"{protagonista.Nombre} demuestra que cada mujer que entra al mundo de la tecnología tiene el poder de cambiarlo.");
            Console.WriteLine("Aunque al principio no vea a nadie como ella, puede llegar a ser el referente que ella misma necesitó.");
            Console.WriteLine("Somos esenciales, somos visibles, y estamos aquí para quedarnos.");
        }
    }
}

