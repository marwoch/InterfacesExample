using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Walkman : IRemoteControl
    {
        public void Mute()
        {
            throw new NotImplementedException();
        }

        public void TogglePower()
        {
            throw new NotImplementedException();
        }

        public void VolumeDown()
        {
            throw new NotImplementedException();
        }

        public void VolumeUp()
        {
            throw new NotImplementedException();
        }
    }

    class ComputerRemote : IRemoteControl
    {
        public void Mute()
        {
            throw new NotImplementedException();
        }

        public void TogglePower()
        {
            throw new NotImplementedException();
        }

        public void VolumeDown()
        {
            throw new NotImplementedException();
        }

        public void VolumeUp()
        {
            throw new NotImplementedException();
        }
    }
}
