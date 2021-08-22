using UnityEngine;

public class ShrineController : MonoBehaviour
{
    public static ShrineController SControllerInstance;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int buildProgress = 10;
    public int shrineProgress;
    public bool shrineUpdate;
    
    void ChangeSprite()
    {
        if (shrineProgress == spriteArray.Length - 1)
        {
            shrineProgress--;
        }
        spriteRenderer.sprite = spriteArray[shrineProgress];
        shrineProgress++;
    }

    public void UpdateShrine()
    {
        buildProgress -= 10;
        if (buildProgress == 0)
        {
            shrineUpdate = true;
            buildProgress = 10;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        shrineUpdate = false;
        SControllerInstance = this;
        shrineProgress = 0;
        ChangeSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (shrineUpdate)
        {
            ChangeSprite();
            shrineUpdate = false;
        }
    }
}
