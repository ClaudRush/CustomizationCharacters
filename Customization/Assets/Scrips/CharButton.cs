using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class CharButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Character _char;
    [SerializeField] private CharacterBattonsView _characterBattonsView;
    public Character Char => _char;

    public CharacterBattonsView CharacterBattonsView => _characterBattonsView;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SpawnCharacter);
        _button.onClick.AddListener(CreateSkinButtons);
    }
    public void Init(Character character, CharacterBattonsView characterBattonsView)
    {
        _char = character;
        _characterBattonsView = characterBattonsView;
    }
    public void SpawnCharacter()
    {
        var stand = _characterBattonsView.Stand;
        if (stand.transform.childCount != 0)
        {
            Destroy(stand.GetChild(0).gameObject);
        }
        Instantiate(_char.gameObject, stand);

    }
    public void CreateSkinButtons()
    {
        var currentSlotsCountainer = _char.SlotsContainer;
        var standCharacter = _characterBattonsView.Stand.GetChild(0).GetComponent<Character>();
        //var standCharacter = GameManager.instance.stand.GetChild(0).GetComponent<Character>().SlotsContainer;
        if (standCharacter != null)
        {
            if (standCharacter.SlotsContainer != null)
            {
                for (int i = 0; i < standCharacter.SlotsContainer.Length; i++)
                {
                    if (_characterBattonsView.SkinBattonsPanel.GetScrollsSlotsContent(i).childCount != 0)
                    {
                        for (int j = 0; j < standCharacter.SlotsContainer.GetSlot(i).Length; j++)
                        {
                            Destroy(_characterBattonsView.SkinBattonsPanel.GetScrollsSlotsContent(i).GetChild(j).gameObject);
                        }
                    }
                }
            }
            if (currentSlotsCountainer != null)
            {
                for (int i = 0; i < currentSlotsCountainer.Length; i++)
                {
                    if (currentSlotsCountainer.GetSlot(i) != null)
                    {
                        for (int j = 0; j < currentSlotsCountainer.GetSlot(i).Length; j++)
                        {
                            var button = Instantiate(_characterBattonsView.SkinBattonsPanel.SkinButton, _characterBattonsView.SkinBattonsPanel.GetScrollsSlotsContent(i));
                            var skinButton = button.GetComponent<SkinButton>();
                            skinButton.Init(this, currentSlotsCountainer.GetSkin(i, j));
                            var buttonText = skinButton.transform.GetChild(0).GetComponent<Text>();
                            buttonText.text = skinButton.Skin.name;
                        }
                    }
                }
            }
        }
    }
}

