using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class inputcontroller : MonoBehaviour
{
    
    EventSystem system;
    public Selectable firstinput;
    void Start()
    {
        system = EventSystem.current;//in navigation order input box selected
        firstinput.Select();
    }

    // Update is called once per frame
    void Update()
    {
        //enter um up arow press chyrhal previous selectod box il povum
      /*  if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Selectable before = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
            if (before != null)
            {
                before.Select();
            }
            //enter press cheythal next select aavum
            else if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
                if (next != null)
                {
                    next.Select();
                }
            }
        }*/
    }
}
