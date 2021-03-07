using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    

    public enum InventoryItemDataType { Cannon, Body}

    public abstract class AbstractPlayerInventoryItemData : ScriptableObject
    {
        [SerializeField] private string _ItemId;

        public abstract void CreateIntoInventory(PlayerInventoryController targetPlayerInventory);
    }
}