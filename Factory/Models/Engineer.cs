using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
    {
      public Engineer()
      {
        this.Machines = new HashSet<EngineerMachine>();
      }

      public int EngineerId { get; set; }
      public int MachineId { get; set; }
      public string Name { get; set; }
      public string Degree { get; set; }

      public  ICollection<EngineerMachine> Machines { get; set; }
    }
}