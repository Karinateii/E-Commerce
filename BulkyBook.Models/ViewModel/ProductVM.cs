using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models.ViewModel
{
    public class ProductVM
    {
        public Product Product { get; set; }
        //Retrieving all the categories but converting it to a Select Item

        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; } 

        [ValidateNever]
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }

               
    }
}
