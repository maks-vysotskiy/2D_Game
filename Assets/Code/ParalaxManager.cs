using UnityEngine;

public class ParalaxManager
{
    private const float backGroundCoef = 0.3f;
    private const float middleGroundCoef = 0.5f;

    private Camera _camera;
    private Transform _backTransform;
    private Transform _middleGroundTransform;

    private Vector3 _backStartPosition;
    private Vector3 _middleGroundStartPosition;

    private Vector3 _cameraStartPosition;

    public ParalaxManager(Camera camera, Transform backTransform, Transform middleGround)
    {
        _camera = camera;
        _backTransform = backTransform;
        _middleGroundTransform = middleGround;

        _backStartPosition = backTransform.position;
        _middleGroundStartPosition = middleGround.position;
        _cameraStartPosition = camera.transform.position;
    }

    public void Update()
    {
        _backTransform.position = _backStartPosition + (_camera.transform.position - _cameraStartPosition) * backGroundCoef;
        _middleGroundTransform.position = _middleGroundStartPosition + (_camera.transform.position - _cameraStartPosition) * middleGroundCoef;
    }
    
}
