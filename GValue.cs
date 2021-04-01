using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
#if !SERVER
using UnityEngine;
#endif
using Object = System.Object;

namespace GEngine
{
    public struct GValue
    {
        public static readonly GValue NONE = new GValue() {_kind = Kind.NONE};

        public enum Kind
        {
            NONE,
            BOOLEAN,
            SBYTE,
            BYTE,
            CHAR,
            SHORT,
            USHORT,
            INT,
            UINT,
            LONG,
            ULONG,
            SINGLE,
            DOUBLE,
            STRING,
            BOOLEAN_ARRAY,
            SBYTE_ARRAY,
            BYTE_ARRAY,
            CHAR_ARRAY,
            SHORT_ARRAY,
            USHORT_ARRAY,
            INT_ARRAY,
            UINT_ARRAY,
            LONG_ARRAY,
            ULONG_ARRAY,
            SINGLE_ARRAY,
            DOUBLE_ARRAY,
            STRING_ARRAY,
        }

        [StructLayout(LayoutKind.Explicit)]
        struct Value
        {
            [FieldOffset(0)] internal Boolean _boolean;

            [FieldOffset(0)] internal SByte _int8;

            [FieldOffset(0)] internal Byte _uint8;

            [FieldOffset(0)] internal Char _char;

            [FieldOffset(0)] internal Int16 _int16;

            [FieldOffset(0)] internal UInt16 _uint16;

            [FieldOffset(0)] internal Int32 _int32;

            [FieldOffset(0)] internal UInt32 _uint32;

            [FieldOffset(0)] internal Int64 _int64;

            [FieldOffset(0)] internal UInt64 _uint64;

            [FieldOffset(0)] internal Single _single;

            [FieldOffset(0)] internal Double _double;
        };

        private Kind _kind;
        private Value _value;
        private Object _object;

        public Kind Type => _kind;

        public static implicit operator GValue(bool value)
        {
            return new GValue() {_kind = Kind.BOOLEAN, _value = new Value() {_boolean = value}};
        }

        public static implicit operator bool(GValue value)
        {
            return value._value._boolean;
        }

        public static implicit operator GValue(sbyte value)
        {
            return new GValue() {_kind = Kind.SBYTE, _value = new Value() {_int8 = value}};
        }

        public static implicit operator sbyte(GValue value)
        {
            return value._value._int8;
        }

        public static implicit operator GValue(byte value)
        {
            return new GValue() {_kind = Kind.BYTE, _value = new Value() {_uint8 = value}};
        }

        public static implicit operator byte(GValue value)
        {
            return value._value._uint8;
        }

        public static implicit operator GValue(char value)
        {
            return new GValue() {_kind = Kind.CHAR, _value = new Value() {_char = value}};
        }

        public static implicit operator char(GValue value)
        {
            return value._value._char;
        }

        public static implicit operator GValue(short value)
        {
            return new GValue() {_kind = Kind.SHORT, _value = new Value() {_int16 = value}};
        }

        public static implicit operator short(GValue value)
        {
            return value._value._int16;
        }

        public static implicit operator GValue(ushort value)
        {
            return new GValue() {_kind = Kind.USHORT, _value = new Value() {_uint16 = value}};
        }

        public static implicit operator ushort(GValue value)
        {
            return value._value._uint16;
        }

        public static implicit operator GValue(int value)
        {
            return new GValue() {_kind = Kind.INT, _value = new Value() {_int32 = value}};
        }

        public static implicit operator int(GValue value)
        {
            return value._value._int32;
        }

        public static implicit operator GValue(uint value)
        {
            return new GValue() {_kind = Kind.UINT, _value = new Value() {_uint32 = value}};
        }

        public static implicit operator uint(GValue value)
        {
            return value._value._uint32;
        }

        public static implicit operator GValue(long value)
        {
            return new GValue() {_kind = Kind.LONG, _value = new Value() {_int64 = value}};
        }

        public static implicit operator long(GValue value)
        {
            return value._value._int64;
        }

        public static implicit operator GValue(ulong value)
        {
            return new GValue() {_kind = Kind.ULONG, _value = new Value() {_uint64 = value}};
        }

