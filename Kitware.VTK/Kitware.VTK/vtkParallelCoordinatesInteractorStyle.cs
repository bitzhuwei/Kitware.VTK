using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelCoordinatesInteractorStyle : vtkInteractorStyleTrackballCamera
	{
		public enum INTERACT_HOVER_WrapperEnum
		{
			INTERACT_HOVER,
			INTERACT_INSPECT,
			INTERACT_PAN = 3,
			INTERACT_ZOOM = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesInteractorStyle";

		public new static readonly string MRClassNameKey;

		static vtkParallelCoordinatesInteractorStyle()
		{
			vtkParallelCoordinatesInteractorStyle.MRClassNameKey = "class vtkParallelCoordinatesInteractorStyle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesInteractorStyle"));
		}

		public vtkParallelCoordinatesInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesInteractorStyle New()
		{
			vtkParallelCoordinatesInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelCoordinatesInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_EndInspect_01(HandleRef pThis);

		public virtual void EndInspect()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_EndInspect_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_EndPan_02(HandleRef pThis);

		public override void EndPan()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_EndPan_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_EndZoom_03(HandleRef pThis);

		public override void EndZoom()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_EndZoom_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_04(HandleRef pThis);

		public virtual int[] GetCursorCurrentPosition()
		{
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_05(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetCursorCurrentPosition(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetCursorCurrentPosition(IntPtr _arg)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_07(HandleRef pThis, HandleRef viewport, IntPtr pos);

		public void GetCursorCurrentPosition(vtkViewport viewport, IntPtr pos)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_07(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_08(HandleRef pThis);

		public virtual int[] GetCursorLastPosition()
		{
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetCursorLastPosition(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetCursorLastPosition(IntPtr _arg)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_11(HandleRef pThis, HandleRef viewport, IntPtr pos);

		public void GetCursorLastPosition(vtkViewport viewport, IntPtr pos)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_12(HandleRef pThis);

		public virtual int[] GetCursorStartPosition()
		{
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_13(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetCursorStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_13(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetCursorStartPosition(IntPtr _arg)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_15(HandleRef pThis, HandleRef viewport, IntPtr pos);

		public void GetCursorStartPosition(vtkViewport viewport, IntPtr pos)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_15(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_Inspect_16(HandleRef pThis, int x, int y);

		public virtual void Inspect(int x, int y)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_Inspect_16(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesInteractorStyle_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesInteractorStyle_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelCoordinatesInteractorStyle NewInstance()
		{
			vtkParallelCoordinatesInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnChar_21(HandleRef pThis);

		public override void OnChar()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnChar_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeave_22(HandleRef pThis);

		public override void OnLeave()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnLeave_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeftButtonDown_23(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnLeftButtonDown_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeftButtonUp_24(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnLeftButtonUp_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnMiddleButtonDown_25(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnMiddleButtonDown_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnMiddleButtonUp_26(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnMiddleButtonUp_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnMouseMove_27(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnMouseMove_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnRightButtonDown_28(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnRightButtonDown_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_OnRightButtonUp_29(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_OnRightButtonUp_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_Pan_30(HandleRef pThis);

		public override void Pan()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_Pan_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesInteractorStyle vtkParallelCoordinatesInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesInteractorStyle = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesInteractorStyle.Register(null);
				}
			}
			return vtkParallelCoordinatesInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_StartInspect_32(HandleRef pThis, int x, int y);

		public virtual void StartInspect(int x, int y)
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_StartInspect_32(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_StartPan_33(HandleRef pThis);

		public override void StartPan()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_StartPan_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_StartZoom_34(HandleRef pThis);

		public override void StartZoom()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_StartZoom_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesInteractorStyle_Zoom_35(HandleRef pThis);

		public override void Zoom()
		{
			vtkParallelCoordinatesInteractorStyle.vtkParallelCoordinatesInteractorStyle_Zoom_35(base.GetCppThis());
		}
	}
}
