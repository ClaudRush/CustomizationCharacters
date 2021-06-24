using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBattonsView : MonoBehaviour
{
    [SerializeField] private GameObject _charButton;
    [SerializeField] private Transform _contentView;
    [SerializeField] private GameObject _stand;
    [SerializeField] private SkinButtonsView _skinBattonsPanel;

    public Transform Stand => _stand.GetComponent<Transform>();

    public SkinButtonsView SkinBattonsPanel => _skinBattonsPanel;

    private void Start()
    {
        _contentView = gameObject.GetComponent<Transform>().GetChild(0).GetChild(0).GetComponent<Transform>();
        CreateButtons();
    }

    public void CreateButtons()
    {
        var charBank = _stand.GetComponent<CharacterView>().CharBank;
        for (int i = 0; i < charBank.Length; i++)
        {
            var button = Instantiate(_charButton, _contentView);
            var buttonText = button.transform.GetChild(0).GetComponent<Text>();
            var charButton = button.GetComponent<CharButton>();
            charButton.Init(charBank.GetCharacter(i), this);
            buttonText.text = "Character_" + charButton.Char.ID;
        }
    }
}
