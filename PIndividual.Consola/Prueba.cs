using PIndividual.BL;
using PIndividual.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.PruebasConsola
{
    class Prueba
    {
        Pruebas bl = new Pruebas();

        public void Agregarvuelo()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                var v1 = new Vuelos();
                v1.Duracion = 0;
                v1.Escala = "s";
                v1.Round_trip = true;
                v1.Tipo = "s";
                bl.AddVuelo(v1);
            }

        }
        public void AgregarAviones()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                var A1 = new Aviones();
                A1.Asientos = "0";
                A1.Cantidad = 0;
                A1.Modelo = "ABC";
                bl.AddAvion(A1);
            }

        }
        public void AgregarPasajeros()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                var P1 = new Pasajeros();
                P1.Id_vuelo = 0;
                P1.Apellidos = "Badilla";
                P1.Nombre = "Jeison";
                P1.Pasaporte = 23;
                P1.Visa = 111;
                bl.AddPasajero(P1);
            }

        }
    }

}