        public static implicit operator ulong(GValue value)
        {
            return value._value._uint64;
        }

        public static implicit operator GValue(float value)
        {
            return new GValue() {_kind = Kind.SINGLE, _value = new Value() {_single = value}};
        }

        public static implicit operator float(GValue value)
        {
            return value._value._single;
        }

        public static implicit operator GValue(double value)
        {
            return new GValue() {_kind = Kind.DOUBLE, _value = new Value() {_double = value}};
        }

        public static implicit operator double(GValue value)
        {
            return value._value._double;
        }

        public static implicit operator GValue(string value)
        {
            return new GValue() {_kind = Kind.STRING, _object = value};
        }

        public static implicit operator string(GValue value)
        {
            return value.ToString();
        }

        public static implicit operator GValue(bool[] value)
        {
            return new GValue() {_kind = Kind.BOOLEAN_ARRAY, _object = value};
        }

        public static implicit operator bool[](GValue value)
        {
            return value._kind == Kind.BOOLEAN_ARRAY ? (bool[]) value._object : null;
        }

        public static implicit operator GValue(sbyte[] value)
        {
            return new GValue() {_kind = Kind.SBYTE_ARRAY, _object = value};
        }

        public static implicit operator sbyte[](GValue value)
        {
            return value._kind == Kind.SBYTE_ARRAY ? (sbyte[]) value._object : null;
        }

        public static implicit operator GValue(byte[] value)
        {
            return new GValue() {_kind = Kind.BYTE_ARRAY, _object = value};
        }

        public static implicit operator byte[](GValue value)
        {
            return value._kind == Kind.BYTE_ARRAY ? (byte[]) value._object : null;
        }

        public static implicit operator GValue(char[] value)
        {
            return new GValue() {_kind = Kind.CHAR_ARRAY, _object = value};
        }

        public static implicit operator char[](GValue value)
        {
            return value._kind == Kind.CHAR_ARRAY ? (char[]) value._object : null;
        }

        public static implicit operator GValue(short[] value)
        {
            return new GValue() {_kind = Kind.SHORT_ARRAY, _object = value};
        }

        public static implicit operator short[](GValue value)
        {
            return value._kind == Kind.SHORT_ARRAY ? (short[]) value._object : null;
        }

        public static implicit operator GValue(ushort[] value)
        {
            return new GValue() {_kind = Kind.USHORT_ARRAY, _object = value};
        }

        public static implicit operator ushort[](GValue value)
        {
            return value._kind == Kind.USHORT_ARRAY ? (ushort[]) value._object : null;
        }

        public static implicit operator GValue(int[] value)
        {
            return new GValue() {_kind = Kind.INT_ARRAY, _object = value};
        }

        public static implicit operator int[](GValue value)
        {
            return value._kind == Kind.INT_ARRAY ? (int[]) value._object : null;
        }

        public static implicit operator GValue(uint[] value)
        {
            return new GValue() {_kind = Kind.UINT_ARRAY, _object = value};
        }

        public static implicit operator uint[](GValue value)
        {
            return value._kind == Kind.UINT_ARRAY ? (uint[]) value._object : null;
        }

        public static implicit operator GValue(long[] value)
        {
            return new GValue() {_kind = Kind.LONG_ARRAY, _object = value};
        }

        public static implicit operator long[](GValue value)
        {
            return value._kind == Kind.LONG_ARRAY ? (long[]) value._object : null;
        }

        public static implicit operator GValue(ulong[] value)
        {
            return new GValue() {_kind = Kind.ULONG_ARRAY, _object = value};
        }

        public static implicit operator ulong[](GValue value)
        {
            return value._kind == Kind.ULONG_ARRAY ? (ulong[]) value._object : null;
        }

        public static implicit operator GValue(float[] value)
        {
            return new GValue() {_kind = Kind.SINGLE_ARRAY, _object = value};
        }

        public static implicit operator float[](GValue value)
        {
            return value._kind == Kind.SINGLE_ARRAY ? (float[]) value._object : null;
        }

        public static implicit operator GValue(double[] value)
        {
            return new GValue() {_kind = Kind.DOUBLE_ARRAY, _object = value};
        }

