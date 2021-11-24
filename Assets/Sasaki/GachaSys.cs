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


    public static int m_money = 10;

    void Start()
    {
        m_ResultDsp.SetActive(false);
    }

    public virtual void Gacha()
    {
        if (m_money >= 3)
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
    }

}
