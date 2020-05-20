using ProductivityTools.PSCmdlet;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace ProductivityTools.PSDisplayPosition.Cmdlet.DisplayDetails
{
    [Cmdlet(VerbsCommon.Get, "DisplayDetails")]
    public class ExternalDisplayToLeftCmdlet : PSCmdletPT
    {
        protected override void ProcessRecord()
        {
            App.MoveDisplayApp app = new App.MoveDisplayApp();
            var x=app.GetDisplayDetails();
            WriteObject(x);
        }
    }
}
