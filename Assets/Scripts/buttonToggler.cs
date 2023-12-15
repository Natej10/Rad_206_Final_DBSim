using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class buttonToggler : MonoBehaviour
{
    public GameObject thisObject;
    void Start()
    {

    }
    void Update()
    {

    }
    public void onButtonPressed()
    {
        if (thisObject.activeInHierarchy == true)
            thisObject.SetActive(false);
        else
            thisObject.SetActive(true);
    } 

}
