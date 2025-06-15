using System;
using System.Collections.Generic;

namespace CA_Sotify_Ödev_.Models;

public partial class Album
{
    public int Id { get; set; }

    public string AlbumName { get; set; } = null!;

    public int ArtistId { get; set; }

    public int UsersId { get; set; }

    public virtual Artisit Artist { get; set; } = null!;

    public virtual ICollection<Music> Musics { get; set; } = new List<Music>();

    public virtual User Users { get; set; } = null!;
}
