using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using MARDEK.CharacterSystem;

namespace MARDEK.UI
{
    public class CharacterUI : MonoBehaviour
    {
        public Character character { get; private set; }

        private void Awake()
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        public void AssignCharacter(Character c)
        {
            character = c;
        }
    }
}