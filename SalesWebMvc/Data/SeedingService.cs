using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (
                _context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any()
                ) 
            {
                return; //Banco de Dados Já Foi Populado, Não fazer nada
            }

            Department d1 = new Department(1,"Geral");
            Seller s1 = new Seller(1, "Geral", null,new DateTime(2000,01,01),0.0,d1);
            SalesRecord r1 = new SalesRecord(1, new DateTime(2000, 01, 01),0.0,SaleStatus.Billed,s1);

            _context.Department.AddRange(d1);
            _context.Seller.AddRange(s1);
            _context.SalesRecord.AddRange(r1);
            _context.SaveChanges();

        }
    }
}
