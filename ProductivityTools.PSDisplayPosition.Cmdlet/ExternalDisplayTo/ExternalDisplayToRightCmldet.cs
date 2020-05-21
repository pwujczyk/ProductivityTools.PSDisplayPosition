﻿using System;
using System.ComponentModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using ProductivityTools.PSCmdlet;
using ProductivityTools.PSDisplayPosition.Cmdlet.Commands;

namespace ProductivityTools.PSDisplayPosition.Cmdlet
{
    [Description("Command moves external display to the right")]
    [Cmdlet(VerbsCommon.Move,"ExternalDisplayToRight")]
    public class ExternalDisplayToRightCmldet : ExternalDisplayToCmldetBase
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
