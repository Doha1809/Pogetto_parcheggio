using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Park
    {
        public int Num_posti;
        public int Numero_ingressi;
        public int numero_uscita;
        public List<Auto> Auto_parcheggiate=new List<Auto>();
        Semaphore semaforo= new Semaphore(1,1);
        public Park(int Num_posti, int Numero_ingressi, int numero_uscita) 
        {
            this.Num_posti = Num_posti;
            this.Numero_ingressi = Numero_ingressi;
            this.numero_uscita=numero_uscita;
        }
        public void Parcheggiare(Auto auto)
        {
            Auto_parcheggiate.Add(auto);
            Console.WriteLine("Auto parcheggiata");
        }
        public void Richiesta(Auto auto)
        {
            Console.WriteLine("Voglio parcheggiare. Aspetto in coda");
            semaforo.WaitOne();
            Parcheggiare(auto);


        }
    }
}
