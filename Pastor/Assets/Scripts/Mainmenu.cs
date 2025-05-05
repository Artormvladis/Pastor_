using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadSceneAsync("level 1");
    }
}
