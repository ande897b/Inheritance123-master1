using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository : Merchandise
    {       
        private List<Merchandise> merchandises = new List<Merchandise>();
  
        
        public void AddMerchandise (Merchandise merchandise)
        {

            merchandises.Add(merchandise);
            //if (merchandise is Amulet)
            //{
            //    merchandises.Add(merchandise);
                
            //}
            //else if (merchandise is Book)
            //{
            //    merchandises.Add(merchandise);
            //}
        }


        public Merchandise GetMerchandise (string itemId)
        {
            for (int i = 0; i < merchandises.Count; i++)
            {
                if (merchandises[i].ItemId == itemId)
                {
                    return merchandises[i];
                }
            }
            return null;
        }
      public double GetTotalValue()
        {
            Utility util = new Utility();

            if (true)
            {

            }
            double value = 0;
            for (int i = 0; i < merchandises.Count; i++)
            {
                value += util.GetValueOfMerchandise(merchandises[i]);
            }



            return value;

        }
   

        

    }
}
