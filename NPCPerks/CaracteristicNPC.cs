using System;
using System.Collections.Generic;
using System.Text;

namespace NPCPerks
{
    [Flags]
    enum caracteristcsNPC
    {
        //1 bit, 2 bits, 4 bits e 8 bits
        Stealth = 1,
        Combat = 2,
        Lockpick = 4,
        Luck = 8
    }
}
