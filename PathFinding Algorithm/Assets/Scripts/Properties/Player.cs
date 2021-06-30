using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Machine machine;
    private void Start()
    {
        Debug.Log(machine.Name);
        machine.Name = "Fuck";
        Debug.Log(machine.Name);

    }
}
