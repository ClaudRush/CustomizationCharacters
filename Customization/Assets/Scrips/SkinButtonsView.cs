using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinButtonsView : MonoBehaviour
{
    [SerializeField] private GameObject _skinButton;
    [SerializeField] private Transform[] _scrollsSlotsContent;

    public Transform[] ScrollsSlotsContent => _scrollsSlotsContent;

    public GameObject SkinButton => _skinButton; 

    public Transform GetScrollsSlotsContent(int i) => _scrollsSlotsContent[i];

    private void Awake()
    {
        for (int i = 0; i < 3; i++)//поменять тройку на ГО скролвью скинбатон 
        {
            _scrollsSlotsContent[i] = gameObject.transform.GetChild(i).GetChild(0).GetChild(0);
        }
    }
}
