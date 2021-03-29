using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assignment8
{
    public class SSword : Sword
    {
        public  bool isSilvered()
        {
            return true;
        }

        Text text;
        string savedText;
        public override void addEnchant()
        {
            savedText = savedText + "This sword is enchanted.";
            savedText = savedText + "\n";

        }

        public override void addSilver()
        {
            savedText = savedText + "This sword is silvered.";
            savedText = savedText + "\n";
        }

        public override void Damage()
        {
            savedText = savedText + "This sword does 7 damage.";
            savedText = savedText + "\n";
        }

        public string printText()
        {
            return savedText;
        }

    }
}