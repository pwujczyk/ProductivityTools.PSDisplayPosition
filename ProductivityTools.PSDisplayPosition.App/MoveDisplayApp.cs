using ProductivityTools.UnmanagedDisplayWrapper;
using System;

namespace ProductivityTools.PSDisplayPosition.App
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
    }
}
