using UnityEngine;

public class Knopkalifta : MonoBehaviour
{
    [SerializeField] GameObject _canold;
    [SerializeField] GameObject _door1;
    [SerializeField] GameObject _door2;
    bool isPress = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isPress) return;
        _canold.transform.position += new Vector3(0, 0, 0.01f);
        _door1.transform.position += new Vector3(1, 0, 0);
        _door2.transform.position += new Vector3(-1, 0, 0);
        isPress = true;
    }
}
