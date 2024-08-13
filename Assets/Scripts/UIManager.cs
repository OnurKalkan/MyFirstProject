using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu, inGameMenu, endMenu;
    public Image healthBar;
    public GameObject newGameButton, resumeGameButton, bgMusic;
    public Toggle soundOnOff;
    public Slider volumeSlider;
    public TMP_Dropdown resolutionChanger;
    public TMP_InputField charName;
    public TextMeshProUGUI welcomeText, playerName;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("CharName") != "")
            welcomeText.text = "Welcome " + PlayerPrefs.GetString("CharName") + "!!";
        else
            welcomeText.text = "Welcome Player!!";
        playerName.text = PlayerPrefs.GetString("CharName");

        volumeSlider.value = bgMusic.GetComponent<AudioSource>().volume;
        healthBar.fillAmount = (float)GameObject.FindGameObjectWithTag("Player").GetComponent<CubePerson>().health / 100.0f;
        StartingMenuOrder();
        print(Screen.currentResolution + "\n" + SystemInfo.deviceModel);
    }

    void StartingMenuOrder()
    {
        mainMenu.SetActive(true);
        endMenu.SetActive(false);
        inGameMenu.SetActive(false);
        resumeGameButton.SetActive(false);
        newGameButton.SetActive(true);
    }

    public void StartNewGame()
    {
        mainMenu.SetActive(false);
        endMenu.SetActive(false);
        inGameMenu.SetActive(true);
    }

    public void OpenInGameMenu()
    {
        mainMenu.SetActive(false);
        endMenu.SetActive(false);
        inGameMenu.SetActive(true);
    }

    public void OpenMainMenu()
    {
        mainMenu.SetActive(true);
        endMenu.SetActive(false);
        inGameMenu.SetActive(false);
        //newGameButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Resume Game";
        resumeGameButton.SetActive(true);
        newGameButton.SetActive(false);
    }

    public void ExitToDesktop()
    {
        Application.Quit();//windows'a doner
        print("The game closed!");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//kendi kendini tekrar acar
        //SceneManager.LoadScene(0);//index no'su 0 olan leveli acar
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//bir sonraki index no'lu leveli acar
    }

    public void SomeLogMessage()
    {
        print("will switch to next level");
    }

    public void SoundOnOff()
    {
        if(soundOnOff.isOn == true)
        {
            bgMusic.GetComponent<AudioSource>().mute = false;
        }
        else
        {
            bgMusic.GetComponent<AudioSource>().mute = true;
        }            
    }

    public void VolumeChanger()
    {
        bgMusic.GetComponent<AudioSource>().volume = volumeSlider.value;
    }

    public void ChangeResolution()
    {
        if(resolutionChanger.value == 0)
        {
            print("HD");
            Screen.SetResolution(1920, 1080, true);
        }
        else if(resolutionChanger.value == 1)
        {
            print("2K");
            Screen.SetResolution(2160, 1440, true);
        }
        else if (resolutionChanger.value == 2)
        {
            print("4K");
            Screen.SetResolution(3840, 2160, true);
        }
    }

    public void SetYourName()
    {
        PlayerPrefs.SetString("CharName", charName.text);
        welcomeText.text = "Welcome " + PlayerPrefs.GetString("CharName") + "!!";
        playerName.text = PlayerPrefs.GetString("CharName");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (mainMenu.activeInHierarchy == true)
                OpenInGameMenu();
            else
                OpenMainMenu();
        }
    }
}
