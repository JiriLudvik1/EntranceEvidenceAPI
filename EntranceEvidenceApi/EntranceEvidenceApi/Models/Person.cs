using System.ComponentModel.DataAnnotations;

namespace EntranceEvidenceApi.Models
{
  public class Person
  {
    public long Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public bool IsActive { get; set; } = true;
  }
}
