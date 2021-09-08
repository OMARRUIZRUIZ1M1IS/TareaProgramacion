using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class ProductoModel
    {

        private Producto[] productos;
        #region CRUD

        #endregion

        #region private  Method


        private void Add(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }
            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            pds = tmp;

        }
        #endregion

        public void Add(Producto p)
        {
            Add(p, ref productos);
        }


        public int Update (Producto p)
        {
            if(p == null)
            {
                throw new ArgumentException(" el producto no puede ser null");
            }
            int index = GetIndexById(p.Id);
            if ( index < 0)
            {
                throw new ArgumentException($" el producto con el { p.Id} no puede ser encontrado");
            }
            productos[index] = p;
            return index;
        }

        public Producto[] GetAll()
        {
            return productos;
        }

        public bool Delete( Producto p)
        {
            if ( p == null)
            {
                throw new ArgumentException(" el producto no puede ser null");
            }
            int index = GetIndexById(p.Id);
            if ( index < 0)
            {
                throw new ArgumentException($" el producto con el { p.Id} no puede ser encontrado");
            }
            if (index != productos[productos.Length -1])
            {
                productos[index] = productos[productos.Length - 1];
            
            }
            Producto [] tmp= new Producto
        }

        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("el id no puede ser 0 o menor ");
            }
            int index = int.MinValue, i = 0;
            if ( productos== null)
            {
                return index;
            }
             foreach ( Producto p in productos)
            {
                if (p.Id == id )
                {
                    index = i;
                    break;
                }
            }
            return index;
        }


        #region Queries 
        public Producto GetIndexByIdd ( int id)
        {
            if ( id< 0)
            {
                throw new ArgumentException($"el id { id}  no es valido");
            }
            int index = GetIndexById(id);
            return index <= 0 ? null : productos[index];
        }

        #endregion
    }
}
