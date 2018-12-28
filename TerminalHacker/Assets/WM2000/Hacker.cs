using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MainMenu();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    int level, screen = 0;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen = Screen.MainMenu;

    void MainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("HACKERMAN! HACKERMAN!");
        Terminal.WriteLine("Does whatever a hacker can!\n");
        Terminal.WriteLine("Press 1 to hack into a box");
        Terminal.WriteLine("Press 2 to hack into my laptop");
        Terminal.WriteLine("Press 3 to hack into the TARDIS");
    }

    void OnUserInput(string input)
    {
        if (input == "1")
        {
            Terminal.WriteLine("You chose to hack into a box");
            level = 1;
            currentScreen = Screen.Password;
            GameStart();
        }
        else if (input == "2")
        {
            Terminal.WriteLine("You chose to hack into a my laptop. BEWARE!");
            level = 2;
            currentScreen = Screen.Password;
            GameStart(); 
        }
        else if (input == "3")
        {
            Terminal.WriteLine("You chose to hack into the TARDIS. How good do you think you are?");
            level = 3;
            currentScreen = Screen.Password;
            GameStart();
        }
        else if (input == "menu")
            MainMenu();
        else if (input == "Easter Egg?")
            Terminal.WriteLine("Created by D-3P0");
        else
            Terminal.WriteLine("Follow the instructions");
    }

    void GameStart()
    {
        
    }
}