using UnityEngine;

namespace Rudder.Wrappers
{
    public interface IGetWorldToScreenPoint
    {
        public Vector3 WorldToScreenPoint(Vector3 position);
    }
}