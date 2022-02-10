﻿using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext contex)
        {
            _context = contex;
        }

        public List<Department> FindlAll() 
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
