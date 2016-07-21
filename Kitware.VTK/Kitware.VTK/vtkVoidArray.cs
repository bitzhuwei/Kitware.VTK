using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVoidArray : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoidArray";

		public new static readonly string MRClassNameKey;

		static vtkVoidArray()
		{
			vtkVoidArray.MRClassNameKey = "class vtkVoidArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoidArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoidArray"));
		}

		public vtkVoidArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVoidArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVoidArray New()
		{
			vtkVoidArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoidArray.vtkVoidArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVoidArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVoidArray.vtkVoidArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVoidArray_Allocate_01(HandleRef pThis, long sz, long ext);

		public int Allocate(long sz, long ext)
		{
			return vtkVoidArray.vtkVoidArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVoidArray_DeepCopy_02(HandleRef pThis, HandleRef va);

		public void DeepCopy(vtkVoidArray va)
		{
			vtkVoidArray.vtkVoidArray_DeepCopy_02(base.GetCppThis(), (va == null) ? default(HandleRef) : va.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVoidArray_GetDataType_03(HandleRef pThis);

		public int GetDataType()
		{
			return vtkVoidArray.vtkVoidArray_GetDataType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVoidArray_GetDataTypeSize_04(HandleRef pThis);

		public int GetDataTypeSize()
		{
			return vtkVoidArray.vtkVoidArray_GetDataTypeSize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkVoidArray_GetNumberOfPointers_05(HandleRef pThis);

		public long GetNumberOfPointers()
		{
			return vtkVoidArray.vtkVoidArray_GetNumberOfPointers_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVoidArray_GetVoidPointer_06(HandleRef pThis, long id);

		public IntPtr GetVoidPointer(long id)
		{
			return vtkVoidArray.vtkVoidArray_GetVoidPointer_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVoidArray_Initialize_07(HandleRef pThis);

		public void Initialize()
		{
			vtkVoidArray.vtkVoidArray_Initialize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkVoidArray_InsertNextVoidPointer_08(HandleRef pThis, IntPtr tuple);

		public long InsertNextVoidPointer(IntPtr tuple)
		{
			return vtkVoidArray.vtkVoidArray_InsertNextVoidPointer_08(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVoidArray_InsertVoidPointer_09(HandleRef pThis, long i, IntPtr ptr);

		public void InsertVoidPointer(long i, IntPtr ptr)
		{
			vtkVoidArray.vtkVoidArray_InsertVoidPointer_09(base.GetCppThis(), i, ptr);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVoidArray_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVoidArray.vtkVoidArray_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkVoidArray_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVoidArray.vtkVoidArray_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVoidArray_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVoidArray NewInstance()
		{
			vtkVoidArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoidArray.vtkVoidArray_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVoidArray_Reset_14(HandleRef pThis);

		public void Reset()
		{
			vtkVoidArray.vtkVoidArray_Reset_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkVoidArray_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVoidArray SafeDownCast(vtkObjectBase o)
		{
			vtkVoidArray vtkVoidArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoidArray.vtkVoidArray_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoidArray = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoidArray.Register(null);
				}
			}
			return vtkVoidArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVoidArray_SetNumberOfPointers_16(HandleRef pThis, long number);

		public void SetNumberOfPointers(long number)
		{
			vtkVoidArray.vtkVoidArray_SetNumberOfPointers_16(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVoidArray_SetVoidPointer_17(HandleRef pThis, long id, IntPtr ptr);

		public void SetVoidPointer(long id, IntPtr ptr)
		{
			vtkVoidArray.vtkVoidArray_SetVoidPointer_17(base.GetCppThis(), id, ptr);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkVoidArray_Squeeze_18(HandleRef pThis);

		public void Squeeze()
		{
			vtkVoidArray.vtkVoidArray_Squeeze_18(base.GetCppThis());
		}
	}
}
