using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellQuality : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellQuality";

		public new static readonly string MRClassNameKey;

		static vtkCellQuality()
		{
			vtkCellQuality.MRClassNameKey = "class vtkCellQuality";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellQuality.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellQuality"));
		}

		public vtkCellQuality(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellQuality_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellQuality New()
		{
			vtkCellQuality result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellQuality.vtkCellQuality_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellQuality() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellQuality.vtkCellQuality_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellQuality_GetQualityMeasure_01(HandleRef pThis);

		public virtual int GetQualityMeasure()
		{
			return vtkCellQuality.vtkCellQuality_GetQualityMeasure_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCellQuality_GetUndefinedQuality_02(HandleRef pThis);

		public virtual double GetUndefinedQuality()
		{
			return vtkCellQuality.vtkCellQuality_GetUndefinedQuality_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCellQuality_GetUnsupportedGeometry_03(HandleRef pThis);

		public virtual double GetUnsupportedGeometry()
		{
			return vtkCellQuality.vtkCellQuality_GetUnsupportedGeometry_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellQuality_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellQuality.vtkCellQuality_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellQuality_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellQuality.vtkCellQuality_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellQuality_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellQuality NewInstance()
		{
			vtkCellQuality result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellQuality.vtkCellQuality_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCellQuality_PixelArea_08(HandleRef pThis, HandleRef arg0);

		public double PixelArea(vtkCell arg0)
		{
			return vtkCellQuality.vtkCellQuality_PixelArea_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCellQuality_PolygonArea_09(HandleRef pThis, HandleRef arg0);

		public double PolygonArea(vtkCell arg0)
		{
			return vtkCellQuality.vtkCellQuality_PolygonArea_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellQuality_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellQuality SafeDownCast(vtkObjectBase o)
		{
			vtkCellQuality vtkCellQuality = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellQuality.vtkCellQuality_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellQuality = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellQuality.Register(null);
				}
			}
			return vtkCellQuality;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasure_11(HandleRef pThis, int _arg);

		public virtual void SetQualityMeasure(int _arg)
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasure_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToArea_12(HandleRef pThis);

		public void SetQualityMeasureToArea()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToArea_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToAspectBeta_13(HandleRef pThis);

		public void SetQualityMeasureToAspectBeta()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToAspectBeta_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToAspectFrobenius_14(HandleRef pThis);

		public void SetQualityMeasureToAspectFrobenius()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToAspectFrobenius_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToAspectGamma_15(HandleRef pThis);

		public void SetQualityMeasureToAspectGamma()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToAspectGamma_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToAspectRatio_16(HandleRef pThis);

		public void SetQualityMeasureToAspectRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToAspectRatio_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToCollapseRatio_17(HandleRef pThis);

		public void SetQualityMeasureToCollapseRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToCollapseRatio_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToCondition_18(HandleRef pThis);

		public void SetQualityMeasureToCondition()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToCondition_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToDiagonal_19(HandleRef pThis);

		public void SetQualityMeasureToDiagonal()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToDiagonal_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToDimension_20(HandleRef pThis);

		public void SetQualityMeasureToDimension()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToDimension_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToDistortion_21(HandleRef pThis);

		public void SetQualityMeasureToDistortion()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToDistortion_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToJacobian_22(HandleRef pThis);

		public void SetQualityMeasureToJacobian()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToJacobian_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToMaxAngle_23(HandleRef pThis);

		public void SetQualityMeasureToMaxAngle()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMaxAngle_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToMaxAspectFrobenius_24(HandleRef pThis);

		public void SetQualityMeasureToMaxAspectFrobenius()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMaxAspectFrobenius_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToMaxEdgeRatio_25(HandleRef pThis);

		public void SetQualityMeasureToMaxEdgeRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMaxEdgeRatio_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToMedAspectFrobenius_26(HandleRef pThis);

		public void SetQualityMeasureToMedAspectFrobenius()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMedAspectFrobenius_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToMinAngle_27(HandleRef pThis);

		public void SetQualityMeasureToMinAngle()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMinAngle_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToOddy_28(HandleRef pThis);

		public void SetQualityMeasureToOddy()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToOddy_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToRadiusRatio_29(HandleRef pThis);

		public void SetQualityMeasureToRadiusRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToRadiusRatio_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToRelativeSizeSquared_30(HandleRef pThis);

		public void SetQualityMeasureToRelativeSizeSquared()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToRelativeSizeSquared_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToScaledJacobian_31(HandleRef pThis);

		public void SetQualityMeasureToScaledJacobian()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToScaledJacobian_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToShape_32(HandleRef pThis);

		public void SetQualityMeasureToShape()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShape_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToShapeAndSize_33(HandleRef pThis);

		public void SetQualityMeasureToShapeAndSize()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShapeAndSize_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToShear_34(HandleRef pThis);

		public void SetQualityMeasureToShear()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShear_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToShearAndSize_35(HandleRef pThis);

		public void SetQualityMeasureToShearAndSize()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShearAndSize_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToSkew_36(HandleRef pThis);

		public void SetQualityMeasureToSkew()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToSkew_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToStretch_37(HandleRef pThis);

		public void SetQualityMeasureToStretch()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToStretch_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToTaper_38(HandleRef pThis);

		public void SetQualityMeasureToTaper()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToTaper_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToVolume_39(HandleRef pThis);

		public void SetQualityMeasureToVolume()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToVolume_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetQualityMeasureToWarpage_40(HandleRef pThis);

		public void SetQualityMeasureToWarpage()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToWarpage_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetUndefinedQuality_41(HandleRef pThis, double _arg);

		public virtual void SetUndefinedQuality(double _arg)
		{
			vtkCellQuality.vtkCellQuality_SetUndefinedQuality_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellQuality_SetUnsupportedGeometry_42(HandleRef pThis, double _arg);

		public virtual void SetUnsupportedGeometry(double _arg)
		{
			vtkCellQuality.vtkCellQuality_SetUnsupportedGeometry_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCellQuality_TriangleStripArea_43(HandleRef pThis, HandleRef arg0);

		public double TriangleStripArea(vtkCell arg0)
		{
			return vtkCellQuality.vtkCellQuality_TriangleStripArea_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
