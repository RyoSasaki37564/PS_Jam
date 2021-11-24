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


    [SerializeField] public int MoneyInPockets;
    /// <summary>所持金を表示する UI のテキスト</summary>
    [SerializeField] Text _moneyText;
    public int GachaPulledCounter = 0;
    public static bool GameOver = false;

    [SerializeField] GameObject m_jibun = default;

    [SerializeField] GameObject m_ensyutu = default;

    [SerializeField]int m_kakaku = 5;

    void Start()
    {
        m_ensyutu.SetActive(false);
        _moneyText.text = "MONEY: " + MoneyInPockets.ToString();
        m_ResultDsp.SetActive(false);
    }

    public virtual void Gacha()
    {
        m_ensyutu.SetActive(true);
        UseMoney(m_kakaku);
        if (MoneyInPockets >= m_kakaku)
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
    void Update()
    {
        if (MoneyInPockets <= 0)
        {
            GameOver = true;
        }
    }

    public void UseMoney(int money)
    {

        MoneyInPockets -= money;
        Debug.LogFormat("Money: {0}", MoneyInPockets);

        _moneyText.text = "MONEY: " + MoneyInPockets.ToString();

        m_ensyutu.SetActive(true);

        m_jibun.SetActive(false);
    }
}
