using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [Tooltip("Couleur de l'obstacle une fois touché")]
    [SerializeField] private Material _hitMaterial;

    private GameManager _gameManager;
    private Renderer _renderer;
    private bool _wasHit;
    private void Awake()
    {
        _renderer= GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.TryGetComponent<Player>(out _) || _wasHit)
        {

            return;

        }

        _wasHit = true;
        _renderer.material = _hitMaterial;
        //Augmenter le hitcount dans le gameManager
        _gameManager.RegisterHit();
    }

}
