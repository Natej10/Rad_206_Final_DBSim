using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainingMenuManager : MonoBehaviour
{
    public GameObject rgSegmentMenu;
    public GameObject lgSegmentMenu;
    public GameObject rwSegmentMenu;
    public GameObject lwSegmentMenu;
    public GameObject otherSegmentMenu;
    // Start is called before the first frame update
    void Start()
    {
        lgSegmentMenu.SetActive(false);
        rgSegmentMenu.SetActive(false);
        lwSegmentMenu.SetActive(false);
        rwSegmentMenu.SetActive(false);
        otherSegmentMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwitchSegmentMenu()
        {
        if (rgSegmentMenu.activeInHierarchy)
        {
            rgSegmentMenu.SetActive(false);
            lgSegmentMenu.SetActive(true);
        }
        else if (lgSegmentMenu.activeInHierarchy)
        {
            lgSegmentMenu.SetActive(false);
            rwSegmentMenu.SetActive(true);
        }
        else if (rwSegmentMenu.activeInHierarchy)
        {
            rwSegmentMenu.SetActive(false);
            lwSegmentMenu.SetActive(true);
        }
        else if (lwSegmentMenu.activeInHierarchy)
        {
            lwSegmentMenu.SetActive(false);
            otherSegmentMenu.SetActive(true);
        }
        else if (otherSegmentMenu.activeInHierarchy)
        {
            otherSegmentMenu.SetActive(false);
        }
        else
        {
            rgSegmentMenu.SetActive(true);
        }


    }
}