        public static implicit operator double[](GValue value)
        {
            return value._kind == Kind.DOUBLE_ARRAY ? (double[]) value._object : null;
        }

        public static implicit operator GValue(string[] value)
        {
            return new GValue() {_kind = Kind.STRING_ARRAY, _object = value};
        }

        public static implicit operator string[](GValue value)
        {
            return value._kind == Kind.STRING_ARRAY ? (string[]) value._object : null;
        }

        #if !SERVER
        
        public static implicit operator Vector2(GValue value)
        {
            if (value._kind == Kind.SINGLE_ARRAY && value._object != null)
            {
                var singles = (float[]) value._object;
                if (singles.Length == 1)
                    return new Vector2(singles[0], 0);
                if (singles.Length > 1)
                    return new Vector2(singles[0], singles[1]);
            }

            return Vector2.zero;
        }

        public static implicit operator Vector3(GValue value)
        {
            if (value._kind == Kind.SINGLE_ARRAY && value._object != null)
            {
                var singles = (float[]) value._object;
                if (singles.Length == 1)
                    return new Vector3(singles[0], 0, 0);
                if (singles.Length == 2)
                    return new Vector3(singles[0], singles[1], 0);
                if (singles.Length > 2)
                    return new Vector3(singles[0], singles[1], singles[2]);
            }

            return Vector3.zero;
        }

        public static implicit operator Color(GValue value)
        {
            if (value._kind == Kind.SINGLE_ARRAY && value._object != null)
            {
                var singles = (float[]) value._object;
                if (singles.Length == 3)
                    return new Color(singles[0], singles[1], singles[2], 1);
                if (singles.Length > 3)
                    return new Color(singles[0], singles[1], singles[2], singles[2]);
            }

            if (value._kind == Kind.INT_ARRAY && value._object != null)
            {
                var int32s = (int[]) value._object;
                if (int32s.Length == 3)
                    return new Color(int32s[0] * 1.0f / 255, int32s[1] * 1.0f / 255, int32s[2] * 1.0f / 255, 1);
                if (int32s.Length > 3)
                    return new Color(int32s[0] * 1.0f / 255, int32s[1] * 1.0f / 255, int32s[2] * 1.0f / 255,
                        int32s[2] * 1.0f / 255);
            }

            return Color.white;
        }

        public static implicit operator Vector2[](GValue value)
        {
            if (value._kind == Kind.SINGLE_ARRAY && value._object != null)
            {
                var singles = (float[]) value._object;
                var cn = singles.Length;
                if (cn > 0)
                {
                    Vector2[] vecs = new Vector2[cn / 2];
                    for (int i = 0; i < cn && i + 2 <= cn;)
                    {
                        vecs[i / 2] = new Vector2(singles[i], singles[i + 1]);
                        i += 2;
                    }
                }
            }

            return new Vector2[0];
        }

        public static implicit operator Vector3[](GValue value)
        {
            if (value._kind == Kind.SINGLE_ARRAY && value._object != null)
            {
                var singles = (float[]) value._object;
                var cn = singles.Length;
                if (cn > 0)
                {
                    Vector3[] vecs = new Vector3[cn / 3];
                    for (int i = 0; i < cn && i + 3 <= cn;)
                    {
                        vecs[i / 3] = new Vector3(singles[i], singles[i + 1], singles[i + 2]);
                        i += 3;
                    }
                }
            }

            return new Vector3[0];
        }
        
        #endif

        public static implicit operator Dictionary<int, int>(GValue value)
        {
            if (value._kind == Kind.INT_ARRAY && value._object != null)
            {
                var int32s = (int[]) value._object;
                var cn = int32s.Length;
                Dictionary<int, int> dic = new Dictionary<int, int>(cn / 2);
                if (cn > 0)
                {
                    for (int i = 0; i < cn && i + 2 <= cn;)
                    {
                        dic[int32s[i]] = int32s[i + 1];
                        i += 2;
                    }
                }
            }

            return null;
        }

