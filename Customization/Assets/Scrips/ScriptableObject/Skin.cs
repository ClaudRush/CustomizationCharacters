using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Skin", menuName = "Customization/Skin")]
public class Skin : ScriptableObject
{
    [SerializeField] private Sprite sprite;

    public Sprite Sprite => sprite; 
}
