using System.Threading;

namespace Entidades
{
    public delegate void NotificarCambio(string mensaje);
    public sealed class TiempoLlamada
    {
        public event NotificarCambio OnNotificar;

        public TiempoLlamada()
        {

        }

        /// <summary>
        /// Metodo que se va a subscribir al evento que funciona como cronometro de la llamada, que estará en un hilo secundario.
        /// </summary>
        /// <param name="cancel"></param>
        public void IniciarLlamada(CancellationTokenSource cancel)
        {
            int hora = 0;
            int minutos = 0;
            int segundos = 0;
            while (!cancel.IsCancellationRequested)
            {
                segundos += 1;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos += 1;//60000
                }
                if (minutos == 60)
                {
                    minutos = 0;
                    hora += 1;//3600000
                }
                Thread.Sleep(1000);
                if (this.OnNotificar is not null)
                {
                    this.OnNotificar.Invoke($"{hora} : {minutos} : {segundos}");
                } 
            }
        }
    }
}
