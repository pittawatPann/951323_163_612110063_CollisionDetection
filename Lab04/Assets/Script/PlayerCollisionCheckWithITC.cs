using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisionCheckWithITC : MonoBehaviour
{
    public Text _textPickUpInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        ItemtypeComponent itc = collision.gameObject.GetComponent<ItemtypeComponent>();


        if(itc != null)
        {
            switch(itc.Type)
            {
                case ItemType.SPHERE_DROP_ITEM:
                    _textPickUpInfo.text = "SPHERE_DROP_ITEM has been picked up";
                    break;
                case ItemType.CUBE_OBSTACLE:
                    _textPickUpInfo.text = "CUBE_OBSTACLE has been picked up";
                    break;
                case ItemType.CAPSUE_OBSTACLE:
                    _textPickUpInfo.text = "CAPSUE_OBSTACLE has been picked up";
                    break;
                case ItemType.CYLINDER_OBSTACLE:
                    _textPickUpInfo.text = "CYLINDER_OBSTACLE has been picked up";
                    break;
                case ItemType.SWORD:
                    _textPickUpInfo.text = "SWORD has been picked up";
                    break;
                case ItemType.DUMBELL:
                    _textPickUpInfo.text = "DUMBELL has been picked up";
                    break;
                case ItemType.JAR:
                    _textPickUpInfo.text = "JAR has been picked up";
                    break;
            }
        }
    }
}
