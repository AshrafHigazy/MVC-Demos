using Demo.DataAccess.Context;

namespace Demo.DataAccess.Repositories;
public class UnitOfWork(CompanyDbContext dbContext,
    IEmployeeRepository employeeRepository,
    IDepartmentRepository departmentRepository) : IUnitOfWork
{

    public IEmployeeRepository Employees => employeeRepository;
    public IDepartmentRepository Departments => departmentRepository;


    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}
