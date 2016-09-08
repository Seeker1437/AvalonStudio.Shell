using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Avalonia;
using ReactiveUI;

namespace AvaloniaShell.Core.Util
{
	public static class Extensions
	{
		public static double DistanceTo(this Point p, Point q)
		{
			double a = p.X - q.X;
			double b = p.Y - q.Y;
			double distance = Math.Sqrt(a * a + b * b);
			return distance;
		}

		public static void Apply<T>(this IEnumerable<T> enumerable, Action<T> action)
		{
			foreach (var item in enumerable)
			{
				action(item);
			}
		}

		public static void OnPropertyChanged(this ReactiveObject reactiveObject, [CallerMemberName]string propertyName = null)
		{
			reactiveObject.RaisePropertyChanged(propertyName);
		}

		public static void RaisePropertyChanged<T>(this ReactiveObject reactiveObject, Expression<Func<T>> changedProperty)
		{
			string name = ((MemberExpression)changedProperty.Body).Member.Name;
			reactiveObject.OnPropertyChanged(name);
		}

		public static MethodInfo GetMethod(this Type type, string methodName)
		{
			return type.GetTypeInfo().DeclaredMethods.FirstOrDefault(x => x.Name == methodName);
		}
	}
}
