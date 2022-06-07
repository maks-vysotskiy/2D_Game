using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SpriteAnimationConfig", menuName = "Configs/SpriteAnimationsConfig")]
public class SpriteAnimationsConfig : ScriptableObject
{
    [SerializeField] private List<SpriteSequence> _sequences;
    public List<SpriteSequence> Sequences  => _sequences; 
}
