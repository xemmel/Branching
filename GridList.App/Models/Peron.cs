using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridList.App.Models
{
  public class Peron
  {
    public string Name { get; set; }
    public DateTime BirthDay { get; set; }
    public DateTime? Death { get; set; }

    public bool Alive
    {
      get
      {
        return !Death.HasValue;
      }
    }
  }
}
