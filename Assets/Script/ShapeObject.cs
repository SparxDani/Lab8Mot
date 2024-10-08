using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeObject : MonoBehaviour
{
    [SerializeField] private ColorShapeDataSO shapeData;
    [SerializeField] private SpriteRenderer spriteRenderer;

    public static event Action<Sprite> OnChangeShape;

    private void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        spriteRenderer.sprite = shapeData.sprite;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeShape?.Invoke(shapeData.sprite);
        }
    }
}