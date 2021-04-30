using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Escalonador
{
    public class CPU
    {
        private int _Quantum;
        private int _QuantumInterno;
        public Fila Fila = new Fila();

        public Processo EmExecucao;
        
        public int Quantum
        {
            get { return _Quantum; }
            set { _Quantum = value; }
        }

        public CPU()
        {
            _QuantumInterno = _Quantum;
            _Quantum = 5;
        }

        public void Clock()
        {
            if (EmExecucao == null)
            {
                EmExecucao = Fila.PegaProximo();
                if (EmExecucao == null)
                {
                    return;
                }
            }

            EmExecucao.Tempo--;
            if (EmExecucao.Tempo <= 0)
            {
                EmExecucao = null;
                _QuantumInterno = _Quantum;
                //return;
            }

            _QuantumInterno--;
            if (_QuantumInterno <= 0)
            {
                Fila.Insere(EmExecucao);
                EmExecucao = null;
                _QuantumInterno = _Quantum;
            }
        }
    }
}
