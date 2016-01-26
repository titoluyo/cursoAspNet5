﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ShoppingCartServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<ItemDetailsModel> GetItemDetails();

        [OperationContract]
        bool AddItemShoppingCart(ItemDetailsModel item);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public partial class ItemDetailsModel
    {
        [DataMember]
        public int Item_Id { get; set; }
        [DataMember]
        public string Item_Name { get; set; }
        [DataMember]
        public Nullable<decimal> Item_Price { get; set; }
        [DataMember]
        public string Image_Name { get; set; }
    }
}
