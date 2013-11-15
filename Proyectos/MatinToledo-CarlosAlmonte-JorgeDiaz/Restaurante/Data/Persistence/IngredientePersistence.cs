using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Commons;

namespace Data.Persistence
{
    class IngredientePersistence : IPersistence<Ingrediente>
    {
        public Ingrediente Read(int Id)
        {
            Ingrediente response;
            try
            {
                using (var restaurante_entities = new ProgAvanzada_ArqSoftware_RestauranteEntities())
                {
                    response = restaurante_entities.Ingredientes.Single(x => x.Id == Id);
                }
            }
            catch (Exception e) { throw e; }

            return response;
        }

        public Ingrediente Update(Ingrediente Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Ingrediente Entity)
        {
            throw new NotImplementedException();
        }

        public List<Ingrediente> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
