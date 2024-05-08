using DataAccessLayer.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class CategoryOperations
    {
        public List<Category> GetCategories()
        {
            NorthWndContext cnt  = new NorthWndContext();
            return cnt.Categories.ToList();
        }
    }
}
