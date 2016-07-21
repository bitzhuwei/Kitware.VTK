using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransformCollection : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformCollection";

		public new static readonly string MRClassNameKey;

		static vtkTransformCollection()
		{
			vtkTransformCollection.MRClassNameKey = "class vtkTransformCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformCollection"));
		}

		public vtkTransformCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformCollection New()
		{
			vtkTransformCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransformCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransformCollection.vtkTransformCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransformCollection_AddItem_01(HandleRef pThis, HandleRef t);

		public void AddItem(vtkTransform t)
		{
			vtkTransformCollection.vtkTransformCollection_AddItem_01(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTransform GetNextItem()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransformCollection_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransformCollection.vtkTransformCollection_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransformCollection_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransformCollection.vtkTransformCollection_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCollection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransformCollection NewInstance()
		{
			vtkTransformCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCollection_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformCollection SafeDownCast(vtkObjectBase o)
		{
			vtkTransformCollection vtkTransformCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformCollection = (vtkTransformCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformCollection.Register(null);
				}
			}
			return vtkTransformCollection;
		}
	}
}
