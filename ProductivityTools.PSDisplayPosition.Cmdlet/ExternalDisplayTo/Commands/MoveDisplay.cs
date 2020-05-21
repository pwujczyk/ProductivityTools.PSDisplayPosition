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
            this.Cmdlet.WriteVerbose("Hello from ProductivityTools.PSDisplayPosition.Cmdlet");
            MoveDisplayApp app = new MoveDisplayApp();
            if (base.Cmdlet is ExternalDisplayToLeftCmdlet)
            {
                this.Cmdlet.WriteVerbose("Move external display to left was chosen");
                app.MoveDisplay(Direction.Left);
            }

            if (base.Cmdlet is ExternalDisplayToRightCmldet)
            {
                this.Cmdlet.WriteVerbose("Move external display to right was chosen");
                app.MoveDisplay(Direction.Right);
            }

            this.Cmdlet.WriteVerbose("Operation was done display should be moved");
            this.Cmdlet.WriteVerbose("Bye Bye!");
        }
    }
}
