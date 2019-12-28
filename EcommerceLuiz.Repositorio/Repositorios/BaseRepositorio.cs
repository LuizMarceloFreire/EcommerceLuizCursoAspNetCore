using EcommerceLuiz.Dominio.Contratos;
using EcommerceLuiz.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcommerceLuiz.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly EcommerceLuizContexto EcommerceLuizContexto;
        public BaseRepositorio(EcommerceLuizContexto ecommerceLuizContexto)
        {
            EcommerceLuizContexto = ecommerceLuizContexto;
        }
        public void Adicionar(TEntity entity)
        {
            EcommerceLuizContexto.Set<TEntity>().Add(entity);
            EcommerceLuizContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            EcommerceLuizContexto.Set<TEntity>().Update(entity);
            EcommerceLuizContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return EcommerceLuizContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return EcommerceLuizContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            EcommerceLuizContexto.Remove(entity);
            EcommerceLuizContexto.SaveChanges();
        }

        public void Dispose()
        {
            EcommerceLuizContexto.Dispose();
        }
    }
}
