namespace Mathment.Graphics;

public class CubicBezier {
    public Vector2 P1, P2;

    public CubicBezier(Vector2 p1, Vector2 p2) => (P1, P2) = (p1, p2);
    public CubicBezier(float x1, float y1, float x2, float y2) => (P1, P2) = (new Vector2(x1, y1), new Vector2(x2, y2));

    public float GetAt(float t) {
        return (float)Math.Pow(1 - t, 3) * 0 + 3 * (float)Math.Pow(1 - t, 2) * t * P1.X + 3 * (1 - t) * (float)Math.Pow(t, 2) * P2.X + (float)Math.Pow(t, 3) * 1;
    }
}

public static class CubicBezierPreset {
    public static CubicBezier EaseIn = new CubicBezier(0.42f, 0f, 1f, 1f);
    public static CubicBezier EaseOut = new CubicBezier(0f, 0f, 0.58f, 1f);
    public static CubicBezier EaseInOut = new CubicBezier(0.42f, 0f, 0.58f, 1f);
    public static CubicBezier Linear = new CubicBezier(0f, 0f, 1f, 1f);
    public static CubicBezier EaseInSine = new CubicBezier(0.47f, 0f, 0.745f, 0.715f);
    public static CubicBezier EaseOutSine = new CubicBezier(0.39f, 0.575f, 0.565f, 1f);
    public static CubicBezier EaseInOutSine = new CubicBezier(0.445f, 0.05f, 0.55f, 0.95f);
    public static CubicBezier EaseInQuad = new CubicBezier(0.55f, 0.085f, 0.68f, 0.53f);
    public static CubicBezier EaseOutQuad = new CubicBezier(0.25f, 0.46f, 0.45f, 0.94f);
    public static CubicBezier EaseInOutQuad = new CubicBezier(0.455f, 0.03f, 0.515f, 0.955f);
    public static CubicBezier EaseInCubic = new CubicBezier(0.55f, 0.055f, 0.675f, 0.19f);
    public static CubicBezier EaseOutCubic = new CubicBezier(0.215f, 0.61f, 0.355f, 1f);
    public static CubicBezier EaseInOutCubic = new CubicBezier(0.645f, 0.045f, 0.355f, 1f);
    public static CubicBezier EaseInQuart = new CubicBezier(0.895f, 0.03f, 0.685f, 0.22f);
    public static CubicBezier EaseOutQuart = new CubicBezier(0.165f, 0.84f, 0.44f, 1f);
    public static CubicBezier EaseInOutQuart = new CubicBezier(0.77f, 0f, 0.175f, 1f);
    public static CubicBezier EaseInQuint = new CubicBezier(0.755f, 0.05f, 0.855f, 0.06f);
    public static CubicBezier EaseOutQuint = new CubicBezier(0.23f, 1f, 0.32f, 1f);
    public static CubicBezier EaseInOutQuint = new CubicBezier(0.86f, 0f, 0.07f, 1f);
    public static CubicBezier EaseInExpo = new CubicBezier(0.95f, 0.05f, 0.795f, 0.035f);
    public static CubicBezier EaseOutExpo = new CubicBezier(0.19f, 1f, 0.22f, 1f);
    public static CubicBezier EaseInOutExpo = new CubicBezier(1f, 0f, 0f, 1f);
    public static CubicBezier EaseInCirc = new CubicBezier(0.6f, 0.04f, 0.98f, 0.335f);
    public static CubicBezier EaseOutCirc = new CubicBezier(0.075f, 0.82f, 0.165f, 1f);
    public static CubicBezier EaseInOutCirc = new CubicBezier(0.785f, 0.135f, 0.15f, 0.86f);
    public static CubicBezier EaseInBack = new CubicBezier(0.6f, -0.28f, 0.735f, 0.045f);
    public static CubicBezier EaseOutBack = new CubicBezier(0.175f, 0.885f, 0.32f, 1.275f);
    public static CubicBezier EaseInOutBack = new CubicBezier(0.68f, -0.55f, 0.265f, 1.55f);
}