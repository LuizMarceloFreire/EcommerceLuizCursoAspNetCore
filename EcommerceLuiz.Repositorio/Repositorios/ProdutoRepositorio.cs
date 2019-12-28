using EcommerceLuiz.Dominio.Contratos;
using EcommerceLuiz.Dominio.Entidades;
using EcommerceLuiz.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLuiz.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(EcommerceLuizContexto ecommerceLuizContexto) : base(ecommerceLuizContexto)
        {
        }
    }
}
