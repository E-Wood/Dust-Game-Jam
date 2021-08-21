using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool
{
    public Type type;
    public Material material;
    public enum Type
    {
        Pick,
        Hoe,
        Shovel,
        Sword
    }

    public enum Material
    {
        Bone = 1,
        Stone = 2,
        Iron = 3,
        Thaumite = 4
    }
}
