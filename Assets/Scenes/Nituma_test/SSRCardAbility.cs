using UnityEngine;

public class SSRCardAbility : MonoBehaviour
{
    [SerializeField] int _power = 50;
    private void Start()
    {
        FindObjectOfType<Player>().AddPower(_power);
    }
}
