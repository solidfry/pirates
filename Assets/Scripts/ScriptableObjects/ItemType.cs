using UnityEngine;

[CreateAssetMenu(menuName="Items/Item Type")]
public class ItemType : ScriptableObject
{
    public string itemName;
    public Color color = Color.white;
    [SerializeField]
    public Sprite image;
    [SerializeField] public int value;
}
