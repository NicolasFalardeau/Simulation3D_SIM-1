using UnityEngine;
using TMPro
public class GameUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private TMP_Text _penaltyText;
    [SerializeField] private TMP_Text _hitText;

    private void Update()
    {
        // Le teps change a chaque frame
        _timeText.text = $"Teps : {Time.timeSinceLevelLoad}";
    }

}
