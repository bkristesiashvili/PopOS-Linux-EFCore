using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TESTEF.Entities;

namespace TESTEF;

// public sealed class TestSimpleDbContext : DbContext
// {
//     public TestSimpleDbContext(DbContextOptions<TestSimpleDbContext> options) : base(options) { }
// }

public sealed class TestIdentityDbContext : IdentityDbContext<User, Role, Guid>
{
    public TestIdentityDbContext(DbContextOptions<TestIdentityDbContext> options) : base(options) { }
}