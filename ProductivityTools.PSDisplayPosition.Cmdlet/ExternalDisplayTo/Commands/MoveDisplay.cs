using ProductivityTools.PSDisplayPosition.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.PSDisplayPosition.Cmdlet.Commands
{
    public class MoveDisplay : PSCmdlet.PSCommandPT<ExternalDisplayToCmldetBase>
    {
        public MoveDisplay(ExternalDisplayToCmldetBase cmdletType) : base(cmdletType)
        {
        }

        protected override bool Condition => true;

        protected override void Invoke()
        {
            MoveDisplayApp app = new MoveDisplayApp();
            if (base.Cmdlet is ExternalDisplayToLeftCmdlet)
            {
                app.MoveDisplay(Direction.Left);
            }

            if (base.Cmdlet is ExternalDisplayToRightCmldet)
            {
                app.MoveDisplay(Direction.Right);
            }
        }
    }
}
