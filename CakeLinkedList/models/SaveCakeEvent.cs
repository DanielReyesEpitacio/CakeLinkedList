using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeLinkedList.models
{
    public class SaveCakeEvent
    {
        public Cake cake { get; set; }
        public string actionType { get; set; }

        public SaveCakeEvent(Cake cake, string actionType)
        {
            this.cake = cake;
            this.actionType = actionType;
        }
    }
}
