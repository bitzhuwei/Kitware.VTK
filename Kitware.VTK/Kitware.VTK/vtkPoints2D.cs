using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPoints2D : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPoints2D";

		public new static readonly string MRClassNameKey;

		static vtkPoints2D()
		{
			vtkPoints2D.MRClassNameKey = "class vtkPoints2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPoints2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoints2D"));
		}

		public vtkPoints2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPoints2D New()
		{
			vtkPoints2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPoints2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPoints2D.vtkPoints2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPoints2D_Allocate_01(HandleRef pThis, long sz, long ext);

		public virtual int Allocate(long sz, long ext)
		{
			return vtkPoints2D.vtkPoints2D_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_ComputeBounds_02(HandleRef pThis);

		public virtual void ComputeBounds()
		{
			vtkPoints2D.vtkPoints2D_ComputeBounds_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_DeepCopy_03(HandleRef pThis, HandleRef ad);

		public virtual void DeepCopy(vtkPoints2D ad)
		{
			vtkPoints2D.vtkPoints2D_DeepCopy_03(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkPoints2D_GetActualMemorySize_04(HandleRef pThis);

		public uint GetActualMemorySize()
		{
			return vtkPoints2D.vtkPoints2D_GetActualMemorySize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_GetBounds_05(HandleRef pThis);

		public IntPtr GetBounds()
		{
			return vtkPoints2D.vtkPoints2D_GetBounds_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_GetBounds_06(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkPoints2D.vtkPoints2D_GetBounds_06(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_GetData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetData()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_GetData_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPoints2D_GetDataType_08(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkPoints2D.vtkPoints2D_GetDataType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPoints2D_GetNumberOfPoints_09(HandleRef pThis);

		public long GetNumberOfPoints()
		{
			return vtkPoints2D.vtkPoints2D_GetNumberOfPoints_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_GetPoint_10(HandleRef pThis, long id);

		public IntPtr GetPoint(long id)
		{
			return vtkPoints2D.vtkPoints2D_GetPoint_10(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_GetPoint_11(HandleRef pThis, long id, IntPtr x);

		public void GetPoint(long id, IntPtr x)
		{
			vtkPoints2D.vtkPoints2D_GetPoint_11(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_GetPoints_12(HandleRef pThis, HandleRef ptId, HandleRef fp);

		public void GetPoints(vtkIdList ptId, vtkPoints2D fp)
		{
			vtkPoints2D.vtkPoints2D_GetPoints_12(base.GetCppThis(), (ptId == null) ? default(HandleRef) : ptId.GetCppThis(), (fp == null) ? default(HandleRef) : fp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_GetVoidPointer_13(HandleRef pThis, int id);

		public IntPtr GetVoidPointer(int id)
		{
			return vtkPoints2D.vtkPoints2D_GetVoidPointer_13(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_Initialize_14(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkPoints2D.vtkPoints2D_Initialize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPoints2D_InsertNextPoint_15(HandleRef pThis, IntPtr x);

		public long InsertNextPoint(IntPtr x)
		{
			return vtkPoints2D.vtkPoints2D_InsertNextPoint_15(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkPoints2D_InsertNextPoint_16(HandleRef pThis, double x, double y);

		public long InsertNextPoint(double x, double y)
		{
			return vtkPoints2D.vtkPoints2D_InsertNextPoint_16(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_InsertPoint_17(HandleRef pThis, long id, IntPtr x);

		public void InsertPoint(long id, IntPtr x)
		{
			vtkPoints2D.vtkPoints2D_InsertPoint_17(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_InsertPoint_18(HandleRef pThis, long id, double x, double y);

		public void InsertPoint(long id, double x, double y)
		{
			vtkPoints2D.vtkPoints2D_InsertPoint_18(base.GetCppThis(), id, x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPoints2D_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPoints2D.vtkPoints2D_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPoints2D_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPoints2D.vtkPoints2D_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_New_21(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkPoints2D New(int dataType)
		{
			vtkPoints2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_New_21(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPoints2D NewInstance()
		{
			vtkPoints2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_Reset_24(HandleRef pThis);

		public virtual void Reset()
		{
			vtkPoints2D.vtkPoints2D_Reset_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPoints2D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPoints2D SafeDownCast(vtkObjectBase o)
		{
			vtkPoints2D vtkPoints2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints2D = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints2D.Register(null);
				}
			}
			return vtkPoints2D;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetData_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetData(vtkDataArray arg0)
		{
			vtkPoints2D.vtkPoints2D_SetData_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataType_27(HandleRef pThis, int dataType);

		public virtual void SetDataType(int dataType)
		{
			vtkPoints2D.vtkPoints2D_SetDataType_27(base.GetCppThis(), dataType);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToBit_28(HandleRef pThis);

		public void SetDataTypeToBit()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToBit_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToChar_29(HandleRef pThis);

		public void SetDataTypeToChar()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToChar_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToDouble_30(HandleRef pThis);

		public void SetDataTypeToDouble()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToDouble_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToFloat_31(HandleRef pThis);

		public void SetDataTypeToFloat()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToFloat_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToInt_32(HandleRef pThis);

		public void SetDataTypeToInt()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToInt_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToLong_33(HandleRef pThis);

		public void SetDataTypeToLong()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToLong_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToShort_34(HandleRef pThis);

		public void SetDataTypeToShort()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToShort_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedChar_35(HandleRef pThis);

		public void SetDataTypeToUnsignedChar()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedChar_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedInt_36(HandleRef pThis);

		public void SetDataTypeToUnsignedInt()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedInt_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedLong_37(HandleRef pThis);

		public void SetDataTypeToUnsignedLong()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedLong_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedShort_38(HandleRef pThis);

		public void SetDataTypeToUnsignedShort()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedShort_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetNumberOfPoints_39(HandleRef pThis, long number);

		public void SetNumberOfPoints(long number)
		{
			vtkPoints2D.vtkPoints2D_SetNumberOfPoints_39(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetPoint_40(HandleRef pThis, long id, IntPtr x);

		public void SetPoint(long id, IntPtr x)
		{
			vtkPoints2D.vtkPoints2D_SetPoint_40(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_SetPoint_41(HandleRef pThis, long id, double x, double y);

		public void SetPoint(long id, double x, double y)
		{
			vtkPoints2D.vtkPoints2D_SetPoint_41(base.GetCppThis(), id, x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_ShallowCopy_42(HandleRef pThis, HandleRef ad);

		public virtual void ShallowCopy(vtkPoints2D ad)
		{
			vtkPoints2D.vtkPoints2D_ShallowCopy_42(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPoints2D_Squeeze_43(HandleRef pThis);

		public virtual void Squeeze()
		{
			vtkPoints2D.vtkPoints2D_Squeeze_43(base.GetCppThis());
		}
	}
}
