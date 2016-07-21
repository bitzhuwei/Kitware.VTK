using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnsignedIntArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedIntArray";

		public new static readonly string MRClassNameKey;

		static vtkUnsignedIntArray()
		{
			vtkUnsignedIntArray.MRClassNameKey = "class vtkUnsignedIntArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedIntArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedIntArray"));
		}

		public vtkUnsignedIntArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedIntArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedIntArray New()
		{
			vtkUnsignedIntArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnsignedIntArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnsignedIntArray.vtkUnsignedIntArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedIntArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkUnsignedIntArray_GetDataTypeValueMax_02();

		public static uint GetDataTypeValueMax()
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkUnsignedIntArray_GetDataTypeValueMin_03();

		public static uint GetDataTypeValueMin()
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedIntArray_GetPointer_04(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetPointer_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_GetTupleValue_05(HandleRef pThis, long i, IntPtr tuple);

		public void GetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkUnsignedIntArray_GetValue_06(HandleRef pThis, long id);

		public uint GetValue(long id)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedIntArray_GetValueRange_07(HandleRef pThis, int comp);

		public IntPtr GetValueRange(int comp)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetValueRange_07(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_GetValueRange_08(HandleRef pThis, IntPtr range, int comp);

		public void GetValueRange(IntPtr range, int comp)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedIntArray_GetValueRange_09(HandleRef pThis);

		public IntPtr GetValueRange()
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetValueRange_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_GetValueRange_10(HandleRef pThis, IntPtr range);

		public void GetValueRange(IntPtr range)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedIntArray_InsertNextTupleValue_11(HandleRef pThis, IntPtr tuple);

		public long InsertNextTupleValue(IntPtr tuple)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedIntArray_InsertNextValue_12(HandleRef pThis, uint f);

		public long InsertNextValue(uint f)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_InsertTupleValue_13(HandleRef pThis, long i, IntPtr tuple);

		public void InsertTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_InsertValue_14(HandleRef pThis, long id, uint f);

		public void InsertValue(long id, uint f)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedIntArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedIntArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedIntArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnsignedIntArray NewInstance()
		{
			vtkUnsignedIntArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedIntArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedIntArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedIntArray vtkUnsignedIntArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedIntArray = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedIntArray.Register(null);
				}
			}
			return vtkUnsignedIntArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_SetArray_20(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_SetArray_21(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_SetTupleValue_23(HandleRef pThis, long i, IntPtr tuple);

		public void SetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedIntArray_SetValue_24(HandleRef pThis, long id, uint value);

		public void SetValue(long id, uint value)
		{
			vtkUnsignedIntArray.vtkUnsignedIntArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedIntArray_WritePointer_25(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_WritePointer_25(base.GetCppThis(), id, number);
		}
	}
}
