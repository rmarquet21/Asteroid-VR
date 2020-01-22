using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangerSceneJeu()
    {
        SceneManager.LoadScene(1); //changement de scene  
    }

    public void ChangerSceneMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
