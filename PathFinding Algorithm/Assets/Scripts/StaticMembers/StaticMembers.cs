using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMembers : MonoBehaviour
{
    [SerializeField]
    private static string Name = "StaticMan";

    private void Start()
    {
        Debug.Log(Name);
    }
}