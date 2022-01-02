using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape_Game : MonoBehaviour
{
    
    void Update()
    {
       
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
