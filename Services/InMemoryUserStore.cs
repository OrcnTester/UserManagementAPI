using System.Collections.Concurrent;
using UserManagementAPI.Models;

namespace UserManagementAPI.Services;

public class InMemoryUserStore : IUserStore
{
    private readonly ConcurrentDictionary<int, User> _users = new();
    private int _idSeq = 0;

    public InMemoryUserStore()
    {
        Add(new User { Name = "Orcun", Email = "orcun@techhive.local", Department = "IT" });
        Add(new User { Name = "Ayse", Email = "ayse@techhive.local", Department = "HR" });
    }

    public IReadOnlyList<User> GetAll()
        => _users.Values.OrderBy(u => u.Id).ToList();

    public User? GetById(int id)
        => _users.TryGetValue(id, out var user) ? user : null;

    public User Add(User user)
    {
        var id = Interlocked.Increment(ref _idSeq);
        user.Id = id;
        _users[id] = user;
        return user;
    }

    public bool Update(int id, User user)
    {
        if (!_users.ContainsKey(id)) return false;
        user.Id = id;
        _users[id] = user;
        return true;
    }

    public bool Delete(int id)
        => _users.TryRemove(id, out _);
}
