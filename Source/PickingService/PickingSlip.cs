using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PickingService
{
  [DataContract]
  public class PickingSlip
  {
    [DataMember]
    public string DocumentNumber { get; set; }

    Collection<InventoryItem> mItems;
    [DataMember]
    public Collection<InventoryItem> Items
    {
      get { return mItems ?? (mItems = new Collection<InventoryItem>()); }
    }
  }
}
