using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCharArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCharArray";

		public new static readonly string MRClassNameKey;

		static vtkCharArray()
		{
			vtkCharArray.MRClassNameKey = "class vtkCharArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCharArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCharArray"));
		}

		public vtkCharArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCharArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCharArray New()
		{
			vtkCharArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCharArray.vtkCharArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCharArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCharArray.vtkCharArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCharArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkCharArray.vtkCharArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern sbyte vtkCharArray_GetDataTypeValueMax_02();

		public static sbyte GetDataTypeValueMax()
		{
			return vtkCharArray.vtkCharArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern sbyte vtkCharArray_GetDataTypeValueMin_03();

		public static sbyte GetDataTypeValueMin()
		{
			return vtkCharArray.vtkCharArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCharArray_GetPointer_04(HandleRef pThis, long id);

		public string GetPointer(long id)
		{
			return Marshal.PtrToStringAnsi(vtkCharArray.vtkCharArray_GetPointer_04(base.GetCppThis(), id));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_GetTupleValue_05(HandleRef pThis, long i, string tuple);

		public void GetTupleValue(long i, string tuple)
		{
			vtkCharArray.vtkCharArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern sbyte vtkCharArray_GetValue_06(HandleRef pThis, long id);

		public sbyte GetValue(long id)
		{
			return vtkCharArray.vtkCharArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCharArray_GetValueRange_07(HandleRef pThis, int comp);

		public string GetValueRange(int comp)
		{
			return Marshal.PtrToStringAnsi(vtkCharArray.vtkCharArray_GetValueRange_07(base.GetCppThis(), comp));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_GetValueRange_08(HandleRef pThis, string range, int comp);

		public void GetValueRange(string range, int comp)
		{
			vtkCharArray.vtkCharArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCharArray_GetValueRange_09(HandleRef pThis);

		public string GetValueRange()
		{
			return Marshal.PtrToStringAnsi(vtkCharArray.vtkCharArray_GetValueRange_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_GetValueRange_10(HandleRef pThis, string range);

		public void GetValueRange(string range)
		{
			vtkCharArray.vtkCharArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkCharArray_InsertNextTupleValue_11(HandleRef pThis, string tuple);

		public long InsertNextTupleValue(string tuple)
		{
			return vtkCharArray.vtkCharArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkCharArray_InsertNextValue_12(HandleRef pThis, sbyte f);

		public long InsertNextValue(sbyte f)
		{
			return vtkCharArray.vtkCharArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_InsertTupleValue_13(HandleRef pThis, long i, string tuple);

		public void InsertTupleValue(long i, string tuple)
		{
			vtkCharArray.vtkCharArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_InsertValue_14(HandleRef pThis, long id, sbyte f);

		public void InsertValue(long id, sbyte f)
		{
			vtkCharArray.vtkCharArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCharArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCharArray.vtkCharArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCharArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCharArray.vtkCharArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCharArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCharArray NewInstance()
		{
			vtkCharArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCharArray.vtkCharArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCharArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCharArray SafeDownCast(vtkObjectBase o)
		{
			vtkCharArray vtkCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCharArray.vtkCharArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCharArray = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCharArray.Register(null);
				}
			}
			return vtkCharArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_SetArray_20(HandleRef pThis, string array, long size, int save);

		public void SetArray(string array, long size, int save)
		{
			vtkCharArray.vtkCharArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_SetArray_21(HandleRef pThis, string array, long size, int save, int deleteMethod);

		public void SetArray(string array, long size, int save, int deleteMethod)
		{
			vtkCharArray.vtkCharArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkCharArray.vtkCharArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_SetTupleValue_23(HandleRef pThis, long i, string tuple);

		public void SetTupleValue(long i, string tuple)
		{
			vtkCharArray.vtkCharArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCharArray_SetValue_24(HandleRef pThis, long id, sbyte value);

		public void SetValue(long id, sbyte value)
		{
			vtkCharArray.vtkCharArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCharArray_WritePointer_25(HandleRef pThis, long id, long number);

		public string WritePointer(long id, long number)
		{
			return Marshal.PtrToStringAnsi(vtkCharArray.vtkCharArray_WritePointer_25(base.GetCppThis(), id, number));
		}
	}
}
