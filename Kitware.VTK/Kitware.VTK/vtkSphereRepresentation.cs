using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSphereRepresentation : vtkWidgetRepresentation
	{
		public enum MovingHandle_WrapperEnum
		{
			MovingHandle = 1,
			OnSphere,
			Outside = 0,
			Scaling = 4,
			Translating = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkSphereRepresentation()
		{
			vtkSphereRepresentation.MRClassNameKey = "class vtkSphereRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereRepresentation"));
		}

		public vtkSphereRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereRepresentation New()
		{
			vtkSphereRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSphereRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSphereRepresentation.vtkSphereRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetBounds_03(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetCenter_04(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_GetCenter_05(HandleRef pThis, IntPtr xyz);

		public void GetCenter(IntPtr xyz)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetCenter_05(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetHandleDirection_06(HandleRef pThis);

		public virtual double[] GetHandleDirection()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandleDirection_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_GetHandleDirection_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetHandleDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandleDirection_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_GetHandleDirection_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetHandleDirection(IntPtr _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandleDirection_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetHandlePosition_09(HandleRef pThis);

		public virtual double[] GetHandlePosition()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandlePosition_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_GetHandlePosition_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetHandlePosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandlePosition_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_GetHandlePosition_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetHandlePosition(IntPtr _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandlePosition_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetHandleProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandleProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSphereRepresentation_GetHandleText_13(HandleRef pThis);

		public virtual int GetHandleText()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetHandleText_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetHandleTextProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetHandleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandleTextProperty_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_GetHandleVisibility_15(HandleRef pThis);

		public virtual int GetHandleVisibility()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetHandleVisibility_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_GetPhiResolution_16(HandleRef pThis);

		public int GetPhiResolution()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetPhiResolution_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_GetPolyData_17(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetPolyData_17(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_GetRadialLine_18(HandleRef pThis);

		public virtual int GetRadialLine()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRadialLine_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetRadialLineProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetRadialLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetRadialLineProperty_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkSphereRepresentation_GetRadius_20(HandleRef pThis);

		public double GetRadius()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRadius_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_GetRepresentation_21(HandleRef pThis);

		public virtual int GetRepresentation()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRepresentation_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_GetRepresentationMaxValue_22(HandleRef pThis);

		public virtual int GetRepresentationMaxValue()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRepresentationMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_GetRepresentationMinValue_23(HandleRef pThis);

		public virtual int GetRepresentationMinValue()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRepresentationMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetSelectedHandleProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetSelectedHandleProperty_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSphereRepresentation_GetSelectedSphereProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetSelectedSphereProperty_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkSphereRepresentation_GetSphere_26(HandleRef pThis, HandleRef sphere);

		public void GetSphere(vtkSphere sphere)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetSphere_26(base.GetCppThis(), (sphere == null) ? default(HandleRef) : sphere.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_GetSphereProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetSphereProperty_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSphereRepresentation_GetThetaResolution_28(HandleRef pThis);

		public int GetThetaResolution()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetThetaResolution_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_HandleTextOff_29(HandleRef pThis);

		public virtual void HandleTextOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleTextOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_HandleTextOn_30(HandleRef pThis);

		public virtual void HandleTextOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleTextOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_HandleVisibilityOff_31(HandleRef pThis);

		public virtual void HandleVisibilityOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleVisibilityOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_HandleVisibilityOn_32(HandleRef pThis);

		public virtual void HandleVisibilityOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleVisibilityOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_HasTranslucentPolygonalGeometry_33(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_HasTranslucentPolygonalGeometry_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_IsA_34(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_IsA_34(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_IsTypeOf_35(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_IsTypeOf_35(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSphereRepresentation NewInstance()
		{
			vtkSphereRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_NewInstance_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_PlaceWidget_38(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_PlaceWidget_38(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_PlaceWidget_39(HandleRef pThis, IntPtr center, IntPtr handlePosition);

		public virtual void PlaceWidget(IntPtr center, IntPtr handlePosition)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_PlaceWidget_39(base.GetCppThis(), center, handlePosition);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_RadialLineOff_40(HandleRef pThis);

		public virtual void RadialLineOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_RadialLineOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_RadialLineOn_41(HandleRef pThis);

		public virtual void RadialLineOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_RadialLineOn_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_ReleaseGraphicsResources_42(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_ReleaseGraphicsResources_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_RenderOpaqueGeometry_43(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_RenderOpaqueGeometry_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_RenderOverlay_44(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_RenderOverlay_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereRepresentation_RenderTranslucentPolygonalGeometry_45(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_RenderTranslucentPolygonalGeometry_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereRepresentation_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSphereRepresentation vtkSphereRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereRepresentation = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereRepresentation.Register(null);
				}
			}
			return vtkSphereRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetCenter_47(HandleRef pThis, IntPtr c);

		public void SetCenter(IntPtr c)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetCenter_47(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetCenter_48(HandleRef pThis, double x, double y, double z);

		public void SetCenter(double x, double y, double z)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetCenter_48(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetHandleDirection_49(HandleRef pThis, IntPtr dir);

		public void SetHandleDirection(IntPtr dir)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleDirection_49(base.GetCppThis(), dir);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetHandleDirection_50(HandleRef pThis, double dx, double dy, double dz);

		public void SetHandleDirection(double dx, double dy, double dz)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleDirection_50(base.GetCppThis(), dx, dy, dz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetHandlePosition_51(HandleRef pThis, IntPtr handle);

		public void SetHandlePosition(IntPtr handle)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandlePosition_51(base.GetCppThis(), handle);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetHandlePosition_52(HandleRef pThis, double x, double y, double z);

		public void SetHandlePosition(double x, double y, double z)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandlePosition_52(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetHandleText_53(HandleRef pThis, int _arg);

		public virtual void SetHandleText(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleText_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetHandleVisibility_54(HandleRef pThis, int _arg);

		public virtual void SetHandleVisibility(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleVisibility_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetInteractionState_55(HandleRef pThis, int state);

		public void SetInteractionState(int state)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetInteractionState_55(base.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetPhiResolution_56(HandleRef pThis, int r);

		public void SetPhiResolution(int r)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetPhiResolution_56(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetRadialLine_57(HandleRef pThis, int _arg);

		public virtual void SetRadialLine(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRadialLine_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetRadius_58(HandleRef pThis, double r);

		public void SetRadius(double r)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRadius_58(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetRepresentation_59(HandleRef pThis, int _arg);

		public virtual void SetRepresentation(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentation_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetRepresentationToOff_60(HandleRef pThis);

		public void SetRepresentationToOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentationToOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetRepresentationToSurface_61(HandleRef pThis);

		public void SetRepresentationToSurface()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentationToSurface_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetRepresentationToWireframe_62(HandleRef pThis);

		public void SetRepresentationToWireframe()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentationToWireframe_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_SetThetaResolution_63(HandleRef pThis, int r);

		public void SetThetaResolution(int r)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetThetaResolution_63(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_StartWidgetInteraction_64(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_StartWidgetInteraction_64(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereRepresentation_WidgetInteraction_65(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_WidgetInteraction_65(base.GetCppThis(), e);
		}
	}
}
