using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool
{
    public Type type;
    public Material material;

    public Tool(Type type, Material material)
    {
        this.type = type;
        this.material = material;
    }
    public enum Type
    {
        Hands,
        Pick,
        Hoe,
        Shovel,
        Sword
    }

    public enum Material
    {
        Hands = 1,
        Bone = 2,
        Stone = 3,
        Iron = 4,
        Thaumite = 5
    }
}
