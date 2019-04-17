using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoDisplay : MonoBehaviour
{
    public Component comp;

    public TextMeshProUGUI TextComponent;

    void LateUpdate()
    {
        if (!comp)
        {
            return;
        }
        if (!TextComponent)
        {
            return;
        }

        TextComponent.text = string.Empty;


        foreach (var field in GetFieldInfoFromComponent(comp))
        {
            TextComponent.text += "(" + field.FieldType + ") " + field.Name + " " + field.GetValue(comp) + "\n";
        }
    }

    public System.Reflection.FieldInfo[] GetFieldInfoFromComponent(Component comp)
    {
        return comp.GetType().GetFields();
    }
}
