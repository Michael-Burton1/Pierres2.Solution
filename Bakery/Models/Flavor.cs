using System.Collections.Generic;

namespace Bakery.Models
{
  public class Flavors
  {
    public Flavors()
    {
      this.JoinFT = new HashSet<FlavorTreats>();
    }
    public int FlavorId {get; set;}
    public string Name {get; set;}
    public string Type {get; set;}
    public int Rating {get; set;}
    public virtual ApplicationUser User {get; set;}
    public virtual ICollection<FlavorTreats> JoinFT {get; set;}
  }
}