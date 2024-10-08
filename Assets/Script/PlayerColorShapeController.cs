using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    [SerializeField] private ColorShapeDataSO playerData;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
        ShapeObject.OnChangeShape += UpdateShape;
    }

    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
        ShapeObject.OnChangeShape -= UpdateShape;
    }

    private void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        spriteRenderer.color = playerData.color;
        spriteRenderer.sprite = playerData.sprite;
    }

    private void UpdateColor(Color newColor)
    {
        playerData.color = newColor;
        spriteRenderer.color = newColor;
    }

    private void UpdateShape(Sprite newSprite)
    {
        playerData.sprite = newSprite;
        spriteRenderer.sprite = newSprite;
    }
}
