using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new CharacterID",menuName = "Customization/CharacterID")]
public class CharacterID : ScriptableObject
{
    [SerializeField] private string _iD;

    public string ID => _iD;
}
