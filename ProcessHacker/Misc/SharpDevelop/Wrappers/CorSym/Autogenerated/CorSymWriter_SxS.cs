// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2201 $</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorSym
{
	using System;
	
	
	public partial class CorSymWriter_SxS
	{
		
		private Debugger.Interop.CorSym.CorSymWriter_SxS wrappedObject;
		
		internal Debugger.Interop.CorSym.CorSymWriter_SxS WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public CorSymWriter_SxS(Debugger.Interop.CorSym.CorSymWriter_SxS wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(CorSymWriter_SxS));
		}
		
		public static CorSymWriter_SxS Wrap(Debugger.Interop.CorSym.CorSymWriter_SxS objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new CorSymWriter_SxS(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~CorSymWriter_SxS()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(CorSymWriter_SxS));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(CorSymWriter_SxS o1, CorSymWriter_SxS o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(CorSymWriter_SxS o1, CorSymWriter_SxS o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			CorSymWriter_SxS casted = o as CorSymWriter_SxS;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
	}
}

#pragma warning restore 1591
