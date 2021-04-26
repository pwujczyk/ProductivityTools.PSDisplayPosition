using ProductivityTools.PSCmdlet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management.Automation;
using System.Text;

namespace ProductivityTools.DisplayPosition.Cmdlet.DisplayDetails
{
    [Description("Command displays information about all connected")]
    [Cmdlet(VerbsCommon.Get, "DisplayDetails")]
    public class ExternalDisplayToLeftCmdlet : PSCmdletPT
    {
        protected override void ProcessRecord()
        {
            WriteVerbose("Hello from ProductivityTools.DisplayPosition.Cmdlet");
            WriteVerbose("Getting display data");
            App.MoveDisplayApp app = new App.MoveDisplayApp();
            var x=app.GetDisplayDetails();
            WriteObject(x);
            WriteVerbose("Bye Bye!");
        }
    }
}
