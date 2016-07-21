using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSignedCharArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSignedCharArray";

		public new static readonly string MRClassNameKey;

		static vtkSignedCharArray()
		{
			vtkSignedCharArray.MRClassNameKey = "class vtkSignedCharArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSignedCharArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSignedCharArray"));
		}

		public vtkSignedCharArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSignedCharArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSignedCharArray New()
		{
			vtkSignedCharArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSignedCharArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSignedCharArray.vtkSignedCharArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSignedCharArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern sbyte vtkSignedCharArray_GetDataTypeValueMax_02();

		public static sbyte GetDataTypeValueMax()
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern sbyte vtkSignedCharArray_GetDataTypeValueMin_03();

		public static sbyte GetDataTypeValueMin()
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSignedCharArray_GetPointer_04(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetPointer_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_GetTupleValue_05(HandleRef pThis, long i, IntPtr tuple);

		public void GetTupleValue(long i, IntPtr tuple)
		{
			vtkSignedCharArray.vtkSignedCharArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern sbyte vtkSignedCharArray_GetValue_06(HandleRef pThis, long id);

		public sbyte GetValue(long id)
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSignedCharArray_GetValueRange_07(HandleRef pThis, int comp);

		public IntPtr GetValueRange(int comp)
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetValueRange_07(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_GetValueRange_08(HandleRef pThis, IntPtr range, int comp);

		public void GetValueRange(IntPtr range, int comp)
		{
			vtkSignedCharArray.vtkSignedCharArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSignedCharArray_GetValueRange_09(HandleRef pThis);

		public IntPtr GetValueRange()
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetValueRange_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_GetValueRange_10(HandleRef pThis, IntPtr range);

		public void GetValueRange(IntPtr range)
		{
			vtkSignedCharArray.vtkSignedCharArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkSignedCharArray_InsertNextTupleValue_11(HandleRef pThis, IntPtr tuple);

		public long InsertNextTupleValue(IntPtr tuple)
		{
			return vtkSignedCharArray.vtkSignedCharArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkSignedCharArray_InsertNextValue_12(HandleRef pThis, sbyte f);

		public long InsertNextValue(sbyte f)
		{
			return vtkSignedCharArray.vtkSignedCharArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_InsertTupleValue_13(HandleRef pThis, long i, IntPtr tuple);

		public void InsertTupleValue(long i, IntPtr tuple)
		{
			vtkSignedCharArray.vtkSignedCharArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_InsertValue_14(HandleRef pThis, long id, sbyte f);

		public void InsertValue(long id, sbyte f)
		{
			vtkSignedCharArray.vtkSignedCharArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSignedCharArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSignedCharArray.vtkSignedCharArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSignedCharArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSignedCharArray.vtkSignedCharArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSignedCharArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSignedCharArray NewInstance()
		{
			vtkSignedCharArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSignedCharArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSignedCharArray SafeDownCast(vtkObjectBase o)
		{
			vtkSignedCharArray vtkSignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSignedCharArray = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSignedCharArray.Register(null);
				}
			}
			return vtkSignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_SetArray_20(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkSignedCharArray.vtkSignedCharArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_SetArray_21(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkSignedCharArray.vtkSignedCharArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkSignedCharArray.vtkSignedCharArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_SetTupleValue_23(HandleRef pThis, long i, IntPtr tuple);

		public void SetTupleValue(long i, IntPtr tuple)
		{
			vtkSignedCharArray.vtkSignedCharArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSignedCharArray_SetValue_24(HandleRef pThis, long id, sbyte value);

		public void SetValue(long id, sbyte value)
		{
			vtkSignedCharArray.vtkSignedCharArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSignedCharArray_WritePointer_25(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkSignedCharArray.vtkSignedCharArray_WritePointer_25(base.GetCppThis(), id, number);
		}
	}
}
