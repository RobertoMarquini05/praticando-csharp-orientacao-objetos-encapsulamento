using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    internal class HistoricoMedico
    {
        public string CodigoProntuario { get; private set; }

        public HistoricoMedico(string codigoProntuario)
        {
            CodigoProntuario = codigoProntuario;
        }

        public void ExibirCodigo()
        {
            Console.WriteLine($"Código do prontuário: {CodigoProntuario}");
        }
    }
}
