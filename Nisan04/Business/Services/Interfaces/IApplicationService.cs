public interface IApplicationService
{
    Task<List<ApplicationResponse>> GetAllAsync();
    Task<ApplicationResponse> GetByIdAsync(int id);
    Task<ApplicationResponse> CreateAsync(CreateApplicationRequest request);
    Task DeleteAsync(int id);
}