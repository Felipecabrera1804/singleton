using System;
using Library;

namespace Library
{
    public class Singleton<T> where T : new()
    {
        // void Subscribe(IObserver<T> observer);

        // void Unsubscribe(IObserver<T> observer);
        // private Singleton()
        // {
        //     // Intentionally left blank
        // }

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }

}