using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Final4360.Pages;

public class AddModel : PageModel
{
    private readonly ILogger<AddModel> _logger;
    private readonly DBContext _context;
    public List<posting> postings {get; set;} = default!;
    public SelectList PostingDropDown {get; set;} = default!;
    public List<resident> residents {get; set;} = default!;
    [BindProperty]
    [Display(Name = "Resident")]
    [StringLength(60)]
    [Required]
    public string ResidentSelected {get; set;}= default!;
    [BindProperty]
    [Display(Name = "Posting Service")]
    [Required]
    public int PostingID {get; set;}= default!;
    [BindProperty]
    [Display(Name = "Delivery Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString ="0:mm/dd/yyyy",ApplyFormatInEditMode =true)]
    [Required]
    public DateTime DeliveryDate {get; set;}
    public AddModel(DBContext context,ILogger<AddModel> logger)
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
            residents=_context.resident.ToList();
            postings=_context.posting.ToList();
            PostingDropDown = new SelectList(postings, "PostingID", "Service");
        }
    }
    
    public void OnPost()
    {
        residents=_context.resident.ToList();
        postings=_context.posting.ToList();
        PostingDropDown = new SelectList(postings, "PostingID", "Service");
        var holder=_context.resident.FirstOrDefault(resident => resident.FullName == ResidentSelected);
        if(holder!=null)
        {
            _logger.LogInformation("OnPost() Called for resident "+ResidentSelected+" "+PostingID+" "+DeliveryDate);
            _context.package.Add(new package{ResidentID = holder.ResidentID,PostingID=PostingID,DeliveryDate = DeliveryDate,PickupDate=null});
            _context.SaveChanges();
            Email.send(holder.Email);
            Response.Redirect("./add");
        }
        else
        {
            _logger.LogInformation("OnPost() Called for unknown "+ResidentSelected+" "+PostingID+" "+DeliveryDate);
            _context.unknown.Add(new unknown{FullName = ResidentSelected,PostingID=PostingID,DeliveryDate = DeliveryDate});
            _context.SaveChanges();
            Response.Redirect("./add");
        }
    }
}