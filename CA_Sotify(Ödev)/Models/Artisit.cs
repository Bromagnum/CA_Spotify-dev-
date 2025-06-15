using System;
using System.Collections.Generic;

namespace CA_Sotify_Ödev_.Models;

public partial class Artisit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
