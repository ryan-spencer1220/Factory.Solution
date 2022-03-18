using System.Collections.Generic;

namespace SillystringFactory.Models
{
  public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<EngineerMachine>();
        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        public string EnginnerStatus { get; set; }
        public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
    }
}