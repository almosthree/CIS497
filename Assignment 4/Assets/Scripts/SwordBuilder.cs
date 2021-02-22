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


        /*void Start()
        {
           
        }*/

        // Update is called once per frame
        /*void Update()
        {

        }*/

        // We could create the object and add decorators with
        // one method per setting:
        /*        public void SetRaceElf()
                {
                    this.character = new RaceElf();
                    DisplayCharacter();
                }

                public void SetRaceTroll()
                {
                    this.character = new RaceTroll();
                    DisplayCharacter();
                }

                public void AddProfessionWarrior()
                {
                    this.character = new ProfessionWarrior(character);
                    DisplayCharacter();
                }

                public void AddProfessionWizard()
                {
                    this.character = new ProfessionWizard(character);
                    DisplayCharacter();
                }*/

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