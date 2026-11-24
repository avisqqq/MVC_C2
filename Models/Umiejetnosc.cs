using System.ComponentModel.DataAnnotations;

namespace MojeCV.Models;

public class Umiejetnosc
{
    public int Id { get; set; }
    public string Nazwa { get; set; } = "";

    [Range(1, 5)]
    public int Poziom { get; set; }   // 1–5
    public string Kategoria { get; set; } = "";
}
