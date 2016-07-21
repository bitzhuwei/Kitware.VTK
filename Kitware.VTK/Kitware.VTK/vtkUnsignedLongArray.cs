using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnsignedLongArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedLongArray";

		public new static readonly string MRClassNameKey;

		static vtkUnsignedLongArray()
		{
			vtkUnsignedLongArray.MRClassNameKey = "class vtkUnsignedLongArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedLongArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedLongArray"));
		}

		public vtkUnsignedLongArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedLongArray New()
		{
			vtkUnsignedLongArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnsignedLongArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnsignedLongArray.vtkUnsignedLongArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedLongArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkUnsignedLongArray_GetDataTypeValueMax_02();

		public static uint GetDataTypeValueMax()
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkUnsignedLongArray_GetDataTypeValueMin_03();

		public static uint GetDataTypeValueMin()
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongArray_GetPointer_04(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetPointer_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_GetTupleValue_05(HandleRef pThis, long i, IntPtr tuple);

		public void GetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkUnsignedLongArray_GetValue_06(HandleRef pThis, long id);

		public uint GetValue(long id)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongArray_GetValueRange_07(HandleRef pThis, int comp);

		public IntPtr GetValueRange(int comp)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetValueRange_07(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_GetValueRange_08(HandleRef pThis, IntPtr range, int comp);

		public void GetValueRange(IntPtr range, int comp)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongArray_GetValueRange_09(HandleRef pThis);

		public IntPtr GetValueRange()
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetValueRange_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_GetValueRange_10(HandleRef pThis, IntPtr range);

		public void GetValueRange(IntPtr range)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedLongArray_InsertNextTupleValue_11(HandleRef pThis, IntPtr tuple);

		public long InsertNextTupleValue(IntPtr tuple)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedLongArray_InsertNextValue_12(HandleRef pThis, uint f);

		public long InsertNextValue(uint f)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_InsertTupleValue_13(HandleRef pThis, long i, IntPtr tuple);

		public void InsertTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_InsertValue_14(HandleRef pThis, long id, uint f);

		public void InsertValue(long id, uint f)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedLongArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedLongArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnsignedLongArray NewInstance()
		{
			vtkUnsignedLongArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedLongArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedLongArray vtkUnsignedLongArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongArray = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongArray.Register(null);
				}
			}
			return vtkUnsignedLongArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_SetArray_20(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_SetArray_21(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_SetTupleValue_23(HandleRef pThis, long i, IntPtr tuple);

		public void SetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedLongArray_SetValue_24(HandleRef pThis, long id, uint value);

		public void SetValue(long id, uint value)
		{
			vtkUnsignedLongArray.vtkUnsignedLongArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedLongArray_WritePointer_25(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_WritePointer_25(base.GetCppThis(), id, number);
		}
	}
}
