using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoliCheat.ModSystem
{
    public class VMod
    {
        public virtual string ModName => "Default Mod";
        public virtual void OnStart() { }
        public virtual void OnUpdate() { }
        public virtual void OnFixedUpdate() { }
        public virtual void OnLateUpdate() { }
        public virtual void OnGUI() { }
        public virtual void OnQuit() { }
    }
}
