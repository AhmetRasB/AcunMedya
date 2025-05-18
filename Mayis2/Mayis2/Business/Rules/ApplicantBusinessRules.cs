using Mayis2.DataAccess.Abstract;

namespace Mayis2.Business.Rules;

public class ApplicantBusinessRules
{
    private readonly IApplicantRepository _repository;
    private readonly IBlacklistRepository _blacklistRepository;

    public ApplicantBusinessRules(IApplicantRepository repository, IBlacklistRepository blacklistRepository)
    {
        _repository = repository;
        _blacklistRepository = blacklistRepository;
    }

    public async Task CannotApplyTwiceWithSameIdentity(string identityNumber)
    {
        var exists = await _repository.AnyAsync(a => a.IdentityNumber == identityNumber);
        if (exists)
            throw new BusinessException("Aynı TC Kimlik No ile birden fazla başvuru yapılamaz.");
    }

    public async Task CannotApplyIfBlacklisted(Guid applicantId)
    {
        var isBlacklisted = await _blacklistRepository.AnyAsync(b => b.ApplicantId == applicantId && b.IsActive);
        if (isBlacklisted)
            throw new BusinessException("Kara listeye alınan bir başvuru sahibi başvuru yapamaz.");
    }

    public async Task ApplicantMustExist(Guid applicantId)
    {
        var exists = await _repository.GetByIdAsync(applicantId);
        if (exists == null)
            throw new BusinessException("Sistemde kayıtlı olmayan bir başvuru sahibi ile işlem yapılamaz.");
    }
} 