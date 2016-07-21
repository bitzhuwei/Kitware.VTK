using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleRubberBand3D : vtkInteractorStyleTrackballCamera
	{
		public enum SELECT_NORMAL_WrapperEnum
		{
			SELECT_NORMAL,
			SELECT_UNION
		}

		public enum NONE_WrapperEnum
		{
			NONE,
			PANNING,
			ROTATING = 3,
			SELECTING,
			ZOOMING = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBand3D";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleRubberBand3D()
		{
			vtkInteractorStyleRubberBand3D.MRClassNameKey = "class vtkInteractorStyleRubberBand3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBand3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBand3D"));
		}

		public vtkInteractorStyleRubberBand3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBand3D New()
		{
			vtkInteractorStyleRubberBand3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleRubberBand3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_GetEndPosition_01(HandleRef pThis);

		public virtual int[] GetEndPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetEndPosition_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_GetEndPosition_02(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetEndPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetEndPosition_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_GetEndPosition_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetEndPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetEndPosition_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBand3D_GetInteraction_04(HandleRef pThis);

		public virtual int GetInteraction()
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetInteraction_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkInteractorStyleRubberBand3D_GetRenderOnMouseMove_05(HandleRef pThis);

		public virtual bool GetRenderOnMouseMove()
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetRenderOnMouseMove_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_GetStartPosition_06(HandleRef pThis);

		public virtual int[] GetStartPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetStartPosition_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_GetStartPosition_07(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetStartPosition_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_GetStartPosition_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetStartPosition_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBand3D_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBand3D_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleRubberBand3D NewInstance()
		{
			vtkInteractorStyleRubberBand3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnLeftButtonDown_13(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnLeftButtonDown_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnLeftButtonUp_14(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnLeftButtonUp_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMiddleButtonDown_15(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMiddleButtonDown_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMiddleButtonUp_16(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMiddleButtonUp_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMouseMove_17(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMouseMove_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMouseWheelBackward_18(HandleRef pThis);

		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMouseWheelBackward_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMouseWheelForward_19(HandleRef pThis);

		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMouseWheelForward_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnRightButtonDown_20(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnRightButtonDown_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_OnRightButtonUp_21(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnRightButtonUp_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOff_22(HandleRef pThis);

		public virtual void RenderOnMouseMoveOff()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOn_23(HandleRef pThis);

		public virtual void RenderOnMouseMoveOn()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBand3D SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBand3D vtkInteractorStyleRubberBand3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBand3D = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBand3D.Register(null);
				}
			}
			return vtkInteractorStyleRubberBand3D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand3D_SetRenderOnMouseMove_25(HandleRef pThis, byte _arg);

		public virtual void SetRenderOnMouseMove(bool _arg)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_SetRenderOnMouseMove_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
