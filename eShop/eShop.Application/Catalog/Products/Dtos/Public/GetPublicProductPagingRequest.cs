using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products.Dtos.Public
{
   public class GetPublicProductPagingRequest: PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
