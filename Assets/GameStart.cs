using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] GameObject m_jibun = default;
    [SerializeField] GameObject m_battle = default;

    public static int enemyID = 0;

    private void Start()
    {
        m_battle.SetActive(false);
    }

    public void Hajimari()
    {
        enemyID = Random.Range(0, 3);
        m_battle.SetActive(true);
        m_jibun.SetActive(false);
    }
}

