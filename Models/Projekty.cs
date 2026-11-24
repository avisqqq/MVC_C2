using System.ComponentModel.DataAnnotations;

namespace MojeCV.Models;

public class Projekt
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Nazwa { get; set; } = "";

    [StringLength(1000)]
    public string? Opis { get; set; }

    [Url]
    public string? LinkRepozytorium { get; set; }
}

