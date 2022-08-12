using System;
using RAGE;

namespace CursorVisibility
{
    public class CursorVisibility : Events.Script
    {
        public CursorVisibility()
        {
            Events.Add("SetCursorVisibility", SetCursorVisibility);
        }

        public void SetCursorVisibility(object [] args)
        {
            RAGE.Ui.Cursor.Visible = (bool)args[0];
        }
    }
}
