using System.ComponentModel.DataAnnotations;
using Org.BouncyCastle.Bcpg.Sig;

namespace UmbracoCMS.ViewModels;

public class CallbackFormViewModel
{
    [Required(ErrorMessage = "Name is required.")]
    [Display(Name = "Name")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Email is required.")]
    [Display(Name = "Email address")]
    [RegularExpression (@"^(([^<>()\[\]\\.,;:\s@\""]+(\.[^<>()\[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}(\.[0-9]{1,3}){3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", 
    ErrorMessage = "Invalid Email address")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Phone is required.")]
    [Display(Name = "Phone")]
    public string Phone { get; set; } = null!;

    [Required(ErrorMessage = "Please select an option.")]
    public string SelectedOption { get; set; } = null!;

}
