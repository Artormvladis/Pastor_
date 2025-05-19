using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public void Scoreleave()
    {
        SceneManager.LoadSceneAsync("level 1");
    }
}
