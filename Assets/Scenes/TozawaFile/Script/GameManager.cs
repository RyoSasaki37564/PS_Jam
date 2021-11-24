using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] int _moneyInPockets;
    /// <summary>所持金を表示する UI のテキスト</summary>
    GameObject _moneyText;
    public int GachaPulledCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        _moneyText = GameObject.Find("MoneyText"); // スコアを表示するオブジェクト
    }
    public void UseMoney(int money)
    {
        _moneyInPockets -= money;
        Debug.LogFormat("Money: {0}", _moneyInPockets);

        // 所持金を画面に表示する
        Text scoreText = _moneyText.GetComponent<Text>();
        scoreText.text = "MONEY: " + _moneyInPockets.ToString();
    }
    void Update()
    {
    }
}
