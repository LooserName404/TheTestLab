using System;
using Rudder.Wrappers;
using UnityEngine;

namespace Rudder
{
    public class RudderScreenPositionHandler
    {
        private readonly IGetWorldToScreenPoint _getWorldToScreenPoint;
        private readonly IGetRenderMode _canvas;

        public RudderScreenPositionHandler(IGetWorldToScreenPoint getWorldToScreenPoint, IGetRenderMode canvas)
        {
            _getWorldToScreenPoint = getWorldToScreenPoint;
            _canvas = canvas;
        }

        public Vector3 GetPosition(Vector3 position)
        {
            return _canvas.RenderMode switch
            {
                RenderMode.ScreenSpaceCamera => _getWorldToScreenPoint.WorldToScreenPoint(position),
                RenderMode.ScreenSpaceOverlay => position,
                _ => throw new NotImplementedException()
            };
        }
    }
}