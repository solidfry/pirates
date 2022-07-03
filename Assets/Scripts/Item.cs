using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemType itemType;
    [SerializeField]
    private NFTGen nft;
    public ItemType ItemType => itemType;
    private SpriteRenderer[] sprites;
    [SerializeField]
    private int value;
    [SerializeField]
    private TMP_Text valueText;
    

    private void OnEnable()
    {
        SetValue();
        SetValueText();
    }

    private void OnValidate()
    {
        SetValue();
        SetValueText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.TryGetComponent<Player>(out var player))
        {
            player.items.Add(this);
            gameObject.SetActive(false);
        } 
    }

    void SetValue()
    {
        value = nft.value;
    }

    void SetValueText()
    {
        if (valueText != null)
        {
            valueText.text = value.ToString();
        }
    }
}
