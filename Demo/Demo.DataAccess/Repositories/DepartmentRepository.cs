using Demo.DataAccess.Context;

namespace Demo.DataAccess.Repositories;
public class DepartmentRepository(CompanyDbContext context) // Injection 
    : BaseRepository<Department>(context), IDepartmentRepository
{


}
