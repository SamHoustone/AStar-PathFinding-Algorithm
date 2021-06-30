using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerenaryUseCase : MonoBehaviour
{
    private bool isDead;
    private string outputMessage;
    private int Health = 1;

    private void Start()
    {
        outputMessage = Health == 1 ? "Correct" : "Wrong";
        Debug.Log(outputMessage);
    }
}
