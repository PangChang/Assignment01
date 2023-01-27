using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour{
    
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //To Load in the next scene after this current one
    }

}
