﻿using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext contex)
        {
            _context = contex;
        }

        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) 
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id) 
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.ID == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if(!_context.Seller.Any(x =>  x.ID == obj.ID))
            {
                throw new DllNotFoundException("ID not Found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }catch( DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }

        }
    }
}