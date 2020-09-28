using UnityEngine;

namespace RPG.Core
{
    public class DestroyAfterEffect : MonoBehaviour
    {
        [SerializeField] GameObject targetToDestory;

        private void Update()
        {
            if (!GetComponent<ParticleSystem>().IsAlive())
            {
                if (targetToDestory != null)
                {
                    Destroy(targetToDestory);
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}