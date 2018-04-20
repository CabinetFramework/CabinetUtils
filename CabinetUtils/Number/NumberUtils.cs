
/**********************************************************
 * 
 * 命名空间：
 *          CabinetUtils.Number
 * 
 * 描述：
 *          N/A
 *          
 * 功能及上下游：
 *          N/A
 *          
 * 人员：
 *          大鱼
 *          
 * 创建时间：
 *          2018/4/19 17:14:26
 * 
 ***********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetUtils.Number
{
    public class NumberUtils
    {
        /// <summary>
        /// 随机生成一个质数
        /// </summary>
        /// <param name="seed">随机生成器的种子</param>
        /// <param name="max">随机质数的上限</param>
        /// <returns>随机质数</returns>
        public static int RandomPrime(int seed, int max = Int32.MaxValue)
        {
            Random random = new Random(seed);
            int data = random.Next(max);

            for(int i = data; i >= 2; i--)
            {
                if (IsPrime(i)) { return i; }
            }

            return 2;
        }

        /// <summary>
        /// 随机生成一个质数数组
        /// </summary>
        /// <param name="length">数组长度</param>
        /// <param name="max">随机质数的上限</param>
        /// <returns>随机质数数组</returns>
        public static int[] RandomPrimeArray(int length = 1, int max = Int32.MaxValue)
        {
            int[] array = new int[length];
            
            for(int i = 0; i < length; i++)
            {
                array[i] = RandomPrime(seed:i + 1, max:max);
            }

            return array;
        }
        
        /// <summary>
        /// 判断大于0的整数是否为质数
        /// </summary>
        /// <param name="x">整数 x</param>
        /// <returns>true:质数 / false:非质数</returns>
        public static bool IsPrime(int x)
        {
            if (1 >= x) { return false; }
            if (2 == x) { return true; }

            int end = (int)Math.Sqrt(x);
            for(int i = 2; i < end; i++)
            {
                if (0 == x % i) { return false; }
            }

            return true;
        }
    }
}
