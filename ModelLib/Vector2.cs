using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    /// <summary>
    /// Heavily inspired by the Vector2 struct from Unity
    /// </summary>
    public struct Vector2 : IEquatable<Vector2>, IFormattable
    {
        private static readonly Vector2 zeroVector = new Vector2(0f, 0f);
        private static readonly Vector2 oneVector = new Vector2(1f, 1f);
        private static readonly Vector2 upVector = new Vector2(0f, 1f);
        private static readonly Vector2 downVector = new Vector2(0f, -1f);
        private static readonly Vector2 leftVector = new Vector2(-1f, 0f);
        private static readonly Vector2 rightVector = new Vector2(1f, 0f);

        public static Vector2 zero => zeroVector;
        public static Vector2 one => oneVector;
        public static Vector2 up => upVector;
        public static Vector2 down => downVector;
        public static Vector2 left => leftVector;
        public static Vector2 right => rightVector;

        public float x { get; set; }
        public float y { get; set; }

        public Vector2()
        {
            this.x = 0;
            this.y = 0;
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Set(float newX, float newY)
        {
            x = newX;
            y = newY;
        }


        // OPERATORS - This is so we can do some of the operations we know from int and float, but on a Vector2
        #region Operators
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }
        public static Vector2 operator *(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x * b.x, a.y * b.y);
        }
        public static Vector2 operator /(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x / b.x, a.y / b.y);
        }
        public static Vector2 operator -(Vector2 a)
        {
            return new Vector2(0f - a.x, 0f - a.y);
        }
        public static Vector2 operator *(Vector2 a, float d)
        {
            return new Vector2(a.x * d, a.y * d);
        }
        public static Vector2 operator *(float d, Vector2 a)
        {
            return new Vector2(a.x * d, a.y * d);
        }
        public static Vector2 operator /(Vector2 a, float d)
        {
            return new Vector2(a.x / d, a.y / d);
        }
        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            float num = lhs.x - rhs.x;
            float num2 = lhs.y - rhs.y;
            return num * num + num2 * num2 < 9.99999944E-11f;
        }
        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }
        #endregion

        // OVERRIDES
        #region Overrides
        // Equals
        public override bool Equals(object other)
        {
            if (!(other is Vector2))
            {
                return false;
            }

            return Equals((Vector2)other);
        }
        public bool Equals(Vector2 other)
        {
            return x == other.x && y == other.y;
        }

        // ToString
        public override string ToString()
        {
            return ToString(null, CultureInfo.InvariantCulture.NumberFormat);
        }

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.InvariantCulture.NumberFormat);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "F1";
            }

            return String.Format("({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        // Hash Code
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2);
        }
        #endregion
    }
}
