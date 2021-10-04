using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof(ThirdPersonCharacter))]
    public class GladiatorUserControl : MonoBehaviour
    {
        private ThirdPersonCharacter M_gladiator;
        private Vector3 M_move;
        private bool groundedPlayer;
        // Start is called before the first frame update
        void Start()
        {

            M_gladiator = GetComponent<ThirdPersonCharacter>();
        }

        // Update is called once per frame
        void Update()
        {
            if (!groundedPlayer)
            {
                groundedPlayer = CrossPlatformInputManager.GetButtonDown("Jump");          
            }

        }
    }
}
