using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaSys : MonoBehaviour
{
    [SerializeField] GameObject m_ResultDsp = default; //ガチャ結果表示親
    [SerializeField] GameObject m_gachaResultPanel = default; //ガチャ結果表示パネル

    [SerializeField] List<GameObject> m_CanHitCharactors_SSR = new List<GameObject>(); //排出SSRキャラリスト
    [SerializeField] List<GameObject> m_CanHitCharactors_SR = new List<GameObject>(); //排出SRキャラリスト
    [SerializeField] List<GameObject> m_CanHitCharactors_R = new List<GameObject>(); //排出Rキャラリスト
    [SerializeField] List<GameObject> m_CanHitCharactors_C = new List<GameObject>(); //排出ザコキャラリスト
    [SerializeField] List<GameObject> m_CanHitCharactors_M = new List<GameObject>(); //排出地雷キャラリスト


    [SerializeField] public int MoneyInPockets;
    /// <summary>所持金を表示する UI のテキスト</summary>
    [SerializeField] Text _moneyText;
    public static bool GameOver = false;

    [SerializeField] GameObject m_jibun = default;

    [SerializeField] GameObject m_ensyutu = default;

    [SerializeField] int m_kakaku0 = 5;
    [SerializeField] int m_kakaku1 = 10;
    [SerializeField] int m_kakaku2 = 1;

    [SerializeField] GameObject m_TheWin = default;
    [SerializeField] GameObject m_TheLose = default;

    [SerializeField] int tekiPower = 250;

    [SerializeField] GameObject[] m_enemyArray = new GameObject[3];

    public enum Turn
    {
        InputTurn,
        BattleTurn,
        GameSetTurn,
    }
    public static Turn m_turn = Turn.InputTurn;

    private void Awake()
    {
        foreach(var x in m_enemyArray)
        {
            x.SetActive(false);
        }
    }

    void Start()
    {
        m_enemyArray[GameStart.enemyID].SetActive(true);

        m_turn = Turn.InputTurn;

        m_ensyutu.SetActive(false);
        _moneyText.text = "銭: " + MoneyInPockets.ToString();
        m_ResultDsp.SetActive(false);
        m_TheWin.SetActive(false);
        m_TheLose.SetActive(false);
        MoneyInPockets = 100;
    }

    public void Gacha0()
    {
        m_ensyutu.SetActive(true);
        UseMoney(m_kakaku0);
        if (MoneyInPockets >= m_kakaku0)
        {
            m_ResultDsp.SetActive(true);

            int rondom = Random.Range(0, 100);

            if (rondom < 15)
            {
                //当選キャラをリザルトに表示する。
                int ssr = Random.Range(0, m_CanHitCharactors_SSR.Count);
                var x = Instantiate(m_CanHitCharactors_SSR[ssr]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_SSR[ssr].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
            else if (rondom < 51)
            {
                int sr = Random.Range(0, m_CanHitCharactors_SR.Count);
                var x = Instantiate(m_CanHitCharactors_SR[sr]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_SR[sr].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
            else
            {
                int r = Random.Range(0, m_CanHitCharactors_R.Count);
                var x = Instantiate(m_CanHitCharactors_R[r]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_R[r].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
        }
        m_jibun.SetActive(false);
    }
    public void Gacha1()
    {
        m_ensyutu.SetActive(true);
        UseMoney(m_kakaku1);
        if (MoneyInPockets >= m_kakaku1)
        {
            m_ResultDsp.SetActive(true);

            int rondom = Random.Range(0, 100);

            if (rondom < 50)
            {
                //当選キャラをリザルトに表示する。
                int ssr = Random.Range(0, m_CanHitCharactors_SSR.Count);
                var x = Instantiate(m_CanHitCharactors_SSR[ssr]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_SSR[ssr].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
            else if (rondom < 61)
            {
                int c = Random.Range(0, m_CanHitCharactors_C.Count);
                var x = Instantiate(m_CanHitCharactors_C[c]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_C[c].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
            else
            {
                int m = Random.Range(0, m_CanHitCharactors_M.Count);
                var x = Instantiate(m_CanHitCharactors_M[m]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_M[m].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
        }
        m_jibun.SetActive(false);
    }
    public void Gacha2()
    {
        m_ensyutu.SetActive(true);
        UseMoney(m_kakaku2);
        if (MoneyInPockets >= m_kakaku2)
        {
            m_ResultDsp.SetActive(true);

            int rondom = Random.Range(0, 100);

            if (rondom < 1)
            {
                //当選キャラをリザルトに表示する。
                int ssr = Random.Range(0, m_CanHitCharactors_SSR.Count);
                var x = Instantiate(m_CanHitCharactors_SSR[ssr]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_SSR[ssr].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
            else if (rondom < 31)
            {
                int r = Random.Range(0, m_CanHitCharactors_R.Count);
                var x = Instantiate(m_CanHitCharactors_R[r]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_R[r].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
            else
            {
                int c = Random.Range(0, m_CanHitCharactors_R.Count);
                var x = Instantiate(m_CanHitCharactors_C[c]);
                x.SetActive(true);
                x.transform.SetParent(m_gachaResultPanel.transform);
                x.transform.localScale = m_CanHitCharactors_C[c].transform.localScale;
                x.transform.localPosition = new Vector3(0, 0, 0);

            }
        }
        m_jibun.SetActive(false);
    }
    void Update()
    {
        if (m_turn == Turn.InputTurn && MoneyInPockets <= 0)
        {
            //GameOver = true;
            m_turn = Turn.BattleTurn;
        }

        if(m_turn == Turn.BattleTurn)
        {
            
             if(tekiPower < Player._power)
             {
                m_TheWin.SetActive(true);
             }
             else if(tekiPower == Player._power)
             {
                m_TheWin.SetActive(true);
                m_TheLose.SetActive(true);
            }
             else
             {
                m_TheLose.SetActive(true);
             }
             
        }
    }

    public void UseMoney(int money)
    {

        MoneyInPockets -= money;
        Debug.LogFormat("銭: {0}", MoneyInPockets);

        _moneyText.text = "銭: " + MoneyInPockets.ToString();

        m_ensyutu.SetActive(true);

        m_jibun.SetActive(false);
    }
}
