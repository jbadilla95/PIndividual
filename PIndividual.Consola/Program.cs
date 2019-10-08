using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIndividual.DAL;
using PIndividual.BL;


namespace PIndividual.PruebasConsola
{
    class Program
    {

        static void Main(string[] args)
        {
            Prueba pru = new Prueba();
            pru.AgregarAviones();
            //pru.AgregarPasajeros();
            //pru.Agregarvuelo();

            //Pruebas p = new Pruebas();
            //p.UpdateVuelo();
        }

    }
}
