using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] SpriteRenderer _background;
    [SerializeField] SpriteRenderer _middleground;
    [Space]    
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private SpriteAnimationsConfig _spriteAnimationsConfig;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform, _middleground.transform);

        _spriteAnimator = new SpriteAnimator(_spriteAnimationsConfig);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.Idle, true, 0.1f);
    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }

}
