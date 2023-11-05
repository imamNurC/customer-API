
namespace CustomerAPI.Models;
//mengacu untuk membuat skema database dan properti2 nya
public class CustomerModel
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? HomeAddress { get; set; }
}
