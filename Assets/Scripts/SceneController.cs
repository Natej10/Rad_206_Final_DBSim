using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public GameObject AboutObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadGame()
    {
        loadScene("BrainTime");
    }
    public void loadPractice()
    {
        loadScene("PracticeScene");
    }    
    public void loadTraining()
    {
        loadScene("TrainingScene");
        //unloadScene("MainMenuScene");
    }
    public void loadMainMenu()
    {
        //unloadAllScenes();
        loadScene("MainMenuScene");
        //SceneManager.
    }
    void loadScene(string sceneToLoad)
    {
        SceneManager.LoadSceneAsync(sceneToLoad);
        //SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Additive);
    }
    void unloadScene(string sceneToUnload)
    {
        SceneManager.UnloadSceneAsync(sceneToUnload);
    }
    void unloadAllScenes()
    {
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(i));
        }
    }
    public void LoadAbout()
    {
        AboutObject.SetActive(!AboutObject.activeInHierarchy);
    }
}
