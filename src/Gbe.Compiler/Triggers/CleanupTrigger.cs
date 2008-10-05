using System.Collections.Generic;
using Gbe.Compiler.Actions;

namespace Gbe.Compiler.Triggers
{
    public class CleanupTrigger : Trigger
    {
        public CleanupTrigger(List<Action> actions) : base(actions)
        {
        }
    }
}
