using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final4360.Pages;

public class RemoveModel : PageModel
{
    private readonly ILogger<RemoveModel> _logger;
    private readonly DBContext _context;
    public SelectList PackagesDropDown {get; set;} = default!;
    [BindProperty]
    [Display(Name = "Packages")]
    [Required]
    public int PackageSelect {get; set;}= default!;

    public RemoveModel(DBContext context,ILogger<RemoveModel> logger)
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
            PackagesDropDown = new SelectList((from p in _context.package join r in _context.resident on p.ResidentID equals r.ResidentID join s in _context.posting on p.PostingID equals s.PostingID where p.PickupDate==null select new {PackageID=p.PackageID,Data=r.FullName+" "+s.Service+" "+p.DeliveryDate.Date.ToShortDateString()}), "PackageID", "Data");
        }
    }
    public void OnPost()
    {
        _logger.LogInformation("OnPost() Called "+PackageSelect);
        var holder=_context.package.FirstOrDefault(package => package.PackageID == PackageSelect);
        holder!.PickupDate=DateTime.Now;
        _context.SaveChanges();
        Response.Redirect("./remove");
    }
}
