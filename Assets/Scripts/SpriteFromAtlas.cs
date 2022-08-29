using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class SpriteFromAtlas : MonoBehaviour
{
    [SerializeField] private SpriteAtlas _spriteAtlas;
    [SerializeField] private string _spriteName;
    void Start()
    {
        GetComponent<Image>().sprite = _spriteAtlas.GetSprite(_spriteName);
    }
}
