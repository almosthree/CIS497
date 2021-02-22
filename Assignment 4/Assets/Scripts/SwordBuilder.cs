using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DecoratorPattern  
{
    public class SwordBuilder : MonoBehaviour
    {
        //This reference holds the character object being created
        public Sword Sword;
        public void AddRune(string newRune)
        {
            switch (newRune)
            {
                case "Fire":
                    this.Sword = new RuneFire(Sword);
                    break;
                case "Nature":
                    this.Sword = new RuneNature(Sword);
                    break;
            }
            //Then update the display
            DisplayCharacter();
        }

        public void DisplayCharacter()
        {
            gameObject.GetComponent<Text>().text = Sword.GetDescription() +
                " does " + Sword.GetDamage() + " damage.";
        }

    }
}