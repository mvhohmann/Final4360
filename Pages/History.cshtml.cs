using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final4360.Pages;

public class HistoryModel : PageModel
{
    private readonly ILogger<HistoryModel> _logger;
    private readonly DBContext _context;
    public SelectList ResidentsDropDown {get; set;} = default!;
    
    public SelectList PackagesSelected {get; set;} = default!;
    [BindProperty]
    [Display(Name = "Resident")]
    [Required]
    public int ResidentSelect {get; set;}= default!;

    public HistoryModel(DBContext context, ILogger<HistoryModel> logger)
    {
        _context=context;
        _logger = logger;
    }

    public void OnGet()
    {
        if(!@IndexModel.loginpass)
        {
            Response.Redirect("./index");
        }
        else
        {
            ResidentsDropDown = new SelectList((from r in _context.resident select new {ResidentID=r.ResidentID,Data=r.FullName+" "+r.UnitNumber}), "ResidentID", "Data");
            PackagesSelected=new SelectList(Enumerable.Empty<SelectListItem>());
        }
    }
    public void OnPost()
    {
        _logger.LogInformation("OnPost() Called "+ResidentSelect);
        ResidentsDropDown = new SelectList((from r in _context.resident select new {ResidentID=r.ResidentID,Data=r.FullName+" "+r.UnitNumber}), "ResidentID", "Data");
        PackagesSelected=new SelectList((from p in _context.package join r in _context.resident on p.ResidentID equals r.ResidentID join s in _context.posting on p.PostingID equals s.PostingID where p.ResidentID==ResidentSelect select new {PackageID=p.PackageID,Data=r.FullName+" "+s.Service+" "+p.DeliveryDate.Date.ToShortDateString()+" "+p.PickupDate!.Value.ToShortDateString()}), "PackageID", "Data");
    }
}
