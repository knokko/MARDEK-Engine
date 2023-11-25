using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BattleModel : MonoBehaviour
{
    [SerializeField] string nameFrom5118;
    [SerializeField] int spriteID;
    [SerializeField] string skin;

    public void Create(string name, int spriteID, string skin)
    {
        nameFrom5118 = name;
        this.spriteID = spriteID;
        this.skin = skin;
    }

    [ContextMenu("Import")]
    public void Import()
    {
        var obj = SWFSpriteImporter.CreateOrInstantiateByID(spriteID, transform);
        foreach (var shape in obj.GetComponentsInChildren<SWFShape>())
            shape.CalculateSortingOrderAndColor();
    }

    [ContextMenu("Skin")]
    public void Skin()
    {
        foreach (var sprite in GetComponentsInChildren<SWFSprite>())
            sprite.PlayAnimationByLabel(skin);
    }
}