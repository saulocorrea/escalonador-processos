using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escalonador
{
    public class Processo
    {
        #region Propriedades
        public enum Tipos {
            IOBound = 1,
            CPUBound = 2
        }

        private static int PID = 0;
        private int _Tempo;
        private int _PId;
        private Tipos _Tipo;
        private int _TempoIO;
        private int _TempoIOInterno;
        private int _EntrarEmIO; // numero de clock que vai entrar em IO

        public int Tempo
        {
            get { return _Tempo; }

            set
            {
                if (value > 0)
                {
                    _Tempo = value;
                }
                else
                {
                    _Tempo = 0;
                }
                if (_TempoIOInterno == 0)
                {
                    _TempoIOInterno = _Tempo;
                }
            }
        }

        public int PId
        {
            get { return _PId; }
        }

        public Tipos Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public int TempoIO
        {
            get { return _TempoIO; }
            set { _TempoIO = value; }
        }

        public int EntrarEmIO
        {
            get { return _EntrarEmIO; }
            set { _EntrarEmIO = value; }
        }
        #endregion

        #region Métodos
        public Processo()
        {
            PID++;
            this._PId = PID;
            this._Tempo = 0;
            this._Tipo = Tipos.CPUBound;
        }
        public Processo(int Tempo)
        {
            PID++;
            this._PId = PID;
            this._Tempo = Tempo;
            this._Tipo = Tipos.CPUBound;
        }
        public bool EntraIO()
        {
            return this._Tipo == Tipos.IOBound && (this._TempoIOInterno == (this._Tempo + this._EntrarEmIO));
        }
        #endregion

    }
}
