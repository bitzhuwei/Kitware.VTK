using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCleanPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCleanPolyData";

		public new static readonly string MRClassNameKey;

		static vtkCleanPolyData()
		{
			vtkCleanPolyData.MRClassNameKey = "class vtkCleanPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCleanPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCleanPolyData"));
		}

		public vtkCleanPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCleanPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCleanPolyData New()
		{
			vtkCleanPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCleanPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCleanPolyData.vtkCleanPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ConvertLinesToPointsOff_01(HandleRef pThis);

		public virtual void ConvertLinesToPointsOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertLinesToPointsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ConvertLinesToPointsOn_02(HandleRef pThis);

		public virtual void ConvertLinesToPointsOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertLinesToPointsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ConvertPolysToLinesOff_03(HandleRef pThis);

		public virtual void ConvertPolysToLinesOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertPolysToLinesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ConvertPolysToLinesOn_04(HandleRef pThis);

		public virtual void ConvertPolysToLinesOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertPolysToLinesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ConvertStripsToPolysOff_05(HandleRef pThis);

		public virtual void ConvertStripsToPolysOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertStripsToPolysOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ConvertStripsToPolysOn_06(HandleRef pThis);

		public virtual void ConvertStripsToPolysOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertStripsToPolysOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_CreateDefaultLocator_07(HandleRef pThis, HandleRef input);

		public void CreateDefaultLocator(vtkPolyData input)
		{
			vtkCleanPolyData.vtkCleanPolyData_CreateDefaultLocator_07(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCleanPolyData_GetAbsoluteTolerance_08(HandleRef pThis);

		public virtual double GetAbsoluteTolerance()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetAbsoluteTolerance_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCleanPolyData_GetAbsoluteToleranceMaxValue_09(HandleRef pThis);

		public virtual double GetAbsoluteToleranceMaxValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetAbsoluteToleranceMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCleanPolyData_GetAbsoluteToleranceMinValue_10(HandleRef pThis);

		public virtual double GetAbsoluteToleranceMinValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetAbsoluteToleranceMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_GetConvertLinesToPoints_11(HandleRef pThis);

		public virtual int GetConvertLinesToPoints()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetConvertLinesToPoints_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_GetConvertPolysToLines_12(HandleRef pThis);

		public virtual int GetConvertPolysToLines()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetConvertPolysToLines_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_GetConvertStripsToPolys_13(HandleRef pThis);

		public virtual int GetConvertStripsToPolys()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetConvertStripsToPolys_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCleanPolyData_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_GetLocator_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkCleanPolyData_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_GetPieceInvariant_16(HandleRef pThis);

		public virtual int GetPieceInvariant()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetPieceInvariant_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_GetPointMerging_17(HandleRef pThis);

		public virtual int GetPointMerging()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetPointMerging_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCleanPolyData_GetTolerance_18(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetTolerance_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_GetToleranceIsAbsolute_19(HandleRef pThis);

		public virtual int GetToleranceIsAbsolute()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetToleranceIsAbsolute_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCleanPolyData_GetToleranceMaxValue_20(HandleRef pThis);

		public virtual double GetToleranceMaxValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetToleranceMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCleanPolyData_GetToleranceMinValue_21(HandleRef pThis);

		public virtual double GetToleranceMinValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetToleranceMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCleanPolyData.vtkCleanPolyData_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCleanPolyData_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCleanPolyData.vtkCleanPolyData_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCleanPolyData_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCleanPolyData NewInstance()
		{
			vtkCleanPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_OperateOnBounds_26(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public virtual void OperateOnBounds(IntPtr arg0, IntPtr arg1)
		{
			vtkCleanPolyData.vtkCleanPolyData_OperateOnBounds_26(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_OperateOnPoint_27(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public virtual void OperateOnPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkCleanPolyData.vtkCleanPolyData_OperateOnPoint_27(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_PieceInvariantOff_28(HandleRef pThis);

		public virtual void PieceInvariantOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_PieceInvariantOff_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_PieceInvariantOn_29(HandleRef pThis);

		public virtual void PieceInvariantOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_PieceInvariantOn_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_PointMergingOff_30(HandleRef pThis);

		public virtual void PointMergingOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_PointMergingOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_PointMergingOn_31(HandleRef pThis);

		public virtual void PointMergingOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_PointMergingOn_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ReleaseLocator_32(HandleRef pThis);

		public void ReleaseLocator()
		{
			vtkCleanPolyData.vtkCleanPolyData_ReleaseLocator_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCleanPolyData_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCleanPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkCleanPolyData vtkCleanPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCleanPolyData = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCleanPolyData.Register(null);
				}
			}
			return vtkCleanPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetAbsoluteTolerance_34(HandleRef pThis, double _arg);

		public virtual void SetAbsoluteTolerance(double _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetAbsoluteTolerance_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetConvertLinesToPoints_35(HandleRef pThis, int _arg);

		public virtual void SetConvertLinesToPoints(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetConvertLinesToPoints_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetConvertPolysToLines_36(HandleRef pThis, int _arg);

		public virtual void SetConvertPolysToLines(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetConvertPolysToLines_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetConvertStripsToPolys_37(HandleRef pThis, int _arg);

		public virtual void SetConvertStripsToPolys(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetConvertStripsToPolys_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetLocator_38(HandleRef pThis, HandleRef locator);

		public virtual void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetLocator_38(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetPieceInvariant_39(HandleRef pThis, int _arg);

		public virtual void SetPieceInvariant(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetPieceInvariant_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetPointMerging_40(HandleRef pThis, int _arg);

		public virtual void SetPointMerging(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetPointMerging_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetTolerance_41(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetTolerance_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_SetToleranceIsAbsolute_42(HandleRef pThis, int _arg);

		public virtual void SetToleranceIsAbsolute(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetToleranceIsAbsolute_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ToleranceIsAbsoluteOff_43(HandleRef pThis);

		public virtual void ToleranceIsAbsoluteOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ToleranceIsAbsoluteOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCleanPolyData_ToleranceIsAbsoluteOn_44(HandleRef pThis);

		public virtual void ToleranceIsAbsoluteOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ToleranceIsAbsoluteOn_44(base.GetCppThis());
		}
	}
}
