using Jeremy_Castillo_Ap1_PF.BLL;
using Jeremy_Castillo_Ap1_PF.DAL;

namespace Jeremy_Castillo_Ap1_PF.Entidades
{
    public class UnitOfWork
    {
        private  EstudiantesBLL _estudiantes;
        private TiposDocumentosBLL _tiposDocumentos;
        private ExpedientesBLL _expedientes;
        private Contexto _contexto;

        public UnitOfWork(Contexto contexto)
        {
            _contexto = contexto;
        }

        public EstudiantesBLL estudiantesBLL
        {
            get
            {
                if (_estudiantes == null)
                {
                    _estudiantes= new EstudiantesBLL(_contexto);
                }

                return _estudiantes;
            }
        }

        public TiposDocumentosBLL tiposDocumentosBLL
        {
            get
            {
                if (_tiposDocumentos == null)
                {
                    _tiposDocumentos = new TiposDocumentosBLL(_contexto);
                }

                return _tiposDocumentos;
            }
        }

        public ExpedientesBLL expedientesBLL
        {
            get{

                if (_expedientes == null)
                {
                    _expedientes = new ExpedientesBLL(_contexto);
                }

                return _expedientes;
            }
        }

        public void Save()
        {
            _contexto.SaveChanges();
        }

    }
}