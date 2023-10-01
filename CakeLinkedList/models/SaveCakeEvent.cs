using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeLinkedList.models
{
    //Esta clase es utilizada para enviar datos entre componentes. Encapsula el pastel a 
    //agregar y en si debe ser agregado al inicio o al final
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
