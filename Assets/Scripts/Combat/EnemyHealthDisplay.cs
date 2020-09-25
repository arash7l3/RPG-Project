using RPG.Combat;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Resources
{
    public class EnemyHealthDisplay : MonoBehaviour
    {
        Fighter fighter;

        private void Awake()
        {
            fighter = GameObject.FindWithTag("Player").GetComponent<Fighter>();
        }

        private void Update()
        {
            Health health = fighter.GetTarget();
            if (health == null)
            {
                GetComponent<Text>().text = "N/A";
            }
            else
            {
                GetComponent<Text>().text = String.Format("{0:0}%", health.GetPercentage());
            }
        }
    }
}