        public static bool Parse(string src, string type, out GValue value)
        {
            value = NONE;

            switch (type)
            {
                case "bool":
                    Parse(src, out bool val);
                    value = val;
                    return true;
                case "sbyte":
                    if (sbyte.TryParse(src, out var _sbyte))
                    {
                        value = _sbyte;
                        return true;
                    }

                    return false;
                case "byte":
                    if (byte.TryParse(src, out var _byte))
                    {
                        value = _byte;
                        return true;
                    }

                    return false;
                case "char":
                    if (char.TryParse(src, out var _char))
                    {
                        value = _char;
                        return true;
                    }

                    return false;
                case "short":
                    if (short.TryParse(src, out var _short))
                    {
                        value = _short;
                        return true;
                    }

                    return false;
                case "ushort":
                    if (ushort.TryParse(src, out var _ushort))
                    {
                        value = _ushort;
                        return true;
                    }

                    return false;
                case "int":
                    if (Parse(src, out int _int))
                    {
                        value = _int;
                        return true;
                    }

                    return false;
                case "uint":
                    if (Parse(src, out uint _uint))
                    {
                        value = _uint;
                        return true;
                    }

                    return false;
                case "long":
                    if (Parse(src, out long _long))
                    {
                        value = _long;
                        return true;
                    }

                    return false;
                case "ulong":
                    if (Parse(src, out ulong _ulong))
                    {
                        value = _ulong;
                        return true;
                    }

                    return false;
                case "float":
                    if (Parse(src, out float _float))
                    {
                        value = _float;
                        return true;
                    }

                    return false;
                case "double":
                    if (Parse(src, out double _double))
                    {
                        value = _double;
                        return true;
                    }

                    return false;
                case "string":
                    value = src;
                    return true;
                case "bool[]":
                case "List<bool>":
                    if (Parse(src, out bool[] _bools))
                    {
                        value = _bools;
                        return true;
                    }

                    return false;
                case "sbyte[]":
                case "List<sbyte>":
                    if (Parse(src, out sbyte[] _sbytes))
                    {
                        value = _sbytes;
                        return true;
                    }

                    return false;
                case "byte[]":
                case "List<byte>":
                    if (Parse(src, out byte[] _bytes))
                    {
                        value = _bytes;
                        return true;
                    }

                    return false;
                case "char[]":
                case "List<char>":
                    if (Parse(src, out char[] _chars))
                    {
                        value = _chars;
                        return true;
                    }

                    return false;
                case "short[]":
                case "List<short>":
                    if (Parse(src, out short[] _shorts))
                    {
                        value = _shorts;
                        return true;
                    }

                    return false;
                case "ushort[]":
                case "List<ushort>":
                    if (Parse(src, out ushort[] _ushorts))
                    {
                        value = _ushorts;
                        return true;
                    }

                    return false;
                case "int[]":
                case "List<int>":
                case "Dictionary<int,int>":
                    if (Parse(src, out int[] _ints))
                    {
                        value = _ints;
                        return true;
                    }

                    return false;
                case "uint[]":
                case "List<uint>":
                    if (Parse(src, out uint[] _uints))
                    {
                        value = _uints;
                        return true;
                    }

                    return false;
                case "long[]":
                case "List<long>":
                    if (Parse(src, out long[] _longs))
                    {
                        value = _longs;
                        return true;
                    }

                    return false;
                case "ulong[]":
                case "List<ulong>":
                    if (Parse(src, out ulong[] _ulongs))
                    {
                        value = _ulongs;
                        return true;
                    }

                    return false;
                case "float[]":
                case "List<float>":
                case "Vector2":
                case "Vector3":
                case "Vector4":
                    if (Parse(src, out float _floats))
                    {
                        value = _floats;
                        return true;
                    }

                    return false;
                case "double[]":
                case "List<double>":
                    if (Parse(src, out double[] _doubles))
                    {
                        value = _doubles;
                        return true;
                    }

                    return false;
                case "string[]":
                case "List<string>":
                    Parse(src, out string[] _strings);
                    value = _strings;
                    return true;
                case "Color":
                    if (ParseHexColor(src, out float[] _color))
                    {
                        value = _color;
                        return true;
                    }
                    return false;
                default:
                    if (!string.IsNullOrEmpty(type) && type[0] >= 'A' && type[0] <= 'Z' && Parse(src, out int _enum))//首字母大写按枚举处理，默认转换int
                    {
                        value = _enum;
                        return true;
                    }
                    
                    value = src;
                    return true;
                // throw new NotImplementedException(type);
            }
        }

