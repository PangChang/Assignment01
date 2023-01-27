using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit"); //Will not exit, but will just display the message in the game console.
        Application.Quit(); //To quit
    }
}
