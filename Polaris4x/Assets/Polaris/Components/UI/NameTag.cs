using System;
using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(TextMesh))]
    class NameTag : MonoBehaviour
    {
        public void SetName(string name)
        {
            if (name.Length > 0)
            {
                var mesh = GetComponent<TextMesh>();
                mesh.text = name;
            }
        }
    }
}
