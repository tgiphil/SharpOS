//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using SharpOS.AOT.Attributes;
using SharpOS.Korlib.Runtime;

namespace InternalSystem {
	[TargetNamespace ("System")]
	public class Object {
		internal VTable VTable;
		internal uint Synchronisation = 0;

		public Object ()
		{
		}

		public virtual string ToString()
		{
			return this.VTable.Type.Name;
		}

		public virtual int GetHashCode ()
		{
			return 0; // TODO
		}

		public unsafe virtual bool Equals (object o)
		{
			void *p1 = Runtime.GetPointerFromObject (this);
			void *p2 = Runtime.GetPointerFromObject (o);

			return p1 == p2;
		}
	}
}
