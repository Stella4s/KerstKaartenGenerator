using KerstKaartenGenerator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerstKaartenGenerator.Data
{
    public class DbSeeder
    {
        private readonly AppDbContext _context;

        public DbSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (!_context.Contacts.Any())
            {
                //Seed Contacts
                var contacts = new List<Contact>() 
                {
                    new Contact{FirstName = "Jane", LastName = "Smith", Email = "JaneSmith@test.com"},
                    new Contact{FirstName = "Mike", LastName = "Potter", Email = "MikePotter@test.com"},
                    new Contact{FirstName = "James", LastName = "Grey", Email = "JGrey@test.com"},
                    new Contact{FirstName = "Derrick", LastName = "Stone", Email = "DerrickStone@test.com"},
                    new Contact{FirstName = "Minerva", LastName = "Anderson", Email = "MinervaAnderson@test.com"}
                };
                _context.AddRange(contacts);
               
            }
            _context.SaveChanges();
           
        }
    }
}
