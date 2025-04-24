using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Base;

public class EfRepositoryBase<T> : IRepository<T>, IAsyncRepository<T> where T : class
{
    private readonly DbContext _context;

    public EfRepositoryBase(DbContext context)
    {
        _context = context;
    }

    public void Add(T entity) => _context.Set<T>().Add(entity);
    public void Delete(T entity) => _context.Set<T>().Remove(entity);
    public void Update(T entity) => _context.Set<T>().Update(entity);
    public T GetById(int id) => _context.Set<T>().Find(id);
    public List<T> GetAll() => _context.Set<T>().ToList();

    public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);
    public async Task<List<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
    public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);
    public async Task UpdateAsync(T entity) => await Task.Run(() => _context.Set<T>().Update(entity));
    public async Task DeleteAsync(T entity) => await Task.Run(() => _context.Set<T>().Remove(entity));
}
