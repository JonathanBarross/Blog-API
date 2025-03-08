using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Nome obrigatório")]
    [MaxLength(10)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "E-mail obrigatório")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [MinLength(5)]
    public string Email { get; set; }
}