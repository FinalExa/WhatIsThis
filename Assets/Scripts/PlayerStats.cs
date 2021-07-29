using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float baseAttack;
    [SerializeField] private float baseHealth;
    [SerializeField] private float baseLevel;
    public float BaseAttack { get; set; }
    public float BaseHealth { get; set; }
    public float BaseLevel { get; set; }

    private void Start()
    {
        BaseAttack = baseAttack;
        BaseHealth = baseHealth;
        BaseLevel = baseLevel;
        print(BaseAttack + " " + BaseHealth + " " + BaseLevel);
    }
}
