using UnityEngine.SceneManagement;
using UnityEngine;

public class SceanChange : MonoBehaviour
{
    [SerializeField] GameObject m_jibun = default;

    [SerializeField] GameObject m_gacha = default;

    void NextScene(int Sceannum)
    {
        //SceneManager.LoadScene(Sceannum);

        m_gacha.SetActive(true);

        m_jibun.SetActive(false);
    }
}
