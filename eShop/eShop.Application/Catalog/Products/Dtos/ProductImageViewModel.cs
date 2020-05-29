﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products.Dtos
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public bool IsDefault { get; set; }
        public long FileSize { get; set; }
    }
}
