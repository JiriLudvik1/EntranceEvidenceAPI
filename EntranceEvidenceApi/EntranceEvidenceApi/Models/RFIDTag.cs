using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntranceEvidenceApi.Models
{
  public class RFIDTag
  {
    public long Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string EPC { get; set; }

    public long OwnerId { get; set; }
    [ForeignKey("OwnerId")]
    public Person Owner { get; set; }
  }
}
