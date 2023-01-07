using System;
using System.Linq;

namespace ConsoleApp3.ExtendMath
{
    public static class EMath
    {
        #region REMAP
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static byte Remap(byte value, byte fromMin, byte fromMax, byte toMin, byte toMax)
        {
            return (byte)((value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin);
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static ushort Remap(ushort value, ushort fromMin, ushort fromMax, ushort toMin, ushort toMax)
        {
            return (ushort)((value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin);
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static short Remap(short value, short fromMin, short fromMax, short toMin, short toMax)
        {
            return (short)((value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin);
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static uint Remap(uint value, uint fromMin, uint fromMax, uint toMin, uint toMax)
        {
            return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin;
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static int Remap(int value, int fromMin, int fromMax, int toMin, int toMax)
        {
            return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin;
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static ulong Remap(ulong value, ulong fromMin, ulong fromMax, ulong toMin, ulong toMax)
        {
            return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin;
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static long Remap(long value, long fromMin, long fromMax, long toMin, long toMax)
        {
            return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin;
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static float Remap(float value, float fromMin, float fromMax, float toMin, float toMax)
        {
            return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin;
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static double Remap(double value, double fromMin, double fromMax, double toMin, double toMax)
        {
            return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin;
        }
        /// <summary>
        /// Remap the value from range to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromMin"></param>
        /// <param name="fromMax"></param>
        /// <param name="toMin"></param>
        /// <param name="toMax"></param>
        /// <returns></returns>
        public static decimal Remap(decimal value, decimal fromMin, decimal fromMax, decimal toMin, decimal toMax)
        {
            return (value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin;
        }
        #endregion
        #region MAX
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static byte Max(byte[] arr)
        {
            byte m = arr[0];
            for(int i = 1; i<arr.Length;i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static short Max(short[] arr)
        {
            short m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ushort Max(ushort[] arr)
        {
            ushort m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Max(int[] arr)
        {
            int m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static uint Max(uint[] arr)
        {
            uint m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long Max(long[] arr)
        {
            long m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ulong Max(ulong[] arr)
        {
            ulong m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static float Max(float[] arr)
        {
            float m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Max(double[] arr)
        {
            double m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal Max(decimal[] arr)
        {
            decimal m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the max value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T Max<T>(T[] arr)
        {
            dynamic m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            return m;
        }
        #endregion
        #region MINIMUM
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static byte Min(byte[] arr)
        {
            byte m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static short Min(short[] arr)
        {
            short m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ushort Min(ushort[] arr)
        {
            ushort m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Min(int[] arr)
        {
            int m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static uint Min(uint[] arr)
        {
            uint m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long Min(long[] arr)
        {
            long m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ulong Min(ulong[] arr)
        {
            ulong m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static float Min(float[] arr)
        {
            float m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Min(double[] arr)
        {
            double m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal Min(decimal[] arr)
        {
            decimal m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        /// <summary>
        /// Return the min value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T Min<T>(T[] arr)
        {
            dynamic m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            return m;
        }
        #endregion
        #region MAX AND MINIMUM
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(byte[] arr, ref byte min, ref byte max)
        {
            byte m = arr[0];
            byte x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(ushort[] arr, ref ushort min, ref ushort max)
        {
            ushort m = arr[0];
            ushort x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(short[] arr, ref short min, ref short max)
        {
            short m = arr[0];
            short x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(int[] arr, ref int min, ref int max)
        {
            int m = arr[0];
            int x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(uint[] arr, ref uint min, ref uint max)
        {
            uint m = arr[0];
            uint x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(long[] arr, ref long min, ref long max)
        {
            long m = arr[0];
            long x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(ulong[] arr, ref ulong min, ref ulong max)
        {
            ulong m = arr[0];
            ulong x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(float[] arr, ref float min, ref float max)
        {
            float m = arr[0];
            float x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(double[] arr, ref double min, ref double max)
        {
            double m = arr[0];
            double x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax(decimal[] arr, ref decimal min, ref decimal max)
        {
            decimal m = arr[0];
            decimal x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        /// <summary>
        /// Find min and max from array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void MinMax<T>(T[] arr, ref T min, ref T max)
        {
            dynamic m = arr[0];
            dynamic x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
                if (x < arr[i])
                    x = arr[i];
            }
            min = m;
            max = x;
        }
        #endregion
        /// <summary>
        /// Return copy of array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static unsafe T[] Copy<T>(T[] arr)
        {
            T[] res = new T[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * sizeof(T));
            return res;
        }
        #region SORT
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static byte[] Sort(byte[] arr)
        {
            byte[] res = new byte[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static short[] Sort(short[] arr)
        {
            short[] res = new short[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 2);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ushort[] Sort(ushort[] arr)
        {
            ushort[] res = new ushort[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 2);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Sort(int[] arr)
        {
            int[] res = new int[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 4);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static uint[] Sort(uint[] arr)
        {
            uint[] res = new uint[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 4);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long[] Sort(long[] arr)
        {
            long[] res = new long[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 8);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ulong[] Sort(ulong[] arr)
        {
            ulong[] res = new ulong[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 8);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static float[] Sort(float[] arr)
        {
            float[] res = new float[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 4);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double[] Sort(double[] arr)
        {
            double[] res = new double[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 8);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal[] Sort(decimal[] arr)
        {
            decimal[] res = new decimal[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * 16);
            Merge(res);
            return res;
        }
        /// <summary>
        /// Sort the array 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static unsafe T[] Sort<T>(T[] arr)
        {
            T[] res = new T[arr.Length];
            Buffer.BlockCopy(arr, 0, res, 0, arr.Length * sizeof(T));
            Merge(res);
            return res;
        }

        static void Merge(byte[] arr)
        {
            if (arr.Length > 1)
            {
                byte[] a = new byte[(int)Math.Ceiling(arr.Length / 2.0)];
                byte[] b = new byte[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length);
                Buffer.BlockCopy(arr, a.Length , b, 0, b.Length);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    byte d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(short[] arr)
        {
            if (arr.Length > 1)
            {
                short[] a = new short[(int)Math.Ceiling(arr.Length / 2.0)];
                short[] b = new short[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 2);
                Buffer.BlockCopy(arr, a.Length * 2, b, 0, b.Length * 2);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    short d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(ushort[] arr)
        {
            if (arr.Length > 1)
            {
                ushort[] a = new ushort[(int)Math.Ceiling(arr.Length / 2.0)];
                ushort[] b = new ushort[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 2);
                Buffer.BlockCopy(arr, a.Length * 2, b, 0, b.Length * 2);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    ushort d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(int[] arr)
        {
            if (arr.Length > 1)
            {
                int[] a = new int[(int)Math.Ceiling(arr.Length / 2.0)];
                int[] b = new int[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 4);
                Buffer.BlockCopy(arr, a.Length * 4, b, 0, b.Length * 4);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    int d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(uint[] arr)
        {
            if (arr.Length > 1)
            {
                uint[] a = new uint[(int)Math.Ceiling(arr.Length / 2.0)];
                uint[] b = new uint[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 4);
                Buffer.BlockCopy(arr, a.Length * 4, b, 0, b.Length * 4);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    uint d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(long[] arr)
        {
            if (arr.Length > 1)
            {
                long[] a = new long[(int)Math.Ceiling(arr.Length / 2.0)];
                long[] b = new long[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 8);
                Buffer.BlockCopy(arr, a.Length * 8, b, 0, b.Length * 8);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    long d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(ulong[] arr)
        {
            if (arr.Length > 1)
            {
                ulong[] a = new ulong[(int)Math.Ceiling(arr.Length / 2.0)];
                ulong[] b = new ulong[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 8);
                Buffer.BlockCopy(arr, a.Length * 8, b, 0, b.Length * 8);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    ulong d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(float[] arr)
        {
            if (arr.Length > 1)
            {
                float[] a = new float[(int)Math.Ceiling(arr.Length / 2.0)];
                float[] b = new float[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 4);
                Buffer.BlockCopy(arr, a.Length * 4, b, 0, b.Length * 4);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    float d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(double[] arr)
        {
            if (arr.Length > 1)
            {
                double[] a = new double[(int)Math.Ceiling(arr.Length / 2.0)];
                double[] b = new double[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 8);
                Buffer.BlockCopy(arr, a.Length * 8, b, 0, b.Length * 8);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    double d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static void Merge(decimal[] arr)
        {
            if (arr.Length > 1)
            {
                decimal[] a = new decimal[(int)Math.Ceiling(arr.Length / 2.0)];
                decimal[] b = new decimal[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * 16);
                Buffer.BlockCopy(arr, a.Length * 16, b, 0, b.Length * 16);
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    decimal d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        static unsafe void Merge<T>(T[] arr)
        {
            if (arr.Length > 1)
            {
                T[] a = new T[(int)Math.Ceiling(arr.Length / 2.0)];
                T[] b = new T[arr.Length / 2];
                Buffer.BlockCopy(arr, 0, a, 0, a.Length * sizeof(T));
                Buffer.BlockCopy(arr, a.Length * sizeof(T), b, 0, b.Length * sizeof(T));
                Merge(a);
                Merge(b);
                for (int i = 0, ai = 0, bi = 0; i < arr.Length; i++)
                {
                    if (ai >= a.Length)
                    {
                        while (i < arr.Length) arr[i++] = b[bi++];
                        break;
                    }
                    if (bi >= b.Length)
                    {
                        while (i < arr.Length) arr[i++] = a[ai++];
                        break;
                    }
                    dynamic d1 = a[ai];
                    if (d1 > b[bi]) arr[i] = b[bi++];
                    else arr[i] = a[ai++];
                }
            }
        }
        #endregion
        #region SUM
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static uint Sum(byte[] arr)
        {
            uint res = arr[0];
            for(int i = 1; i<arr.Length;i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Sum(short[] arr)
        {
            int res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static uint Sum(ushort[] arr)
        {
            uint res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long Sum(int[] arr)
        {
            long res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ulong Sum(uint[] arr)
        {
            ulong res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long Sum(long[] arr)
        {
            long res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ulong Sum(ulong[] arr)
        {
            ulong res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Sum(float[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Sum(double[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return Sum of array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal Sum(decimal[] arr)
        {
            decimal res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res;
        }
        /// <summary>
        /// Return sum of array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T Sum<T>(T[] arr)
        {
            dynamic res = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                res += arr[i];
            }
            return res;
        }
        #endregion
        #region MEAN
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(byte[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(short[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(ushort[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(int[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(uint[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(long[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(ulong[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(float[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean(double[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal Mean(decimal[] arr)
        {
            decimal res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res += arr[i];
            return res / arr.Length;
        }
        /// <summary>
        /// Return the Mean(Average) value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Mean<T>(T[] arr)
        {
            double res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                dynamic d = arr[i];
                res += d;
            }
            return res / arr.Length;
        }
        #endregion
        #region MEDIAN
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static byte Median(byte[] arr, bool sorted = false)
        {
            byte[] tmp;
            if(sorted)tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                int half = arr.Length / 2;
                byte v = arr[half - 1];
                half = arr[half];
                return (byte)((v + half) / 2);
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static short Median(short[] arr, bool sorted = false)
        {
            short[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                int half = arr.Length / 2;
                short v = arr[half - 1];
                half = arr[half];
                return (short)((v + half) / 2);
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static ushort Median(ushort[] arr, bool sorted = false)
        {
            ushort[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                int half = arr.Length / 2;
                ushort v = arr[half - 1];
                half = arr[half];
                return (ushort)((v + half) / 2);
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static int Median(int[] arr, bool sorted = false)
        {
            int[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                int half = arr.Length / 2;
                int v = arr[half - 1];
                half = arr[half];
                return (v + half) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static uint Median(uint[] arr, bool sorted = false)
        {
            uint[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                uint half = (uint)arr.Length / 2u;
                uint v = arr[half - 1];
                half = arr[half];
                return (v + half) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static long Median(long[] arr, bool sorted = false)
        {
            long[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                long half = arr.Length / 2L;
                long v = arr[half - 1];
                half = arr[half];
                return (v + half) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static ulong Median(ulong[] arr, bool sorted = false)
        {
            ulong[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                ulong half = (ulong)arr.Length / 2LU;
                ulong v = arr[half - 1];
                half = arr[half];
                return (v + half) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static float Median(float[] arr, bool sorted = false)
        {
            float[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                int half = arr.Length / 2;
                float v = arr[half - 1];
                return (v + arr[half]) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static double Median(double[] arr, bool sorted = false)
        {
            double[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                int half = arr.Length / 2;
                double v = arr[half - 1];
                return (v + arr[half]) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static decimal Median(decimal[] arr, bool sorted = false)
        {
            decimal[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            if (arr.Length % 2 == 0)
            {
                int half = arr.Length / 2;
                decimal v = arr[half - 1];
                return (v + arr[half]) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        /// <summary>
        /// Return Median(Mid element) on this array
        /// <para>If there 2 mid elements returns their Mean value</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static T Median<T>(T[] arr, bool sorted = false)
        {
            T[] tmp;
            if (!sorted)
            {
                tmp = Sort(arr);
            }
            else
            {
                tmp = Copy(arr);
            }
            if (arr.Length % 2 == 0)
            {
                dynamic half = arr.Length / 2;
                dynamic v = arr[half - 1];
                half = arr[half];
                return (v + half) / 2;
            }
            return tmp[tmp.Length / 2];
        }
        #endregion
        #region MODE
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static byte Mode(byte[] arr, bool sorted = false)
        {
            byte[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            byte element = tmp[0];
            byte elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static short Mode(short[] arr, bool sorted = false)
        {
            short[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            short element = tmp[0];
            short elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static ushort Mode(ushort[] arr, bool sorted = false)
        {
            ushort[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            ushort element = tmp[0];
            ushort elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static int Mode(int[] arr, bool sorted = false)
        {
            int[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            int element = tmp[0];
            int elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static uint Mode(uint[] arr, bool sorted = false)
        {
            uint[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            uint element = tmp[0];
            uint elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static long Mode(long[] arr, bool sorted = false)
        {
            long[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            long element = tmp[0];
            long elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static ulong Mode(ulong[] arr, bool sorted = false)
        {
            ulong[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            ulong element = tmp[0];
            ulong elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static float Mode(float[] arr, bool sorted = false)
        {
            float[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            float element = tmp[0];
            float elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static double Mode(double[] arr, bool sorted = false)
        {
            double[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double element = tmp[0];
            double elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static decimal Mode(decimal[] arr, bool sorted = false)
        {
            decimal[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            decimal element = tmp[0];
            decimal elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i] == element)
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        /// <summary>
        /// Return Mode(Most repeating element) in array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static T Mode<T>(T[] arr, bool sorted = false)
        {
            T[] tmp;
            if (!sorted)
            {
                tmp = Sort(arr);
            }
            else
            {
                tmp = Copy(arr);
            }
            T element = tmp[0];
            T elementMax = tmp[0];
            int count = 1;
            int max = 0;

            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i].Equals(element))
                {
                    count++;
                }
                else if (count > max)
                {
                    elementMax = element;
                    max = count;
                    count = 1;
                    element = tmp[i];
                }
            }
            return elementMax;
        }
        #endregion
        #region VARIANCE
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(byte[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                byte val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(short[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                short val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(ushort[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                ushort val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(int[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(uint[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                uint val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(long[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                long val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(ulong[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                ulong val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(float[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                float val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance(double[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                double val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal Variance(decimal[] arr)
        {
            decimal mean = Mean(arr);
            decimal[] dif = new decimal[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                decimal val = arr[i];
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        /// <summary>
        /// Return Variance value.
        /// <para>Variance number that indicates how spread out the values are.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Variance<T>(T[] arr)
        {
            double mean = Mean(arr);
            double[] dif = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                dynamic val = arr[i];
                double d = (double)val;
                dif[i] = val - mean;
                dif[i] *= dif[i];
            }
            return Mean(dif);
        }
        #endregion
        #region DEVIATION
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(byte[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(short[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(ushort[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(int[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(uint[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(long[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(ulong[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(float[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(double[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation(decimal[] arr)
        {
            return Math.Sqrt((double)Variance(arr));
        }
        /// <summary>
        /// Return Standard Deviation value.
        /// <para>Standard Deviation number that indicates how spread out the values are.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Deviation<T>(T[] arr)
        {
            return Math.Sqrt(Variance(arr));
        }
        #endregion
        #region Percentile
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static byte Percentile(byte[] arr, double percent, bool sorted = false)
        {
            byte[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static short Percentile(short[] arr, double percent, bool sorted = false)
        {
            short[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static ushort Percentile(ushort[] arr, double percent, bool sorted = false)
        {
            ushort[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static int Percentile(int[] arr, double percent, bool sorted = false)
        {
            int[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static uint Percentile(uint[] arr, double percent, bool sorted = false)
        {
            uint[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static long Percentile(long[] arr, double percent, bool sorted = false)
        {
            long[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static ulong Percentile(ulong[] arr, double percent, bool sorted = false)
        {
            ulong[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static float Percentile(float[] arr, double percent, bool sorted = false)
        {
            float[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static double Percentile(double[] arr, double percent, bool sorted = false)
        {
            double[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static decimal Percentile(decimal[] arr, double percent, bool sorted = false)
        {
            decimal[] tmp;
            if (sorted) tmp = Copy(arr);
            else tmp = Sort(arr);
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        /// <summary>
        /// Return number that describes the value that a given percent of the values are lower than.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="percent"></param>
        /// <param name="sorted"></param>
        /// <returns></returns>
        public static T Percentile<T>(T[] arr, double percent, bool sorted = false)
        {
            T[] tmp;
            if (!sorted)
            {
                tmp = Sort(arr);
            }
            else
            {
                tmp = Copy(arr);
            }
            double p = percent / 100;
            return tmp[(int)(arr.Length * p)];
        }
        #endregion
        #region PEARSON_CORRELATION
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(byte[] x, byte[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(short[] x, short[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(ushort[] x, ushort[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(int[] x, int[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(uint[] x, uint[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(long[] x, long[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(ulong[] x, ulong[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(float[] x, float[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation(double[] x, double[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                double xDiff = x[i] - xMean;
                double yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static decimal PearsonCorrelation(decimal[] x, decimal[] y)
        {
            decimal xMean = Mean(x);
            decimal yMean = Mean(y);
            decimal numerator = 0;
            decimal xDenominator = 0;
            decimal yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                decimal xDiff = x[i] - xMean;
                decimal yDiff = y[i] - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / (decimal)Math.Sqrt((double)(xDenominator * yDenominator));
        }
        /// <summary>
        /// Return Pearson Correlation Coefficient between two arrays.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PearsonCorrelation<T>(T[] x, T[] y)
        {
            double xMean = Mean(x);
            double yMean = Mean(y);
            double numerator = 0;
            double xDenominator = 0;
            double yDenominator = 0;

            for (int i = 0; i < x.Length && i < y.Length; i++)
            {
                dynamic v = x[i];
                double xDiff = v - xMean;
                v = y[i];
                double yDiff = v - yMean;
                numerator += xDiff * yDiff;
                xDenominator += xDiff * xDiff;
                yDenominator += yDiff * yDiff;
            }

            return numerator / Math.Sqrt(xDenominator * yDenominator);
        }
        #endregion

        /// <summary>
        /// Check if number is prime and return the answer.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(uint n)
        {
            if (n == 1) return false;
            for(int i = 2; i<n;i++)
            {
                if(n % i == 0) return false;
            }
            return true;
        }
        /// <summary>
        /// Return the Greatest common divisor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        /// <summary>
        /// Return Least common multiple.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Lcm(int a, int b)
        {
            return Math.Abs(a * b) / Gcd(a, b);
        }

        /// <summary>
        /// Return fibonachi value of v.
        /// <para>DONT ENTER NUMBER OVER 94 !!!</para>
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static ulong Fibonachi(byte v)
        {
            return (ulong)Math.Round(Math.Pow(1.618, v) / 2.236);
        }
    }
}
