using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public class CustomerPlan
    {
        public PlanVersion PlanVersion { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public List<string> CompanyPolicies { get; set; }
        public List<string> Regulations { get; set; }
        public List<string> Languages { get; set; }

        public CustomerPlan()
        {
        }

        public object DeepCopy()
        {
            using(var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, this);
                memoryStream.Position = 0;

                return (CustomerPlan)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }

    [Serializable]
    public class PlanVersion
    {
        public int Version { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Expiration { get; set; }
    }

}
