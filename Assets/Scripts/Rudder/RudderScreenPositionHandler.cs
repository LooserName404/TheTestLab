using System;
using UnityEngine;

namespace Rudder
{
    public class RudderScreenPositionHandler
    {
        private readonly ICameraWrapper _cameraWrapper;

        public RudderScreenPositionHandler(ICameraWrapper cameraWrapper)
        {
            _cameraWrapper = cameraWrapper;
        }
        public Vector3 GetPosition(Vector3 position, ICanvasWrapper canvas)
        {
            return canvas.RenderMode switch
            {
                RenderMode.ScreenSpaceCamera => _cameraWrapper.WorldToScreenPoint(position),
                RenderMode.ScreenSpaceOverlay => position,
                _ => throw new NotImplementedException(),
            };
        }
    }
}