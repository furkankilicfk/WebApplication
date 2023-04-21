using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.ModelMetaDataTypes;

namespace WebApplication1.Models
{
  /*  [ModelMetadataType(typeof(ProductMetaData))]  */              //Product sınıfının validationlarının buradan alındığını bildirdik
    public class Product
    {
        //public int Id { get; set; }
       
        public string ProductName { get; set; }

        public int Quantity { get; set; }
        public string Email { get; set; }

       
    }
}
