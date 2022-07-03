using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;
using Random = UnityEngine.Random;

public class NFTGen : MonoBehaviour
{
    [SerializeField] private NftData nftData;

    [SerializeField] private SpriteRenderer background, body, face, accessory;
    public int value { get; private set; }
    System.Random _rand;
    int _randomValue;

    private void Awake()
    {
        SetValues();
    }

    private void OnValidate()
    {
        SetValues();
    }

    void SetValues()
    {
        value = 0;
        SetBackground();
        SetAccessory();
        SetFace();
        SetBody();
    }
    
    void SetBackground()
    {
        _rand = new System.Random(GetInstanceID());
        _randomValue = _rand.Next(0, nftData.backgrounds.Count);
        background.sprite = nftData.backgrounds[_randomValue].image;
        background.color = nftData.backgrounds[_randomValue].traitColor.color;
        AddToValue(nftData.backgrounds[_randomValue].value);
    }

    void SetBody()
    {
        _rand = new System.Random(GetInstanceID());
        _randomValue = _rand.Next(0, nftData.bodies.Count);
        body.sprite = nftData.bodies[_randomValue].image;
        body.color = nftData.bodies[_randomValue].traitColor.color;
        AddToValue(nftData.bodies[_randomValue].value);
    }

    void SetAccessory()
    {
        _rand = new System.Random(GetInstanceID());
        _randomValue = _rand.Next(0, nftData.accessories.Count);
        accessory.sprite = nftData.accessories[_randomValue].image;
        accessory.color = nftData.accessories[_randomValue].traitColor.color;
        AddToValue(nftData.accessories[_randomValue].value);
    }

    void SetFace()
    {
        _rand = new System.Random(GetInstanceID());
        _randomValue = _rand.Next(0, nftData.faces.Count);
        face.sprite = nftData.faces[_randomValue].image;
        face.color = nftData.faces[_randomValue].traitColor.color;
        AddToValue(nftData.faces[_randomValue].value);
    }

    void AddToValue(int valueToAdd)
    {
        value += valueToAdd;
    }
}
