using UnityEngine;

namespace Napadol.Tools
{
    public static class Easing
    {
        public static float EaseLinear(float t)
        {
            return t;
        }
        #region EaseIn
        public static float EaseInSine(float t)
        {
            return 1f - Mathf.Cos((t * Mathf.PI) / 2f);
        }
        public static float EaseInCubic(float t)
        {
            return t * t * t;
        }
        public static float EaseInQuint(float t)
        {
            return t * t * t * t * t;
        }
        public static float EaseInCirc(float t)
        {
            return 1f - Mathf.Sqrt(1f - Mathf.Pow(t, 2));
        }
        public static float EaseInElastic(float t)
        {
            const float c4 = (2f * Mathf.PI) / 3f;
            
            return t == 0f 
                ? 0f
                : t >= 0.99f
                    ? 1f
                    : -Mathf.Pow(2f, 10f * t - 10f) 
                      * Mathf.Sin((t * 10f - 10.75f) * c4);
        }
        public static float EaseInQuad(float t)
        {
            return t * t;
        }
        public static float EaseInQuart(float t)
        {
            return t * t * t * t;
        }
        public static float EaseInExpo(float t)
        {
            return t == 0 ? 0 : Mathf.Pow(2f, 10f * t - 10f);
        }
        public static float EaseInBack(float t)
        {
            const float c1 = 1.70158f;
            const float c3 = c1 + 1f;
            
            return c3 * t * t * t - c1 * t * t;
        }
        public static float EaseInBounce(float t)
        {
            return 1f - EaseOutBounce(1f - t);
        }
        #endregion
        #region EaseOut
        public static float EaseOutSine(float t)
        {
            return Mathf.Sin((t * Mathf.PI) / 2f);
        }
        public static float EaseOutCubic(float t)
        {
            return 1f - Mathf.Pow(1 - t, 3);
        }
        public static float EaseOutQuint(float t)
        {
            return 1f - Mathf.Pow(1 - t, 5);
        }
        public static float EaseOutCirc(float t)
        {
            return Mathf.Sqrt(1 - Mathf.Pow(t - 1, 2));
        }
        public static float EaseOutElastic(float t)
        {
            const float c4 = (2f * Mathf.PI) / 3f;
            
            return t == 0f
                ? 0f
                : t >= 0.99f
                    ? 1f
                    : Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * 10f - 0.75f) * c4) + 1f;
        }
        public static float EaseOutQuad(float t)
        {
            return 1f - (1f - t) * (1f - t);
        }
        public static float EaseOutQuart(float t)
        {
            return 1f - Mathf.Pow(1f - t, 4);
        }
        public static float EaseOutExpo(float t)
        {
            return t >= 0.99f ? 1f : 1f - Mathf.Pow(2, -10f * t);
        }
        public static float EaseOutBack(float t)
        {
            const float c1 = 1.70158f;
            const float c3 = c1 + 1f;
            return 1f + c3 * Mathf.Pow(t - 1, 3) + c1 * Mathf.Pow(t - 1f, 2);
        }
        public static float EaseOutBounce(float t)
        {
            const float n1 = 7.5625f;
            const float d1 = 2.75f;

            if (t < 1f / d1)
            {
                return n1 * t * t;
            } 
            else if (t < 2f / d1)
            {
                return n1 * (t -= 1.5f / d1) * t + 0.75f;
            }
            else if (t <  2.5f / d1)
            {
                return  n1 * (t -= 2.25f / d1) * t + 0.9375f;
            }
            else
            {
                return n1 * (t -= 2.625f / d1) * t + 0.984375f;
            }
        }
        #endregion
        #region EaseInOut
        public static float EaseInOutSine(float t)
        {
            return -(Mathf.Cos(Mathf.PI * t) - 1f)/2f;
        }
        public static float EaseInOutCubic(float t)
        {
            return t < 0.5f ? 4f * t * t * t : 1f - Mathf.Pow(-2f * t + 2f, 3) / 2f;
        }
        public static float EaseInOutQuint(float t)
        {
            return t < 0.5f ? 16f * t * t * t * t * t : 1f - Mathf.Pow(-2f * t + 2f, 5) / 2f;
        }
        public static float EaseInOutCirc(float t)
        {
            return t < 0.5f 
                ? (1f - Mathf.Sqrt(1f - Mathf.Pow(2f * t, 2))) / 2f 
                : (Mathf.Sqrt(1f - Mathf.Pow(-2f * t + 2f, 2)) + 1f) / 2f;
        }
        public static float EaseInOutElastic(float t)
        {
            const float c5 = (2f * Mathf.PI) / 4.5f;
            
            return t == 0f
                ? 0f
                : t >= 0.99f
                    ? 1f
                    : t < 0.5f
                    ? -(Mathf.Pow(2f, 20 * t - 10f) * Mathf.Sin((20f * t - 11.125f) * c5)) / 2f
                    : (Mathf.Pow(2f, -20 * t + 10f) * Mathf.Sin((20f * t - 11.125f) * c5)) / 2f + 1f;
        }
        public static float EaseInOutQuad(float t)
        {
            return t < 0.5f ? 2f * t * t : 1 - Mathf.Pow(-2f * t + 2f, 2) / 2f;
        }
        public static float EaseInOutQuart(float t)
        {
            return t < 0.5f ? 8 * t * t * t * t : 1f - Mathf.Pow(-2f * t + 2f, 4) / 2f;
        }
        public static float EaseInOutExpo(float t)
        {
            return t == 0f
                ? 0f
                : t >= 0.99f
                    ? 1f
                    : t < 0.5f ? Mathf.Pow(2f, -20f * t - 10f) / 2f
                        : (2f - Mathf.Pow(2f, -20f * t + 10f) / 2f);
        }
        public static float EaseInOutBack(float t)
        {
            const float c1 = 1.70158f;
            const float c2 = c1 * 1.525f;

            return t < 0.5f
                ? (Mathf.Pow(2f * t, 2) * ((c2 + 1f) * 2f * t - c2)) / 2f
                : (Mathf.Pow(2f * t - 2f, 2) * ((c2 + 1f) * (t * 2f - 2f) + c2) + 2f) / 2f;
        }
        public static float EaseInOutBounce(float t)
        {
            return t < 0.5f
                ? (1 - EaseOutBounce(1f - 2f * t)) / 2f
                : (1 + EaseOutBounce(2f * t - 1f)) / 2f;
        }
        #endregion
    }
}
