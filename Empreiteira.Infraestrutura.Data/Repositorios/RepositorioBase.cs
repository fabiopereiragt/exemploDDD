using System;
using System.Collections.Generic;
using Empreiteira.Dominio.Interfaces.Repositorios;
using Empreiteira.Infraestrutura.Data.Interfaces;
using System.Data;
using Empreiteira.Infraestrutura.Data.Mapeamentos;
using DapperExtensions;

namespace Empreiteira.Infraestrutura.Data.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _uow;
        private readonly IDapperContexto _context;
        protected IDbConnection _db { get; set; }

        protected IUnitOfWork Uow { get { return _uow; } }
        protected IDapperContexto Contexto { get { return _context; } }

        public RepositorioBase(IDapperContexto context, IUnitOfWork uow)
        {
            _db = context.Connection;
            _context = context;
            _uow = uow;
            InicializaMapperDapper();
        }

        public static void InicializaMapperDapper()
        {
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[]
            {
                typeof(UsuarioMap).Assembly //,
                //typeof(TipoUsuarioMap).Assembly
            });
        }

        public bool Adicionar(TEntity obj)
        {
            try
            {
                var transaction = _uow.BeginTransaction();
                if (transaction != null)
                {
                    var entidade = _db.Insert(obj, transaction);
                    if (entidade != null)
                        Commit();
                }
            }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
            return true;
        }

        public bool Atualizar(TEntity obj)
        {
            try
            {
                var bAlterado = _db.Update(obj, _uow.BeginTransaction());
                if (bAlterado)
                    Commit();
            }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
            return true;
        }

        public bool Excluir(TEntity obj)
        {
            try
            {
                var bExcluiu = _db.Delete(obj, _uow.BeginTransaction());
                if (bExcluiu)
                    Commit();
            }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
            return true;
        }

        public TEntity SelecionarPorId(int id)
        {
            try { return _db.Get<TEntity>(id); }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
        }

        public TEntity SelecionarPorId(string id)
        {
            try { return _db.Get<TEntity>(id); }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
        }

        public IEnumerable<TEntity> SelecionarPor(object @where = null)
        {
            try { return _db.GetList<TEntity>(@where); }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
        }

        public int Count(object @where = null)
        {
            try { return _db.Count<TEntity>(@where); }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
        }

        public IEnumerable<TEntity> SelecionarTodos()
        {
            try { return _db.GetList<TEntity>(); }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
        }

        public void Commit()
        {
            _uow.Commit();
        }

        public void Rollback()
        {
            _uow.Rollback();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
