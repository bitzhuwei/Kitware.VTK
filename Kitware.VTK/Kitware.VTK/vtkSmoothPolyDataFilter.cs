using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSmoothPolyDataFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSmoothPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkSmoothPolyDataFilter()
		{
			vtkSmoothPolyDataFilter.MRClassNameKey = "class vtkSmoothPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSmoothPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmoothPolyDataFilter"));
		}

		public vtkSmoothPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSmoothPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSmoothPolyDataFilter New()
		{
			vtkSmoothPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSmoothPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_BoundarySmoothingOff_01(HandleRef pThis);

		public virtual void BoundarySmoothingOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_BoundarySmoothingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_BoundarySmoothingOn_02(HandleRef pThis);

		public virtual void BoundarySmoothingOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_BoundarySmoothingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOff_03(HandleRef pThis);

		public virtual void FeatureEdgeSmoothingOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOn_04(HandleRef pThis);

		public virtual void FeatureEdgeSmoothingOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorScalarsOff_05(HandleRef pThis);

		public virtual void GenerateErrorScalarsOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorScalarsOn_06(HandleRef pThis);

		public virtual void GenerateErrorScalarsOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorVectorsOff_07(HandleRef pThis);

		public virtual void GenerateErrorVectorsOff()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorVectorsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_GenerateErrorVectorsOn_08(HandleRef pThis);

		public virtual void GenerateErrorVectorsOn()
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GenerateErrorVectorsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_GetBoundarySmoothing_09(HandleRef pThis);

		public virtual int GetBoundarySmoothing()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetBoundarySmoothing_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetConvergence_10(HandleRef pThis);

		public virtual double GetConvergence()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetConvergence_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetConvergenceMaxValue_11(HandleRef pThis);

		public virtual double GetConvergenceMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetConvergenceMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetConvergenceMinValue_12(HandleRef pThis);

		public virtual double GetConvergenceMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetConvergenceMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngle_13(HandleRef pThis);

		public virtual double GetEdgeAngle()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetEdgeAngle_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngleMaxValue_14(HandleRef pThis);

		public virtual double GetEdgeAngleMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetEdgeAngleMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngleMinValue_15(HandleRef pThis);

		public virtual double GetEdgeAngleMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetEdgeAngleMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngle_16(HandleRef pThis);

		public virtual double GetFeatureAngle()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureAngle_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngleMaxValue_17(HandleRef pThis);

		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureAngleMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngleMinValue_18(HandleRef pThis);

		public virtual double GetFeatureAngleMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureAngleMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_GetFeatureEdgeSmoothing_19(HandleRef pThis);

		public virtual int GetFeatureEdgeSmoothing()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetFeatureEdgeSmoothing_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_GetGenerateErrorScalars_20(HandleRef pThis);

		public virtual int GetGenerateErrorScalars()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetGenerateErrorScalars_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_GetGenerateErrorVectors_21(HandleRef pThis);

		public virtual int GetGenerateErrorVectors()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetGenerateErrorVectors_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterations_22(HandleRef pThis);

		public virtual int GetNumberOfIterations()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfIterations_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterationsMaxValue_23(HandleRef pThis);

		public virtual int GetNumberOfIterationsMaxValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfIterationsMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterationsMinValue_24(HandleRef pThis);

		public virtual int GetNumberOfIterationsMinValue()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetNumberOfIterationsMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSmoothPolyDataFilter_GetRelaxationFactor_25(HandleRef pThis);

		public virtual double GetRelaxationFactor()
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetRelaxationFactor_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSmoothPolyDataFilter_GetSource_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_GetSource_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSmoothPolyDataFilter_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSmoothPolyDataFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSmoothPolyDataFilter NewInstance()
		{
			vtkSmoothPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSmoothPolyDataFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSmoothPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSmoothPolyDataFilter vtkSmoothPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSmoothPolyDataFilter = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSmoothPolyDataFilter.Register(null);
				}
			}
			return vtkSmoothPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetBoundarySmoothing_32(HandleRef pThis, int _arg);

		public virtual void SetBoundarySmoothing(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetBoundarySmoothing_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetConvergence_33(HandleRef pThis, double _arg);

		public virtual void SetConvergence(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetConvergence_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetEdgeAngle_34(HandleRef pThis, double _arg);

		public virtual void SetEdgeAngle(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetEdgeAngle_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetFeatureAngle_35(HandleRef pThis, double _arg);

		public virtual void SetFeatureAngle(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetFeatureAngle_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetFeatureEdgeSmoothing_36(HandleRef pThis, int _arg);

		public virtual void SetFeatureEdgeSmoothing(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetFeatureEdgeSmoothing_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetGenerateErrorScalars_37(HandleRef pThis, int _arg);

		public virtual void SetGenerateErrorScalars(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetGenerateErrorScalars_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetGenerateErrorVectors_38(HandleRef pThis, int _arg);

		public virtual void SetGenerateErrorVectors(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetGenerateErrorVectors_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetNumberOfIterations_39(HandleRef pThis, int _arg);

		public virtual void SetNumberOfIterations(int _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetNumberOfIterations_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetRelaxationFactor_40(HandleRef pThis, double _arg);

		public virtual void SetRelaxationFactor(double _arg)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetRelaxationFactor_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSmoothPolyDataFilter_SetSource_41(HandleRef pThis, HandleRef source);

		public void SetSource(vtkPolyData source)
		{
			vtkSmoothPolyDataFilter.vtkSmoothPolyDataFilter_SetSource_41(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}
	}
}
