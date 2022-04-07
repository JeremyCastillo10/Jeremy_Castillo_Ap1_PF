using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Jeremy_Castillo_Ap1_PF.DAL;
using Jeremy_Castillo_Ap1_PF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Jeremy_Castillo_Ap1_PF.BLL
{
    public class EstudiantesBLL
    {
        private Contexto _contexto;




        public EstudiantesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int id)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Estudiantes.Any(p => p.EstudianteId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Insertar(Estudiantes estudiante)
        {
            bool paso = false;

            try
            {
                if (_contexto.Estudiantes.Add(estudiante) != null)
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(estudiante).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public bool Guardar(Estudiantes estudiante)
        {
            if (!Existe(estudiante.EstudianteId))
                return Insertar(estudiante);
            else
                return Modificar(estudiante);
        }

       public Estudiantes? Buscar(int Id)
        {
            Estudiantes? estudiante;
            try
            {
                estudiante = _contexto.Estudiantes.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                var estudiante = _contexto.Estudiantes.Find(id);
                if(estudiante != null)
                {
                    _contexto.Estudiantes.Remove(estudiante);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

      public List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> criterio)
        {
             List<Estudiantes> lista = new List<Estudiantes>();

            try
            {
                lista = _contexto.Estudiantes.Where(criterio).ToList();
                
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }


        public List<Nacionalidades> GetListNacionalidades(Expression<Func<Nacionalidades, bool>> criterio)
        {
            List<Nacionalidades> lista = new List<Nacionalidades>();
            try
            {
                lista = _contexto.Nacionalidades.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            
            return lista;
        }
        
       
    }
}