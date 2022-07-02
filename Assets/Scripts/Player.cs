using ScriptableObjects;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField]
    public ItemCollection items;
    
    [SerializeField]
    private Collider playerCollider;

    private void Awake()
    {
        playerCollider = this.gameObject.GetComponentInChildren<Collider>();
    }
}
