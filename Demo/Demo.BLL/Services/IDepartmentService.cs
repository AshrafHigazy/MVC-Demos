using Demo.BLL.DataTransferObjects.Departments;

namespace Demo.BLL.Services;
public interface IDepartmentService
{
    Task<DepartmentDetailsResponse?> GetByIdAsync(int id);
    Task<IEnumerable<DepartmentResponse>> GetAllAsync();
    Task<int> CreateAsync(DepartmentRequest department);
    Task<int> UpdateAsync(DepartmentUpdateRequest department);
    Task<bool> DeleteAsync(int id);
}
