
namespace EjercicioHerencia_Angel
{
    public class OperacionesHerencias : Operaciones
    {
        public void Imprimir()
        {
            Console.WriteLine("Area del cuadrado: " + AreaCuadrado(5));
            Console.WriteLine("Longitud del Circulo: " + LongitudCirculo(3));
            Console.WriteLine("Volumen del cubo: " + VolumenCubo(5));

        }

            

    }
}
