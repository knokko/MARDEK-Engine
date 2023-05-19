using UnityEngine;

namespace MARDEK.CharacterSystem
{
    [CreateAssetMenu(menuName = "MARDEK/Character/PortraitType")]
    public class PortraitType : ScriptableObject
    {
        [SerializeField] string _name;

        public string name { get { return _name; } }
    }
}
