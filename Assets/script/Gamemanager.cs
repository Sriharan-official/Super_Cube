using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public float Restartdelay = 1f;
    public GameObject ended;
    public void complete()
    {
        ended.SetActive(true);
    }
    public void Endgame()
    {
        
       
            Debug.Log("GAME OVER");
            Invoke("Restart", Restartdelay);
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
