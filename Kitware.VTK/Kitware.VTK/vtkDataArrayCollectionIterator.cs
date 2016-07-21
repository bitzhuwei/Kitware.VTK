using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataArrayCollectionIterator : vtkCollectionIterator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataArrayCollectionIterator";

		public new static readonly string MRClassNameKey;

		static vtkDataArrayCollectionIterator()
		{
			vtkDataArrayCollectionIterator.MRClassNameKey = "class vtkDataArrayCollectionIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataArrayCollectionIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArrayCollectionIterator"));
		}

		public vtkDataArrayCollectionIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArrayCollectionIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataArrayCollectionIterator New()
		{
			vtkDataArrayCollectionIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataArrayCollectionIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArrayCollectionIterator_GetDataArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetDataArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_GetDataArray_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArrayCollectionIterator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArrayCollectionIterator_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArrayCollectionIterator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataArrayCollectionIterator NewInstance()
		{
			vtkDataArrayCollectionIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArrayCollectionIterator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataArrayCollectionIterator SafeDownCast(vtkObjectBase o)
		{
			vtkDataArrayCollectionIterator vtkDataArrayCollectionIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArrayCollectionIterator = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArrayCollectionIterator.Register(null);
				}
			}
			return vtkDataArrayCollectionIterator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArrayCollectionIterator_SetCollection_07(HandleRef pThis, HandleRef arg0);

		public override void SetCollection(vtkCollection arg0)
		{
			vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_SetCollection_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArrayCollectionIterator_SetCollection_08(HandleRef pThis, HandleRef arg0);

		public void SetCollection(vtkDataArrayCollection arg0)
		{
			vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_SetCollection_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
