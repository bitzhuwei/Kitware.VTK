using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoInteractorStyle : vtkInteractorStyleTrackballCamera
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoInteractorStyle";

		public new static readonly string MRClassNameKey;

		static vtkGeoInteractorStyle()
		{
			vtkGeoInteractorStyle.MRClassNameKey = "class vtkGeoInteractorStyle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoInteractorStyle"));
		}

		public vtkGeoInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoInteractorStyle New()
		{
			vtkGeoInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoInteractorStyle.vtkGeoInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoInteractorStyle.vtkGeoInteractorStyle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_Dolly_01(HandleRef pThis);

		public override void Dolly()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_Dolly_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoInteractorStyle_GetGeoCamera_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoCamera GetGeoCamera()
		{
			vtkGeoCamera vtkGeoCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoInteractorStyle.vtkGeoInteractorStyle_GetGeoCamera_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoCamera = (vtkGeoCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoCamera.Register(null);
				}
			}
			return vtkGeoCamera;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoInteractorStyle_GetLockHeading_03(HandleRef pThis);

		public virtual bool GetLockHeading()
		{
			return vtkGeoInteractorStyle.vtkGeoInteractorStyle_GetLockHeading_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoInteractorStyle_GetRayIntersection_04(HandleRef pThis, IntPtr origin, IntPtr direction, IntPtr intersection);

		public int GetRayIntersection(IntPtr origin, IntPtr direction, IntPtr intersection)
		{
			return vtkGeoInteractorStyle.vtkGeoInteractorStyle_GetRayIntersection_04(base.GetCppThis(), origin, direction, intersection);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoInteractorStyle_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoInteractorStyle.vtkGeoInteractorStyle_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoInteractorStyle_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoInteractorStyle.vtkGeoInteractorStyle_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_LockHeadingOff_07(HandleRef pThis);

		public virtual void LockHeadingOff()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_LockHeadingOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_LockHeadingOn_08(HandleRef pThis);

		public virtual void LockHeadingOn()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_LockHeadingOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoInteractorStyle_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoInteractorStyle NewInstance()
		{
			vtkGeoInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoInteractorStyle.vtkGeoInteractorStyle_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnChar_11(HandleRef pThis);

		public override void OnChar()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnChar_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnEnter_12(HandleRef pThis);

		public override void OnEnter()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnEnter_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnLeave_13(HandleRef pThis);

		public override void OnLeave()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnLeave_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnLeftButtonDown_14(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnLeftButtonDown_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnLeftButtonUp_15(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnLeftButtonUp_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnMiddleButtonDown_16(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnMiddleButtonDown_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnMiddleButtonUp_17(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnMiddleButtonUp_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnMouseMove_18(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnMouseMove_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnRightButtonDown_19(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnRightButtonDown_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_OnRightButtonUp_20(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_OnRightButtonUp_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_Pan_21(HandleRef pThis);

		public override void Pan()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_Pan_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_RedrawRectangle_22(HandleRef pThis);

		public void RedrawRectangle()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_RedrawRectangle_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_ResetCamera_23(HandleRef pThis);

		public void ResetCamera()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_ResetCamera_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_ResetCameraClippingRange_24(HandleRef pThis);

		public void ResetCameraClippingRange()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_ResetCameraClippingRange_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_RubberBandZoom_25(HandleRef pThis);

		public virtual void RubberBandZoom()
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_RubberBandZoom_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoInteractorStyle_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkGeoInteractorStyle vtkGeoInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoInteractorStyle.vtkGeoInteractorStyle_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoInteractorStyle = (vtkGeoInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoInteractorStyle.Register(null);
				}
			}
			return vtkGeoInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_SetCurrentRenderer_27(HandleRef pThis, HandleRef arg0);

		public override void SetCurrentRenderer(vtkRenderer arg0)
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_SetCurrentRenderer_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_SetInteractor_28(HandleRef pThis, HandleRef interactor);

		public override void SetInteractor(vtkRenderWindowInteractor interactor)
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_SetInteractor_28(base.GetCppThis(), (interactor == null) ? default(HandleRef) : interactor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_SetLockHeading_29(HandleRef pThis, byte _arg);

		public virtual void SetLockHeading(bool _arg)
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_SetLockHeading_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_StartState_30(HandleRef pThis, int newstate);

		public override void StartState(int newstate)
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_StartState_30(base.GetCppThis(), newstate);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_ViewportToLongLat_31(HandleRef pThis, double x, double y, ref double lon, ref double lat);

		public void ViewportToLongLat(double x, double y, ref double lon, ref double lat)
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_ViewportToLongLat_31(base.GetCppThis(), x, y, ref lon, ref lat);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoInteractorStyle_ViewportToWorld_32(HandleRef pThis, double x, double y, ref double wx, ref double wy, ref double wz);

		public int ViewportToWorld(double x, double y, ref double wx, ref double wy, ref double wz)
		{
			return vtkGeoInteractorStyle.vtkGeoInteractorStyle_ViewportToWorld_32(base.GetCppThis(), x, y, ref wx, ref wy, ref wz);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_WidgetInteraction_33(HandleRef pThis, HandleRef caller);

		public void WidgetInteraction(vtkObject caller)
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_WidgetInteraction_33(base.GetCppThis(), (caller == null) ? default(HandleRef) : caller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoInteractorStyle_WorldToLongLat_34(HandleRef pThis, double wx, double wy, double wz, ref double lon, ref double lat);

		public void WorldToLongLat(double wx, double wy, double wz, ref double lon, ref double lat)
		{
			vtkGeoInteractorStyle.vtkGeoInteractorStyle_WorldToLongLat_34(base.GetCppThis(), wx, wy, wz, ref lon, ref lat);
		}
	}
}
