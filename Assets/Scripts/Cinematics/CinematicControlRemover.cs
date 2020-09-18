using UnityEngine;
using UnityEngine.Playables;
using RPG.Core;
using RPG.Control;

namespace RPG.Cinematics
{
    public class CinematicControlRemover : MonoBehaviour
    {
        GameObject player;

        private void Start()
        {
            GetComponent<PlayableDirector>().played += DisableControl;
            GetComponent<PlayableDirector>().stopped += EnableControl;

            player = GameObject.FindWithTag("Player");
        }

        void DisableControl(PlayableDirector pd)
        {
            player.GetComponent<ActionScheduler>().CancelCurrentAction();
            EnablePlayerController(false);
        }

        void EnableControl(PlayableDirector pd)
        {
            EnablePlayerController(true);
        }

        void EnablePlayerController(bool enable)
        {
            player.GetComponent<PlayerController>().enabled = enable;
        }
    }
}
