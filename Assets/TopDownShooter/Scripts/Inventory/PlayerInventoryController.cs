using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {

        [SerializeField] private AbstractPlayerInventoryItemData[] _inventoryItemDataArray;


        private void Start()
        {
            IntializeInventory(_inventoryItemDataArray);   
        }

        public void IntializeInventory(AbstractPlayerInventoryItemData[] InventoryItemDataArray)
        {
            for(int i = 0; i< InventoryItemDataArray.Length; i++)
            {
                InventoryItemDataArray[i].CreateIntoInventory(this);
            }
        }

    }
}