using System;

namespace MyLibrary
{
	public static class CheckNullExtensions
	{
		public static void NullDo<T>(this T obj, Action action) where T : class
		{
			if (null == obj) { action(); }
		}

		public static void NotNullDo<T>(this T obj, Action<T> action) where T : class
		{
			if (null == obj) { return; }
			action(obj);
		}

		public static R NotNullDo<T, R>(this T obj, Func<T, R> func) where T : class
		{
			if (null == obj) { return default(R); }
			return func(obj);
		}
	}
}
