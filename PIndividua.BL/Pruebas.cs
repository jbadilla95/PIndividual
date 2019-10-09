using PIndividual.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.BL
{
    public class Pruebas
    {
        public void AddVuelo(Vuelos v1)
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {

                context.Vuelos.Add(v1);
                context.SaveChanges();
            }
        }
        public void AddAvion(Aviones A1)
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                context.Aviones.Add(A1);
                context.SaveChanges();
            }
        }
        public void AddPasajero(Pasajeros P1)
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                context.Pasajeros.Add(P1);
                context.SaveChanges();
            }
        }


        public void UpdateVuelo()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {

                    var vuelo = context.Vuelos.Where(x => x.Id_vuelo == 1).SingleOrDefault();
                    vuelo.Escala = "Actualizado";

                    //context.Entry(vuelo).State = System.Data.Entity.EntityState.Modified; // le estoy diciendo al entity que fue cambiado 

                    context.SaveChanges(); // cambio
                }
                catch (Exception exp)
                {
                    Console.WriteLine("ERROR:  " + exp.Message);
                }
            }
        }
    }
}
