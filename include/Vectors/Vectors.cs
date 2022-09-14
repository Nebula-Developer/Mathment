namespace Mathment.Graphics;

public class Vector2 {
    public float X, Y;
    public Vector2(float x, float y) => (X, Y) = (x, y);
    public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.X + b.X, a.Y + b.Y);
    public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.X - b.X, a.Y - b.Y);
    public static Vector2 operator *(Vector2 a, float b) => new Vector2(a.X * b, a.Y * b);
    public static Vector2 operator *(float a, Vector2 b) => new Vector2(a * b.X, a * b.Y);
    public static Vector2 operator /(Vector2 a, float b) => new Vector2(a.X / b, a.Y / b);
    public static Vector2 operator /(float a, Vector2 b) => new Vector2(a / b.X, a / b.Y);
    public static Vector2 operator -(Vector2 a) => new Vector2(-a.X, -a.Y);
    public static bool operator ==(Vector2 a, Vector2 b) => a.X == b.X && a.Y == b.Y;
    public static bool operator !=(Vector2 a, Vector2 b) => a.X != b.X || a.Y != b.Y;
}

public class Vector3 {
    public float X, Y, Z;
    public Vector3(float x, float y, float z) => (X, Y, Z) = (x, y, z);
}

public class Vector4 {
    public float X, Y, Z, W;
    public Vector4(float x, float y, float z, float w) => (X, Y, Z, W) = (x, y, z, w);
}

public class Vector2i {
    public int X, Y;
    public Vector2i(int x, int y) => (X, Y) = (x, y);
}

public class Vector3i {
    public int X, Y, Z;
    public Vector3i(int x, int y, int z) => (X, Y, Z) = (x, y, z);
}

public class Vector4i {
    public int X, Y, Z, W;
    public Vector4i(int x, int y, int z, int w) => (X, Y, Z, W) = (x, y, z, w);
}