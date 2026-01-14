using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI_SharedMaterial : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Renderer _renderer;
    [SerializeField]
    Material mat;

    void Awake()
    {
        mat = new Material(_renderer.sharedMaterial);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mat.SetFloat("_VoronoiSpeed", -.2f);
        mat.SetFloat("_hover", 0f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mat.SetFloat("_VoronoiSpeed", -.2f);
        mat.SetFloat("_hover", 1f);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
}
