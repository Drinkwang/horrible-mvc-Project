using System;
namespace UniFrame.Common
{
    /// <summary>
    /// 泛型单例类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Singleton<T> where T : class
    {
        private static readonly object __lock = new object();
        private static T __instance = null;

        /// <summary>
        /// 单例实例
        /// </summary>
        public static T Instance
        {
            get
            {
                if (__instance == null)
                {
                    lock (__lock)
                    {
                        if (__instance == null)
                            __instance = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
                return __instance;
            }
        }
    }
}