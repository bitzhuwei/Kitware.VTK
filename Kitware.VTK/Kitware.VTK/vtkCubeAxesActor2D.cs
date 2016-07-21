using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCubeAxesActor2D : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCubeAxesActor2D";

		public new static readonly string MRClassNameKey;

		static vtkCubeAxesActor2D()
		{
			vtkCubeAxesActor2D.MRClassNameKey = "class vtkCubeAxesActor2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCubeAxesActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeAxesActor2D"));
		}

		public vtkCubeAxesActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCubeAxesActor2D New()
		{
			vtkCubeAxesActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCubeAxesActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCubeAxesActor2D.vtkCubeAxesActor2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetAxisLabelTextProperty_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetAxisLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetAxisLabelTextProperty_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetAxisTitleTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetAxisTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetAxisTitleTextProperty_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetBounds_03(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_GetBounds_04(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

		public void GetBounds(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetBounds_04(base.GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_GetBounds_05(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetBounds_05(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetCamera_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetCamera_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCubeAxesActor2D_GetCornerOffset_07(HandleRef pThis);

		public virtual double GetCornerOffset()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetCornerOffset_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetFlyMode_08(HandleRef pThis);

		public virtual int GetFlyMode()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFlyMode_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetFlyModeMaxValue_09(HandleRef pThis);

		public virtual int GetFlyModeMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFlyModeMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetFlyModeMinValue_10(HandleRef pThis);

		public virtual int GetFlyModeMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFlyModeMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCubeAxesActor2D_GetFontFactor_11(HandleRef pThis);

		public virtual double GetFontFactor()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFontFactor_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCubeAxesActor2D_GetFontFactorMaxValue_12(HandleRef pThis);

		public virtual double GetFontFactorMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFontFactorMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCubeAxesActor2D_GetFontFactorMinValue_13(HandleRef pThis);

		public virtual double GetFontFactorMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFontFactorMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetInertia_14(HandleRef pThis);

		public virtual int GetInertia()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInertia_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetInertiaMaxValue_15(HandleRef pThis);

		public virtual int GetInertiaMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInertiaMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetInertiaMinValue_16(HandleRef pThis);

		public virtual int GetInertiaMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInertiaMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetInput_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInput_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetLabelFormat_18(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetLabelFormat_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetNumberOfLabels_19(HandleRef pThis);

		public virtual int GetNumberOfLabels()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfLabels_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetNumberOfLabelsMaxValue_20(HandleRef pThis);

		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfLabelsMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetNumberOfLabelsMinValue_21(HandleRef pThis);

		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfLabelsMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetRanges_22(HandleRef pThis);

		public double[] GetRanges()
		{
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetRanges_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_GetRanges_23(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

		public void GetRanges(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetRanges_23(base.GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_GetRanges_24(HandleRef pThis, IntPtr ranges);

		public void GetRanges(IntPtr ranges)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetRanges_24(base.GetCppThis(), ranges);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetScaling_25(HandleRef pThis);

		public virtual int GetScaling()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetScaling_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetShowActualBounds_26(HandleRef pThis);

		public virtual int GetShowActualBounds()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetShowActualBounds_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetShowActualBoundsMaxValue_27(HandleRef pThis);

		public virtual int GetShowActualBoundsMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetShowActualBoundsMaxValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetShowActualBoundsMinValue_28(HandleRef pThis);

		public virtual int GetShowActualBoundsMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetShowActualBoundsMinValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetUseRanges_29(HandleRef pThis);

		public virtual int GetUseRanges()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetUseRanges_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetViewProp_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProp GetViewProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetViewProp_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetXAxisActor2D_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAxisActor2D GetXAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetXAxisActor2D_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetXAxisVisibility_32(HandleRef pThis);

		public virtual int GetXAxisVisibility()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetXAxisVisibility_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetXLabel_33(HandleRef pThis);

		public virtual string GetXLabel()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetXLabel_33(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetYAxisActor2D_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAxisActor2D GetYAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetYAxisActor2D_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetYAxisVisibility_35(HandleRef pThis);

		public virtual int GetYAxisVisibility()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetYAxisVisibility_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetYLabel_36(HandleRef pThis);

		public virtual string GetYLabel()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetYLabel_36(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetZAxisActor2D_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAxisActor2D GetZAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetZAxisActor2D_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_GetZAxisVisibility_38(HandleRef pThis);

		public virtual int GetZAxisVisibility()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetZAxisVisibility_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_GetZLabel_39(HandleRef pThis);

		public virtual string GetZLabel()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetZLabel_39(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_HasTranslucentPolygonalGeometry_40(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_HasTranslucentPolygonalGeometry_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_IsA_41(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_IsA_41(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_IsTypeOf_42(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_IsTypeOf_42(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCubeAxesActor2D NewInstance()
		{
			vtkCubeAxesActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_NewInstance_44(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_ReleaseGraphicsResources_45(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ReleaseGraphicsResources_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_RenderOpaqueGeometry_46(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_RenderOpaqueGeometry_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_RenderOverlay_47(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_RenderOverlay_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor2D_RenderTranslucentPolygonalGeometry_48(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_RenderTranslucentPolygonalGeometry_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor2D_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCubeAxesActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkCubeAxesActor2D vtkCubeAxesActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCubeAxesActor2D = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCubeAxesActor2D.Register(null);
				}
			}
			return vtkCubeAxesActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_ScalingOff_50(HandleRef pThis);

		public virtual void ScalingOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ScalingOff_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_ScalingOn_51(HandleRef pThis);

		public virtual void ScalingOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ScalingOn_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetAxisLabelTextProperty_52(HandleRef pThis, HandleRef p);

		public virtual void SetAxisLabelTextProperty(vtkTextProperty p)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetAxisLabelTextProperty_52(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetAxisTitleTextProperty_53(HandleRef pThis, HandleRef p);

		public virtual void SetAxisTitleTextProperty(vtkTextProperty p)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetAxisTitleTextProperty_53(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetBounds_54(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetBounds_54(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetBounds_55(HandleRef pThis, IntPtr _arg);

		public virtual void SetBounds(IntPtr _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetBounds_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetCamera_56(HandleRef pThis, HandleRef arg0);

		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetCamera_56(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetCornerOffset_57(HandleRef pThis, double _arg);

		public virtual void SetCornerOffset(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetCornerOffset_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetFlyMode_58(HandleRef pThis, int _arg);

		public virtual void SetFlyMode(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyMode_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetFlyModeToClosestTriad_59(HandleRef pThis);

		public void SetFlyModeToClosestTriad()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyModeToClosestTriad_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetFlyModeToNone_60(HandleRef pThis);

		public void SetFlyModeToNone()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyModeToNone_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetFlyModeToOuterEdges_61(HandleRef pThis);

		public void SetFlyModeToOuterEdges()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyModeToOuterEdges_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetFontFactor_62(HandleRef pThis, double _arg);

		public virtual void SetFontFactor(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFontFactor_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetInertia_63(HandleRef pThis, int _arg);

		public virtual void SetInertia(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetInertia_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetInput_64(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataSet arg0)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetInput_64(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetLabelFormat_65(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetLabelFormat_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetNumberOfLabels_66(HandleRef pThis, int _arg);

		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetNumberOfLabels_66(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetRanges_67(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetRanges(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetRanges_67(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetRanges_68(HandleRef pThis, IntPtr _arg);

		public virtual void SetRanges(IntPtr _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetRanges_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetScaling_69(HandleRef pThis, int _arg);

		public virtual void SetScaling(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetScaling_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetShowActualBounds_70(HandleRef pThis, int _arg);

		public virtual void SetShowActualBounds(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetShowActualBounds_70(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetUseRanges_71(HandleRef pThis, int _arg);

		public virtual void SetUseRanges(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetUseRanges_71(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetViewProp_72(HandleRef pThis, HandleRef prop);

		public void SetViewProp(vtkProp prop)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetViewProp_72(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetXAxisVisibility_73(HandleRef pThis, int _arg);

		public virtual void SetXAxisVisibility(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetXAxisVisibility_73(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetXLabel_74(HandleRef pThis, string _arg);

		public virtual void SetXLabel(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetXLabel_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetXOrigin_75(HandleRef pThis, double _arg);

		public virtual void SetXOrigin(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetXOrigin_75(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetYAxisVisibility_76(HandleRef pThis, int _arg);

		public virtual void SetYAxisVisibility(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetYAxisVisibility_76(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetYLabel_77(HandleRef pThis, string _arg);

		public virtual void SetYLabel(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetYLabel_77(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetYOrigin_78(HandleRef pThis, double _arg);

		public virtual void SetYOrigin(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetYOrigin_78(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetZAxisVisibility_79(HandleRef pThis, int _arg);

		public virtual void SetZAxisVisibility(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetZAxisVisibility_79(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetZLabel_80(HandleRef pThis, string _arg);

		public virtual void SetZLabel(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetZLabel_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_SetZOrigin_81(HandleRef pThis, double _arg);

		public virtual void SetZOrigin(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetZOrigin_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_ShallowCopy_82(HandleRef pThis, HandleRef actor);

		public void ShallowCopy(vtkCubeAxesActor2D actor)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ShallowCopy_82(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_UseRangesOff_83(HandleRef pThis);

		public virtual void UseRangesOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_UseRangesOff_83(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_UseRangesOn_84(HandleRef pThis);

		public virtual void UseRangesOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_UseRangesOn_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_XAxisVisibilityOff_85(HandleRef pThis);

		public virtual void XAxisVisibilityOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_XAxisVisibilityOff_85(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_XAxisVisibilityOn_86(HandleRef pThis);

		public virtual void XAxisVisibilityOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_XAxisVisibilityOn_86(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_YAxisVisibilityOff_87(HandleRef pThis);

		public virtual void YAxisVisibilityOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_YAxisVisibilityOff_87(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_YAxisVisibilityOn_88(HandleRef pThis);

		public virtual void YAxisVisibilityOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_YAxisVisibilityOn_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_ZAxisVisibilityOff_89(HandleRef pThis);

		public virtual void ZAxisVisibilityOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ZAxisVisibilityOff_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor2D_ZAxisVisibilityOn_90(HandleRef pThis);

		public virtual void ZAxisVisibilityOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ZAxisVisibilityOn_90(base.GetCppThis());
		}
	}
}
