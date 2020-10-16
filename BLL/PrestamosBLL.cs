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
    public class PrestamosBLL
    {
        public static bool Guardar(Prestamos prestamos)
        {
            if (!Existe(prestamos.PrestamosId))
                return Insertar(prestamos);
            else
                return Modificar(prestamos);

        }

        private static bool Insertar(Prestamos prestamos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Prestamos.Add(prestamos);
                contexto.Personas.Find(prestamos.PersonaId).Balance += prestamos.Balance;
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


        private static bool Modificar(Prestamos prestamos)
        {
            bool paso = false;
            decimal BalanceAnterior = Buscar(prestamos.PrestamosId).Balance;
            int PersonaIdAnterior = Buscar(prestamos.PrestamosId).PersonaId;
            Contexto contexto = new Contexto();

            try
            {

                if (PersonaIdAnterior != prestamos.PersonaId)
                {
                    contexto.Personas.Find(PersonaIdAnterior).Balance -= BalanceAnterior;
                    contexto.Personas.Find(prestamos.PersonaId).Balance += prestamos.Balance;
                }
                else
                {
                    contexto.Personas.Find(prestamos.PersonaId).Balance -= BalanceAnterior;
                    contexto.Personas.Find(prestamos.PersonaId).Balance += prestamos.Balance;
                }

                contexto.Entry(prestamos).State = EntityState.Modified;
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
                var auxPrestamo = contexto.Prestamos.Find(id);
                if (auxPrestamo != null)
                {
                    contexto.Personas.Find(auxPrestamo.PersonaId).Balance -= auxPrestamo.Balance;
                    contexto.Prestamos.Remove(auxPrestamo);
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

        public static Prestamos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Prestamos prestamos;

            try
            {
                prestamos = contexto.Prestamos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return prestamos;

        }

        public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> prestamos)
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Prestamos.Where(prestamos).ToList();
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
                encontrado = contexto.Prestamos.Any(p => p.PrestamosId == id);

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