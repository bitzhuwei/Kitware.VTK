using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConstrainedPointHandleRepresentation : vtkHandleRepresentation
	{
		public enum Oblique_WrapperEnum
		{
			Oblique = 3,
			XAxis = 0,
			YAxis,
			ZAxis
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkConstrainedPointHandleRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkConstrainedPointHandleRepresentation()
		{
			vtkConstrainedPointHandleRepresentation.MRClassNameKey = "class vtkConstrainedPointHandleRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConstrainedPointHandleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConstrainedPointHandleRepresentation"));
		}

		public vtkConstrainedPointHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConstrainedPointHandleRepresentation New()
		{
			vtkConstrainedPointHandleRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConstrainedPointHandleRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

		public void AddBoundingPlane(vtkPlane plane)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_AddBoundingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_BuildRepresentation_02(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_BuildRepresentation_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_CheckConstraint_03(HandleRef pThis, HandleRef renderer, IntPtr pos);

		public override int CheckConstraint(vtkRenderer renderer, IntPtr pos)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_CheckConstraint_03(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetActiveCursorShape_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetActiveCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetActiveCursorShape_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetActiveProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetActiveProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetActiveProperty_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkConstrainedPointHandleRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetActors_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetBoundingPlanes_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlaneCollection GetBoundingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetBoundingPlanes_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetCursorShape_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetCursorShape_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetObliquePlane_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlane GetObliquePlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetObliquePlane_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetPosition_11(HandleRef pThis);

		public IntPtr GetPosition()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetPosition_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_GetPosition_12(HandleRef pThis, IntPtr xyz);

		public void GetPosition(IntPtr xyz)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetPosition_12(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormal_13(HandleRef pThis);

		public virtual int GetProjectionNormal()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionNormal_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormalMaxValue_14(HandleRef pThis);

		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionNormalMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormalMinValue_15(HandleRef pThis);

		public virtual int GetProjectionNormalMinValue()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionNormalMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkConstrainedPointHandleRepresentation_GetProjectionPosition_16(HandleRef pThis);

		public virtual double GetProjectionPosition()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionPosition_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProperty_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetSelectedProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetSelectedProperty_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkConstrainedPointHandleRepresentation_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_HasTranslucentPolygonalGeometry_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_Highlight_20(HandleRef pThis, int highlight);

		public override void Highlight(int highlight)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_Highlight_20(base.GetCppThis(), highlight);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConstrainedPointHandleRepresentation NewInstance()
		{
			vtkConstrainedPointHandleRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_ReleaseGraphicsResources_25(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_ReleaseGraphicsResources_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_RemoveAllBoundingPlanes_26(HandleRef pThis);

		public void RemoveAllBoundingPlanes()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RemoveAllBoundingPlanes_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_RemoveBoundingPlane_27(HandleRef pThis, HandleRef plane);

		public void RemoveBoundingPlane(vtkPlane plane)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RemoveBoundingPlane_27(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_RenderOpaqueGeometry_28(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RenderOpaqueGeometry_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_RenderOverlay_29(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RenderOverlay_29(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkConstrainedPointHandleRepresentation_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RenderTranslucentPolygonalGeometry_30(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConstrainedPointHandleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkConstrainedPointHandleRepresentation vtkConstrainedPointHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConstrainedPointHandleRepresentation = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConstrainedPointHandleRepresentation.Register(null);
				}
			}
			return vtkConstrainedPointHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetActiveCursorShape_32(HandleRef pThis, HandleRef activeShape);

		public void SetActiveCursorShape(vtkPolyData activeShape)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetActiveCursorShape_32(base.GetCppThis(), (activeShape == null) ? default(HandleRef) : activeShape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_33(HandleRef pThis, HandleRef arg0);

		public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_34(HandleRef pThis, HandleRef planes);

		public void SetBoundingPlanes(vtkPlanes planes)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_34(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetCursorShape_35(HandleRef pThis, HandleRef cursorShape);

		public void SetCursorShape(vtkPolyData cursorShape)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetCursorShape_35(base.GetCppThis(), (cursorShape == null) ? default(HandleRef) : cursorShape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetDisplayPosition_36(HandleRef pThis, IntPtr pos);

		public override void SetDisplayPosition(IntPtr pos)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetDisplayPosition_36(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetObliquePlane_37(HandleRef pThis, HandleRef arg0);

		public void SetObliquePlane(vtkPlane arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetObliquePlane_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetPosition_38(HandleRef pThis, double x, double y, double z);

		public void SetPosition(double x, double y, double z)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetPosition_38(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetPosition_39(HandleRef pThis, IntPtr xyz);

		public void SetPosition(IntPtr xyz)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetPosition_39(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormal_40(HandleRef pThis, int _arg);

		public virtual void SetProjectionNormal(int _arg)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormal_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToOblique_41(HandleRef pThis);

		public void SetProjectionNormalToOblique()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToOblique_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToXAxis_42(HandleRef pThis);

		public void SetProjectionNormalToXAxis()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToXAxis_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToYAxis_43(HandleRef pThis);

		public void SetProjectionNormalToYAxis()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToYAxis_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToZAxis_44(HandleRef pThis);

		public void SetProjectionNormalToZAxis()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToZAxis_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionPosition_45(HandleRef pThis, double position);

		public void SetProjectionPosition(double position)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionPosition_45(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetRenderer_46(HandleRef pThis, HandleRef ren);

		public override void SetRenderer(vtkRenderer ren)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetRenderer_46(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_ShallowCopy_47(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_ShallowCopy_47(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_StartWidgetInteraction_48(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_StartWidgetInteraction_48(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkConstrainedPointHandleRepresentation_WidgetInteraction_49(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_WidgetInteraction_49(base.GetCppThis(), eventPos);
		}
	}
}
