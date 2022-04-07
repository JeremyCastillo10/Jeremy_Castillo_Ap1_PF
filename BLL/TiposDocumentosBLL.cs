using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Jeremy_Castillo_Ap1_PF.DAL;
using Jeremy_Castillo_Ap1_PF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Jeremy_Castillo_Ap1_PF.BLL
{
    public class TiposDocumentosBLL
    {
        private Contexto _contexto;

        Estudiantes Estudiantes = new Estudiantes();


        public TiposDocumentosBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int id)
        {
            bool paso = false;

            try
            {
                paso = _contexto.TiposDocumentos.Any(p => p.TipoDocumentoId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Insertar(TiposDocumentos tipo)
        {
            bool paso = false;
            try
            {
                if (_contexto.TiposDocumentos.Add(tipo) != null)
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(TiposDocumentos tipo)
        {
            bool paso = false;
            try
            {
                _contexto.Entry(tipo).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }

            return paso;
        }

        public bool Guardar(TiposDocumentos tipo)
        {
            if(Existe(tipo.TipoDocumentoId))
                return Modificar(tipo);
            else
                return Insertar(tipo);
        }

       public TiposDocumentos? Buscar(int Id)
        {
            TiposDocumentos? tipo;
            try
            {
                tipo = _contexto.TiposDocumentos.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return tipo;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                var tipo = _contexto.TiposDocumentos.Find(id);
                if(tipo != null)
                {
                    _contexto.TiposDocumentos.Remove(tipo);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

      public List<TiposDocumentos> GetList(Expression<Func<TiposDocumentos, bool>> criterio)
        {
            List<TiposDocumentos> lista = new List<TiposDocumentos>();
            try
            {
                lista = _contexto.TiposDocumentos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            
            return lista;
        }
       
    }
}