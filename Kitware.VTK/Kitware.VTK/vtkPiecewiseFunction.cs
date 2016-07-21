using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPiecewiseFunction : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunction";

		public new static readonly string MRClassNameKey;

		static vtkPiecewiseFunction()
		{
			vtkPiecewiseFunction.MRClassNameKey = "class vtkPiecewiseFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunction"));
		}

		public vtkPiecewiseFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunction New()
		{
			vtkPiecewiseFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPiecewiseFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPiecewiseFunction.vtkPiecewiseFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_AddPoint_01(HandleRef pThis, double x, double y);

		public int AddPoint(double x, double y)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_AddPoint_01(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_AddPoint_02(HandleRef pThis, double x, double y, double midpoint, double sharpness);

		public int AddPoint(double x, double y, double midpoint, double sharpness)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_AddPoint_02(base.GetCppThis(), x, y, midpoint, sharpness);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_AddSegment_03(HandleRef pThis, double x1, double y1, double x2, double y2);

		public void AddSegment(double x1, double y1, double x2, double y2)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_AddSegment_03(base.GetCppThis(), x1, y1, x2, y2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_AdjustRange_04(HandleRef pThis, IntPtr range);

		public int AdjustRange(IntPtr range)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_AdjustRange_04(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_AllowDuplicateScalarsOff_05(HandleRef pThis);

		public virtual void AllowDuplicateScalarsOff()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_AllowDuplicateScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_AllowDuplicateScalarsOn_06(HandleRef pThis);

		public virtual void AllowDuplicateScalarsOn()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_AllowDuplicateScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_BuildFunctionFromTable_07(HandleRef pThis, double x1, double x2, int size, IntPtr table, int stride);

		public void BuildFunctionFromTable(double x1, double x2, int size, IntPtr table, int stride)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_BuildFunctionFromTable_07(base.GetCppThis(), x1, x2, size, table, stride);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_ClampingOff_08(HandleRef pThis);

		public virtual void ClampingOff()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_ClampingOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_ClampingOn_09(HandleRef pThis);

		public virtual void ClampingOn()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_ClampingOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_DeepCopy_10(HandleRef pThis, HandleRef f);

		public override void DeepCopy(vtkDataObject f)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_DeepCopy_10(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_FillFromDataPointer_11(HandleRef pThis, int arg0, IntPtr arg1);

		public void FillFromDataPointer(int arg0, IntPtr arg1)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_FillFromDataPointer_11(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_GetAllowDuplicateScalars_12(HandleRef pThis);

		public virtual int GetAllowDuplicateScalars()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetAllowDuplicateScalars_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_GetClamping_13(HandleRef pThis);

		public virtual int GetClamping()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetClamping_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_GetData_14(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunction GetData(vtkInformation info)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_GetData_14((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_GetData_15(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunction GetData(vtkInformationVector v, int i)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_GetData_15((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_GetDataObjectType_16(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetDataObjectType_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_GetDataPointer_17(HandleRef pThis);

		public IntPtr GetDataPointer()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetDataPointer_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPiecewiseFunction_GetFirstNonZeroValue_18(HandleRef pThis);

		public double GetFirstNonZeroValue()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetFirstNonZeroValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_GetNodeValue_19(HandleRef pThis, int index, IntPtr val);

		public int GetNodeValue(int index, IntPtr val)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetNodeValue_19(base.GetCppThis(), index, val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_GetRange_20(HandleRef pThis);

		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_GetRange_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_GetRange_21(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetRange(ref double _arg1, ref double _arg2)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_GetRange_21(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_GetRange_22(HandleRef pThis, IntPtr _arg);

		public virtual void GetRange(IntPtr _arg)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_GetRange_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_GetSize_23(HandleRef pThis);

		public int GetSize()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetSize_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_GetTable_24(HandleRef pThis, double x1, double x2, int size, IntPtr table, int stride);

		public void GetTable(double x1, double x2, int size, IntPtr table, int stride)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_GetTable_24(base.GetCppThis(), x1, x2, size, table, stride);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_GetType_25(HandleRef pThis);

		public string GetTypeWrapper()
		{
			return Marshal.PtrToStringAnsi(vtkPiecewiseFunction.vtkPiecewiseFunction_GetType_25(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPiecewiseFunction_GetValue_26(HandleRef pThis, double x);

		public double GetValue(double x)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetValue_26(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_Initialize_27(HandleRef pThis);

		public override void Initialize()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_Initialize_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPiecewiseFunction NewInstance()
		{
			vtkPiecewiseFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_RemoveAllPoints_32(HandleRef pThis);

		public void RemoveAllPoints()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_RemoveAllPoints_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_RemovePoint_33(HandleRef pThis, double x);

		public int RemovePoint(double x)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_RemovePoint_33(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPiecewiseFunction_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPiecewiseFunction SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_SetAllowDuplicateScalars_35(HandleRef pThis, int _arg);

		public virtual void SetAllowDuplicateScalars(int _arg)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_SetAllowDuplicateScalars_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_SetClamping_36(HandleRef pThis, int _arg);

		public virtual void SetClamping(int _arg)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_SetClamping_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPiecewiseFunction_SetNodeValue_37(HandleRef pThis, int index, IntPtr val);

		public int SetNodeValue(int index, IntPtr val)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_SetNodeValue_37(base.GetCppThis(), index, val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPiecewiseFunction_ShallowCopy_38(HandleRef pThis, HandleRef f);

		public override void ShallowCopy(vtkDataObject f)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_ShallowCopy_38(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}
	}
}
