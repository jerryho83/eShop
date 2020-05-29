using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products.Dtos.Manage
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keywork { get; set; }
        public int? CatrgoryId{ get; set; }
    }
}
