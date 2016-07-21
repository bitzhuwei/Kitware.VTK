using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnsignedShortArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedShortArray";

		public new static readonly string MRClassNameKey;

		static vtkUnsignedShortArray()
		{
			vtkUnsignedShortArray.MRClassNameKey = "class vtkUnsignedShortArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedShortArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedShortArray"));
		}

		public vtkUnsignedShortArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedShortArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedShortArray New()
		{
			vtkUnsignedShortArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnsignedShortArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnsignedShortArray.vtkUnsignedShortArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedShortArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ushort vtkUnsignedShortArray_GetDataTypeValueMax_02();

		public static ushort GetDataTypeValueMax()
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ushort vtkUnsignedShortArray_GetDataTypeValueMin_03();

		public static ushort GetDataTypeValueMin()
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedShortArray_GetPointer_04(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetPointer_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_GetTupleValue_05(HandleRef pThis, long i, IntPtr tuple);

		public void GetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern ushort vtkUnsignedShortArray_GetValue_06(HandleRef pThis, long id);

		public ushort GetValue(long id)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedShortArray_GetValueRange_07(HandleRef pThis, int comp);

		public IntPtr GetValueRange(int comp)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetValueRange_07(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_GetValueRange_08(HandleRef pThis, IntPtr range, int comp);

		public void GetValueRange(IntPtr range, int comp)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedShortArray_GetValueRange_09(HandleRef pThis);

		public IntPtr GetValueRange()
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetValueRange_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_GetValueRange_10(HandleRef pThis, IntPtr range);

		public void GetValueRange(IntPtr range)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedShortArray_InsertNextTupleValue_11(HandleRef pThis, IntPtr tuple);

		public long InsertNextTupleValue(IntPtr tuple)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkUnsignedShortArray_InsertNextValue_12(HandleRef pThis, ushort f);

		public long InsertNextValue(ushort f)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_InsertTupleValue_13(HandleRef pThis, long i, IntPtr tuple);

		public void InsertTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_InsertValue_14(HandleRef pThis, long id, ushort f);

		public void InsertValue(long id, ushort f)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedShortArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkUnsignedShortArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedShortArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnsignedShortArray NewInstance()
		{
			vtkUnsignedShortArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedShortArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnsignedShortArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedShortArray vtkUnsignedShortArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedShortArray = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedShortArray.Register(null);
				}
			}
			return vtkUnsignedShortArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_SetArray_20(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_SetArray_21(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_SetTupleValue_23(HandleRef pThis, long i, IntPtr tuple);

		public void SetTupleValue(long i, IntPtr tuple)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkUnsignedShortArray_SetValue_24(HandleRef pThis, long id, ushort value);

		public void SetValue(long id, ushort value)
		{
			vtkUnsignedShortArray.vtkUnsignedShortArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkUnsignedShortArray_WritePointer_25(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_WritePointer_25(base.GetCppThis(), id, number);
		}
	}
}
