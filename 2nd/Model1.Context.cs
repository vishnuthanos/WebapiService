﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2nd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeDBEntities1 : DbContext
    {
        public EmployeeDBEntities1()
            : base("name=EmployeeDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer1> Customers1 { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Mas_Department> Mas_Department { get; set; }
        public virtual DbSet<Mas_Employee> Mas_Employee { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    
        public virtual ObjectResult<Get_AllEmployees_Result> Get_AllEmployees(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_AllEmployees_Result>("Get_AllEmployees", idParameter);
        }
    
        public virtual ObjectResult<spgetemps_Result> spgetemps()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spgetemps_Result>("spgetemps");
        }
    
        public virtual int USP_Emp_Delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Emp_Delete", idParameter);
        }
    
        public virtual int USP_Emp_Insert(string name, Nullable<int> salary, Nullable<int> deptId)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(int));
    
            var deptIdParameter = deptId.HasValue ?
                new ObjectParameter("DeptId", deptId) :
                new ObjectParameter("DeptId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Emp_Insert", nameParameter, salaryParameter, deptIdParameter);
        }
    
        public virtual int USP_Emp_Update(Nullable<int> id, string name, Nullable<int> salary, Nullable<int> deptId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(int));
    
            var deptIdParameter = deptId.HasValue ?
                new ObjectParameter("DeptId", deptId) :
                new ObjectParameter("DeptId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Emp_Update", idParameter, nameParameter, salaryParameter, deptIdParameter);
        }
    }
}
