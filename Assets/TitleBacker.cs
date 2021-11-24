using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBacker : MonoBehaviour
{
    [SerializeField] 

    public void Restter()
    {
        Player._power = 0;
        SceneManager.LoadScene(0);
    }
}
