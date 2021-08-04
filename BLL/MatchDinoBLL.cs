using DinoMatchGame.DAL;
using DinoMatchGame.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DinoMatchGame.BLL
{
    public class MatchDinoBLL
    {
        public static bool Guardar(MatchDino MatchDino)
        {
            if (!Existe(MatchDino.Id))
                return Insertar(MatchDino);
            else
                return Modificar(MatchDino);
        }

        private static bool Existe(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                paso = contexto.MatchDino.Any(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Insertar(MatchDino MatchDino)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.MatchDino.Add(MatchDino);
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(MatchDino MatchDino)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(MatchDino).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var ventas = Buscar(id);

                contexto.Entry(ventas).State = EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static MatchDino Buscar(int id)
        {
            Contexto contexto = new Contexto();
            MatchDino MatchDino;

            try
            {
                MatchDino = contexto.MatchDino.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return MatchDino;
        }

        public static List<MatchDino> GetMatchDino()
        {
            List<MatchDino> lista = new List<MatchDino>();
            Contexto db = new Contexto();
            try
            {
                lista = db.MatchDino.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }

        public static List<MatchDino> GetList(Expression<Func<MatchDino, bool>> criterio)
        {
            List<MatchDino> lista = new List<MatchDino>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.MatchDino.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
        

    }
}
