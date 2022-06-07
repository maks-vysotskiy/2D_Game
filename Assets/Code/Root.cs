using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] SpriteRenderer _background;
    [SerializeField] SpriteRenderer _middleground;

    private ParalaxManager _paralaxManager;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform, _middleground.transform);
    }

    private void Update()
    {
        _paralaxManager.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }

}
