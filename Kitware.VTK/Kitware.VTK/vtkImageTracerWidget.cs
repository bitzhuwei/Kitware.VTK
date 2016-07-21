using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageTracerWidget : vtk3DWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageTracerWidget";

		public new static readonly string MRClassNameKey;

		static vtkImageTracerWidget()
		{
			vtkImageTracerWidget.MRClassNameKey = "class vtkImageTracerWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageTracerWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTracerWidget"));
		}

		public vtkImageTracerWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageTracerWidget New()
		{
			vtkImageTracerWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageTracerWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageTracerWidget.vtkImageTracerWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_AutoCloseOff_01(HandleRef pThis);

		public virtual void AutoCloseOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_AutoCloseOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_AutoCloseOn_02(HandleRef pThis);

		public virtual void AutoCloseOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_AutoCloseOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetAutoClose_03(HandleRef pThis);

		public virtual int GetAutoClose()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetAutoClose_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImageTracerWidget_GetCaptureRadius_04(HandleRef pThis);

		public virtual double GetCaptureRadius()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetCaptureRadius_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_GetGlyphSource_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGlyphSource2D GetGlyphSource()
		{
			vtkGlyphSource2D vtkGlyphSource2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetGlyphSource_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyphSource2D = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyphSource2D.Register(null);
				}
			}
			return vtkGlyphSource2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetHandleLeftMouseButton_06(HandleRef pThis);

		public virtual int GetHandleLeftMouseButton()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetHandleLeftMouseButton_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetHandleMiddleMouseButton_07(HandleRef pThis);

		public virtual int GetHandleMiddleMouseButton()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetHandleMiddleMouseButton_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_GetHandlePosition_08(HandleRef pThis, int handle, IntPtr xyz);

		public void GetHandlePosition(int handle, IntPtr xyz)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_GetHandlePosition_08(base.GetCppThis(), handle, xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_GetHandlePosition_09(HandleRef pThis, int handle);

		public double[] GetHandlePosition(int handle)
		{
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetHandlePosition_09(base.GetCppThis(), handle);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_GetHandleProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetHandleProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageTracerWidget_GetHandleRightMouseButton_11(HandleRef pThis);

		public virtual int GetHandleRightMouseButton()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetHandleRightMouseButton_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetImageSnapType_12(HandleRef pThis);

		public virtual int GetImageSnapType()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetImageSnapType_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetImageSnapTypeMaxValue_13(HandleRef pThis);

		public virtual int GetImageSnapTypeMaxValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetImageSnapTypeMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetImageSnapTypeMinValue_14(HandleRef pThis);

		public virtual int GetImageSnapTypeMinValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetImageSnapTypeMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetInteraction_15(HandleRef pThis);

		public virtual int GetInteraction()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetInteraction_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_GetLineProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetLineProperty_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageTracerWidget_GetNumberOfHandles_17(HandleRef pThis);

		public virtual int GetNumberOfHandles()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetNumberOfHandles_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_GetPath_18(HandleRef pThis, HandleRef pd);

		public void GetPath(vtkPolyData pd)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_GetPath_18(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetProjectToPlane_19(HandleRef pThis);

		public virtual int GetProjectToPlane()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectToPlane_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetProjectionNormal_20(HandleRef pThis);

		public virtual int GetProjectionNormal()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionNormal_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetProjectionNormalMaxValue_21(HandleRef pThis);

		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionNormalMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_GetProjectionNormalMinValue_22(HandleRef pThis);

		public virtual int GetProjectionNormalMinValue()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionNormalMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImageTracerWidget_GetProjectionPosition_23(HandleRef pThis);

		public virtual double GetProjectionPosition()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetProjectionPosition_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_GetSelectedHandleProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetSelectedHandleProperty_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageTracerWidget_GetSelectedLineProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_GetSelectedLineProperty_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageTracerWidget_GetSnapToImage_26(HandleRef pThis);

		public virtual int GetSnapToImage()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_GetSnapToImage_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_HandleLeftMouseButtonOff_27(HandleRef pThis);

		public virtual void HandleLeftMouseButtonOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleLeftMouseButtonOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_HandleLeftMouseButtonOn_28(HandleRef pThis);

		public virtual void HandleLeftMouseButtonOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleLeftMouseButtonOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_HandleMiddleMouseButtonOff_29(HandleRef pThis);

		public virtual void HandleMiddleMouseButtonOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleMiddleMouseButtonOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_HandleMiddleMouseButtonOn_30(HandleRef pThis);

		public virtual void HandleMiddleMouseButtonOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleMiddleMouseButtonOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_HandleRightMouseButtonOff_31(HandleRef pThis);

		public virtual void HandleRightMouseButtonOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleRightMouseButtonOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_HandleRightMouseButtonOn_32(HandleRef pThis);

		public virtual void HandleRightMouseButtonOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_HandleRightMouseButtonOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_InitializeHandles_33(HandleRef pThis, HandleRef arg0);

		public void InitializeHandles(vtkPoints arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_InitializeHandles_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_InteractionOff_34(HandleRef pThis);

		public virtual void InteractionOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_InteractionOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_InteractionOn_35(HandleRef pThis);

		public virtual void InteractionOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_InteractionOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_IsA_36(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_IsA_36(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_IsClosed_37(HandleRef pThis);

		public int IsClosed()
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_IsClosed_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageTracerWidget_IsTypeOf_38(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageTracerWidget.vtkImageTracerWidget_IsTypeOf_38(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageTracerWidget NewInstance()
		{
			vtkImageTracerWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_NewInstance_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_PlaceWidget_41(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_PlaceWidget_41(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_PlaceWidget_42(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_PlaceWidget_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_PlaceWidget_43(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_PlaceWidget_43(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_ProjectToPlaneOff_44(HandleRef pThis);

		public virtual void ProjectToPlaneOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_ProjectToPlaneOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_ProjectToPlaneOn_45(HandleRef pThis);

		public virtual void ProjectToPlaneOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_ProjectToPlaneOn_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTracerWidget_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageTracerWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImageTracerWidget vtkImageTracerWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTracerWidget.vtkImageTracerWidget_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageTracerWidget = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageTracerWidget.Register(null);
				}
			}
			return vtkImageTracerWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetAutoClose_47(HandleRef pThis, int _arg);

		public virtual void SetAutoClose(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetAutoClose_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetCaptureRadius_48(HandleRef pThis, double _arg);

		public virtual void SetCaptureRadius(double _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetCaptureRadius_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetEnabled_49(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetEnabled_49(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetHandleLeftMouseButton_50(HandleRef pThis, int _arg);

		public virtual void SetHandleLeftMouseButton(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleLeftMouseButton_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetHandleMiddleMouseButton_51(HandleRef pThis, int _arg);

		public virtual void SetHandleMiddleMouseButton(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleMiddleMouseButton_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetHandlePosition_52(HandleRef pThis, int handle, IntPtr xyz);

		public void SetHandlePosition(int handle, IntPtr xyz)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandlePosition_52(base.GetCppThis(), handle, xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetHandlePosition_53(HandleRef pThis, int handle, double x, double y, double z);

		public void SetHandlePosition(int handle, double x, double y, double z)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandlePosition_53(base.GetCppThis(), handle, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetHandleProperty_54(HandleRef pThis, HandleRef arg0);

		public virtual void SetHandleProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleProperty_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetHandleRightMouseButton_55(HandleRef pThis, int _arg);

		public virtual void SetHandleRightMouseButton(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetHandleRightMouseButton_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetImageSnapType_56(HandleRef pThis, int _arg);

		public virtual void SetImageSnapType(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetImageSnapType_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetInteraction_57(HandleRef pThis, int interact);

		public void SetInteraction(int interact)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetInteraction_57(base.GetCppThis(), interact);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetLineProperty_58(HandleRef pThis, HandleRef arg0);

		public virtual void SetLineProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetLineProperty_58(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetProjectToPlane_59(HandleRef pThis, int _arg);

		public virtual void SetProjectToPlane(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectToPlane_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetProjectionNormal_60(HandleRef pThis, int _arg);

		public virtual void SetProjectionNormal(int _arg)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormal_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetProjectionNormalToXAxes_61(HandleRef pThis);

		public void SetProjectionNormalToXAxes()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormalToXAxes_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetProjectionNormalToYAxes_62(HandleRef pThis);

		public void SetProjectionNormalToYAxes()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormalToYAxes_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetProjectionNormalToZAxes_63(HandleRef pThis);

		public void SetProjectionNormalToZAxes()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionNormalToZAxes_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetProjectionPosition_64(HandleRef pThis, double position);

		public void SetProjectionPosition(double position)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetProjectionPosition_64(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetSelectedHandleProperty_65(HandleRef pThis, HandleRef arg0);

		public virtual void SetSelectedHandleProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetSelectedHandleProperty_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetSelectedLineProperty_66(HandleRef pThis, HandleRef arg0);

		public virtual void SetSelectedLineProperty(vtkProperty arg0)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetSelectedLineProperty_66(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetSnapToImage_67(HandleRef pThis, int snap);

		public void SetSnapToImage(int snap)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetSnapToImage_67(base.GetCppThis(), snap);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SetViewProp_68(HandleRef pThis, HandleRef prop);

		public void SetViewProp(vtkProp prop)
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SetViewProp_68(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SnapToImageOff_69(HandleRef pThis);

		public virtual void SnapToImageOff()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SnapToImageOff_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageTracerWidget_SnapToImageOn_70(HandleRef pThis);

		public virtual void SnapToImageOn()
		{
			vtkImageTracerWidget.vtkImageTracerWidget_SnapToImageOn_70(base.GetCppThis());
		}
	}
}
