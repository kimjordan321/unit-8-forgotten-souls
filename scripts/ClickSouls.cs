using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickSouls : MonoBehaviour
{

    public static float souls;
    public TextMeshProUGUI soulsDisplay;

    public static float click = 1f;
    public GameObject pauseMenu;
    public bool paused = false;
    

	// Use this for initialization
	void Start ()
    {
        paused = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        soulsDisplay.text = "Souls: " + souls.ToString("F0");
        Menu();
    }

    public void Click()
    {
        souls += click;
    }

    private void Menu()
    {
        if (Input.GetButtonDown("Cancel") && paused == false)
        {
            print("pause");
            paused = true;
            pauseMenu.SetActive(true);
        }

        else if (Input.GetButtonDown("Cancel") && paused == true)
        {
            print("Unpause");
            paused = false;
            pauseMenu.SetActive(false);
        }
    }
}
