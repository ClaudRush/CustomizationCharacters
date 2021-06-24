using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Slot", menuName = "Customization/Slot")]
public class Slot : ScriptableObject
{
    [SerializeField] private Skin[] skins;
    public int Length => skins.Length;
    public Skin GetSkin(int i) => skins[i]; 
}
