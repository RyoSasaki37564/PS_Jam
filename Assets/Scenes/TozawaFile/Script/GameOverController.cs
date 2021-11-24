using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    /// <summary>Gameover を表示するオブジェクト</summary>
    GameObject _gameoverText;
    // Start is called before the first frame update
    void Start()
    {
        _gameoverText = GameObject.Find("Gameover Text");
        _gameoverText.SetActive(false);    // 無効にして見えなくする
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.GameOver)
        {
            _gameoverText.SetActive(true); // 有効にする
        }
        
    }
}
