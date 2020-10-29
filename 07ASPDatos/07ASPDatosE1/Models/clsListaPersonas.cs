using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _07ASPDatosE1.Models
{
    public class clsListaPersonas
    {

        public List<clsPersona> listaPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>();

            clsPersona p1 = new clsPersona(23, "Francisco", "Márquez", "Sevilla", "654789123");
            clsPersona p2 = new clsPersona(24, "Jose", "Márquez", "Huelva", "674782330");
            clsPersona p3 = new clsPersona(27, "Maria", "Perez", "Cadiz", "687951453");
            clsPersona p4 = new clsPersona(24, "Jose", "Jimenez", "Madrid", "674782330");

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);

            return lista;
        }

    }
}