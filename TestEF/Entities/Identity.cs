using Microsoft.AspNetCore.Identity;

namespace TESTEF.Entities;

public class User : IdentityUser<Guid> { }

public class Role : IdentityRole<Guid> { }