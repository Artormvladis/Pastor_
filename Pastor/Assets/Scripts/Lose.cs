using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System.Collections;

public class Lose : MonoBehaviour
{
    private async void OnTriggerEnter(Collider other)
    {
        Invoke("Loset", 2f);
    }
    void Loset()
    {
        SceneManager.LoadSceneAsync("Main menu");
    }
}
