using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MojeCV.Data;
using MojeCV.ViewModels;

namespace MojeCV.Controllers;

public class CvController : Controller
{
    private readonly CvContext _context;

    // kontekst dostarcza kontener DI zarejestrowany w Program.cs
    public CvController(CvContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        // Include() pobiera osobę razem z jej doświadczeniami (relacja jeden-do-wielu)
        var osoba = await _context.Osoba
            .Include(o => o.Doswiadczenia)
            .FirstOrDefaultAsync();
        if (osoba == null)
            return RedirectToAction("Create", "Osoby");

        var model = new CvViewModel
        {
            Osoba = osoba,
            Doswiadczenia = osoba.Doswiadczenia
                .OrderByDescending(d => d.DataOd).ToList(),
            Wyksztalcenia = await _context.Wyksztalcenie
                .OrderByDescending(w => w.DataOd).ToListAsync(),
            Umiejetnosci = await _context.Umiejetnosc
                .OrderByDescending(u => u.Poziom).ToListAsync(),
            Projekty = await _context.Projekt.ToListAsync()
        };
        return View(model);
    }
}
