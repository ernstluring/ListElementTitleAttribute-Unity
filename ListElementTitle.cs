using UnityEngine;

public class ListElementTitle : PropertyAttribute
{
    public string varName;
    public ListElementTitle(string elementTitleProperty)
    {
        varName = elementTitleProperty;
    }
}
