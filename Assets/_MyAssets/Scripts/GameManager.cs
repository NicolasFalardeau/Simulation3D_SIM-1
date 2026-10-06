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

    /// <summary>
    /// Affiche le temps et le résulat du niveau qui vient de se terminer
    /// </summary>
    public void CompleteLevel()
    {
        float duration = Time.timeSinceLevelLoad;
        float score = duration + _hitCount * 5;
        Debug.Log("***** Résultats *****");
        Debug.Log($"Arrivée en {duration:F2} sec., pénalité : {_hitCount * 5}");
        Debug.Log($"Résultat final : {score:F2} secondes ");
    }
}
