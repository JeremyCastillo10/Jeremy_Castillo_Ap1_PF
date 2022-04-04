using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Jeremy_Castillo_Ap1_PF.DAL;
using Jeremy_Castillo_Ap1_PF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Jeremy_Castillo_Ap1_PF.BLL
{
    public class ExpedientesBLL
    {
        private Contexto _contexto;

        Expedientes Expedientes = new Expedientes();
        public List<TiposDocumentos>? listaTipos = new List<TiposDocumentos>();


        public ExpedientesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int id)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Expedientes.Any(p => p.ExpedienteId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Insertar(Expedientes expediente)
        {
            bool paso = false;

            try
            {
                if (_contexto.Expedientes.Add(expediente) != null)
                
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Expedientes expediente)
        {
            bool paso = false;

            try
            {
                _contexto.Database.ExecuteSqlRaw($"DELETE FROM ExpedientesDetalle WHERE ExpedienteId={expediente.ExpedienteId}");

                foreach (var Anterior in expediente.ExpedienteDetalle)
                {
                    _contexto.Entry(Anterior).State = EntityState.Added;
                }

                _contexto.Entry(expediente).State = EntityState.Modified;

                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public bool Guardar(Expedientes expediente)
        {
            if(Existe(expediente.ExpedienteId))
                return Modificar(expediente);
            else
                return Insertar(expediente);
        }

       public Expedientes? Buscar(int Id)
        {
            Expedientes? expediente;

            try
            {
                expediente = _contexto.Expedientes
                    .Include(x => x.ExpedienteDetalle)
                    .Where(p => p.ExpedienteId == Id)
                    .AsNoTracking()
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return expediente;
        }

        public bool Eliminar(int id)
        {
           bool paso = false;

            try
            {
                var expedientes = _contexto.Expedientes.Find(id);
                if(expedientes != null)
                {
                    _contexto.Expedientes.Remove(expedientes);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

      public List<Expedientes> GetList(Expression<Func<Expedientes, bool>> criterio)
        {
            List<Expedientes> lista = new List<Expedientes>();
            try
            {
                lista = _contexto.Expedientes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            
            return lista;
        }

        public List<ExpedientesDetalle> GetListDetalle(Expression<Func<ExpedientesDetalle, bool>> criterio)
        {
            List<ExpedientesDetalle> lista = new List<ExpedientesDetalle>();
            try
            {
                lista = _contexto.ExpedientesDetalle.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            
            return lista;
        }
       
    }
}