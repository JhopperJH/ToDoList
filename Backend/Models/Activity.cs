using System;
using System.Collections.Generic;

namespace ToDo.Models;

public partial class Activity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime Deadline { get; set; }

    public virtual User User { get; set; } = null!;
}
