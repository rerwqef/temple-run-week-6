 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Gamemanger : MonoBehaviour
{
public GameObject support;

    void Start()
    {
     
    }

    void Update()
    {

    }

    /*  private void OnTriggerEnter(Collider other)
      {
          if (other.findtag("triggerbrick"))
          {
              support.SetActive(false);

          }
      }*/
    public void quit()
    {
          Application.Quit();
    }
}
