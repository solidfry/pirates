using UnityEngine;

[CreateAssetMenu(menuName="Items/Item Type")]
public class ItemType : ScriptableObject
{
    public string itemName;
    [SerializeField] public int value;
}
