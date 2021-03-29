using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assignment8
{
    public class SwordGen : MonoBehaviour
    {
        SSword sSword = new SSword();
        ISword iSword = new ISword();
        public Text mytext;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (this.gameObject.GetComponent("red"))
                    {
                        if (hit.transform != null)
                        {
                            Debug.Log("This works");
                            sSword.completeForge();
                            mytext.text = sSword.printText();
                        }
                    }
                    else
                    {
                        if (hit.transform != null)
                        {
                            Debug.Log("This works");
                            sSword.completeForge();
                            mytext.text = iSword.printText();
                        }
                    }
                }
            }

        }
    }
}
