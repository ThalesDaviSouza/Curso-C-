using System.Collections.Generic;

namespace Sets.Entities {
    internal class Course {
    
        public HashSet<int> Students { get; private set; } = new HashSet<int>();

    }
}
