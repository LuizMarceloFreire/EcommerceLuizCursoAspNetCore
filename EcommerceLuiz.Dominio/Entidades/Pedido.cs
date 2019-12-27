using EcommerceLuiz.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcommerceLuiz.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public DateTime DataEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedidos.Any())
                AdicionarMensagem("Pedido não pode ficar sem item de pedido.");

            if (string.IsNullOrEmpty(CEP))
                AdicionarMensagem("O CEP não pode ser vazio.");

            if (FormaPagamentoId == 0)
                AdicionarMensagem("Não foi informado a forma de pagamento.");
        }
    }
}
