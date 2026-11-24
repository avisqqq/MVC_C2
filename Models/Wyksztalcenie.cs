using System.ComponentModel.DataAnnotations;

namespace MojeCV.Models;


public class Wyksztalcenie
{
    public int Id { get; set; }

    [Required, StringLength(150)]
    public string Uczelnia { get; set; } = "";


    public string Tytul { get; set; } = "";

    [Required, StringLength(100)]
    public string Kierunek { get; set; } = "";
    public string Forma { get; set; } = "";

    [DataType(DataType.Date)]
    public DateTime DataOd { get; set; }
    public DateTime? DataDo { get; set; }   // null = nadal studiuję
}
