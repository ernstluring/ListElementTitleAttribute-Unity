# ListElementTitleAttribute-Unity
A attribute for specifying a variable as name property for a list in the Unity inspector

```c#

[System.Serializable]
public class CharacterStats
{
    public BattleCharacter character;
    public float maxHP;
}

[SerializeField]
[ListElementTitle("character")]
private List<CharacterStats> _characterStats;
```

![listElementTitleAttr-Inspector](https://user-images.githubusercontent.com/8643551/218972070-ec6d1b2e-f5ca-4143-bcb1-041e1affb4b4.png)
