using System.ComponentModel.DataAnnotations.Schema;

namespace EntranceEvidenceApi.Models
{
  public class Entrance
  {
    public long Id { get; set; }
    public long RFIDTagId { get; set; }

    [ForeignKey("RFIDTagId")]
    public RFIDTag RFIDTag { get; set; }

    public long GateId { get; set; }
    [ForeignKey("GateId")]
    public Gate Gate { get; set; }
  }
}
