using MVC_Sec_Project.DAL.Contexts;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Reposatories.Classes
{
    public class UnitOfWork : IUnitOfWork //, IDisposable
    {
        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        private readonly Lazy<IDepartmentReposatory> _departmentReposatory;
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _employeeRepository = new Lazy<IEmployeeRepository>(()=>new EmployeeRepository(_context));
            _departmentReposatory = new Lazy<IDepartmentReposatory>(() => new DepartmentReposatory(_context));
            _context = context;

        }
        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;

        public IDepartmentReposatory DepartmentReposatory => _departmentReposatory.Value;

        //Use it if you need do actions before close the conection
        //public void Dispose()
        //{
        //   _context.Dispose();
        //}

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
