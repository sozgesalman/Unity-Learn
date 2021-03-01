﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Shooting
{
    public class ShootingManager : MonoBehaviour
    {
        public void Shoot(Vector3 from, Vector3 direction)
        {
            RaycastHit hit;
            bool rayHit = Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity);
            Debug.DrawLine(transform.position, transform.position+direction*10, Color.blue, 20);
            Debug.DrawRay(transform.position, direction, Color.red, 20);
            
            if (rayHit)
            {
                Debug.Log("it's Hit!");
                Debug.Log(hit.collider.name);
                var healthStat = hit.collider.GetComponent<HealthStat>();
                if(healthStat != null)
                {
                    healthStat.Hit(5);
                }
            }
        }
    }
}
