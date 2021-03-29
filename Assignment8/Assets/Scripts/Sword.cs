using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assignment8
{
    
    public abstract class Sword
    {
        public Text mytext;
        private string savedText;

        public void MakeSword()
        {
            completeForge();
            
            if(isSilvered())
            {
                addSilver();
            }
            if(isEnchanted())
            {
                addEnchant();
            }
            
        }

        bool isEnchanted()
        {
            return false;
        }

        public void completeForge()
        {
            //savedText = "Your sword has been completed! Click S to check your new sword.";
        }
        public abstract void addEnchant();

        public abstract void Damage();

        public abstract void addSilver();

        bool isSilvered()
        {
            return false;
        }


    }
}