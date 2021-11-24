using UnityEngine;

public class BadCardAbility : MonoBehaviour
{
    [SerializeField] int _power = -20;
    private void Start()
    {
        FindObjectOfType<Player>().AddPower(_power);
    }
}
