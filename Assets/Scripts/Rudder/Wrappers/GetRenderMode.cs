using UnityEngine;
using Zenject;

namespace Rudder.Wrappers
{
    public class GetRenderMode : IGetRenderMode
    {
        private readonly Canvas _canvas;

        public GetRenderMode(Canvas canvas)
        {
            _canvas = canvas;
        }
        
        public RenderMode RenderMode => _canvas.renderMode;
    }
}