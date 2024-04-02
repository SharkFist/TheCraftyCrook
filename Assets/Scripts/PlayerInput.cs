using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CraftyCrook.Movement;

namespace CraftyCrook.PlayerInput
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMovement _playerMovement;
        
        // Start is called before the first frame update
        void Start()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        // Update is called once per frame
        void Update()
        {
            _playerMovement.LeftAndRight(Input.GetAxisRaw("Horizontal"));
            _playerMovement.UpAndDown(Input.GetAxisRaw("Vertical"));
        }
    }
}
