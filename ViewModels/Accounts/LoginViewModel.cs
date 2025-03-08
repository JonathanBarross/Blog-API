using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts;
public class LoginViewModel
{
    [Required(ErrorMessage = "O campo senha está vazio.")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "O campo e-mail está vazio.")]
    [EmailAddress(ErrorMessage = "E-mail inválido.")]
    public string Email { get; set; }
}