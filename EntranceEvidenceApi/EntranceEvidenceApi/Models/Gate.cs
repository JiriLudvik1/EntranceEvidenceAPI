using System.ComponentModel.DataAnnotations;

namespace EntranceEvidenceApi.Models
{
  public class Gate
  {
    public long Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }
  }
}
