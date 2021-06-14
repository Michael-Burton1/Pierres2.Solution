using System;
using System.Collections.Generic;


namespace Bakery.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinFT = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Style { get; set; }
    public int PrepTime { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinFT { get; }
  }
}