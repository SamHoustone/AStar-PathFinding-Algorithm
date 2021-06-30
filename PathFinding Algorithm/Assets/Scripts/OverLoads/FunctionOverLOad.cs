using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionOverLOad : MonoBehaviour
{
    public string Add(string firstString,string secondString)
    {
        return firstString + secondString;
    }
    public int Add(int firstnumber,int secondnumber)
    {
        return firstnumber + secondnumber;
    }
    private void Start()
    {
        Debug.Log(Add(1,2));
    }
}
