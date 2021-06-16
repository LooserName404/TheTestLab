using UnityEngine;

namespace Rudder.Physics
{
    public class AngleCalculator
    {
        public Quaternion Calculate(Vector3 vector)
        {
            return Quaternion.LookRotation(Vector3.forward, vector);
        }
    }
}