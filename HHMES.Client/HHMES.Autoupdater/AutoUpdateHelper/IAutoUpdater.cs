using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autoupdater
{
    public interface IAutoUpdater
    {
        void Update();

        void RollBack();

        
    }
}
