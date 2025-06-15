using System;
using System.Collections.Generic;

namespace CA_Sotify_Ödev_.Models;

public partial class Music
{
    public int Id { get; set; }

    public string SongName { get; set; } = null!;

    public int ArtistId { get; set; }

    public int AlbumId { get; set; }

    public virtual Album Album { get; set; } = null!;
}
