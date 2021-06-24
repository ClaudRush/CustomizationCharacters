using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkinButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private CharButton _charaButton;
    [SerializeField] private Skin _skin;

    public Skin Skin  => _skin;
    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SetSkin);
    }
    public void SetSkin()
    {
        //var characterSkin = _charaButton.Char.GetComponent<SpriteRenderer>();
        var standCharacter = _charaButton.CharacterBattonsView.GetComponent<CharacterBattonsView>().Stand.GetChild(0).GetComponent<SpriteRenderer>();
        //characterSkin.sprite = _skin.Sprite;
        standCharacter.sprite = _skin.Sprite;

    }
    public void Init(CharButton charaButton, Skin skin)
    {
        _charaButton = charaButton;
        _skin = skin;
    }

}
