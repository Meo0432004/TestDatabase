using System;
using System.Collections.Generic;

namespace TestDatabaseGithub.Entities;

public partial class OrderState
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
