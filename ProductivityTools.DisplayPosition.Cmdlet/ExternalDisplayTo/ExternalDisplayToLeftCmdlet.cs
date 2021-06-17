using System;
using System.ComponentModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using ProductivityTools.PSCmdlet;
using ProductivityTools.DisplayPosition.Cmdlet.Commands;

namespace ProductivityTools.DisplayPosition.Cmdlet
{
    [Description("Command moves external display to the left")]
    [Cmdlet(VerbsCommon.Move,"ExternalDisplayToLeft")]
    public class ExternalDisplayToLeftCmdlet : ExternalDisplayToCmldetBase
    {
        protected override void BeginProcessing()
        {
            base.AddCommand(new MoveDisplay(this));
        }

        protected override void ProcessRecord()
        {
            this.ProcessCommands();
        }
    }
}
