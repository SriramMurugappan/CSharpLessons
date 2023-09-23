using System;
using System.Collections.Generic;

namespace MvcProject2.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Language { get; set; }

    public string? HeroName { get; set; }

    public string? Director { get; set; }

    public string? MusicDirector { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? Cost { get; set; }

    public int? Collection { get; set; }

    public decimal? Review { get; set; }
}
