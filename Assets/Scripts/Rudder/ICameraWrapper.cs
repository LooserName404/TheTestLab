using UnityEngine;

namespace Rudder
{
    public interface ICameraWrapper
    {
        public Vector3 WorldToScreenPoint(Vector3 position);
    }
}