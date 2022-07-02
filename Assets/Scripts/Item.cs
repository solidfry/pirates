using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemType itemType;

    public ItemType ItemType => itemType;
    private SpriteRenderer[] sprites;
    [SerializeField]
    private int value;
    [SerializeField]
    private TMP_Text valueText;
    

    private void OnEnable()
    {
        GetSprites();
        SetValue();
        SetValueText();
    }

    private void OnValidate()
    {
        GetSprites();
        SetValue();
        SetValueText();
        ApplySprites();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.TryGetComponent<Player>(out var player))
        {
            player.items.Add(this);
            gameObject.SetActive(false);
        } 
    }

    void GetSprites()
    {
        sprites = FindObjectsOfType<SpriteRenderer>();
        if (sprites != null) { ApplySprites(); }
    }
    
    void ApplySprites()
    {
        foreach (SpriteRenderer sprite in sprites)
        {
            sprite.sprite = itemType.image;
            sprite.color = itemType.color;
        }
    }

    void SetValue()
    {
        value = itemType.value;
    }

    void SetValueText()
    {
        if (valueText != null)
        {
            valueText.text = value.ToString();
        }
    }
}
