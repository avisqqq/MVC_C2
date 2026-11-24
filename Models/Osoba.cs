using System.ComponentModel.DataAnnotations;

namespace MojeCV.Models;

public class Osoba
{
    public int Id { get; set; }

    [Required]
    public string Imie { get; set; } = "";

    [Required]
    public string Nazwisko { get; set; } = "";


    public string Stanowisko { get; set; } = "";



    [Required, EmailAddress]
    public string Email { get; set; } = "";
    public string? Telefon { get; set; }
    public string? Miasto { get; set; }

    [Display(Name = "O mnie")]
    public string? OMnie { get; set; }



    public List<Doswiadczenie> Doswiadczenia { get; set; } = new();
}
