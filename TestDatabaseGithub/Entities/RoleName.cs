using System;
using System.Collections.Generic;

namespace TestDatabaseGithub.Entities;

public partial class RoleName
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
