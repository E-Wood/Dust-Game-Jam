using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static List<iAssignable> spirits = new List<iAssignable>();
    public static EnemyController eControllerInstance;

    public enum SpiritType
    {
        SandSpiritWeak,
        SandSpiritStrong
    }

    public GameObject spiritWeak;
    public GameObject spiritStrong;

    // Start is called before the first frame update
    void Start()
    {
        eControllerInstance = this;

        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Assignment"))
        {
            if (gameObject.GetComponent<Enemy>() == null) continue;

            Enemy spirit = gameObject.GetComponent<Enemy>();
            spirit.setPosition(gameObject.transform.position);
            spirits.Add(spirit);
        }
    }

    public void spawnEnemy(SpiritType type, Vector3 spawnLocation)
    {
        switch (type)
        {
            case SpiritType.SandSpiritWeak:
                GameObject weakSpirit = Instantiate(spiritWeak, spawnLocation, Quaternion.identity);
                spirits.Add(weakSpirit.GetComponent<Enemy>());
                break;
            case SpiritType.SandSpiritStrong:
                GameObject strongSpirit = Instantiate(spiritStrong, spawnLocation, Quaternion.identity);
                spirits.Add(strongSpirit.GetComponent<Enemy>());
                break;
        }
    }
    
    // dont know wtf I'm doing

    public void reduceHealth()
    {
        /*if (spirit.health > 0)
        {
            spirit.health -= 10;
        }
        else
        {
            killSpirit(gameObject);
        }*/
    }

    public void killSpirit(GameObject gameObject)
    {
        Destroy(gameObject);
    }

// Update is called once per frame
    void Update()
    {
        
    }
}
