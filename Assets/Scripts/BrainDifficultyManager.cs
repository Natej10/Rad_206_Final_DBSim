using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain_ : MonoBehaviour
{
    public GameObject brainObject;
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleBrainTransparency()
    {
        Color brainColor = brainObject.GetComponent<Renderer>().material.color;
        if (brainColor.a > 0.999) {brainColor.a = 0.40f;}
        else { brainColor.a = 1.0f; }
        brainObject.GetComponent<Renderer>().material.color = brainColor;
    }
    //brainObject.renderer.material.color.a=Time.time-Mathf.Floor(Time.time);
    public void ToggleTargets()
    {
        targetObject.SetActive(!targetObject.activeInHierarchy);
    }
}
