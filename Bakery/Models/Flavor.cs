using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinFT = new HashSet<FlavorTreat>();
    }
    public int FlavorId {get; set;}
    public string Name {get; set;}
    public string Type {get; set;}
    public int Rating {get; set;}
    public virtual ApplicationUser User {get; set;}
    public virtual ICollection<FlavorTreat> JoinFT {get; set;}
  }
}