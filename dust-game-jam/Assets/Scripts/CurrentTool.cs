using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTool : MonoBehaviour
{
    public Image toolimg;
    public Tool pawnTool;

    public Sprite BONE_SWORD;
    public Sprite BONE_HOE;
    public Sprite BONE_SHOVEL;
    public Sprite BONE_PICK;

    // Start is called before the first frame update

    void Awake()
    {
        //for debug
        pawnTool = new Tool(Tool.Type.Sword, Tool.Material.Bone);
    }

void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (pawnTool.type)
        {
            case(Tool.Type.Sword):
                toolimg.sprite = BONE_SWORD;
                break;
            case(Tool.Type.Shovel):
                toolimg.sprite = BONE_SHOVEL;
                break;
            case(Tool.Type.Hoe):
                toolimg.sprite = BONE_HOE;
                break;
            case(Tool.Type.Pick):
                toolimg.sprite = BONE_PICK;
                break;
            default:
                toolimg.sprite = BONE_PICK; //for testing purposes
                break;
        }
    }

    void SetTool(Tool tool)
    {
        this.pawnTool = tool;
    }
}
