﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HvCommerce.Orders.Domain.Models;

namespace HvCommerce.Orders.ApplicationServices
{
    public interface IShoppingCartService
    {
        IEnumerable<ShoppingCartItem> FindByUserId(long userId);
    }
}