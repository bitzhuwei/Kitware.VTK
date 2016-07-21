using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnsignedLongLongArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedLongLongArray";

		public new static readonly string MRClassNameKey;

		static vtkUnsignedLongLongArray()
		{
			vtkUnsignedLongLongArray.MRClassNameKey = "class vtkUnsignedLongLongArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedLongLongArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedLongLongArray"));
		}

		public vtkUnsignedLongLongArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongLongArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedLongLongArray New()
		{
			vtkUnsignedLongLongArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnsignedLongLongArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedLongLongArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkUnsignedLongLongArray_GetDataTypeValueMax_02();

		public static ulong GetDataTypeValueMax()
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkUnsignedLongLongArray_GetDataTypeValueMin_03();

		public static ulong GetDataTypeValueMin()
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongLongArray_GetPointer_04(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetPointer_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_GetTupleValue_05(HandleRef pThis, long i, IntPtr tuple);

		public void GetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ulong vtkUnsignedLongLongArray_GetValue_06(HandleRef pThis, long id);

		public ulong GetValue(long id)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongLongArray_GetValueRange_07(HandleRef pThis, int comp);

		public IntPtr GetValueRange(int comp)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetValueRange_07(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_GetValueRange_08(HandleRef pThis, IntPtr range, int comp);

		public void GetValueRange(IntPtr range, int comp)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongLongArray_GetValueRange_09(HandleRef pThis);

		public IntPtr GetValueRange()
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetValueRange_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_GetValueRange_10(HandleRef pThis, IntPtr range);

		public void GetValueRange(IntPtr range)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedLongLongArray_InsertNextTupleValue_11(HandleRef pThis, IntPtr tuple);

		public long InsertNextTupleValue(IntPtr tuple)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedLongLongArray_InsertNextValue_12(HandleRef pThis, ulong f);

		public long InsertNextValue(ulong f)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_InsertTupleValue_13(HandleRef pThis, long i, IntPtr tuple);

		public void InsertTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_InsertValue_14(HandleRef pThis, long id, ulong f);

		public void InsertValue(long id, ulong f)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedLongLongArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedLongLongArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongLongArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnsignedLongLongArray NewInstance()
		{
			vtkUnsignedLongLongArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongLongArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedLongLongArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedLongLongArray vtkUnsignedLongLongArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongLongArray = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongLongArray.Register(null);
				}
			}
			return vtkUnsignedLongLongArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_SetArray_20(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_SetArray_21(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_SetTupleValue_23(HandleRef pThis, long i, IntPtr tuple);

		public void SetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongLongArray_SetValue_24(HandleRef pThis, long id, ulong value);

		public void SetValue(long id, ulong value)
		{
			vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongLongArray_WritePointer_25(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_WritePointer_25(base.GetCppThis(), id, number);
		}
	}
}
