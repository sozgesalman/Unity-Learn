using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Player Inventory Cannon Item Data")]

    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            Debug.Log("THIS IS INVENTORY CANNON ITEM DATA");
        }
    }
}