        public static bool Parse(string str, out int val)
        {
            val = 0;
            if (string.IsNullOrEmpty(str)) //不填默认为0
            {
                return true;
            }

            int i = 0, s = 1;
            if (str[0] == '+')
                i = 1;
            else if (str[0] == '-')
            {
                s = -1;
                i = 1;
            }

            for (; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    val = val * 10 + (str[i] - '0');
                }
                else
                    return false;
            }

            val *= s;

            return true;
        }
        
        public static bool Parse(string str, out uint val)
        {
            val = 0;
            if (string.IsNullOrEmpty(str)) //不填默认为0
            {
                return true;
            }
            return uint.TryParse(str, out val);
        }

        public static bool Parse(string str, out float val)
        {
            val = 0f;
            if (string.IsNullOrEmpty(str))
                return true;

            int i = 0, s = 1;
            if (str[0] == '+')
                i = 1;
            else if (str[0] == '-')
            {
                s = -1;
                i = 1;
            }

            int length = str.Length;
            if (str[length - 1] == 'f')
                length--;

            for (; i < length; i++)
            {
                if (str[i] == '.')
                {
                    i++;
                    break;
                }

                if (str[i] >= '0' && str[i] <= '9')
                {
                    val = val * 10 + (str[i] - '0');
                }
                else
                    return false;
            }

            float val2 = 0;
            --length;
            for (; length >= i; length--)
            {
                if (str[length] >= '0' && str[length] <= '9')
                {
                    val2 = (val2 + (str[length] - '0')) * 0.1f;
                }
                else
                    return false;
            }

            val = (val + val2) * s;
            return true;
        }

        public static bool Parse(string str, out bool val)
        {
            val = str.Length > 0 && (str == "1" || str.ToLower() == "true");
            return true;
        }

        public static bool Parse(string str, out long val)
        {
            val = 0L;
            if (string.IsNullOrEmpty(str))
                return true;
            return long.TryParse(str, out val);
        }
        
        public static bool Parse(string str, out ulong val)
        {
            val = 0L;
            if (string.IsNullOrEmpty(str))
                return true;
            return ulong.TryParse(str, out val);
        }
        
        public static bool Parse(string str, out double val)
        {
            val = 0d;
            if (string.IsNullOrEmpty(str))
                return true;
            return double.TryParse(str, out val);
        }

