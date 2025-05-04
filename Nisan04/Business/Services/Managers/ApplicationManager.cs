using Microsoft.EntityFrameworkCore;
using Entities.Enums; // Enum için doğru ad alanını ekledik

public class ApplicationManager : IApplicationService
{
    private readonly AppDbContext _context;

    public ApplicationManager(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<List<ApplicationResponse>> GetAllAsync()
    {
        return await _context.Applications
            .Select(x => new ApplicationResponse
            {
                Id = x.Id,
                State = (ApplicationState)x.ApplicationState // Enum dönüşümü
            })
            .ToListAsync();
    }

    public async Task<ApplicationResponse> GetByIdAsync(int id)
    {
        var app = await _context.Applications.FindAsync(id);
        if (app == null)
        {
            throw new KeyNotFoundException($"Application with ID {id} not found.");
        }

        return new ApplicationResponse
        {
            Id = app.Id,
            State = (ApplicationState)app.ApplicationState // Enum dönüşümü
        };
    }

    public async Task<ApplicationResponse> CreateAsync(CreateApplicationRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        var application = new Application
        {
            ApplicantId = request.ApplicantId,
            BootcampId = request.BootcampId,
            ApplicationState = ApplicationState.PENDING
        };

        _context.Applications.Add(application);
        await _context.SaveChangesAsync();

        return new ApplicationResponse
        {
            Id = application.Id,
            State = (ApplicationState)application.ApplicationState // Enum dönüşümü
        };
    }

    public async Task DeleteAsync(int id)
    {
        var app = await _context.Applications.FindAsync(id);
        if (app == null)
        {
            throw new KeyNotFoundException($"Application with ID {id} not found.");
        }

        _context.Applications.Remove(app);
        await _context.SaveChangesAsync();
    }
}
