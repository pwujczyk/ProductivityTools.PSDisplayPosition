using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.PSDisplayPosition.Cmdlet.Commands
{
    public class MoveDisplay : PSCmdlet.PSCommandPT<ExternalMonitorToLeftCmdlet>
    {
        public MoveDisplay(ExternalMonitorToLeftCmdlet cmdletType) : base(cmdletType)
        {
        }

        protected override bool Condition => true;

        protected override void Invoke()
        {
            WriteOutput("Hello");
        }
    }
}
