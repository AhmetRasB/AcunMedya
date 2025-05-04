using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ApplicationController : ControllerBase
{
    private readonly IApplicationService _applicationService;

    public ApplicationController(IApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _applicationService.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id) => Ok(await _applicationService.GetByIdAsync(id));

    [HttpPost]
    public async Task<IActionResult> Create(CreateApplicationRequest request) => Ok(await _applicationService.CreateAsync(request));

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _applicationService.DeleteAsync(id);
        return NoContent();
    }
}