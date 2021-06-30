using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicAndPrivateMembers : MonoBehaviour
{
    [SerializeField]
    private string Name;

    private void Start()
    {
        Debug.Log(Name);
    }
}
