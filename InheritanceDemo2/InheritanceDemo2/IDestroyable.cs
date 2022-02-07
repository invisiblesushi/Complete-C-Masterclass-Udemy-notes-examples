using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    interface IDestroyable
    {
        //Prop to store audio file of destruction sound
        string DestructionSound { get; set; }

        //mehtod to destroy an object
        void Destroy();
    }
}
