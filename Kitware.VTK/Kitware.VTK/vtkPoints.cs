using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPoints : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPoints";

		public new static readonly string MRClassNameKey;

		static vtkPoints()
		{
			vtkPoints.MRClassNameKey = "class vtkPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoints"));
		}

		public vtkPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPoints New()
		{
			vtkPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints.vtkPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPoints.vtkPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPoints_Allocate_01(HandleRef pThis, long sz, long ext);

		public virtual int Allocate(long sz, long ext)
		{
			return vtkPoints.vtkPoints_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_ComputeBounds_02(HandleRef pThis);

		public virtual void ComputeBounds()
		{
			vtkPoints.vtkPoints_ComputeBounds_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_DeepCopy_03(HandleRef pThis, HandleRef ad);

		public virtual void DeepCopy(vtkPoints ad)
		{
			vtkPoints.vtkPoints_DeepCopy_03(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkPoints_GetActualMemorySize_04(HandleRef pThis);

		public uint GetActualMemorySize()
		{
			return vtkPoints.vtkPoints_GetActualMemorySize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_GetBounds_05(HandleRef pThis);

		public double[] GetBounds()
		{
			IntPtr intPtr = vtkPoints.vtkPoints_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_GetBounds_06(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkPoints.vtkPoints_GetBounds_06(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_GetData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetData()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints.vtkPoints_GetData_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPoints_GetDataType_08(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkPoints.vtkPoints_GetDataType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPoints_GetNumberOfPoints_09(HandleRef pThis);

		public long GetNumberOfPoints()
		{
			return vtkPoints.vtkPoints_GetNumberOfPoints_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_GetPoint_10(HandleRef pThis, long id);

		public double[] GetPoint(long id)
		{
			IntPtr intPtr = vtkPoints.vtkPoints_GetPoint_10(base.GetCppThis(), id);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_GetPoint_11(HandleRef pThis, long id, IntPtr x);

		public void GetPoint(long id, IntPtr x)
		{
			vtkPoints.vtkPoints_GetPoint_11(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_GetPoints_12(HandleRef pThis, HandleRef ptId, HandleRef fp);

		public void GetPoints(vtkIdList ptId, vtkPoints fp)
		{
			vtkPoints.vtkPoints_GetPoints_12(base.GetCppThis(), (ptId == null) ? default(HandleRef) : ptId.GetCppThis(), (fp == null) ? default(HandleRef) : fp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_GetVoidPointer_13(HandleRef pThis, int id);

		public IntPtr GetVoidPointer(int id)
		{
			return vtkPoints.vtkPoints_GetVoidPointer_13(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_Initialize_14(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkPoints.vtkPoints_Initialize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPoints_InsertNextPoint_15(HandleRef pThis, IntPtr x);

		public long InsertNextPoint(IntPtr x)
		{
			return vtkPoints.vtkPoints_InsertNextPoint_15(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPoints_InsertNextPoint_16(HandleRef pThis, double x, double y, double z);

		public long InsertNextPoint(double x, double y, double z)
		{
			return vtkPoints.vtkPoints_InsertNextPoint_16(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_InsertPoint_17(HandleRef pThis, long id, IntPtr x);

		public void InsertPoint(long id, IntPtr x)
		{
			vtkPoints.vtkPoints_InsertPoint_17(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_InsertPoint_18(HandleRef pThis, long id, double x, double y, double z);

		public void InsertPoint(long id, double x, double y, double z)
		{
			vtkPoints.vtkPoints_InsertPoint_18(base.GetCppThis(), id, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPoints_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPoints.vtkPoints_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPoints_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPoints.vtkPoints_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_New_21(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkPoints New(int dataType)
		{
			vtkPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints.vtkPoints_New_21(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPoints NewInstance()
		{
			vtkPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints.vtkPoints_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_Reset_24(HandleRef pThis);

		public virtual void Reset()
		{
			vtkPoints.vtkPoints_Reset_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPoints SafeDownCast(vtkObjectBase o)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints.vtkPoints_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetData_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetData(vtkDataArray arg0)
		{
			vtkPoints.vtkPoints_SetData_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataType_27(HandleRef pThis, int dataType);

		public virtual void SetDataType(int dataType)
		{
			vtkPoints.vtkPoints_SetDataType_27(base.GetCppThis(), dataType);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToBit_28(HandleRef pThis);

		public void SetDataTypeToBit()
		{
			vtkPoints.vtkPoints_SetDataTypeToBit_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToChar_29(HandleRef pThis);

		public void SetDataTypeToChar()
		{
			vtkPoints.vtkPoints_SetDataTypeToChar_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToDouble_30(HandleRef pThis);

		public void SetDataTypeToDouble()
		{
			vtkPoints.vtkPoints_SetDataTypeToDouble_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToFloat_31(HandleRef pThis);

		public void SetDataTypeToFloat()
		{
			vtkPoints.vtkPoints_SetDataTypeToFloat_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToInt_32(HandleRef pThis);

		public void SetDataTypeToInt()
		{
			vtkPoints.vtkPoints_SetDataTypeToInt_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToLong_33(HandleRef pThis);

		public void SetDataTypeToLong()
		{
			vtkPoints.vtkPoints_SetDataTypeToLong_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToShort_34(HandleRef pThis);

		public void SetDataTypeToShort()
		{
			vtkPoints.vtkPoints_SetDataTypeToShort_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToUnsignedChar_35(HandleRef pThis);

		public void SetDataTypeToUnsignedChar()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedChar_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToUnsignedInt_36(HandleRef pThis);

		public void SetDataTypeToUnsignedInt()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedInt_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToUnsignedLong_37(HandleRef pThis);

		public void SetDataTypeToUnsignedLong()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedLong_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetDataTypeToUnsignedShort_38(HandleRef pThis);

		public void SetDataTypeToUnsignedShort()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedShort_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetNumberOfPoints_39(HandleRef pThis, long number);

		public void SetNumberOfPoints(long number)
		{
			vtkPoints.vtkPoints_SetNumberOfPoints_39(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetPoint_40(HandleRef pThis, long id, IntPtr x);

		public void SetPoint(long id, IntPtr x)
		{
			vtkPoints.vtkPoints_SetPoint_40(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_SetPoint_41(HandleRef pThis, long id, double x, double y, double z);

		public void SetPoint(long id, double x, double y, double z)
		{
			vtkPoints.vtkPoints_SetPoint_41(base.GetCppThis(), id, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_ShallowCopy_42(HandleRef pThis, HandleRef ad);

		public virtual void ShallowCopy(vtkPoints ad)
		{
			vtkPoints.vtkPoints_ShallowCopy_42(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints_Squeeze_43(HandleRef pThis);

		public virtual void Squeeze()
		{
			vtkPoints.vtkPoints_Squeeze_43(base.GetCppThis());
		}
	}
}
