using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new SlotContainer", menuName = "Customization/SlotContainer")]
public class SlotsContainer : ScriptableObject
{
    [SerializeField] private Slot[] slots;
    public int Length => slots.Length;
    public Slot GetSlot(int i) => slots[i];
    public Skin GetSkin(int i, int j) => GetSlot(i).GetSkin(j);
}
