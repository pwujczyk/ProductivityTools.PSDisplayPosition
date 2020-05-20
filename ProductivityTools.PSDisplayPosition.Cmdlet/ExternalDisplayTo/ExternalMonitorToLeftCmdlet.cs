﻿using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using ProductivityTools.PSCmdlet;
using ProductivityTools.PSDisplayPosition.Cmdlet.Commands;

namespace ProductivityTools.PSDisplayPosition.Cmdlet
{
    [Cmdlet(VerbsCommon.Move,"ExternalMonitorToLeft")]
    public class ExternalMonitorToLeftCmdlet : ExternalMonitorToCmldetBase
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