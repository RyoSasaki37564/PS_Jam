using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int MoneyInPockets;
    /// <summary>所持金を表示する UI のテキスト</summary>
    [SerializeField] Text _moneyText;
    public int GachaPulledCounter = 0;
    public static bool GameOver  =false;

    [SerializeField] GameObject m_jibun = default;

    [SerializeField] GameObject m_ensyutu = default;

    // Start is called before the first frame update
    void Start()
    {
        m_ensyutu.SetActive(false);
        //_moneyText = GameObject.Find("MoneyText"); // スコアを表示するオブジェクト
        _moneyText.text = "MONEY: " + MoneyInPockets.ToString();
        
    }
    public void UseMoney(int money)
    {
        
        MoneyInPockets -= money;
        Debug.LogFormat("Money: {0}", MoneyInPockets);

        /*
        // 所持金を画面に表示する
        Text scoreText = _moneyText.GetComponent<Text>();
        scoreText.text = "MONEY: " + MoneyInPockets.ToString();
        */

        _moneyText.text = "MONEY: " + MoneyInPockets.ToString();

        m_ensyutu.SetActive(true);

        m_jibun.SetActive(false);
    }
    void Update()
    {
        if(MoneyInPockets<=0)
        {
            GameOver = true;
        }
    }
}
