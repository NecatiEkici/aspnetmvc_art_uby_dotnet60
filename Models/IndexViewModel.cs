using Art.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Art.Models;

public class IndexViewModel
{

    /*Validations*/
    [Required(ErrorMessage = "Lütfen doldurunuz!")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Lütfen doldurunuz!")]
    public string? Lastname { get; set; }

    [Required(ErrorMessage = "Lütfen doldurunuz!")]
    [EmailAddress(ErrorMessage = "Geçerli bir e-mail adresi giriniz!")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Lütfen doldurunuz!")]
    public string? Message { get; set; }


    /*Others*/
    public Site? Site { get; set; }

    public IEnumerable<Slide>? Slides { get; set; }

    public Blog? Blog { get; set; }
    public IEnumerable<Blog>? Blogs { get; set; }

    public Event? Event { get; set; }
    public IEnumerable<Event>? Events { get; set; }
    public IEnumerable<Comment>? Comments { get; set; }

}
