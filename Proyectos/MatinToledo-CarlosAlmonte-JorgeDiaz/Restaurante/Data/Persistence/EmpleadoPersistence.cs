using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Commons;

namespace Data.Persistence
{
    class EmpleadoPersistence : IPersistence<Empleado>
    {

        public Empleado Read(int Id)
        {
            Empleado response;
            try
            {
                using (var restaurante_entities = new ProgAvanzada_ArqSoftware_RestauranteEntities())
                {
                    response = restaurante_entities.Empleadoes.Single(x => x.Id == Id);
                }
            }
            catch (Exception e) { throw e; }

            return response;
        }

        public Empleado Update(Empleado Entity)
        {
            Empleado response;
            try
            {
                using (var restaurante_entities = new ProgAvanzada_ArqSoftware_RestauranteEntities())
                {
                    var tmp = new Empleado { Id = Entity.Id };
                    restaurante_entities.Empleadoes.Attach(tmp);
                    restaurante_entities.Empleadoes.ApplyCurrentValues(Entity);
                    restaurante_entities.SaveChanges();
                    response = Entity;
                }
            }
            catch (Exception e) { throw e; }

            return response;
        }

        public bool Delete(Empleado Entity)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetList()
        {
            throw new NotImplementedException();
        }
    }

}
