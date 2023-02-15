using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ListElementTitle))]
public class ListElementTitleDrawer : PropertyDrawer
{
    private SerializedProperty _titleNameProp;

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, label, true);
    }

    public override void OnGUI(Rect position,
                              SerializedProperty property,
                              GUIContent label)
    {
        ListElementTitle titleAttribute = (ListElementTitle)attribute;
        string pathName = property.propertyPath + "." + titleAttribute.varName;
        _titleNameProp = property.serializedObject.FindProperty(pathName);

        string newlabel = GetTitle();
        if (string.IsNullOrEmpty(newlabel))
            newlabel = label.text;

        EditorGUI.PropertyField(position, property, new GUIContent(newlabel, label.tooltip), true);
    }

    private string GetTitle()
    {
        if (_titleNameProp == null)
            return string.Empty;

        switch (_titleNameProp.propertyType)
        {
            case SerializedPropertyType.Generic:
                break;
            case SerializedPropertyType.Integer:
                return _titleNameProp.intValue.ToString();
            case SerializedPropertyType.Boolean:
                return _titleNameProp.boolValue.ToString();
            case SerializedPropertyType.Float:
                return _titleNameProp.floatValue.ToString();
            case SerializedPropertyType.String:
                return _titleNameProp.stringValue;
            case SerializedPropertyType.Color:
                return _titleNameProp.colorValue.ToString();
            case SerializedPropertyType.ObjectReference:
                return _titleNameProp.objectReferenceValue ? _titleNameProp.objectReferenceValue.ToString() : string.Empty;
            case SerializedPropertyType.LayerMask:
                break;
            case SerializedPropertyType.Enum:
                return _titleNameProp.enumNames[_titleNameProp.enumValueIndex];
            case SerializedPropertyType.Vector2:
                return _titleNameProp.vector2Value.ToString();
            case SerializedPropertyType.Vector3:
                return _titleNameProp.vector3Value.ToString();
            case SerializedPropertyType.Vector4:
                return _titleNameProp.vector4Value.ToString();
            case SerializedPropertyType.Rect:
                break;
            case SerializedPropertyType.ArraySize:
                break;
            case SerializedPropertyType.Character:
                break;
            case SerializedPropertyType.AnimationCurve:
                break;
            case SerializedPropertyType.Bounds:
                break;
            case SerializedPropertyType.Gradient:
                break;
            case SerializedPropertyType.Quaternion:
                break;
            default:
                break;
        }
        return string.Empty;
    }
}
