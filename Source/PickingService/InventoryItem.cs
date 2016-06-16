using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PickingService
{
  [DataContract]
  public class InventoryItem
  {
    [DataMember]
    public string ItemCode { get; set; }

    [DataMember]
    public decimal Quantity { get; set; }
  }
}
