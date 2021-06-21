using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FistVR;
using UnityEngine;

namespace H3VRModdingTutorialEpisode3
{
    [RequireComponent(typeof(BoxCollider))]
    public class Button : MonoBehaviour
    {
        private BoxCollider _buttonCollider;

        private void Awake()
        {
            _buttonCollider = GetComponent<BoxCollider>();

            if (!_buttonCollider.isTrigger)
            {
                Debug.LogError("Box collider on object " + this.name + " is not a trigger!");
                return;
            }
        }

        private void OnCollisionEnter(Collision collider)
        {
            GameObject obj = collider.gameObject;

            if (obj.GetComponent<FVRViveHand>())
            {
                GM.CurrentPlayerBody.KillPlayer(true);
            }
        }
    }
}
