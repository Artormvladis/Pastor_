using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System.Collections;
using TMPro;
using System;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public static int score = 0;
    private static int Bestscore = 0;
    private string _text;
    private async void OnTriggerEnter(Collider other)
    {
        if (score > Bestscore)
        {
            Bestscore = score;
            _text = "Новый лучший счёт: ";
        }
        else
        {
            _text = "Твой счёт: ";
        }
        Invoke("Wine", 2f);
    }
    void Wine()
    {
        text.text =_text + "\n" + Convert.ToString(score);
    }
}
