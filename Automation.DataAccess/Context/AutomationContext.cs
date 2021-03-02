using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Automation.DataAccess.Context
{
    public class AutomationContext : DbContext
    {
        private DbSet<Product> products;

        public DbSet<Product> GetProducts()
        {
            return products;
        }

        public void SetProducts(DbSet<Product> value)
        {
            products = value;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
