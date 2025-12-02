using Microsoft.AspNetCore.Http;

namespace Demo.BLL.Services;
public interface IDocumentService
{
    Task<string?> UploadAsync(IFormFile file, string folderName);
    Task DeleteAsync(string fileName, string folderName);
}
