using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI_Button_test01 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IMaterialModifier
{
    //[SerializeField] Material buttonRenderer;
    public Material material;


    public Material GetModifiedMaterial(Material baseMaterial)
    {
        baseMaterial.SetFloat("_SineSpeed", 4f);
        return baseMaterial;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        material.SetFloat("_VoronoiSpeed", -2f);
        material.SetFloat("_hover", 1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        material.SetFloat("_VoronoiSpeed", -.2f);
        material.SetFloat("_hover", 0f);
    }
}
