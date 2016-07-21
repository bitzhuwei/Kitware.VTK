using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleRubberBand2D : vtkInteractorStyle
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
			SELECTING = 3,
			ZOOMING = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBand2D";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleRubberBand2D()
		{
			vtkInteractorStyleRubberBand2D.MRClassNameKey = "class vtkInteractorStyleRubberBand2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBand2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBand2D"));
		}

		public vtkInteractorStyleRubberBand2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBand2D New()
		{
			vtkInteractorStyleRubberBand2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleRubberBand2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_GetEndPosition_01(HandleRef pThis);

		public virtual int[] GetEndPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetEndPosition_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_GetEndPosition_02(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetEndPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetEndPosition_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_GetEndPosition_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetEndPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetEndPosition_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBand2D_GetInteraction_04(HandleRef pThis);

		public virtual int GetInteraction()
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetInteraction_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkInteractorStyleRubberBand2D_GetRenderOnMouseMove_05(HandleRef pThis);

		public virtual bool GetRenderOnMouseMove()
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetRenderOnMouseMove_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_GetStartPosition_06(HandleRef pThis);

		public virtual int[] GetStartPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetStartPosition_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_GetStartPosition_07(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetStartPosition_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_GetStartPosition_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetStartPosition_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBand2D_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleRubberBand2D_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleRubberBand2D NewInstance()
		{
			vtkInteractorStyleRubberBand2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnLeftButtonDown_13(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnLeftButtonDown_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnLeftButtonUp_14(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnLeftButtonUp_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMiddleButtonDown_15(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMiddleButtonDown_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMiddleButtonUp_16(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMiddleButtonUp_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMouseMove_17(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMouseMove_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMouseWheelBackward_18(HandleRef pThis);

		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMouseWheelBackward_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMouseWheelForward_19(HandleRef pThis);

		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMouseWheelForward_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnRightButtonDown_20(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnRightButtonDown_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_OnRightButtonUp_21(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnRightButtonUp_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOff_22(HandleRef pThis);

		public virtual void RenderOnMouseMoveOff()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOn_23(HandleRef pThis);

		public virtual void RenderOnMouseMoveOn()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleRubberBand2D SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBand2D vtkInteractorStyleRubberBand2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBand2D = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBand2D.Register(null);
				}
			}
			return vtkInteractorStyleRubberBand2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleRubberBand2D_SetRenderOnMouseMove_25(HandleRef pThis, byte _arg);

		public virtual void SetRenderOnMouseMove(bool _arg)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_SetRenderOnMouseMove_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
