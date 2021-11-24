using UnityEngine;

public class Comon : MonoBehaviour
{
    [SerializeField] int _power = 5;
    private void Start()
    {
        FindObjectOfType<Player>().AddPower(_power);
    }
}
