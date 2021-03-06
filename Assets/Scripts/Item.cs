using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemType itemType;
    [SerializeField]
    private NFTGen nft;
    public ItemType ItemType => itemType;
    [SerializeField]
    private int value;
    [SerializeField]
    private TMP_Text valueText;
    

    private void Awake()
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
        if (other.GetComponent<Item>())
        {
            return;
        }
        if (other.transform.parent.TryGetComponent<Player>(out var player))
        {
            player.items.Add(this);
            gameObject.SetActive(false);
        } 
    }

    void SetValue()
    {
        value = nft.nftValue;
    }

    void SetValueText()
    {
        if (valueText != null)
        {
            valueText.text = value.ToString();
        }
    }
}
