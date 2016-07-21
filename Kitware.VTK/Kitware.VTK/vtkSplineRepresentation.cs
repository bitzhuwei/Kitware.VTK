using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSplineRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			Erasing = 7,
			Inserting = 6,
			Moving = 3,
			OnHandle = 1,
			OnLine,
			Outside = 0,
			Scaling = 4,
			Spinning
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkSplineRepresentation()
		{
			vtkSplineRepresentation.MRClassNameKey = "class vtkSplineRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineRepresentation"));
		}

		public vtkSplineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineRepresentation New()
		{
			vtkSplineRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSplineRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSplineRepresentation.vtkSplineRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_ClosedOff_02(HandleRef pThis);

		public virtual void ClosedOff()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_ClosedOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_ClosedOn_03(HandleRef pThis);

		public virtual void ClosedOn()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_ClosedOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_EndWidgetInteraction_05(HandleRef pThis, IntPtr e);

		public override void EndWidgetInteraction(IntPtr e)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_EndWidgetInteraction_05(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_GetBounds_06(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_GetClosed_07(HandleRef pThis);

		public virtual int GetClosed()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetClosed_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_GetHandlePosition_08(HandleRef pThis, int handle, IntPtr xyz);

		public void GetHandlePosition(int handle, IntPtr xyz)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_GetHandlePosition_08(base.GetCppThis(), handle, xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_GetHandlePosition_09(HandleRef pThis, int handle);

		public IntPtr GetHandlePosition(int handle)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetHandlePosition_09(base.GetCppThis(), handle);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_GetHandlePositions_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDoubleArray GetHandlePositions()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_GetHandlePositions_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_GetHandleProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_GetHandleProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSplineRepresentation_GetLineProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_GetLineProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSplineRepresentation_GetNumberOfHandles_13(HandleRef pThis);

		public virtual int GetNumberOfHandles()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetNumberOfHandles_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_GetParametricSpline_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkParametricSpline GetParametricSpline()
		{
			vtkParametricSpline vtkParametricSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_GetParametricSpline_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkSplineRepresentation_GetPolyData_15(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_GetPolyData_15(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_GetProjectToPlane_16(HandleRef pThis);

		public virtual int GetProjectToPlane()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetProjectToPlane_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_GetProjectionNormal_17(HandleRef pThis);

		public virtual int GetProjectionNormal()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetProjectionNormal_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_GetProjectionNormalMaxValue_18(HandleRef pThis);

		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetProjectionNormalMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_GetProjectionNormalMinValue_19(HandleRef pThis);

		public virtual int GetProjectionNormalMinValue()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetProjectionNormalMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSplineRepresentation_GetProjectionPosition_20(HandleRef pThis);

		public virtual double GetProjectionPosition()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetProjectionPosition_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_GetResolution_21(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetResolution_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_GetSelectedHandleProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_GetSelectedHandleProperty_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSplineRepresentation_GetSelectedLineProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_GetSelectedLineProperty_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkSplineRepresentation_GetSummedLength_24(HandleRef pThis);

		public double GetSummedLength()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetSummedLength_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_HasTranslucentPolygonalGeometry_25(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_HasTranslucentPolygonalGeometry_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_InitializeHandles_26(HandleRef pThis, HandleRef points);

		public void InitializeHandles(vtkPoints points)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_InitializeHandles_26(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_IsClosed_28(HandleRef pThis);

		public int IsClosed()
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_IsClosed_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSplineRepresentation NewInstance()
		{
			vtkSplineRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_ProjectToPlaneOff_32(HandleRef pThis);

		public virtual void ProjectToPlaneOff()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_ProjectToPlaneOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_ProjectToPlaneOn_33(HandleRef pThis);

		public virtual void ProjectToPlaneOn()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_ProjectToPlaneOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_ReleaseGraphicsResources_34(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_ReleaseGraphicsResources_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_RenderOpaqueGeometry_35(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_RenderOpaqueGeometry_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_RenderOverlay_36(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_RenderOverlay_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineRepresentation_RenderTranslucentPolygonalGeometry_37(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_RenderTranslucentPolygonalGeometry_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineRepresentation_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSplineRepresentation vtkSplineRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineRepresentation = (vtkSplineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineRepresentation.Register(null);
				}
			}
			return vtkSplineRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetClosed_39(HandleRef pThis, int closed);

		public void SetClosed(int closed)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetClosed_39(base.GetCppThis(), closed);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetHandlePosition_40(HandleRef pThis, int handle, double x, double y, double z);

		public void SetHandlePosition(int handle, double x, double y, double z)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetHandlePosition_40(base.GetCppThis(), handle, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetHandlePosition_41(HandleRef pThis, int handle, IntPtr xyz);

		public void SetHandlePosition(int handle, IntPtr xyz)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetHandlePosition_41(base.GetCppThis(), handle, xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetInteractionState_42(HandleRef pThis, int _arg);

		public virtual void SetInteractionState(int _arg)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetInteractionState_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetLineColor_43(HandleRef pThis, double r, double g, double b);

		public void SetLineColor(double r, double g, double b)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetLineColor_43(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetNumberOfHandles_44(HandleRef pThis, int npts);

		public virtual void SetNumberOfHandles(int npts)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetNumberOfHandles_44(base.GetCppThis(), npts);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetParametricSpline_45(HandleRef pThis, HandleRef arg0);

		public virtual void SetParametricSpline(vtkParametricSpline arg0)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetParametricSpline_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetPlaneSource_46(HandleRef pThis, HandleRef plane);

		public void SetPlaneSource(vtkPlaneSource plane)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetPlaneSource_46(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetProjectToPlane_47(HandleRef pThis, int _arg);

		public virtual void SetProjectToPlane(int _arg)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetProjectToPlane_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetProjectionNormal_48(HandleRef pThis, int _arg);

		public virtual void SetProjectionNormal(int _arg)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetProjectionNormal_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetProjectionNormalToOblique_49(HandleRef pThis);

		public void SetProjectionNormalToOblique()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetProjectionNormalToOblique_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetProjectionNormalToXAxes_50(HandleRef pThis);

		public void SetProjectionNormalToXAxes()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetProjectionNormalToXAxes_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetProjectionNormalToYAxes_51(HandleRef pThis);

		public void SetProjectionNormalToYAxes()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetProjectionNormalToYAxes_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetProjectionNormalToZAxes_52(HandleRef pThis);

		public void SetProjectionNormalToZAxes()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetProjectionNormalToZAxes_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetProjectionPosition_53(HandleRef pThis, double position);

		public void SetProjectionPosition(double position)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetProjectionPosition_53(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_SetResolution_54(HandleRef pThis, int resolution);

		public void SetResolution(int resolution)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetResolution_54(base.GetCppThis(), resolution);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_StartWidgetInteraction_55(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_StartWidgetInteraction_55(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineRepresentation_WidgetInteraction_56(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_WidgetInteraction_56(base.GetCppThis(), e);
		}
	}
}
