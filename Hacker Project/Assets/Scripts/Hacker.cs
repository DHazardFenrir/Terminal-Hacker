using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string greeting = "Scanner Finished. Human detected";
    // Start is called before the first frame update
    void Start()
    {
        
       ShowMainMenu(greeting);
        
    }

    void ShowMainMenu(string welcomeMessage)
    {
        
        Terminal.ClearScreen();
        Terminal.WriteLine(welcomeMessage);
       Terminal.WriteLine("Hello, you were choosen to perform one of our experiments");
        Terminal.WriteLine("Please, select your test to prove your ability");
        Terminal.WriteLine("Press 1 for a Local Home");
        Terminal.WriteLine("Press 2 for a Local Shop");
        Terminal.WriteLine("Press 3 for CIA Headquarters");
        Terminal.WriteLine("Enter your selection: ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
