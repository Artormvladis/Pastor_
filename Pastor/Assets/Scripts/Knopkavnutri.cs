using Newtonsoft.Json.Bson;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knopkavnutri : MonoBehaviour
{
    [SerializeField] GameObject _canold;
    [SerializeField] GameObject _door1;
    [SerializeField] GameObject _door2;
    [SerializeField] string level;
    public static bool isPress1 = false;
    public static string levelchange = "";
    private async void OnTriggerEnter(Collider other)
    {
        levelchange = level;
        if (isPress1) return;
        isPress1 = true;
        _canold.transform.position += new Vector3(-0.02f, 0, 0);
        _door1.transform.position += new Vector3(1, 0, 0);
        _door2.transform.position += new Vector3(-1, 0, 0);
        Invoke("Levelchange", 2f);
    }
    private void Levelchange(string levelchange)
    {
        SceneManager.LoadScene("level " + levelchange);
    }
}
