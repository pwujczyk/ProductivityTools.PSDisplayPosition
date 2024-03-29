﻿using ProductivityTools.UnmanagedDisplayWrapper;
using System;

namespace ProductivityTools.DisplayPosition.App
{
    public class MoveDisplayApp
    {
        public void MoveDisplay(Direction direction)
        {
            Displays displays = new Displays();
            switch (direction)
            {
                case Direction.notDefined:
                    break;
                case Direction.Left:
                    displays.MoveExternalDisplayToLeft();
                    break;
                case Direction.Right:
                    displays.MoveExternalDisplayToRight();
                    break;
                default:
                    break;
            }
        }

        public Display[] GetDisplayDetails()
        {
            Displays displays = new Displays();
            displays.LoadData();
            return displays.ToArray();
        }
    }
}
