using EcommerceLuiz.Dominio.Contratos;
using EcommerceLuiz.Dominio.Entidades;
using EcommerceLuiz.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLuiz.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(EcommerceLuizContexto ecommerceLuizContexto) : base(ecommerceLuizContexto)
        {
        }
    }
}
