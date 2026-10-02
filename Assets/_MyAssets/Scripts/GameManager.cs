using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _hitCount;

    private void Start()
    {
        _hitCount= 0;
        Debug.Log("Atteignez le burger e plus rapideent possible san toucher d'obstacle");
    }

    /// <summary>
    /// Méthode qui augmente le nombre de collisions
    /// </summary>
    public void RegisterHit()
    {
        _hitCount++;
        Debug.Log($"Accrochages : {_hitCount}");
    }
}
