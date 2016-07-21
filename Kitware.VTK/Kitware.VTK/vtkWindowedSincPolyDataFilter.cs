using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWindowedSincPolyDataFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindowedSincPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkWindowedSincPolyDataFilter()
		{
			vtkWindowedSincPolyDataFilter.MRClassNameKey = "class vtkWindowedSincPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindowedSincPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowedSincPolyDataFilter"));
		}

		public vtkWindowedSincPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowedSincPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindowedSincPolyDataFilter New()
		{
			vtkWindowedSincPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWindowedSincPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_BoundarySmoothingOff_01(HandleRef pThis);

		public virtual void BoundarySmoothingOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_BoundarySmoothingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_BoundarySmoothingOn_02(HandleRef pThis);

		public virtual void BoundarySmoothingOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_BoundarySmoothingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOff_03(HandleRef pThis);

		public virtual void FeatureEdgeSmoothingOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOn_04(HandleRef pThis);

		public virtual void FeatureEdgeSmoothingOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOff_05(HandleRef pThis);

		public virtual void GenerateErrorScalarsOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOn_06(HandleRef pThis);

		public virtual void GenerateErrorScalarsOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOff_07(HandleRef pThis);

		public virtual void GenerateErrorVectorsOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOn_08(HandleRef pThis);

		public virtual void GenerateErrorVectorsOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetBoundarySmoothing_09(HandleRef pThis);

		public virtual int GetBoundarySmoothing()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetBoundarySmoothing_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngle_10(HandleRef pThis);

		public virtual double GetEdgeAngle()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetEdgeAngle_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngleMaxValue_11(HandleRef pThis);

		public virtual double GetEdgeAngleMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetEdgeAngleMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngleMinValue_12(HandleRef pThis);

		public virtual double GetEdgeAngleMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetEdgeAngleMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngle_13(HandleRef pThis);

		public virtual double GetFeatureAngle()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureAngle_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngleMaxValue_14(HandleRef pThis);

		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureAngleMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngleMinValue_15(HandleRef pThis);

		public virtual double GetFeatureAngleMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureAngleMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetFeatureEdgeSmoothing_16(HandleRef pThis);

		public virtual int GetFeatureEdgeSmoothing()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetFeatureEdgeSmoothing_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetGenerateErrorScalars_17(HandleRef pThis);

		public virtual int GetGenerateErrorScalars()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetGenerateErrorScalars_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetGenerateErrorVectors_18(HandleRef pThis);

		public virtual int GetGenerateErrorVectors()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetGenerateErrorVectors_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNonManifoldSmoothing_19(HandleRef pThis);

		public virtual int GetNonManifoldSmoothing()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNonManifoldSmoothing_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNormalizeCoordinates_20(HandleRef pThis);

		public virtual int GetNormalizeCoordinates()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNormalizeCoordinates_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterations_21(HandleRef pThis);

		public virtual int GetNumberOfIterations()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfIterations_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMaxValue_22(HandleRef pThis);

		public virtual int GetNumberOfIterationsMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMinValue_23(HandleRef pThis);

		public virtual int GetNumberOfIterationsMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetPassBand_24(HandleRef pThis);

		public virtual double GetPassBand()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetPassBand_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetPassBandMaxValue_25(HandleRef pThis);

		public virtual double GetPassBandMaxValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetPassBandMaxValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWindowedSincPolyDataFilter_GetPassBandMinValue_26(HandleRef pThis);

		public virtual double GetPassBandMinValue()
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_GetPassBandMinValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWindowedSincPolyDataFilter_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowedSincPolyDataFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWindowedSincPolyDataFilter NewInstance()
		{
			vtkWindowedSincPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOff_31(HandleRef pThis);

		public virtual void NonManifoldSmoothingOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOn_32(HandleRef pThis);

		public virtual void NonManifoldSmoothingOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOff_33(HandleRef pThis);

		public virtual void NormalizeCoordinatesOff()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOn_34(HandleRef pThis);

		public virtual void NormalizeCoordinatesOn()
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowedSincPolyDataFilter_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindowedSincPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkWindowedSincPolyDataFilter vtkWindowedSincPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindowedSincPolyDataFilter = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindowedSincPolyDataFilter.Register(null);
				}
			}
			return vtkWindowedSincPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetBoundarySmoothing_36(HandleRef pThis, int _arg);

		public virtual void SetBoundarySmoothing(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetBoundarySmoothing_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetEdgeAngle_37(HandleRef pThis, double _arg);

		public virtual void SetEdgeAngle(double _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetEdgeAngle_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetFeatureAngle_38(HandleRef pThis, double _arg);

		public virtual void SetFeatureAngle(double _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetFeatureAngle_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetFeatureEdgeSmoothing_39(HandleRef pThis, int _arg);

		public virtual void SetFeatureEdgeSmoothing(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetFeatureEdgeSmoothing_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetGenerateErrorScalars_40(HandleRef pThis, int _arg);

		public virtual void SetGenerateErrorScalars(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetGenerateErrorScalars_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetGenerateErrorVectors_41(HandleRef pThis, int _arg);

		public virtual void SetGenerateErrorVectors(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetGenerateErrorVectors_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetNonManifoldSmoothing_42(HandleRef pThis, int _arg);

		public virtual void SetNonManifoldSmoothing(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetNonManifoldSmoothing_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetNormalizeCoordinates_43(HandleRef pThis, int _arg);

		public virtual void SetNormalizeCoordinates(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetNormalizeCoordinates_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetNumberOfIterations_44(HandleRef pThis, int _arg);

		public virtual void SetNumberOfIterations(int _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetNumberOfIterations_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWindowedSincPolyDataFilter_SetPassBand_45(HandleRef pThis, double _arg);

		public virtual void SetPassBand(double _arg)
		{
			vtkWindowedSincPolyDataFilter.vtkWindowedSincPolyDataFilter_SetPassBand_45(base.GetCppThis(), _arg);
		}
	}
}
