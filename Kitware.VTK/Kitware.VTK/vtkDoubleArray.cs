using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDoubleArray : vtkDataArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDoubleArray";

		public new static readonly string MRClassNameKey;

		static vtkDoubleArray()
		{
			vtkDoubleArray.MRClassNameKey = "class vtkDoubleArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDoubleArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDoubleArray"));
		}

		public vtkDoubleArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDoubleArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDoubleArray New()
		{
			vtkDoubleArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDoubleArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDoubleArray.vtkDoubleArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDoubleArray_GetDataType_01(HandleRef pThis);

		public override int GetDataType()
		{
			return vtkDoubleArray.vtkDoubleArray_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDoubleArray_GetDataTypeValueMax_02();

		public static double GetDataTypeValueMax()
		{
			return vtkDoubleArray.vtkDoubleArray_GetDataTypeValueMax_02();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDoubleArray_GetDataTypeValueMin_03();

		public static double GetDataTypeValueMin()
		{
			return vtkDoubleArray.vtkDoubleArray_GetDataTypeValueMin_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDoubleArray_GetPointer_04(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkDoubleArray.vtkDoubleArray_GetPointer_04(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_GetTupleValue_05(HandleRef pThis, long i, IntPtr tuple);

		public void GetTupleValue(long i, IntPtr tuple)
		{
			vtkDoubleArray.vtkDoubleArray_GetTupleValue_05(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkDoubleArray_GetValue_06(HandleRef pThis, long id);

		public double GetValue(long id)
		{
			return vtkDoubleArray.vtkDoubleArray_GetValue_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDoubleArray_GetValueRange_07(HandleRef pThis, int comp);

		public double[] GetValueRange(int comp)
		{
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_GetValueRange_07(base.GetCppThis(), comp);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_GetValueRange_08(HandleRef pThis, IntPtr range, int comp);

		public void GetValueRange(IntPtr range, int comp)
		{
			vtkDoubleArray.vtkDoubleArray_GetValueRange_08(base.GetCppThis(), range, comp);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDoubleArray_GetValueRange_09(HandleRef pThis);

		public double[] GetValueRange()
		{
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_GetValueRange_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_GetValueRange_10(HandleRef pThis, IntPtr range);

		public void GetValueRange(IntPtr range)
		{
			vtkDoubleArray.vtkDoubleArray_GetValueRange_10(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkDoubleArray_InsertNextTupleValue_11(HandleRef pThis, IntPtr tuple);

		public long InsertNextTupleValue(IntPtr tuple)
		{
			return vtkDoubleArray.vtkDoubleArray_InsertNextTupleValue_11(base.GetCppThis(), tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkDoubleArray_InsertNextValue_12(HandleRef pThis, double f);

		public long InsertNextValue(double f)
		{
			return vtkDoubleArray.vtkDoubleArray_InsertNextValue_12(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_InsertTupleValue_13(HandleRef pThis, long i, IntPtr tuple);

		public void InsertTupleValue(long i, IntPtr tuple)
		{
			vtkDoubleArray.vtkDoubleArray_InsertTupleValue_13(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_InsertValue_14(HandleRef pThis, long id, double f);

		public void InsertValue(long id, double f)
		{
			vtkDoubleArray.vtkDoubleArray_InsertValue_14(base.GetCppThis(), id, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDoubleArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDoubleArray.vtkDoubleArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDoubleArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDoubleArray.vtkDoubleArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDoubleArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDoubleArray NewInstance()
		{
			vtkDoubleArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDoubleArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDoubleArray SafeDownCast(vtkObjectBase o)
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_SetArray_20(HandleRef pThis, IntPtr array, long size, int save);

		public void SetArray(IntPtr array, long size, int save)
		{
			vtkDoubleArray.vtkDoubleArray_SetArray_20(base.GetCppThis(), array, size, save);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_SetArray_21(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkDoubleArray.vtkDoubleArray_SetArray_21(base.GetCppThis(), array, size, save, deleteMethod);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_SetNumberOfValues_22(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkDoubleArray.vtkDoubleArray_SetNumberOfValues_22(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_SetTupleValue_23(HandleRef pThis, long i, IntPtr tuple);

		public void SetTupleValue(long i, IntPtr tuple)
		{
			vtkDoubleArray.vtkDoubleArray_SetTupleValue_23(base.GetCppThis(), i, tuple);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDoubleArray_SetValue_24(HandleRef pThis, long id, double value);

		public void SetValue(long id, double value)
		{
			vtkDoubleArray.vtkDoubleArray_SetValue_24(base.GetCppThis(), id, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDoubleArray_WritePointer_25(HandleRef pThis, long id, long number);

		public IntPtr WritePointer(long id, long number)
		{
			return vtkDoubleArray.vtkDoubleArray_WritePointer_25(base.GetCppThis(), id, number);
		}
	}
}
