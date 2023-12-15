using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticeFinish : MonoBehaviour
{
    public TextMeshProUGUI Success_Label;
    public GameObject ResetButton;
    public GameObject Haptics;
    // Start is called before the first frame update
    void Start()
    {
        ResetButton.SetActive(false);
        Success_Label.text = "Place the Needle";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("collide");
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Sphere")
        {

            Success_Label.text = "Success!\n Replace the Pen\nReset the Scene";
            ResetButton.SetActive(true);
            Haptics.SetActive(false);
        }
        /*if (Collider.CompareTag("Finish"))
            {
            Debug.Log("finish");  
            }*/
    }
    public void ResetScene()
    {
        SceneManager.LoadScene("PracticeScene");
    }
}
