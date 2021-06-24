using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterID _iD;
    [SerializeField] private SlotsContainer _slotsContainer;
    public string ID => _iD.ID;

    public SlotsContainer SlotsContainer => _slotsContainer;
}
