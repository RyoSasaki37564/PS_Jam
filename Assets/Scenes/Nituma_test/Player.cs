using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int _power = 0;
    //[SerializeField] public static int _money = 0;
    [SerializeField] Text _playerpower = default;

    private void Update()
    {
        _playerpower.text = "Power: " + _power.ToString();
    }
    public void AddPower(int x)
    {
        _power += x;   
    }
    
}
