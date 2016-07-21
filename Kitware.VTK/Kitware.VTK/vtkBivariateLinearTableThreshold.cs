using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBivariateLinearTableThreshold : vtkTableAlgorithm
	{
		public enum LinearThresholdType
		{
			BLT_ABOVE,
			BLT_BELOW,
			BLT_BETWEEN = 3,
			BLT_NEAR = 2
		}

		public enum OutputPorts
		{
			OUTPUT_ROW_DATA = 1,
			OUTPUT_ROW_IDS = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBivariateLinearTableThreshold";

		public new static readonly string MRClassNameKey;

		static vtkBivariateLinearTableThreshold()
		{
			vtkBivariateLinearTableThreshold.MRClassNameKey = "class vtkBivariateLinearTableThreshold";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBivariateLinearTableThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBivariateLinearTableThreshold"));
		}

		public vtkBivariateLinearTableThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBivariateLinearTableThreshold New()
		{
			vtkBivariateLinearTableThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBivariateLinearTableThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_AddColumnToThreshold_01(HandleRef pThis, long column, long component);

		public void AddColumnToThreshold(long column, long component)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddColumnToThreshold_01(base.GetCppThis(), column, component);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_02(HandleRef pThis, IntPtr p1, IntPtr p2);

		public void AddLineEquation(IntPtr p1, IntPtr p2)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddLineEquation_02(base.GetCppThis(), p1, p2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_03(HandleRef pThis, IntPtr p, double slope);

		public void AddLineEquation(IntPtr p, double slope)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddLineEquation_03(base.GetCppThis(), p, slope);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_04(HandleRef pThis, double a, double b, double c);

		public void AddLineEquation(double a, double b, double c)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_AddLineEquation_04(base.GetCppThis(), a, b, c);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_ClearColumnsToThreshold_05(HandleRef pThis);

		public void ClearColumnsToThreshold()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ClearColumnsToThreshold_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_ClearLineEquations_06(HandleRef pThis);

		public void ClearLineEquations()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ClearLineEquations_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_07(IntPtr p1, IntPtr p2, IntPtr abc);

		public static void ComputeImplicitLineFunction(IntPtr p1, IntPtr p2, IntPtr abc)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_07(p1, p2, abc);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_08(IntPtr p, double slope, IntPtr abc);

		public static void ComputeImplicitLineFunction(IntPtr p, double slope, IntPtr abc)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_08(p, slope, abc);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_GetColumnRanges_09(HandleRef pThis);

		public virtual double[] GetColumnRanges()
		{
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnRanges_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_GetColumnRanges_10(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetColumnRanges(ref double _arg1, ref double _arg2)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnRanges_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_GetColumnRanges_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetColumnRanges(IntPtr _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnRanges_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_GetColumnToThreshold_12(HandleRef pThis, long idx, ref long column, ref long component);

		public void GetColumnToThreshold(long idx, ref long column, ref long component)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetColumnToThreshold_12(base.GetCppThis(), idx, ref column, ref component);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkBivariateLinearTableThreshold_GetDistanceThreshold_13(HandleRef pThis);

		public virtual double GetDistanceThreshold()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetDistanceThreshold_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateLinearTableThreshold_GetInclusive_14(HandleRef pThis);

		public virtual int GetInclusive()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetInclusive_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateLinearTableThreshold_GetLinearThresholdType_15(HandleRef pThis);

		public virtual int GetLinearThresholdType()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetLinearThresholdType_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateLinearTableThreshold_GetNumberOfColumnsToThreshold_16(HandleRef pThis);

		public int GetNumberOfColumnsToThreshold()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetNumberOfColumnsToThreshold_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_GetSelectedRowIds_17(HandleRef pThis, int selection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray GetSelectedRowIds(int selection)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetSelectedRowIds_17(base.GetCppThis(), selection, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateLinearTableThreshold_GetUseNormalizedDistance_18(HandleRef pThis);

		public virtual int GetUseNormalizedDistance()
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_GetUseNormalizedDistance_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_Initialize_19(HandleRef pThis);

		public void Initialize()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_Initialize_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateLinearTableThreshold_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateLinearTableThreshold_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBivariateLinearTableThreshold NewInstance()
		{
			vtkBivariateLinearTableThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBivariateLinearTableThreshold_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBivariateLinearTableThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkBivariateLinearTableThreshold vtkBivariateLinearTableThreshold = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBivariateLinearTableThreshold = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBivariateLinearTableThreshold.Register(null);
				}
			}
			return vtkBivariateLinearTableThreshold;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetColumnRanges_25(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetColumnRanges(double _arg1, double _arg2)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetColumnRanges_25(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetColumnRanges_26(HandleRef pThis, IntPtr _arg);

		public void SetColumnRanges(IntPtr _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetColumnRanges_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetDistanceThreshold_27(HandleRef pThis, double _arg);

		public virtual void SetDistanceThreshold(double _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetDistanceThreshold_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetInclusive_28(HandleRef pThis, int _arg);

		public virtual void SetInclusive(int _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetInclusive_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdType_29(HandleRef pThis, int _arg);

		public virtual void SetLinearThresholdType(int _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdType_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToAbove_30(HandleRef pThis);

		public void SetLinearThresholdTypeToAbove()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToAbove_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBelow_31(HandleRef pThis);

		public void SetLinearThresholdTypeToBelow()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBelow_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBetween_32(HandleRef pThis);

		public void SetLinearThresholdTypeToBetween()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBetween_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToNear_33(HandleRef pThis);

		public void SetLinearThresholdTypeToNear()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToNear_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_SetUseNormalizedDistance_34(HandleRef pThis, int _arg);

		public virtual void SetUseNormalizedDistance(int _arg)
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_SetUseNormalizedDistance_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_UseNormalizedDistanceOff_35(HandleRef pThis);

		public virtual void UseNormalizedDistanceOff()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_UseNormalizedDistanceOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateLinearTableThreshold_UseNormalizedDistanceOn_36(HandleRef pThis);

		public virtual void UseNormalizedDistanceOn()
		{
			vtkBivariateLinearTableThreshold.vtkBivariateLinearTableThreshold_UseNormalizedDistanceOn_36(base.GetCppThis());
		}
	}
}
