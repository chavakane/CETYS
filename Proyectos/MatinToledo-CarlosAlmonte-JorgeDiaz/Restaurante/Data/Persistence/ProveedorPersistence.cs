using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Commons;

namespace Data.Persistence
{
    class ProveedorPersistence : IPersistence<Proveedor>
    {

        public Proveedor Read(int Id)
        {
            Proveedor response;
            try
            {
                using (var restaurante_entities = new ProgAvanzada_ArqSoftware_RestauranteEntities())
                {
                    response = restaurante_entities.Proveedors.Single(x => x.Id == Id);
                }
            }
            catch (Exception e) { throw e; }

            return response;
        }

        public Proveedor Update(Proveedor Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Proveedor Entity)
        {
            throw new NotImplementedException();
        }

        public List<Proveedor> GetList()
        {
            throw new NotImplementedException();
        }
    }

}
