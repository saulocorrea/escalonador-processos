using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escalonador
{
    public class Fila
    {
        List<Processo> ListaFila = new List<Processo>();

        public bool Vazia()
        {
            return this.ListaFila.Count == 0;
        }

        public void Insere(Processo Processo)
        {
            this.ListaFila.Add(Processo);
        }

        public Processo PegaProximo()
        {
            if (this.ListaFila.Count == 0)
            {
                return null;
            }
            else
            {
                Processo Retorno = this.ListaFila[0];
                this.ListaFila.RemoveAt(0);
                return Retorno;
            }
        }

        public List<Processo> ListaProcessos()
        {
            return this.ListaFila;
        }
    }
}