        public static bool Parse(string str, out string[] val, char separator = ',')
        {
            if (string.IsNullOrEmpty(str))
            {
                val = new string[0];
                return true;
            }

            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == separator)
                    num++;
            }

            val = new string[num + 1];

            int start = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == separator)
                {
                    val[index++] = str.Substring(start, i - start);
                    start = i + 1;
                }
            }

            val[index] = start >= str.Length ? string.Empty : str.Substring(start);
            return true;
        }

        public static bool Parse(string str, out bool[] val)
        {
            Parse(str, out string[] strs);
            val = new bool[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!Parse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out sbyte[] val)
        {
            Parse(str, out string[] strs);
            val = new sbyte[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!sbyte.TryParse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out byte[] val)
        {
            Parse(str, out string[] strs);
            val = new byte[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!byte.TryParse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out char[] val)
        {
            Parse(str, out string[] strs);
            val = new char[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!char.TryParse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out short[] val)
        {
            Parse(str, out string[] strs);
            val = new short[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!short.TryParse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out ushort[] val)
        {
            Parse(str, out string[] strs);
            val = new ushort[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!ushort.TryParse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out int[] val)
        {
            Parse(str, out string[] strs);
            val = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!Parse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out uint[] val)
        {
            Parse(str, out string[] strs);
            val = new uint[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!Parse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out long[] val)
        {
            Parse(str, out string[] strs);
            val = new long[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!Parse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out ulong[] val)
        {
            Parse(str, out string[] strs);
            val = new ulong[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!Parse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out float[] val)
        {
            Parse(str, out string[] strs);
            val = new float[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!Parse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(string str, out double[] val)
        {
            Parse(str, out string[] strs);
            val = new double[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (!Parse(strs[i], out val[i]))
                    return false;
            }

            return true;
        }

        public static bool Parse(char c, out int val)
        {
            if (c >= '0' && c <= '9')
                val = c - '0';
            else if (c >= 'a' && c <= 'f')
                val = c - 'a' + 10;
            else if (c >= 'A' && c <= 'F')
                val = c - 'A' + 10;
            else
            {
                val = 0;
                return false;
            }

            return true;
        }

        #if !SERVER
        public static bool Parse(string str, out Color val)
        {
            if (str.Length != 6 && str.Length != 8)
            {
                val = Color.white;
                return true;
            }

            val = new Color();

            for (int i = 0; i < 6;)
            {
                if (!Parse(str[i], out int v1))
                    return false;
                if (!Parse(str[i + 1], out int v2))
                    return false;

                if (i == 0)
                    val.r = (v1 * 16 + v2) * 1.0f / 255f;
                if (i == 2)
                    val.g = (v1 * 16 + v2) * 1.0f / 255f;
                if (i == 4)
                    val.b = (v1 * 16 + v2) * 1.0f / 255f;
                i += 2;
            }

            if (str.Length == 8)
            {
                if (!Parse(str[6], out int v1))
                    return false;
                if (!Parse(str[7], out int v2))
                    return false;
                val.a = (v1 * 16 + v2) * 1.0f / 255f;
            }
            else
                val.a = 1;

            return true;
        }
        #endif

        public static bool ParseHexColor(string str, out float[] val)
        {
            val = new float[4];
            if (str.Length != 6 && str.Length != 8)
                return false;

            val[3] = 1;
            for (int i = 0; i < str.Length;)
            {
                if (!Parse(str[i], out int v1))
                    return false;
                if (!Parse(str[i + 1], out int v2))
                    return false;

                val[i / 2] = (v1 * 16 + v2) * 1.0f / 255f;
                i += 2;
            }

            return true;
        }

        static readonly StringBuilder Builder = new StringBuilder();
        static readonly List<string> Types = new List<string>();

        public static List<GValue[]> Parse(string text, string tag)
        {
            Builder.Clear();
            Types.Clear();
            List<GValue[]> rows = new List<GValue[]>();
            int row = 0, column = 0, length = text.Length;
            GValue[] values = null;

            for (int i = 0; i < length; i++)
            {
                char c = text[i];
                if (c == '\r') continue;
                if (c == '\n' || c == (char) 166)
                {
                    if (row == 0)
                        Types.Add(Builder.ToString());
                    else
                    {
                        if (values == null)
                            values = new GValue[Types.Count];

                        if (column < Types.Count)
                        {
                            if (!Parse(Builder.ToString(), Types[column], out values[column]))
                            {
                                Log.Error($"解析{tag}, 数据行第{row + 1}行，第{column}列, 字段 {Types[column]}, 无法解析数据 {Builder.ToString()}。");
                                break;
                            }
                        }
                    }

                    Builder.Clear();
                    column++;
                }
                else
                {
                    if (c == '\\' && i < length - 1 && text[i + 1] == 'n')
                    {
                        Builder.Append('\n');
                        i++;
                    }
                    else
                    {
                        Builder.Append(c);
                    }
                }

                if (c == '\n')
                {
                    row++;
                    column = 0;

                    if (values != null)
                    {
                        rows.Add(values);
                        values = null;
                    }
                }
            }

            Builder.Clear();
            Types.Clear();
            return rows;
        }

        public static Dictionary<string, string> ParseDic(string text, string tag)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            int row = 0, column = 0, length = text.Length;
            string key = null;
            for (int i = 0; i < length; i++)
            {
                char c = text[i];
                if (c == '\r') continue;
                if (c == '\n' || c == (char) 166)
                {
                    if (column == 0)
                        key = Builder.ToString();
                    else if (column == 1)
                    {
                        if(string.IsNullOrEmpty(key))
                            Log.Error($"解析数据 {tag}(row: {row+1}) Key 为空.");
                        else if(dic.ContainsKey(key))
                            Log.Error($"解析数据 {tag}(row: {row+1}) 存在重复Key： {key}.");
                        else
                            dic.Add(key, Builder.ToString());
                    }

                    Builder.Clear();
                    column++;
                }
                else
                {
                    if (c == '\\' && i < length - 1 && text[i + 1] == 'n')
                    {
                        Builder.Append('\n');
                        i++;
                    }
                    else
                    {
                        Builder.Append(c);
                    }
                }

                if (c == '\n')
                {
                    row++;
                    column = 0;
                }
            }

            return dic;
        }

        public static List<GValue> ParseSingleRow(string text, string tag)
        {
            List<GValue> values = new List<GValue>();
            int row = 0, column = 0, length = text.Length;
            string type = null;
            for (int i = 0; i < length; i++)
            {
                char c = text[i];
                if (c == '\r') continue;
                if (c == '\n' || c == (char) 166)
                {
                    if (column == 0)
                        type = Builder.ToString();
                    else if (column == 1)
                    {
                        if(string.IsNullOrEmpty(type))
                            Log.Error($"解析数据 {tag}(row: {row+1}) Type 为空.");
                        else if(Parse(Builder.ToString(), type, out var value))
                            values.Add(value);
                        else
                        {
                            Log.Error($"解析数据 {tag}(row: {row+1}) 字段错误 type:{type}, val:{Builder.ToString()}.");
                            break;
                        }
                    }

                    Builder.Clear();
                    column++;
                }
                else
                {
                    if (c == '\\' && i < length - 1 && text[i + 1] == 'n')
                    {
                        Builder.Append('\n');
                        i++;
                    }
                    else
                    {
                        Builder.Append(c);
                    }
                }

                if (c == '\n')
                {
                    row++;
                    column = 0;
                }
            }

            return values;
        }
        
        public override string ToString()
        {
            switch (_kind)
            {
                case Kind.NONE:
                    return "NONE";
                case Kind.BOOLEAN:
                    return _value._boolean.ToString();
                case Kind.SBYTE:
                    return _value._int8.ToString();
                case Kind.BYTE:
                    return _value._uint8.ToString();
                case Kind.CHAR:
                    return _value._char.ToString();
                case Kind.SHORT:
                    return _value._int16.ToString();
                case Kind.USHORT:
                    return _value._uint16.ToString();
                case Kind.INT:
                    return _value._int32.ToString();
                case Kind.UINT:
                    return _value._uint32.ToString();
                case Kind.LONG:
                    return _value._int64.ToString();
                case Kind.ULONG:
                    return _value._uint64.ToString();
                case Kind.SINGLE:
                    return _value._single.ToString(CultureInfo.CurrentCulture);
                case Kind.DOUBLE:
                    return _value._double.ToString(CultureInfo.CurrentCulture);
                case Kind.STRING:
                    return (string) _object;
                case Kind.BOOLEAN_ARRAY:
                    return String.Join(",", (bool[]) _object);
                case Kind.SBYTE_ARRAY:
                    return String.Join(",", (sbyte[]) _object);
                case Kind.BYTE_ARRAY:
                    return String.Join(",", (byte[]) _object);
                case Kind.CHAR_ARRAY:
                    return String.Join(",", (char[]) _object);
                case Kind.SHORT_ARRAY:
                    return String.Join(",", (short[]) _object);
                case Kind.USHORT_ARRAY:
                    return String.Join(",", (ushort[]) _object);
                case Kind.INT_ARRAY:
                    return String.Join(",", (int[]) _object);
                case Kind.UINT_ARRAY:
                    return String.Join(",", (uint[]) _object);
                case Kind.LONG_ARRAY:
                    return String.Join(",", (long[]) _object);
                case Kind.ULONG_ARRAY:
                    return String.Join(",", (ulong[]) _object);
                case Kind.SINGLE_ARRAY:
                    return String.Join(",", (float[]) _object);
                case Kind.DOUBLE_ARRAY:
                    return String.Join(",", (double[]) _object);
                case Kind.STRING_ARRAY:
                    return String.Join("\n", (string[]) _object);
            }

            return String.Empty;
        }
    }
}
