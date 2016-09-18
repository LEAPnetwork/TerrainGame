using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class ThirdPersonUserControl : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
        private Vector3 m_Strafe;
        private Vector3 m_TurnAmount;
        
        private void Start()
        {

                m_Cam = Camera.main.transform;  
                m_Character = GetComponent<ThirdPersonCharacter>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                m_Jump = Input.GetButtonDown("Jump");
            }
        }

        /*
        // Fixed update is called in sync with physics
        private void FixedUpdate()
        {
            // read inputs
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");



            bool crouch = Input.GetKey(KeyCode.C);

            m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;

            if (v < 0)
            {
                m_Move = v * m_CamForward + h * m_Cam.right;
            }
            else
            {
                m_Move = v * m_CamForward + h * m_Cam.right;
            }




            // pass all parameters to the character control script
            m_Character.Move(m_Move, crouch, m_Jump);
            m_Jump = false;
        }
        */

        private void FixedUpdate()
        {
            // read inputs
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");

            m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;

      

            m_Move = new Vector3(h, 0f, v);



            m_TurnAmount = Vector3.RotateTowards(Vector3.Scale(transform.forward, new Vector3(1, 0, 1)).normalized, m_CamForward, 1, 1);

      

            // pass all parameters to the character control script
            m_Character.Move(v, m_TurnAmount, m_Jump, h);
            m_Jump = false;
        }
    }
}
