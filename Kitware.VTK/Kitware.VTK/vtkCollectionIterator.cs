using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCollectionIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollectionIterator";

		public new static readonly string MRClassNameKey;

		static vtkCollectionIterator()
		{
			vtkCollectionIterator.MRClassNameKey = "class vtkCollectionIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollectionIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectionIterator"));
		}

		public vtkCollectionIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectionIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollectionIterator New()
		{
			vtkCollectionIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCollectionIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCollectionIterator.vtkCollectionIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectionIterator_GetCollection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCollection GetCollection()
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_GetCollection_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollection = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollection.Register(null);
				}
			}
			return vtkCollection;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectionIterator_GetCurrentObject_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObject GetCurrentObject()
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_GetCurrentObject_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollectionIterator_GoToFirstItem_03(HandleRef pThis);

		public void GoToFirstItem()
		{
			vtkCollectionIterator.vtkCollectionIterator_GoToFirstItem_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollectionIterator_GoToNextItem_04(HandleRef pThis);

		public void GoToNextItem()
		{
			vtkCollectionIterator.vtkCollectionIterator_GoToNextItem_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollectionIterator_InitTraversal_05(HandleRef pThis);

		public void InitTraversal()
		{
			vtkCollectionIterator.vtkCollectionIterator_InitTraversal_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCollectionIterator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCollectionIterator.vtkCollectionIterator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCollectionIterator_IsDoneWithTraversal_07(HandleRef pThis);

		public int IsDoneWithTraversal()
		{
			return vtkCollectionIterator.vtkCollectionIterator_IsDoneWithTraversal_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCollectionIterator_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCollectionIterator.vtkCollectionIterator_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectionIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCollectionIterator NewInstance()
		{
			vtkCollectionIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollectionIterator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollectionIterator SafeDownCast(vtkObjectBase o)
		{
			vtkCollectionIterator vtkCollectionIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollectionIterator.vtkCollectionIterator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectionIterator = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectionIterator.Register(null);
				}
			}
			return vtkCollectionIterator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollectionIterator_SetCollection_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetCollection(vtkCollection arg0)
		{
			vtkCollectionIterator.vtkCollectionIterator_SetCollection_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
