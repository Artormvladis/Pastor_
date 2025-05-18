using UnityEngine;

public class Leave : MonoBehaviour
{
    public void Endgame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
