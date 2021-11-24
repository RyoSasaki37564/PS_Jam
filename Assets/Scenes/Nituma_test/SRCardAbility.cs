using UnityEngine;

public class SRCardAbility : MonoBehaviour
{
    [SerializeField] int _power = 30;
    private void Start()
    {
        FindObjectOfType<Player>().AddPower(_power);
    }
}
