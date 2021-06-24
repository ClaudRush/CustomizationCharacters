using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    [SerializeField] private Transform _stand;
    [SerializeField] private CharBank _charBank;

    public Transform Stand => _stand;
    public CharBank CharBank => _charBank;

    private void Awake()
    {
        _stand = gameObject.GetComponent<Transform>();
    }
}
