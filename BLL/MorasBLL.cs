using Microsoft.EntityFrameworkCore;
using RegistroPrestamos.DAL;
using RegistroPrestamos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RegistroPrestamos.BLL
{
    public class MorasBLL
    {
        public static bool Guardar(Moras mora)
        {
            if (!Existe(mora.MoraId))
                return Insertar(mora);
            else
                return Modificar(mora);

        }

        private static bool Insertar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                foreach (var item in mora.MorasDetalle)
                {
                    var auxPrestamo = contexto.Prestamos.Find(item.PrestamoId);
                    if (auxPrestamo != null)
                    {
                        auxPrestamo.Balance += item.Valor;
                        contexto.Personas.Find(auxPrestamo.PersonaId).Balance += item.Valor; 
                    }

                }

                contexto.Moras.Add(mora);
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


        private static bool Modificar(Moras mora)
        {
            bool paso = false;
            var Anterior = Buscar(mora.MoraId);
            Contexto contexto = new Contexto();

            try
            {
                foreach (var item in Anterior.MorasDetalle)
                {
                    var auxPrestamo = contexto.Prestamos.Find(item.PrestamoId);
                    if (!mora.MorasDetalle.Exists(d => d.MoraDetalleId == item.MoraDetalleId))
                    {
                        if (auxPrestamo != null)
                        {
                            auxPrestamo.Balance -= item.Valor;
                            contexto.Personas.Find(auxPrestamo.PersonaId).Balance -= item.Valor;
                        }

                        contexto.Entry(item).State = EntityState.Deleted;
                    }

                }

                foreach (var item in mora.MorasDetalle)
                {
                    var auxPrestamo = contexto.Prestamos.Find(item.PrestamoId);
                    if (item.MoraDetalleId == 0)
                    {
                        contexto.Entry(item).State = EntityState.Added;
                        if (auxPrestamo != null)
                        {
                            auxPrestamo.Balance += item.Valor;
                            contexto.Personas.Find(auxPrestamo.PersonaId).Balance += item.Valor;
                        }

                    }
                    else
                        contexto.Entry(item).State = EntityState.Modified;
                }

                contexto.Entry(mora).State = EntityState.Modified;
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
            var Anterior = Buscar(id);
            Contexto contexto = new Contexto();

            try
            {
                foreach (var item in Anterior.MorasDetalle)
                {
                    var prestamo = contexto.Prestamos.Find(item.PrestamoId);
                    if (prestamo != null)
                    {
                        prestamo.Balance -= item.Valor;
                        contexto.Personas.Find(prestamo.PersonaId).Balance -= item.Valor;
                    }

                }


                var auxMora = contexto.Moras.Find(id);
                if (auxMora != null)
                {
                    contexto.Moras.Remove(auxMora);
                    paso = contexto.SaveChanges() > 0;

                }
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

        public static Moras Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Moras mora;

            try
            {
                mora = contexto.Moras.Where(m => m.MoraId == id).Include(d => d.MorasDetalle).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return mora;

        }

        public static List<Moras> GetList(Expression<Func<Moras, bool>> mora)
        {
            List<Moras> lista = new List<Moras>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Moras.Where(mora).ToList();
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

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Moras.Any(m => m.MoraId == id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;

        }
    }
}