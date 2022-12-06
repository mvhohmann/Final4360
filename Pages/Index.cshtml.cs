using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Final4360.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly DBContext _context;
    public static int login=0;
    public static bool loginpass=false;
    [BindProperty]
    [Display(Name = "Username")]
    [StringLength(60,MinimumLength =3)]
    [Required]
    public string Username {get; set;} = string.Empty;
    [BindProperty]
    [Display(Name = "Password")]
    [StringLength(60,MinimumLength =3)]
    [Required]
    public string Password {get; set;} = string.Empty;

    public IndexModel(DBContext context,ILogger<IndexModel> logger)
    {
        _context=context;
        _logger = logger;
    }

    public void OnGet()
    {
        login=0;
        loginpass=false;
    }
    
    public void OnPost()
    {
        _logger.LogInformation("OnPost() Called "+Username+" "+Password);
        var holder=_context.staff.FirstOrDefault(staff => staff.StaffUsername == Username);
        if(holder!=null&&holder.StaffPassword==Password)
        {
            login=holder.StaffID;
            loginpass=true;
            Response.Redirect("./add");
        }
    }
}
