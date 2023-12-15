using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMenuManager : MonoBehaviour
{
    public GameObject optionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        optionsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwitchOptionsMenu()
        {
            optionsMenu.SetActive(!optionsMenu.activeInHierarchy);
        }
}
