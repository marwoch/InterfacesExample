using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    interface IRemoteControl
    {
        void VolumeUp();

        void VolumeDown();

        void Mute();

        void TogglePower();
    }
}
