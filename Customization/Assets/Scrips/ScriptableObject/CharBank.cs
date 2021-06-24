using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new CharacterBank", menuName = "Customization/CharacterBank")]
public class CharBank : ScriptableObject
{
    [SerializeField] private Character[] characters;

    public int Length => characters.Length;

    public Character GetCharacter(int character) => characters[character];
}
