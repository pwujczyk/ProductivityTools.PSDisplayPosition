using ProductivityTools.PSDisplayPosition.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.PSDisplayPosition.Cmdlet.Commands
{
    public class MoveDisplay : PSCmdlet.PSCommandPT<ExternalMonitorToCmldetBase>
    {
        public MoveDisplay(ExternalMonitorToCmldetBase cmdletType) : base(cmdletType)
        {
        }

        protected override bool Condition => true;

        protected override void Invoke()
        {
            MoveDisplayApp app = new MoveDisplayApp();
            if (base.Cmdlet is ExternalMonitorToLeftCmdlet)
            {
                app.MoveDisplay(Direction.Left);
            }

            if (base.Cmdlet is ExternalMonitorToRightCmldet)
            {
                app.MoveDisplay(Direction.Right);
            }
        }
    }
}
