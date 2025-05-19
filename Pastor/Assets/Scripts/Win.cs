using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System.Collections;

public class Win : MonoBehaviour
{
    public static int score=0;
    private async void OnTriggerEnter(Collider other)
    {
        Invoke("Wine", 2f);
    }
    void Wine()
    {
        SceneManager.LoadSceneAsync("Main menu");
    }
}
