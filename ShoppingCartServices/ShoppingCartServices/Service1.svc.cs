using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ShoppingCartServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public IEnumerable<ItemDetailsModel> GetItemDetails()
        {
            Repository.ShoppingDbEntities db = new Repository.ShoppingDbEntities();
            var query = db.ItemDetails;

            IList<ItemDetailsModel> itemsList = new List<ItemDetailsModel>();
            query.ToList().ForEach(item =>
            {
                itemsList.Add(new ItemDetailsModel()
                {
                    Item_Id = item.Item_Id,
                    Item_Name = item.Item_Name,
                    Item_Price = item.Item_Price ?? 0,
                    Image_Name = item.Image_Name
                });
            });

            return itemsList;
        }

        public bool AddItemShoppingCart(ItemDetailsModel item)
        {
            Repository.ShoppingDbEntities db = new Repository.ShoppingDbEntities();
            var newItem = db.ItemDetails.Create();
            newItem.Image_Name = item.Image_Name;
            newItem.Item_Id = item.Item_Id;
            newItem.Item_Name = item.Item_Name;
            newItem.Item_Price = item.Item_Price;

            db.ItemDetails.Add(newItem);
            db.SaveChanges();

            return true;
        }
    }
}
