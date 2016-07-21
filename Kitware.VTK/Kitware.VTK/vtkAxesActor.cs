using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAxesActor : vtkProp3D
	{
		public enum CYLINDER_SHAFT_WrapperEnum
		{
			CYLINDER_SHAFT,
			LINE_SHAFT,
			USER_DEFINED_SHAFT
		}

		public enum CONE_TIP_WrapperEnum
		{
			CONE_TIP,
			SPHERE_TIP,
			USER_DEFINED_TIP
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAxesActor";

		public new static readonly string MRClassNameKey;

		static vtkAxesActor()
		{
			vtkAxesActor.MRClassNameKey = "class vtkAxesActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxesActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesActor"));
		}

		public vtkAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxesActor New()
		{
			vtkAxesActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAxesActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAxesActor.vtkAxesActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_AxisLabelsOff_01(HandleRef pThis);

		public virtual void AxisLabelsOff()
		{
			vtkAxesActor.vtkAxesActor_AxisLabelsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_AxisLabelsOn_02(HandleRef pThis);

		public virtual void AxisLabelsOn()
		{
			vtkAxesActor.vtkAxesActor_AxisLabelsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_GetActors_03(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAxesActor.vtkAxesActor_GetActors_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetAxisLabels_04(HandleRef pThis);

		public virtual int GetAxisLabels()
		{
			return vtkAxesActor.vtkAxesActor_GetAxisLabels_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_GetBounds_05(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkAxesActor.vtkAxesActor_GetBounds_05(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetBounds_06(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetConeRadius_07(HandleRef pThis);

		public virtual double GetConeRadius()
		{
			return vtkAxesActor.vtkAxesActor_GetConeRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetConeRadiusMaxValue_08(HandleRef pThis);

		public virtual double GetConeRadiusMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeRadiusMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetConeRadiusMinValue_09(HandleRef pThis);

		public virtual double GetConeRadiusMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeRadiusMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetConeResolution_10(HandleRef pThis);

		public virtual int GetConeResolution()
		{
			return vtkAxesActor.vtkAxesActor_GetConeResolution_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetConeResolutionMaxValue_11(HandleRef pThis);

		public virtual int GetConeResolutionMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeResolutionMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetConeResolutionMinValue_12(HandleRef pThis);

		public virtual int GetConeResolutionMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeResolutionMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetCylinderRadius_13(HandleRef pThis);

		public virtual double GetCylinderRadius()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderRadius_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetCylinderRadiusMaxValue_14(HandleRef pThis);

		public virtual double GetCylinderRadiusMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderRadiusMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetCylinderRadiusMinValue_15(HandleRef pThis);

		public virtual double GetCylinderRadiusMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderRadiusMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetCylinderResolution_16(HandleRef pThis);

		public virtual int GetCylinderResolution()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderResolution_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetCylinderResolutionMaxValue_17(HandleRef pThis);

		public virtual int GetCylinderResolutionMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderResolutionMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetCylinderResolutionMinValue_18(HandleRef pThis);

		public virtual int GetCylinderResolutionMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderResolutionMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkAxesActor_GetMTime_19(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAxesActor.vtkAxesActor_GetMTime_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetNormalizedLabelPosition_20(HandleRef pThis);

		public virtual double[] GetNormalizedLabelPosition()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetNormalizedLabelPosition_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_GetNormalizedLabelPosition_21(HandleRef pThis, IntPtr data);

		public virtual void GetNormalizedLabelPosition(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetNormalizedLabelPosition_21(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetNormalizedShaftLength_22(HandleRef pThis);

		public virtual double[] GetNormalizedShaftLength()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetNormalizedShaftLength_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_GetNormalizedShaftLength_23(HandleRef pThis, IntPtr data);

		public virtual void GetNormalizedShaftLength(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetNormalizedShaftLength_23(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetNormalizedTipLength_24(HandleRef pThis);

		public virtual double[] GetNormalizedTipLength()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetNormalizedTipLength_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_GetNormalizedTipLength_25(HandleRef pThis, IntPtr data);

		public virtual void GetNormalizedTipLength(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetNormalizedTipLength_25(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkAxesActor_GetRedrawMTime_26(HandleRef pThis);

		public override uint GetRedrawMTime()
		{
			return vtkAxesActor.vtkAxesActor_GetRedrawMTime_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetShaftType_27(HandleRef pThis);

		public virtual int GetShaftType()
		{
			return vtkAxesActor.vtkAxesActor_GetShaftType_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetSphereRadius_28(HandleRef pThis);

		public virtual double GetSphereRadius()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereRadius_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetSphereRadiusMaxValue_29(HandleRef pThis);

		public virtual double GetSphereRadiusMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereRadiusMaxValue_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxesActor_GetSphereRadiusMinValue_30(HandleRef pThis);

		public virtual double GetSphereRadiusMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereRadiusMinValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetSphereResolution_31(HandleRef pThis);

		public virtual int GetSphereResolution()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereResolution_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetSphereResolutionMaxValue_32(HandleRef pThis);

		public virtual int GetSphereResolutionMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereResolutionMaxValue_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetSphereResolutionMinValue_33(HandleRef pThis);

		public virtual int GetSphereResolutionMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereResolutionMinValue_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_GetTipType_34(HandleRef pThis);

		public virtual int GetTipType()
		{
			return vtkAxesActor.vtkAxesActor_GetTipType_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetTotalLength_35(HandleRef pThis);

		public virtual double[] GetTotalLength()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetTotalLength_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_GetTotalLength_36(HandleRef pThis, IntPtr data);

		public virtual void GetTotalLength(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetTotalLength_36(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetUserDefinedShaft_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyData GetUserDefinedShaft()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetUserDefinedShaft_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetUserDefinedTip_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyData GetUserDefinedTip()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetUserDefinedTip_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetXAxisCaptionActor2D_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCaptionActor2D GetXAxisCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetXAxisCaptionActor2D_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetXAxisLabelText_40(HandleRef pThis);

		public virtual string GetXAxisLabelText()
		{
			return Marshal.PtrToStringAnsi(vtkAxesActor.vtkAxesActor_GetXAxisLabelText_40(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetXAxisShaftProperty_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetXAxisShaftProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetXAxisShaftProperty_41(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetXAxisTipProperty_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetXAxisTipProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetXAxisTipProperty_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetYAxisCaptionActor2D_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCaptionActor2D GetYAxisCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetYAxisCaptionActor2D_43(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetYAxisLabelText_44(HandleRef pThis);

		public virtual string GetYAxisLabelText()
		{
			return Marshal.PtrToStringAnsi(vtkAxesActor.vtkAxesActor_GetYAxisLabelText_44(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetYAxisShaftProperty_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetYAxisShaftProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetYAxisShaftProperty_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetYAxisTipProperty_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetYAxisTipProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetYAxisTipProperty_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetZAxisCaptionActor2D_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCaptionActor2D GetZAxisCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetZAxisCaptionActor2D_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetZAxisLabelText_48(HandleRef pThis);

		public virtual string GetZAxisLabelText()
		{
			return Marshal.PtrToStringAnsi(vtkAxesActor.vtkAxesActor_GetZAxisLabelText_48(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetZAxisShaftProperty_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetZAxisShaftProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetZAxisShaftProperty_49(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_GetZAxisTipProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetZAxisTipProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetZAxisTipProperty_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_HasTranslucentPolygonalGeometry_51(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAxesActor.vtkAxesActor_HasTranslucentPolygonalGeometry_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_IsA_52(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAxesActor.vtkAxesActor_IsA_52(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_IsTypeOf_53(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAxesActor.vtkAxesActor_IsTypeOf_53(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_NewInstance_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAxesActor NewInstance()
		{
			vtkAxesActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_NewInstance_55(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_ReleaseGraphicsResources_56(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAxesActor.vtkAxesActor_ReleaseGraphicsResources_56(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_RenderOpaqueGeometry_57(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxesActor.vtkAxesActor_RenderOpaqueGeometry_57(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_RenderOverlay_58(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAxesActor.vtkAxesActor_RenderOverlay_58(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxesActor_RenderTranslucentPolygonalGeometry_59(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAxesActor.vtkAxesActor_RenderTranslucentPolygonalGeometry_59(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesActor_SafeDownCast_60(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxesActor SafeDownCast(vtkObjectBase o)
		{
			vtkAxesActor vtkAxesActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_SafeDownCast_60((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesActor = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesActor.Register(null);
				}
			}
			return vtkAxesActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetAxisLabels_61(HandleRef pThis, int _arg);

		public virtual void SetAxisLabels(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetAxisLabels_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetConeRadius_62(HandleRef pThis, double _arg);

		public virtual void SetConeRadius(double _arg)
		{
			vtkAxesActor.vtkAxesActor_SetConeRadius_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetConeResolution_63(HandleRef pThis, int _arg);

		public virtual void SetConeResolution(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetConeResolution_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetCylinderRadius_64(HandleRef pThis, double _arg);

		public virtual void SetCylinderRadius(double _arg)
		{
			vtkAxesActor.vtkAxesActor_SetCylinderRadius_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetCylinderResolution_65(HandleRef pThis, int _arg);

		public virtual void SetCylinderResolution(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetCylinderResolution_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetNormalizedLabelPosition_66(HandleRef pThis, IntPtr v);

		public void SetNormalizedLabelPosition(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedLabelPosition_66(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetNormalizedLabelPosition_67(HandleRef pThis, double x, double y, double z);

		public void SetNormalizedLabelPosition(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedLabelPosition_67(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetNormalizedShaftLength_68(HandleRef pThis, IntPtr v);

		public void SetNormalizedShaftLength(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedShaftLength_68(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetNormalizedShaftLength_69(HandleRef pThis, double x, double y, double z);

		public void SetNormalizedShaftLength(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedShaftLength_69(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetNormalizedTipLength_70(HandleRef pThis, IntPtr v);

		public void SetNormalizedTipLength(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedTipLength_70(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetNormalizedTipLength_71(HandleRef pThis, double x, double y, double z);

		public void SetNormalizedTipLength(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedTipLength_71(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetShaftType_72(HandleRef pThis, int type);

		public void SetShaftType(int type)
		{
			vtkAxesActor.vtkAxesActor_SetShaftType_72(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetShaftTypeToCylinder_73(HandleRef pThis);

		public void SetShaftTypeToCylinder()
		{
			vtkAxesActor.vtkAxesActor_SetShaftTypeToCylinder_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetShaftTypeToLine_74(HandleRef pThis);

		public void SetShaftTypeToLine()
		{
			vtkAxesActor.vtkAxesActor_SetShaftTypeToLine_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetShaftTypeToUserDefined_75(HandleRef pThis);

		public void SetShaftTypeToUserDefined()
		{
			vtkAxesActor.vtkAxesActor_SetShaftTypeToUserDefined_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetSphereRadius_76(HandleRef pThis, double _arg);

		public virtual void SetSphereRadius(double _arg)
		{
			vtkAxesActor.vtkAxesActor_SetSphereRadius_76(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetSphereResolution_77(HandleRef pThis, int _arg);

		public virtual void SetSphereResolution(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetSphereResolution_77(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetTipType_78(HandleRef pThis, int type);

		public void SetTipType(int type)
		{
			vtkAxesActor.vtkAxesActor_SetTipType_78(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetTipTypeToCone_79(HandleRef pThis);

		public void SetTipTypeToCone()
		{
			vtkAxesActor.vtkAxesActor_SetTipTypeToCone_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetTipTypeToSphere_80(HandleRef pThis);

		public void SetTipTypeToSphere()
		{
			vtkAxesActor.vtkAxesActor_SetTipTypeToSphere_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetTipTypeToUserDefined_81(HandleRef pThis);

		public void SetTipTypeToUserDefined()
		{
			vtkAxesActor.vtkAxesActor_SetTipTypeToUserDefined_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetTotalLength_82(HandleRef pThis, IntPtr v);

		public void SetTotalLength(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetTotalLength_82(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetTotalLength_83(HandleRef pThis, double x, double y, double z);

		public void SetTotalLength(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetTotalLength_83(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetUserDefinedShaft_84(HandleRef pThis, HandleRef arg0);

		public void SetUserDefinedShaft(vtkPolyData arg0)
		{
			vtkAxesActor.vtkAxesActor_SetUserDefinedShaft_84(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetUserDefinedTip_85(HandleRef pThis, HandleRef arg0);

		public void SetUserDefinedTip(vtkPolyData arg0)
		{
			vtkAxesActor.vtkAxesActor_SetUserDefinedTip_85(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetXAxisLabelText_86(HandleRef pThis, string _arg);

		public virtual void SetXAxisLabelText(string _arg)
		{
			vtkAxesActor.vtkAxesActor_SetXAxisLabelText_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetYAxisLabelText_87(HandleRef pThis, string _arg);

		public virtual void SetYAxisLabelText(string _arg)
		{
			vtkAxesActor.vtkAxesActor_SetYAxisLabelText_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_SetZAxisLabelText_88(HandleRef pThis, string _arg);

		public virtual void SetZAxisLabelText(string _arg)
		{
			vtkAxesActor.vtkAxesActor_SetZAxisLabelText_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxesActor_ShallowCopy_89(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAxesActor.vtkAxesActor_ShallowCopy_89(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
