using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCubeAxesActor : vtkActor
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCubeAxesActor";

		public new static readonly string MRClassNameKey;

		static vtkCubeAxesActor()
		{
			vtkCubeAxesActor.MRClassNameKey = "class vtkCubeAxesActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCubeAxesActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeAxesActor"));
		}

		public vtkCubeAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCubeAxesActor New()
		{
			vtkCubeAxesActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCubeAxesActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCubeAxesActor.vtkCubeAxesActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_DrawXGridlinesOff_01(HandleRef pThis);

		public virtual void DrawXGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXGridlinesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_DrawXGridlinesOn_02(HandleRef pThis);

		public virtual void DrawXGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawXGridlinesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_DrawYGridlinesOff_03(HandleRef pThis);

		public virtual void DrawYGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYGridlinesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_DrawYGridlinesOn_04(HandleRef pThis);

		public virtual void DrawYGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawYGridlinesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_DrawZGridlinesOff_05(HandleRef pThis);

		public virtual void DrawZGridlinesOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZGridlinesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_DrawZGridlinesOn_06(HandleRef pThis);

		public virtual void DrawZGridlinesOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_DrawZGridlinesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetBounds_07(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetBounds_08(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

		public void GetBounds(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetBounds_08(base.GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetBounds_09(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetBounds_09(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetCamera_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetCamera_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkCubeAxesActor_GetCornerOffset_11(HandleRef pThis);

		public virtual double GetCornerOffset()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetCornerOffset_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetDrawXGridlines_12(HandleRef pThis);

		public virtual int GetDrawXGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawXGridlines_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetDrawYGridlines_13(HandleRef pThis);

		public virtual int GetDrawYGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawYGridlines_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetDrawZGridlines_14(HandleRef pThis);

		public virtual int GetDrawZGridlines()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetDrawZGridlines_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetFlyMode_15(HandleRef pThis);

		public virtual int GetFlyMode()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetFlyMode_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetFlyModeMaxValue_16(HandleRef pThis);

		public virtual int GetFlyModeMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetFlyModeMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetFlyModeMinValue_17(HandleRef pThis);

		public virtual int GetFlyModeMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetFlyModeMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetInertia_18(HandleRef pThis);

		public virtual int GetInertia()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetInertia_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetInertiaMaxValue_19(HandleRef pThis);

		public virtual int GetInertiaMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetInertiaMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetInertiaMinValue_20(HandleRef pThis);

		public virtual int GetInertiaMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetInertiaMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetTickLocation_21(HandleRef pThis);

		public virtual int GetTickLocation()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetTickLocation_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetTickLocationMaxValue_22(HandleRef pThis);

		public virtual int GetTickLocationMaxValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetTickLocationMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetTickLocationMinValue_23(HandleRef pThis);

		public virtual int GetTickLocationMinValue()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetTickLocationMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetXAxisLabelVisibility_24(HandleRef pThis);

		public virtual int GetXAxisLabelVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisLabelVisibility_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetXAxisMinorTickVisibility_25(HandleRef pThis);

		public virtual int GetXAxisMinorTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisMinorTickVisibility_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetXAxisRange_26(HandleRef pThis);

		public virtual double[] GetXAxisRange()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisRange_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetXAxisRange_27(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetXAxisRange(ref double _arg1, ref double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisRange_27(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetXAxisRange_28(HandleRef pThis, IntPtr _arg);

		public virtual void GetXAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisRange_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetXAxisTickVisibility_29(HandleRef pThis);

		public virtual int GetXAxisTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisTickVisibility_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetXAxisVisibility_30(HandleRef pThis);

		public virtual int GetXAxisVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetXAxisVisibility_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetXLabelFormat_31(HandleRef pThis);

		public virtual string GetXLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetXLabelFormat_31(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetXTitle_32(HandleRef pThis);

		public virtual string GetXTitle()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetXTitle_32(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetXUnits_33(HandleRef pThis);

		public virtual string GetXUnits()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetXUnits_33(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetYAxisLabelVisibility_34(HandleRef pThis);

		public virtual int GetYAxisLabelVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisLabelVisibility_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetYAxisMinorTickVisibility_35(HandleRef pThis);

		public virtual int GetYAxisMinorTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisMinorTickVisibility_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetYAxisRange_36(HandleRef pThis);

		public virtual double[] GetYAxisRange()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisRange_36(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetYAxisRange_37(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetYAxisRange(ref double _arg1, ref double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisRange_37(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetYAxisRange_38(HandleRef pThis, IntPtr _arg);

		public virtual void GetYAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisRange_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetYAxisTickVisibility_39(HandleRef pThis);

		public virtual int GetYAxisTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisTickVisibility_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetYAxisVisibility_40(HandleRef pThis);

		public virtual int GetYAxisVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetYAxisVisibility_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetYLabelFormat_41(HandleRef pThis);

		public virtual string GetYLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetYLabelFormat_41(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetYTitle_42(HandleRef pThis);

		public virtual string GetYTitle()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetYTitle_42(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetYUnits_43(HandleRef pThis);

		public virtual string GetYUnits()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetYUnits_43(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetZAxisLabelVisibility_44(HandleRef pThis);

		public virtual int GetZAxisLabelVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisLabelVisibility_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetZAxisMinorTickVisibility_45(HandleRef pThis);

		public virtual int GetZAxisMinorTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisMinorTickVisibility_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetZAxisRange_46(HandleRef pThis);

		public virtual double[] GetZAxisRange()
		{
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisRange_46(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetZAxisRange_47(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetZAxisRange(ref double _arg1, ref double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisRange_47(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_GetZAxisRange_48(HandleRef pThis, IntPtr _arg);

		public virtual void GetZAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisRange_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetZAxisTickVisibility_49(HandleRef pThis);

		public virtual int GetZAxisTickVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisTickVisibility_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_GetZAxisVisibility_50(HandleRef pThis);

		public virtual int GetZAxisVisibility()
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_GetZAxisVisibility_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetZLabelFormat_51(HandleRef pThis);

		public virtual string GetZLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetZLabelFormat_51(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetZTitle_52(HandleRef pThis);

		public virtual string GetZTitle()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetZTitle_52(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_GetZUnits_53(HandleRef pThis);

		public virtual string GetZUnits()
		{
			return Marshal.PtrToStringAnsi(vtkCubeAxesActor.vtkCubeAxesActor_GetZUnits_53(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_IsA_54(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_IsA_54(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_IsTypeOf_55(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_IsTypeOf_55(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCubeAxesActor NewInstance()
		{
			vtkCubeAxesActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_NewInstance_57(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ReleaseGraphicsResources_58(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ReleaseGraphicsResources_58(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_RenderOpaqueGeometry_59(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_RenderOpaqueGeometry_59(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCubeAxesActor_RenderTranslucentGeometry_60(HandleRef pThis, HandleRef arg0);

		public virtual int RenderTranslucentGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor.vtkCubeAxesActor_RenderTranslucentGeometry_60(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeAxesActor_SafeDownCast_61(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCubeAxesActor SafeDownCast(vtkObjectBase o)
		{
			vtkCubeAxesActor vtkCubeAxesActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeAxesActor.vtkCubeAxesActor_SafeDownCast_61((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCubeAxesActor = (vtkCubeAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCubeAxesActor.Register(null);
				}
			}
			return vtkCubeAxesActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetBounds_62(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetBounds_62(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetBounds_63(HandleRef pThis, IntPtr _arg);

		public virtual void SetBounds(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetBounds_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetCamera_64(HandleRef pThis, HandleRef arg0);

		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetCamera_64(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetCornerOffset_65(HandleRef pThis, double _arg);

		public virtual void SetCornerOffset(double _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetCornerOffset_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetDrawXGridlines_66(HandleRef pThis, int _arg);

		public virtual void SetDrawXGridlines(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawXGridlines_66(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetDrawYGridlines_67(HandleRef pThis, int _arg);

		public virtual void SetDrawYGridlines(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawYGridlines_67(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetDrawZGridlines_68(HandleRef pThis, int _arg);

		public virtual void SetDrawZGridlines(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetDrawZGridlines_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetFlyMode_69(HandleRef pThis, int _arg);

		public virtual void SetFlyMode(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyMode_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetFlyModeToClosestTriad_70(HandleRef pThis);

		public void SetFlyModeToClosestTriad()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToClosestTriad_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetFlyModeToFurthestTriad_71(HandleRef pThis);

		public void SetFlyModeToFurthestTriad()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToFurthestTriad_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetFlyModeToOuterEdges_72(HandleRef pThis);

		public void SetFlyModeToOuterEdges()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToOuterEdges_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetFlyModeToStaticEdges_73(HandleRef pThis);

		public void SetFlyModeToStaticEdges()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToStaticEdges_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetFlyModeToStaticTriad_74(HandleRef pThis);

		public void SetFlyModeToStaticTriad()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetFlyModeToStaticTriad_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetInertia_75(HandleRef pThis, int _arg);

		public virtual void SetInertia(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetInertia_75(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetLabelScaling_76(HandleRef pThis, byte arg0, int arg1, int arg2, int arg3);

		public void SetLabelScaling(bool arg0, int arg1, int arg2, int arg3)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetLabelScaling_76(base.GetCppThis(), arg0 ? (byte)1 : (byte)0, arg1, arg2, arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetTickLocation_77(HandleRef pThis, int _arg);

		public virtual void SetTickLocation(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocation_77(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetTickLocationToBoth_78(HandleRef pThis);

		public void SetTickLocationToBoth()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocationToBoth_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetTickLocationToInside_79(HandleRef pThis);

		public void SetTickLocationToInside()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocationToInside_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetTickLocationToOutside_80(HandleRef pThis);

		public void SetTickLocationToOutside()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetTickLocationToOutside_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXAxisLabelVisibility_81(HandleRef pThis, int _arg);

		public virtual void SetXAxisLabelVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisLabelVisibility_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXAxisMinorTickVisibility_82(HandleRef pThis, int _arg);

		public virtual void SetXAxisMinorTickVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisMinorTickVisibility_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXAxisRange_83(HandleRef pThis, IntPtr _arg);

		public void SetXAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisRange_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXAxisRange_84(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetXAxisRange(double _arg1, double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisRange_84(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXAxisTickVisibility_85(HandleRef pThis, int _arg);

		public virtual void SetXAxisTickVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisTickVisibility_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXAxisVisibility_86(HandleRef pThis, int _arg);

		public virtual void SetXAxisVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXAxisVisibility_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXLabelFormat_87(HandleRef pThis, string _arg);

		public virtual void SetXLabelFormat(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXLabelFormat_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXTitle_88(HandleRef pThis, string _arg);

		public virtual void SetXTitle(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXTitle_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetXUnits_89(HandleRef pThis, string _arg);

		public virtual void SetXUnits(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetXUnits_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYAxisLabelVisibility_90(HandleRef pThis, int _arg);

		public virtual void SetYAxisLabelVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisLabelVisibility_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYAxisMinorTickVisibility_91(HandleRef pThis, int _arg);

		public virtual void SetYAxisMinorTickVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisMinorTickVisibility_91(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYAxisRange_92(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetYAxisRange(double _arg1, double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisRange_92(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYAxisRange_93(HandleRef pThis, IntPtr _arg);

		public void SetYAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisRange_93(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYAxisTickVisibility_94(HandleRef pThis, int _arg);

		public virtual void SetYAxisTickVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisTickVisibility_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYAxisVisibility_95(HandleRef pThis, int _arg);

		public virtual void SetYAxisVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYAxisVisibility_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYLabelFormat_96(HandleRef pThis, string _arg);

		public virtual void SetYLabelFormat(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYLabelFormat_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYTitle_97(HandleRef pThis, string _arg);

		public virtual void SetYTitle(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYTitle_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetYUnits_98(HandleRef pThis, string _arg);

		public virtual void SetYUnits(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetYUnits_98(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZAxisLabelVisibility_99(HandleRef pThis, int _arg);

		public virtual void SetZAxisLabelVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisLabelVisibility_99(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZAxisMinorTickVisibility_100(HandleRef pThis, int _arg);

		public virtual void SetZAxisMinorTickVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisMinorTickVisibility_100(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZAxisRange_101(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetZAxisRange(double _arg1, double _arg2)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisRange_101(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZAxisRange_102(HandleRef pThis, IntPtr _arg);

		public void SetZAxisRange(IntPtr _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisRange_102(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZAxisTickVisibility_103(HandleRef pThis, int _arg);

		public virtual void SetZAxisTickVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisTickVisibility_103(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZAxisVisibility_104(HandleRef pThis, int _arg);

		public virtual void SetZAxisVisibility(int _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZAxisVisibility_104(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZLabelFormat_105(HandleRef pThis, string _arg);

		public virtual void SetZLabelFormat(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZLabelFormat_105(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZTitle_106(HandleRef pThis, string _arg);

		public virtual void SetZTitle(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZTitle_106(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_SetZUnits_107(HandleRef pThis, string _arg);

		public virtual void SetZUnits(string _arg)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_SetZUnits_107(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ShallowCopy_108(HandleRef pThis, HandleRef actor);

		public void ShallowCopy(vtkCubeAxesActor actor)
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ShallowCopy_108(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisLabelVisibilityOff_109(HandleRef pThis);

		public virtual void XAxisLabelVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisLabelVisibilityOff_109(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisLabelVisibilityOn_110(HandleRef pThis);

		public virtual void XAxisLabelVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisLabelVisibilityOn_110(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisMinorTickVisibilityOff_111(HandleRef pThis);

		public virtual void XAxisMinorTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisMinorTickVisibilityOff_111(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisMinorTickVisibilityOn_112(HandleRef pThis);

		public virtual void XAxisMinorTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisMinorTickVisibilityOn_112(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisTickVisibilityOff_113(HandleRef pThis);

		public virtual void XAxisTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisTickVisibilityOff_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisTickVisibilityOn_114(HandleRef pThis);

		public virtual void XAxisTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisTickVisibilityOn_114(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisVisibilityOff_115(HandleRef pThis);

		public virtual void XAxisVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisVisibilityOff_115(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_XAxisVisibilityOn_116(HandleRef pThis);

		public virtual void XAxisVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_XAxisVisibilityOn_116(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisLabelVisibilityOff_117(HandleRef pThis);

		public virtual void YAxisLabelVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisLabelVisibilityOff_117(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisLabelVisibilityOn_118(HandleRef pThis);

		public virtual void YAxisLabelVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisLabelVisibilityOn_118(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisMinorTickVisibilityOff_119(HandleRef pThis);

		public virtual void YAxisMinorTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisMinorTickVisibilityOff_119(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisMinorTickVisibilityOn_120(HandleRef pThis);

		public virtual void YAxisMinorTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisMinorTickVisibilityOn_120(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisTickVisibilityOff_121(HandleRef pThis);

		public virtual void YAxisTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisTickVisibilityOff_121(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisTickVisibilityOn_122(HandleRef pThis);

		public virtual void YAxisTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisTickVisibilityOn_122(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisVisibilityOff_123(HandleRef pThis);

		public virtual void YAxisVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisVisibilityOff_123(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_YAxisVisibilityOn_124(HandleRef pThis);

		public virtual void YAxisVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_YAxisVisibilityOn_124(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisLabelVisibilityOff_125(HandleRef pThis);

		public virtual void ZAxisLabelVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisLabelVisibilityOff_125(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisLabelVisibilityOn_126(HandleRef pThis);

		public virtual void ZAxisLabelVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisLabelVisibilityOn_126(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisMinorTickVisibilityOff_127(HandleRef pThis);

		public virtual void ZAxisMinorTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisMinorTickVisibilityOff_127(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisMinorTickVisibilityOn_128(HandleRef pThis);

		public virtual void ZAxisMinorTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisMinorTickVisibilityOn_128(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisTickVisibilityOff_129(HandleRef pThis);

		public virtual void ZAxisTickVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisTickVisibilityOff_129(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisTickVisibilityOn_130(HandleRef pThis);

		public virtual void ZAxisTickVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisTickVisibilityOn_130(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisVisibilityOff_131(HandleRef pThis);

		public virtual void ZAxisVisibilityOff()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisVisibilityOff_131(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCubeAxesActor_ZAxisVisibilityOn_132(HandleRef pThis);

		public virtual void ZAxisVisibilityOn()
		{
			vtkCubeAxesActor.vtkCubeAxesActor_ZAxisVisibilityOn_132(base.GetCppThis());
		}
	}
}
