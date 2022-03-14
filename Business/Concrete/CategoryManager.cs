﻿using Business.Abstract;
using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly BlogDbContext _context;

        public CategoryManager(BlogDbContext context)
        {
            _context = context;
        }

       

        public void Create(Category category)
        {
            category.UpdateDate = DateTime.Now;
            category.UpdateDate = DateTime.Now;
           _context.Categories.Add(category);   
            _context.SaveChanges();
        }

        public List<Category> getAll()
        {
           var category =  _context.Categories.ToList();
           

            return category;    
        }
    }
}
