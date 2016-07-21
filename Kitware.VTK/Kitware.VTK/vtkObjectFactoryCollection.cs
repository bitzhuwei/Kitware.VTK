using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkObjectFactoryCollection : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectFactoryCollection";

		public new static readonly string MRClassNameKey;

		static vtkObjectFactoryCollection()
		{
			vtkObjectFactoryCollection.MRClassNameKey = "class vtkObjectFactoryCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectFactoryCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectFactoryCollection"));
		}

		public vtkObjectFactoryCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactoryCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkObjectFactoryCollection New()
		{
			vtkObjectFactoryCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkObjectFactoryCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkObjectFactoryCollection.vtkObjectFactoryCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactoryCollection_AddItem_01(HandleRef pThis, HandleRef t);

		public void AddItem(vtkObjectFactory t)
		{
			vtkObjectFactoryCollection.vtkObjectFactoryCollection_AddItem_01(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactoryCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObjectFactory GetNextItem()
		{
			vtkObjectFactory vtkObjectFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactory = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactory.Register(null);
				}
			}
			return vtkObjectFactory;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactoryCollection_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkObjectFactoryCollection.vtkObjectFactoryCollection_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactoryCollection_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkObjectFactoryCollection.vtkObjectFactoryCollection_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactoryCollection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkObjectFactoryCollection NewInstance()
		{
			vtkObjectFactoryCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactoryCollection_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkObjectFactoryCollection SafeDownCast(vtkObjectBase o)
		{
			vtkObjectFactoryCollection vtkObjectFactoryCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactoryCollection = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactoryCollection.Register(null);
				}
			}
			return vtkObjectFactoryCollection;
		}
	}
}
