using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSplineWidget : vtk3DWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineWidget";

		public new static readonly string MRClassNameKey;

		static vtkSplineWidget()
		{
			vtkSplineWidget.MRClassNameKey = "class vtkSplineWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineWidget"));
		}

		public vtkSplineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineWidget New()
		{
			vtkSplineWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSplineWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSplineWidget.vtkSplineWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_ClosedOff_01(HandleRef pThis);

		public virtual void ClosedOff()
		{
			vtkSplineWidget.vtkSplineWidget_ClosedOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_ClosedOn_02(HandleRef pThis);

		public virtual void ClosedOn()
		{
			vtkSplineWidget.vtkSplineWidget_ClosedOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetClosed_03(HandleRef pThis);

		public virtual int GetClosed()
		{
			return vtkSplineWidget.vtkSplineWidget_GetClosed_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_GetHandlePosition_04(HandleRef pThis, int handle, IntPtr xyz);

		public void GetHandlePosition(int handle, IntPtr xyz)
		{
			vtkSplineWidget.vtkSplineWidget_GetHandlePosition_04(base.GetCppThis(), handle, xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget_GetHandlePosition_05(HandleRef pThis, int handle);

		public double[] GetHandlePosition(int handle)
		{
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetHandlePosition_05(base.GetCppThis(), handle);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget_GetHandleProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetHandleProperty_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSplineWidget_GetLineProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetLineProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSplineWidget_GetNumberOfHandles_08(HandleRef pThis);

		public virtual int GetNumberOfHandles()
		{
			return vtkSplineWidget.vtkSplineWidget_GetNumberOfHandles_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget_GetParametricSpline_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkParametricSpline GetParametricSpline()
		{
			vtkParametricSpline vtkParametricSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetParametricSpline_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSpline = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSpline.Register(null);
				}
			}
			return vtkParametricSpline;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_GetPolyData_10(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkSplineWidget.vtkSplineWidget_GetPolyData_10(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetProcessEvents_11(HandleRef pThis);

		public virtual int GetProcessEvents()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProcessEvents_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetProcessEventsMaxValue_12(HandleRef pThis);

		public virtual int GetProcessEventsMaxValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProcessEventsMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetProcessEventsMinValue_13(HandleRef pThis);

		public virtual int GetProcessEventsMinValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProcessEventsMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetProjectToPlane_14(HandleRef pThis);

		public virtual int GetProjectToPlane()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectToPlane_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetProjectionNormal_15(HandleRef pThis);

		public virtual int GetProjectionNormal()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionNormal_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetProjectionNormalMaxValue_16(HandleRef pThis);

		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionNormalMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetProjectionNormalMinValue_17(HandleRef pThis);

		public virtual int GetProjectionNormalMinValue()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionNormalMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSplineWidget_GetProjectionPosition_18(HandleRef pThis);

		public virtual double GetProjectionPosition()
		{
			return vtkSplineWidget.vtkSplineWidget_GetProjectionPosition_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_GetResolution_19(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkSplineWidget.vtkSplineWidget_GetResolution_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget_GetSelectedHandleProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetSelectedHandleProperty_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSplineWidget_GetSelectedLineProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_GetSelectedLineProperty_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkSplineWidget_GetSummedLength_22(HandleRef pThis);

		public double GetSummedLength()
		{
			return vtkSplineWidget.vtkSplineWidget_GetSummedLength_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_InitializeHandles_23(HandleRef pThis, HandleRef points);

		public void InitializeHandles(vtkPoints points)
		{
			vtkSplineWidget.vtkSplineWidget_InitializeHandles_23(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSplineWidget.vtkSplineWidget_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_IsClosed_25(HandleRef pThis);

		public int IsClosed()
		{
			return vtkSplineWidget.vtkSplineWidget_IsClosed_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSplineWidget.vtkSplineWidget_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSplineWidget NewInstance()
		{
			vtkSplineWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_PlaceWidget_29(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSplineWidget.vtkSplineWidget_PlaceWidget_29(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_PlaceWidget_30(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkSplineWidget.vtkSplineWidget_PlaceWidget_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_PlaceWidget_31(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkSplineWidget.vtkSplineWidget_PlaceWidget_31(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_ProcessEventsOff_32(HandleRef pThis);

		public virtual void ProcessEventsOff()
		{
			vtkSplineWidget.vtkSplineWidget_ProcessEventsOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_ProcessEventsOn_33(HandleRef pThis);

		public virtual void ProcessEventsOn()
		{
			vtkSplineWidget.vtkSplineWidget_ProcessEventsOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_ProjectToPlaneOff_34(HandleRef pThis);

		public virtual void ProjectToPlaneOff()
		{
			vtkSplineWidget.vtkSplineWidget_ProjectToPlaneOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_ProjectToPlaneOn_35(HandleRef pThis);

		public virtual void ProjectToPlaneOn()
		{
			vtkSplineWidget.vtkSplineWidget_ProjectToPlaneOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSplineWidget vtkSplineWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget.vtkSplineWidget_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineWidget = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineWidget.Register(null);
				}
			}
			return vtkSplineWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetClosed_37(HandleRef pThis, int closed);

		public void SetClosed(int closed)
		{
			vtkSplineWidget.vtkSplineWidget_SetClosed_37(base.GetCppThis(), closed);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetEnabled_38(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetEnabled_38(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetHandlePosition_39(HandleRef pThis, int handle, double x, double y, double z);

		public void SetHandlePosition(int handle, double x, double y, double z)
		{
			vtkSplineWidget.vtkSplineWidget_SetHandlePosition_39(base.GetCppThis(), handle, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetHandlePosition_40(HandleRef pThis, int handle, IntPtr xyz);

		public void SetHandlePosition(int handle, IntPtr xyz)
		{
			vtkSplineWidget.vtkSplineWidget_SetHandlePosition_40(base.GetCppThis(), handle, xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetHandleProperty_41(HandleRef pThis, HandleRef arg0);

		public virtual void SetHandleProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetHandleProperty_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetLineProperty_42(HandleRef pThis, HandleRef arg0);

		public virtual void SetLineProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetLineProperty_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetNumberOfHandles_43(HandleRef pThis, int npts);

		public virtual void SetNumberOfHandles(int npts)
		{
			vtkSplineWidget.vtkSplineWidget_SetNumberOfHandles_43(base.GetCppThis(), npts);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetParametricSpline_44(HandleRef pThis, HandleRef arg0);

		public virtual void SetParametricSpline(vtkParametricSpline arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetParametricSpline_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetPlaneSource_45(HandleRef pThis, HandleRef plane);

		public void SetPlaneSource(vtkPlaneSource plane)
		{
			vtkSplineWidget.vtkSplineWidget_SetPlaneSource_45(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProcessEvents_46(HandleRef pThis, int _arg);

		public virtual void SetProcessEvents(int _arg)
		{
			vtkSplineWidget.vtkSplineWidget_SetProcessEvents_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProjectToPlane_47(HandleRef pThis, int _arg);

		public virtual void SetProjectToPlane(int _arg)
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectToPlane_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProjectionNormal_48(HandleRef pThis, int _arg);

		public virtual void SetProjectionNormal(int _arg)
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormal_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProjectionNormalToOblique_49(HandleRef pThis);

		public void SetProjectionNormalToOblique()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToOblique_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProjectionNormalToXAxes_50(HandleRef pThis);

		public void SetProjectionNormalToXAxes()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToXAxes_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProjectionNormalToYAxes_51(HandleRef pThis);

		public void SetProjectionNormalToYAxes()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToYAxes_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProjectionNormalToZAxes_52(HandleRef pThis);

		public void SetProjectionNormalToZAxes()
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionNormalToZAxes_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetProjectionPosition_53(HandleRef pThis, double position);

		public void SetProjectionPosition(double position)
		{
			vtkSplineWidget.vtkSplineWidget_SetProjectionPosition_53(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetResolution_54(HandleRef pThis, int resolution);

		public void SetResolution(int resolution)
		{
			vtkSplineWidget.vtkSplineWidget_SetResolution_54(base.GetCppThis(), resolution);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetSelectedHandleProperty_55(HandleRef pThis, HandleRef arg0);

		public virtual void SetSelectedHandleProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetSelectedHandleProperty_55(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget_SetSelectedLineProperty_56(HandleRef pThis, HandleRef arg0);

		public virtual void SetSelectedLineProperty(vtkProperty arg0)
		{
			vtkSplineWidget.vtkSplineWidget_SetSelectedLineProperty_56(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
