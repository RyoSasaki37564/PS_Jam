using UnityEngine.SceneManagement;
using UnityEngine;

public class SceanChange : MonoBehaviour
{
    void NextScene(int Sceannum)
    {
        SceneManager.LoadScene(Sceannum);
    }
}
