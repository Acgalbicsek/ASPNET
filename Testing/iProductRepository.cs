﻿using System.Collections;
using Testing.Models;
using System.Collections.Generic;

namespace Testing
{
    public interface iProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}