namespace Mathment.Graphics;

public static class MCurve {
    // EASE
    public static double EaseIn(double t) => t * t * t;
    public static double EaseOut(double t) => 1 - EaseIn(1 - t);
    public static double EaseInOut(double t) => t < 0.5 ? EaseIn(t * 2) / 2 : EaseOut(t * 2 - 1) / 2 + 0.5;
    public static double EaseOutIn(double t) => t < 0.5 ? EaseOut(t * 2) / 2 : EaseIn(t * 2 - 1) / 2 + 0.5;

    // QUADRATIC
    public static double QuadraticIn(double t) => t * t;
    public static double QuadraticOut(double t) => 1 - QuadraticIn(1 - t);
    public static double QuadraticInOut(double t) => t < 0.5 ? QuadraticIn(t * 2) / 2 : QuadraticOut(t * 2 - 1) / 2 + 0.5;
    public static double QuadraticOutIn(double t) => t < 0.5 ? QuadraticOut(t * 2) / 2 : QuadraticIn(t * 2 - 1) / 2 + 0.5;

    // CUBIC
    public static double CubicIn(double t) => t * t * t;
    public static double CubicOut(double t) => 1 - CubicIn(1 - t);
    public static double CubicInOut(double t) => t < 0.5 ? CubicIn(t * 2) / 2 : CubicOut(t * 2 - 1) / 2 + 0.5;
    public static double CubicOutIn(double t) => t < 0.5 ? CubicOut(t * 2) / 2 : CubicIn(t * 2 - 1) / 2 + 0.5;

    // QUARTIC
    public static double QuarticIn(double t) => t * t * t * t;
    public static double QuarticOut(double t) => 1 - QuarticIn(1 - t);
    public static double QuarticInOut(double t) => t < 0.5 ? QuarticIn(t * 2) / 2 : QuarticOut(t * 2 - 1) / 2 + 0.5;
    public static double QuarticOutIn(double t) => t < 0.5 ? QuarticOut(t * 2) / 2 : QuarticIn(t * 2 - 1) / 2 + 0.5;

    // SINE
    public static double SineIn(double t) => 1 - Math.Cos(t * Math.PI / 2);
    public static double SineOut(double t) => 1 - SineIn(1 - t);
    public static double SineInOut(double t) => t < 0.5 ? SineIn(t * 2) / 2 : SineOut(t * 2 - 1) / 2 + 0.5;
    public static double SineOutIn(double t) => t < 0.5 ? SineOut(t * 2) / 2 : SineIn(t * 2 - 1) / 2 + 0.5;

    // EXPONENTIAL
    public static double ExponentialIn(double t) => Math.Pow(2, 10 * (t - 1));
    public static double ExponentialOut(double t) => 1 - ExponentialIn(1 - t);
    public static double ExponentialInOut(double t) => t < 0.5 ? ExponentialIn(t * 2) / 2 : ExponentialOut(t * 2 - 1) / 2 + 0.5;
    public static double ExponentialOutIn(double t) => t < 0.5 ? ExponentialOut(t * 2) / 2 : ExponentialIn(t * 2 - 1) / 2 + 0.5;

    // CIRCULAR
    public static double CircularIn(double t) => 1 - Math.Sqrt(1 - t * t);
    public static double CircularOut(double t) => 1 - CircularIn(1 - t);
    public static double CircularInOut(double t) => t < 0.5 ? CircularIn(t * 2) / 2 : CircularOut(t * 2 - 1) / 2 + 0.5;
    public static double CircularOutIn(double t) => t < 0.5 ? CircularOut(t * 2) / 2 : CircularIn(t * 2 - 1) / 2 + 0.5;

    // ELASTIC
    public static double ElasticIn(double t) => Math.Pow(2, 10 * (t - 1)) * Math.Sin((t - 1.1) * 5 * Math.PI);
    public static double ElasticOut(double t) => 1 - ElasticIn(1 - t);
    public static double ElasticInOut(double t) => t < 0.5 ? ElasticIn(t * 2) / 2 : ElasticOut(t * 2 - 1) / 2 + 0.5;
    public static double ElasticOutIn(double t) => t < 0.5 ? ElasticOut(t * 2) / 2 : ElasticIn(t * 2 - 1) / 2 + 0.5;

    // BACK
    public static double BackIn(double t) => t * t * (2.70158 * t - 1.70158);
    public static double BackOut(double t) => 1 - BackIn(1 - t);
    public static double BackInOut(double t) => t < 0.5 ? BackIn(t * 2) / 2 : BackOut(t * 2 - 1) / 2 + 0.5;
    public static double BackOutIn(double t) => t < 0.5 ? BackOut(t * 2) / 2 : BackIn(t * 2 - 1) / 2 + 0.5;

    // BOUNCE
    public static double BounceIn(double t) => 1 - BounceOut(1 - t);
    public static double BounceOut(double t) => t < 4 / 11.0 ? (121 * t * t) / 16.0 : t < 8 / 11.0 ? (363 / 40.0 * t * t) - (99 / 10.0 * t) + 17 / 5.0 : t < 9 / 10.0 ? (4356 / 361.0 * t * t) - (35442 / 1805.0 * t) + 16061 / 1805.0 : (54 / 5.0 * t * t) - (513 / 25.0 * t) + 268 / 25.0;
    public static double BounceInOut(double t) => t < 0.5 ? BounceIn(t * 2) / 2 : BounceOut(t * 2 - 1) / 2 + 0.5;
    public static double BounceOutIn(double t) => t < 0.5 ? BounceOut(t * 2) / 2 : BounceIn(t * 2 - 1) / 2 + 0.5;
}