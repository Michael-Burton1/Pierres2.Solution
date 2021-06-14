using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class FlavorTreat
  {
    [Key]
    public int FlavorTreatId { get; set; }
    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public virtual Treat Treat { get; set; }
  }
}