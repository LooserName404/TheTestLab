namespace Utils
{
    public static class MathUtils
    {
        public static float Remap(float value, float r1From, float r1To, float r2From, float r2To)
        {
            return (value - r1From) / (r1To - r1From) * (r2To - r2From) + r2From;
        }
    }
}