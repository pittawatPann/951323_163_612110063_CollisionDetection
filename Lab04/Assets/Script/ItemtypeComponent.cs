using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemtypeComponent : MonoBehaviour
{
    [SerializeField]
    protected ItemType _itemType;
    public ItemType Type
    {
        get
        {
            return _itemType;
        }
        set
        {
            _itemType = value;
        }
    }
}
