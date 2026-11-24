using System.ComponentModel.DataAnnotations;

namespace MojeCV.Models;

public class Doswiadczenie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Podaj stanowisko")]
    [StringLength(100)]
    public string Stanowisko { get; set; } = "";

    [Required, StringLength(100)]
    public string Firma { get; set; } = "";

    public int CzasTrwania   // w miesiącach, liczone do DataDo albo do dziś
    {
        get
        {
            DateTime koniec;
            if (DataDo != null && DataDo <= DateTime.Today)
            {
                koniec = DataDo.Value;
            }
            else
            {
                koniec = DateTime.Today;
            }

            int miesiace = (koniec.Year - DataOd.Year) * 12 + koniec.Month - DataOd.Month + 1;
            return miesiace;
        }
    }

    [Display(Name = "Od"), DataType(DataType.Date)]
    public DateTime DataOd { get; set; }


    [Display(Name = "Do"), DataType(DataType.Date)]
    public DateTime? DataDo { get; set; }   // null = nadal pracuję


    [StringLength(1000)]
    public string? Opis { get; set; }

    public int OsobaId { get; set; }
    public Osoba? Osoba { get; set; }
}
