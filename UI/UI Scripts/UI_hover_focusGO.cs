using Mono.Cecil;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class UI_hover_focusGO : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IMaterialModifier
{

    [SerializeField] Material mat1;
    Material mat2;

    void Awake()
    {
        mat2 = new Material(mat1);
        mat2.CopyPropertiesFromMaterial(mat1);
        mat2 = GetComponent<Image>().material = Instantiate(mat2);
    }

    public Material GetModifiedMaterial(Material baseMaterial)
    {
        baseMaterial.SetFloat("_Speed", 0.2f);
        baseMaterial.SetFloat("_onHover", 0f);
        return baseMaterial;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        mat2.SetFloat("_onHover", 1f);   
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        mat2.SetFloat("_onHover", 0f);
    }
}
