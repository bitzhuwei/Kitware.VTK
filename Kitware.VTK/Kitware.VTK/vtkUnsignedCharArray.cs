using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnsignedCharArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedCharArray";

		public new static readonly string MRClassNameKey;

		static vtkUnsignedCharArray()
		{
			vtkUnsignedCharArray.MRClassNameKey = "class vtkUnsignedCharArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedCharArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedCharArray"));
		}

		public vtkUnsignedCharArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedCharArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedCharArray New()
		{
			vtkUnsignedCharArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnsignedCharArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnsignedCharArray.vtkUnsignedCharArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedCharArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkUnsignedCharArray_GetDataTypeValueMax_02();

		public static byte GetDataTypeValueMax()
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkUnsignedCharArray_GetDataTypeValueMin_03();

		public static byte GetDataTypeValueMin()
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedCharArray_GetPointer_04(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetPointer_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_GetTupleValue_05(HandleRef pThis, long i, IntPtr tuple);

		public void GetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkUnsignedCharArray_GetValue_06(HandleRef pThis, long id);

		public byte GetValue(long id)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedCharArray_GetValueRange_07(HandleRef pThis, int comp);

		public IntPtr GetValueRange(int comp)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetValueRange_07(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_GetValueRange_08(HandleRef pThis, IntPtr range, int comp);

		public void GetValueRange(IntPtr range, int comp)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedCharArray_GetValueRange_09(HandleRef pThis);

		public IntPtr GetValueRange()
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetValueRange_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_GetValueRange_10(HandleRef pThis, IntPtr range);

		public void GetValueRange(IntPtr range)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedCharArray_InsertNextTupleValue_11(HandleRef pThis, IntPtr tuple);

		public long InsertNextTupleValue(IntPtr tuple)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedCharArray_InsertNextValue_12(HandleRef pThis, byte f);

		public long InsertNextValue(byte f)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_InsertTupleValue_13(HandleRef pThis, long i, IntPtr tuple);

		public void InsertTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_InsertValue_14(HandleRef pThis, long id, byte f);

		public void InsertValue(long id, byte f)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedCharArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedCharArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedCharArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnsignedCharArray NewInstance()
		{
			vtkUnsignedCharArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedCharArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedCharArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_SetArray_20(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_SetArray_21(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_SetTupleValue_23(HandleRef pThis, long i, IntPtr tuple);

		public void SetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedCharArray_SetValue_24(HandleRef pThis, long id, byte value);

		public void SetValue(long id, byte value)
		{
			vtkUnsignedCharArray.vtkUnsignedCharArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedCharArray_WritePointer_25(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_WritePointer_25(base.GetCppThis(), id, number);
		}
	}
}
