using System;
using Rudder.Input;
using Rudder.Physics;
using UnityEngine;
using Zenject;

namespace Rudder
{
    public class RudderBehaviour : MonoBehaviour, IRudder
    {
        [SerializeField] private Transform validAreaTransform;

        [Inject] private RudderInputHandler _input;
        [Inject] private RudderScreenPositionHandler _screenPositionHandler;
        [Inject] private AngleCalculator _angle;

        private CircleCollider2D _collider;
        private Vector3 _rudderScreenPosition;

        public Vector3 Position => transform.position;

        private void Start()
        {
            _collider = GetComponent<CircleCollider2D>();
            _rudderScreenPosition = _screenPositionHandler.GetPosition(validAreaTransform.position);
        }

        private void Update()
        {
            if (!_input.IsMousePressed) return;

            Debug.Log("MousePressed!");

            var position = _input.GetPosition();
            if (!_input.IsPositionValid(position, _collider)) return;

            var angleVector = ((Vector3) position - _rudderScreenPosition).normalized;

            transform.rotation = _angle.Calculate(angleVector);

            Func<int, int> xf;
            xf = (x) => x * x;
            xf?.Invoke(2);
        }
    }
}