using System;
using System.Collections.Generic;
using DIO_Series.interfaces;

namespace DIO_Series
{
	public class SerieRepositorio : iRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entdade)
        {
            listaSerie[id] = entdade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}