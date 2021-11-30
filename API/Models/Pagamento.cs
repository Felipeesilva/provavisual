using System;

namespace API.Models
{
    public class Pagamento
    {
        //Construtor
        public Pagamento() => CriadoEm = DateTime.Now;
        public int PagamentoId { get; set; }
        public string FormaPagamento { get; set; }
        public string Moeda { get; set; } //real, dollar.
        public DateTime CriadoEm { get; set; }

    }
}