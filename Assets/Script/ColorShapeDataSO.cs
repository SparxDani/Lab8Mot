using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ColorShapeData", menuName = "ColorShapeData")]

public class ColorShapeDataSO : ScriptableObject
{
    public Color color;
    public Sprite sprite;
}
