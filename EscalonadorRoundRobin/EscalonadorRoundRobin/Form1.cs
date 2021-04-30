using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Escalonador;
using System.Timers;

namespace EscalonadorRoundRobin
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer tmrClock;
        private System.Timers.Timer tmrCriaProcessos;

        //CPU Cpu;

        private int TempoCloc = 1000;
        private int TempoMaximoProcesso = 0;
        private int PercentualIO = 0;

        public Processo EmExecucao;
        List<Processo> ListaFila = new List<Processo>();
        List<Processo> ListaFilaEsperaIO = new List<Processo>();

        int Quantum = 0;
        int QuantumInterno = 0;
        
        public Form1()
        {
            InitializeComponent();

            tmrClock = new System.Timers.Timer();
            tmrClock.Elapsed += new ElapsedEventHandler(ClockTic);
            
            tmrCriaProcessos = new System.Timers.Timer();
            tmrCriaProcessos.Elapsed += new ElapsedEventHandler(CriaProcessosTic);

            txtQuantum.Text = "5";
            txtProcessosMinuto.Text = "15";
            txtTempoVidaProcesso.Text = "20";
            txtPercentualIO.Text = "50";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrClock.Stop();
            tmrCriaProcessos.Stop();
            tmrClock.Dispose();
            tmrCriaProcessos.Dispose();
        }

        delegate void InsereItemCallback(string Texto);

        private void InsereItemTabela(string Texto)
        {
            if (this.tblProcessos.InvokeRequired)
            {
                InsereItemCallback d = new InsereItemCallback(InsereItemTabela);
                this.Invoke(d, new object[] { Texto });
            }
            else
            {
                this.tblProcessos.Items.Add(Texto);
            }
        }

        delegate void RemoveItemCallback();

        private void RemoveItem()
        {
            if (this.tblProcessos.InvokeRequired)
            {
                RemoveItemCallback d = new RemoveItemCallback(RemoveItem);
                this.Invoke(d, new object[] { });
            }
            else
            {
                if (this.tblProcessos.Items.Count > 0)
                    this.tblProcessos.Items.RemoveAt(0);
            }
        }

        delegate void SetEmExecucaoCallback(string Texto);

        private void SetarEmExecucao(string Texto)
        {
            if (this.lblProcessoExecucao.InvokeRequired)
            {
                SetEmExecucaoCallback d = new SetEmExecucaoCallback(SetarEmExecucao);
                this.Invoke(d, new object[] { Texto });
            }
            else
            {
                this.lblProcessoExecucao.Text = Texto;
            }
        }

        delegate void InsereItemTabelaEsperaIOCallback(string Texto);

        private void InsereItemTabelaEsperaIO(string Texto)
        {
            if (this.tblProcessos.InvokeRequired)
            {
                InsereItemTabelaEsperaIOCallback d = new InsereItemTabelaEsperaIOCallback(InsereItemTabelaEsperaIO);
                this.Invoke(d, new object[] { Texto });
            }
            else
            {
                this.tblProcessosIO.Items.Add(Texto);
            }
        }

        delegate void RemoveItemEsperaIOCallback(int Posicao);

        private void RemoveItemEsperaIO(int Posicao)
        {
            if (this.tblProcessosIO.InvokeRequired)
            {
                RemoveItemEsperaIOCallback d = new RemoveItemEsperaIOCallback(RemoveItemEsperaIO);
                this.Invoke(d, new object[] { Posicao });
            }
            else
            {
                if (this.tblProcessosIO.Items.Count > 0)
                    this.tblProcessosIO.Items.RemoveAt(Posicao);
            }
        }

        private void AtualizaEmExecucao()
        {
            if (EmExecucao != null)
            {
                SetarEmExecucao("PID = " + EmExecucao.PId + " TEMPO: " + EmExecucao.Tempo + " " + EmExecucao.Tipo.ToString());
            }
            else
            {
                SetarEmExecucao("");
            }
        }

        private void ClockTic(object sender, ElapsedEventArgs e)
        {
            Clock();
        }

        private void CriaProcessosTic(object sender, ElapsedEventArgs e)
        {
            Processo NovoProcesso = new Processo();
            
            Random random = new Random();

            NovoProcesso.Tempo = random.Next(1, TempoMaximoProcesso);

            if (random.Next(0, 100) <= PercentualIO)
            {
                NovoProcesso.Tipo = Processo.Tipos.IOBound;
                NovoProcesso.TempoIO = random.Next(2, 10);
                NovoProcesso.EntrarEmIO = random.Next(1, 10);
            }

            Insere(NovoProcesso);
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            tmrClock.Interval = TempoCloc;
            double Quantidade = 60;

            try
            {
                Quantidade = double.Parse(txtProcessosMinuto.Text) - 1;
                tmrCriaProcessos.Interval = (60 / Quantidade) * 1000;
            }
            catch (Exception)
            {
                Quantidade = 60;
            }

            try
            {
                Quantum = int.Parse(txtQuantum.Text);
                QuantumInterno = Quantum;
            }
            catch { }

            try
            {
                TempoMaximoProcesso = int.Parse(txtTempoVidaProcesso.Text);
            }
            catch { }

            try
            {
                PercentualIO = int.Parse(txtPercentualIO.Text);
            }
            catch { }

            CriaProcessosTic(null, null);

            tmrClock.Start();
            tmrCriaProcessos.Start();
        }

        private void btParar_Click(object sender, EventArgs e)
        {
            tmrClock.Stop();
            tmrCriaProcessos.Stop();
        }

        public bool Vazia()
        {
            return this.ListaFila.Count == 0;
        }

        public void Insere(Processo Processo)
        {
            this.ListaFila.Add(Processo);
            InsereItemTabela(String.Format("Processo {0:D3} - {1} - {2}", Processo.PId, Processo.Tempo, Processo.Tipo.ToString()));
        }

        public void InsereEsperaIO(Processo Processo)
        {
            this.ListaFilaEsperaIO.Add(Processo);
            InsereItemTabelaEsperaIO(String.Format("Processo {0:D3} - {1} - {2}", Processo.PId, Processo.Tempo, Processo.Tipo.ToString()));
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
                RemoveItem();
                return Retorno;
            }
        }

        public void Clock()
        {
            if (EmExecucao == null)
            {
                EmExecucao = PegaProximo();
                if (EmExecucao == null)
                {
                    return;
                }
            }

            EmExecucao.Tempo--;
            if (EmExecucao.Tempo <= 0)
            {
                EmExecucao = null;
                QuantumInterno = Quantum;
                AtualizaEmExecucao();
                //return;
            }

            QuantumInterno--;
            if (QuantumInterno <= 0)
            {
                Insere(EmExecucao);
                EmExecucao = null;
                QuantumInterno = Quantum;
                AtualizaEmExecucao();
            }

            if (EmExecucao != null && EmExecucao.EntraIO())
            {
                InsereEsperaIO(EmExecucao);
                EmExecucao = null;
            }

            for (int i = 0; i < ListaFilaEsperaIO.Count; i++)
            {
                ListaFilaEsperaIO[i].TempoIO--;
                if (ListaFilaEsperaIO[i].TempoIO <= 0)
                {
                    Insere(ListaFilaEsperaIO[i]);
                    ListaFilaEsperaIO.RemoveAt(i);
                    RemoveItemEsperaIO(i);
                }
            }

            AtualizaEmExecucao();
        }
    }
}
