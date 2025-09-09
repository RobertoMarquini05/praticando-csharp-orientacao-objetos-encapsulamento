using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praticando_csharp_orientacao_objetos_encapsulamento
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Placa {  get; set; }
        public double VelocidadeAtual {  get; private set; }
        public DateTime CreatedAt { get; set; }

        public Veiculo(string placa) 
        {
            Id = Guid.NewGuid();
            Placa = placa;
            VelocidadeAtual = 0;
            CreatedAt = DateTime.Now;
        }    

        public void AtualizarVelocidade(double novaVelocidade)
        {
            VelocidadeAtual = novaVelocidade;

            Console.WriteLine($"Veículo: {Placa}\nVelocidade Atual: {VelocidadeAtual}km/h");
        }
    }
}
