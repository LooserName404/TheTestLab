using UnityEngine;
using Zenject;

namespace Rudder.Wrappers
{
    public class GetWorldToScreenPoint : IGetWorldToScreenPoint
    {
        private readonly Camera _camera;

        public GetWorldToScreenPoint(Camera camera)
        {
            _camera = camera;
        }

        public Vector3 WorldToScreenPoint(Vector3 position)
        {
            return _camera.WorldToScreenPoint(position);
        }
    }
}