using System;
using System.Collections.Generic;

namespace Practices
{
    public class Work
    {
        public int ID => counter++;
        public string Name { get; set; }
        private static int counter = 0;
    }

    public class WorkWrap
    {
        public List<Work> WorkCollections { get; set; }
        public WorkWrap()
        {
            WorkCollections = new List<Work>();
            Mediator.GetMediatorInstance().WorkChanged += (s, e) =>
            {
                WorkCollections.Add(e.Work);
            };
        }

        public void PrintOut()
        {
            foreach (var workCollection in WorkCollections)
            {
                Console.WriteLine($"ID {workCollection.ID} - Name {workCollection.Name}");
            }
        }
    }
}
