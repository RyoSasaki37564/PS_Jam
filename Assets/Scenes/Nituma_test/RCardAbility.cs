using UnityEngine;

public class RCardAbility : MonoBehaviour
{
    [SerializeField] int _power = 10;
    private void Start()
    {
        FindObjectOfType<Player>().AddPower(_power);
    }
}
