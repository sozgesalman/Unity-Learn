using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.Inventory {

    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Player Inventory Body Item Data")]

    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            Debug.Log("THIS IS INVENTORY BODY ITEM DATA");
        }
    }
}
