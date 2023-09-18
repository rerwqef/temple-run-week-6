using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class uicontroller : MonoBehaviour
{
    public forplayer player;

    public Slider slider;
    public TextMeshProUGUI score;
    public GameObject pauseMenu;
    public GameObject gameover;
    public GameObject resumemenu;
    public GameObject ifpressedhold;
    public GameObject ifpressedmainmenu;
    public GameObject ifpressedquitinhold;
    public GameObject ifpressedsettings;
    public GameObject ifpressedlevelssettings;
    public GameObject ifpressedsoundsettings;


    int scorevalue = 0;
    public bool o;
    void Start()
    {

        o = false;
        //ayer = GetComponent<forplayer>();
    }
    public bool k = false;

    void Update()
    {
        score.text = (scorevalue).ToString();
        scorevalue += (int)Time.timeScale;

        //if (slider.value % 3000 == 0 && slider.value != 0)
        {
          //  player.runningSpeed = 50f * Time.deltaTime;
           // Invoke("BackToNormal", 6f);
       // }
     //   {

        }
        if (slider.value >= 3000)
        {
            PowerUp();
        }
        else
        {

            //  slider.value = scorevalue % 3000;


        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (k)
        {


            //  Debug.Log("Time.timeScale: " + Time.timeScale);
        }

        Gameover();
        ChangeSliderValue();
    }






    void PowerUp()
    {
        //  Debug.Log("dsjfhg");
        // controller.v = 1f;
        // ur speed up
        slider.value = 0f;
    }

    void BackToNormal()
    {
        player.runningSpeed = 20f * Time.deltaTime;
    }


    public void ChangeSliderValue()
    {
        // newValue += 0.1f;
        // Change the value of the slider
        slider.value += player.coinvalue*10*Time.deltaTime;
    }

    public void pause()
    {
        pauseMenu.SetActive(false);
        resumemenu.SetActive(true);
        Time.timeScale = 0f;//for pausing used
        ifpressedhold.SetActive(true);
        o = true;
        if (o)
        {
            //  player.runningSpeed = 0f;
            //       player.turnspeed = 0f;
        }
    ;
    }
    public void resume()
    {
        resumemenu.SetActive(false);
        pauseMenu.SetActive(true);

        Time.timeScale = 1f;//for restart
        o = false;

    }


    public void presssedcontinue()
    {
        ifpressedhold.SetActive(false);
    }

    public void mainmenupressed()
    {
        ifpressedhold.SetActive(false);
        ifpressedmainmenu.SetActive(true);
    }

    public void gotomainmenu()
    {

    }

    public void returntoifholdpressed()
    {
        ifpressedmainmenu.SetActive(false);
        ifpressedhold.SetActive(true);
    }

    public void ifpresssedexitinhold()
    {
        ifpressedhold.SetActive(false);
        ifpressedquitinhold.SetActive(true);

    }
    public void quit()
    {
        Application.Quit();
    }
    public void ifpressedquitholdno()
    {
        ifpressedquitinhold.SetActive(false);
        ifpressedhold.SetActive(true);

    }
    public void ifpressedsettingst()
    {
        ifpressedsettings.SetActive(true);
    }
    public void ifpressedlevels()
    {
        ifpressedsettings.SetActive(false);
        ifpressedlevelssettings.SetActive(true);
    }
    public void ifpressedbackinlevels()
    {
        ifpressedsettings.SetActive(true);
        ifpressedlevelssettings.SetActive(false);
    }
    public void ifpressedsoundsetting()
    {
        ifpressedsettings.SetActive(false);
        ifpressedhold.SetActive(false);
        ifpressedsoundsettings.SetActive(true);
    }
    public void ifpressedbackinsoundsettings()
    {
        ifpressedsoundsettings.SetActive(false);
        ifpressedsettings.SetActive(true);
    }
    public void ifpressedsettingsback()
    {
        ifpressedsettings.SetActive(false);
        ifpressedhold.SetActive(false);
    }
    public void ku()
    {
        Debug.Log("sdkhfgjhb");
    }

    public void timedown()
    {
        Time.timeScale = 0;
    }
    public void timeup()
    {
        Time.timeScale = 1f;
    }
    public void playagin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;

    }
    public void Gameover()
    {

         Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
        if (player.transform.position.y < -2)
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
        }
    }
}