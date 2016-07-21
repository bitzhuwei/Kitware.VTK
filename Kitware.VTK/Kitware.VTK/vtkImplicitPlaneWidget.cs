using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitPlaneWidget : vtkPolyDataSourceWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneWidget";

		public new static readonly string MRClassNameKey;

		static vtkImplicitPlaneWidget()
		{
			vtkImplicitPlaneWidget.MRClassNameKey = "class vtkImplicitPlaneWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitPlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneWidget"));
		}

		public vtkImplicitPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitPlaneWidget New()
		{
			vtkImplicitPlaneWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitPlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_DrawPlaneOff_01(HandleRef pThis);

		public virtual void DrawPlaneOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_DrawPlaneOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_DrawPlaneOn_02(HandleRef pThis);

		public virtual void DrawPlaneOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_DrawPlaneOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatio_03(HandleRef pThis);

		public virtual double GetDiagonalRatio()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDiagonalRatio_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatioMaxValue_04(HandleRef pThis);

		public virtual double GetDiagonalRatioMaxValue()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDiagonalRatioMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImplicitPlaneWidget_GetDiagonalRatioMinValue_05(HandleRef pThis);

		public virtual double GetDiagonalRatioMinValue()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDiagonalRatioMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetDrawPlane_06(HandleRef pThis);

		public virtual int GetDrawPlane()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetDrawPlane_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetEdgesProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetEdgesProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetNormal_08(HandleRef pThis);

		public double[] GetNormal()
		{
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormal_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_GetNormal_09(HandleRef pThis, IntPtr xyz);

		public void GetNormal(IntPtr xyz)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormal_09(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetNormalProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetNormalToXAxis_11(HandleRef pThis);

		public virtual int GetNormalToXAxis()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalToXAxis_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetNormalToYAxis_12(HandleRef pThis);

		public virtual int GetNormalToYAxis()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalToYAxis_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetNormalToZAxis_13(HandleRef pThis);

		public virtual int GetNormalToZAxis()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetNormalToZAxis_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetOrigin_14(HandleRef pThis);

		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOrigin_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_GetOrigin_15(HandleRef pThis, IntPtr xyz);

		public void GetOrigin(IntPtr xyz)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOrigin_15(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetOriginTranslation_16(HandleRef pThis);

		public virtual int GetOriginTranslation()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOriginTranslation_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetOutlineProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOutlineProperty_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetOutlineTranslation_18(HandleRef pThis);

		public virtual int GetOutlineTranslation()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOutlineTranslation_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetOutsideBounds_19(HandleRef pThis);

		public virtual int GetOutsideBounds()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetOutsideBounds_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_GetPlane_20(HandleRef pThis, HandleRef plane);

		public void GetPlane(vtkPlane plane)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPlane_20(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetPlaneProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPlaneProperty_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_GetPolyData_22(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPolyData_22(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetPolyDataAlgorithm_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetPolyDataAlgorithm_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetScaleEnabled_24(HandleRef pThis);

		public virtual int GetScaleEnabled()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetScaleEnabled_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedNormalProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetSelectedNormalProperty_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedOutlineProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetSelectedOutlineProperty_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_GetSelectedPlaneProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetSelectedPlaneProperty_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_GetTubing_28(HandleRef pThis);

		public virtual int GetTubing()
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_GetTubing_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_IsA_29(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_IsA_29(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget_IsTypeOf_30(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_IsTypeOf_30(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitPlaneWidget NewInstance()
		{
			vtkImplicitPlaneWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_NormalToXAxisOff_33(HandleRef pThis);

		public virtual void NormalToXAxisOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToXAxisOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_NormalToXAxisOn_34(HandleRef pThis);

		public virtual void NormalToXAxisOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToXAxisOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_NormalToYAxisOff_35(HandleRef pThis);

		public virtual void NormalToYAxisOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToYAxisOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_NormalToYAxisOn_36(HandleRef pThis);

		public virtual void NormalToYAxisOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToYAxisOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_NormalToZAxisOff_37(HandleRef pThis);

		public virtual void NormalToZAxisOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToZAxisOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_NormalToZAxisOn_38(HandleRef pThis);

		public virtual void NormalToZAxisOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_NormalToZAxisOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_OriginTranslationOff_39(HandleRef pThis);

		public virtual void OriginTranslationOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OriginTranslationOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_OriginTranslationOn_40(HandleRef pThis);

		public virtual void OriginTranslationOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OriginTranslationOn_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_OutlineTranslationOff_41(HandleRef pThis);

		public virtual void OutlineTranslationOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutlineTranslationOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_OutlineTranslationOn_42(HandleRef pThis);

		public virtual void OutlineTranslationOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutlineTranslationOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_OutsideBoundsOff_43(HandleRef pThis);

		public virtual void OutsideBoundsOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutsideBoundsOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_OutsideBoundsOn_44(HandleRef pThis);

		public virtual void OutsideBoundsOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_OutsideBoundsOn_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_PlaceWidget_45(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_PlaceWidget_45(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_PlaceWidget_46(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_PlaceWidget_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_PlaceWidget_47(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_PlaceWidget_47(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitPlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitPlaneWidget vtkImplicitPlaneWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneWidget = (vtkImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneWidget.Register(null);
				}
			}
			return vtkImplicitPlaneWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_ScaleEnabledOff_49(HandleRef pThis);

		public virtual void ScaleEnabledOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_ScaleEnabledOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_ScaleEnabledOn_50(HandleRef pThis);

		public virtual void ScaleEnabledOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_ScaleEnabledOn_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetDiagonalRatio_51(HandleRef pThis, double _arg);

		public virtual void SetDiagonalRatio(double _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetDiagonalRatio_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetDrawPlane_52(HandleRef pThis, int plane);

		public void SetDrawPlane(int plane)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetDrawPlane_52(base.GetCppThis(), plane);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetEnabled_53(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetEnabled_53(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetNormal_54(HandleRef pThis, double x, double y, double z);

		public void SetNormal(double x, double y, double z)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormal_54(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetNormal_55(HandleRef pThis, IntPtr x);

		public void SetNormal(IntPtr x)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormal_55(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetNormalToXAxis_56(HandleRef pThis, int arg0);

		public void SetNormalToXAxis(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormalToXAxis_56(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetNormalToYAxis_57(HandleRef pThis, int arg0);

		public void SetNormalToYAxis(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormalToYAxis_57(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetNormalToZAxis_58(HandleRef pThis, int arg0);

		public void SetNormalToZAxis(int arg0)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetNormalToZAxis_58(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetOrigin_59(HandleRef pThis, double x, double y, double z);

		public virtual void SetOrigin(double x, double y, double z)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOrigin_59(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetOrigin_60(HandleRef pThis, IntPtr x);

		public virtual void SetOrigin(IntPtr x)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOrigin_60(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetOriginTranslation_61(HandleRef pThis, int _arg);

		public virtual void SetOriginTranslation(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOriginTranslation_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetOutlineTranslation_62(HandleRef pThis, int _arg);

		public virtual void SetOutlineTranslation(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOutlineTranslation_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetOutsideBounds_63(HandleRef pThis, int _arg);

		public virtual void SetOutsideBounds(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetOutsideBounds_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetScaleEnabled_64(HandleRef pThis, int _arg);

		public virtual void SetScaleEnabled(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetScaleEnabled_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SetTubing_65(HandleRef pThis, int _arg);

		public virtual void SetTubing(int _arg)
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SetTubing_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_SizeHandles_66(HandleRef pThis);

		public virtual void SizeHandles()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_SizeHandles_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_TubingOff_67(HandleRef pThis);

		public virtual void TubingOff()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_TubingOff_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_TubingOn_68(HandleRef pThis);

		public virtual void TubingOn()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_TubingOn_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget_UpdatePlacement_69(HandleRef pThis);

		public override void UpdatePlacement()
		{
			vtkImplicitPlaneWidget.vtkImplicitPlaneWidget_UpdatePlacement_69(base.GetCppThis());
		}
	}
}
