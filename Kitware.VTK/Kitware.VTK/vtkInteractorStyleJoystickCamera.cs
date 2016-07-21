using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleJoystickCamera : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleJoystickCamera";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleJoystickCamera()
		{
			vtkInteractorStyleJoystickCamera.MRClassNameKey = "class vtkInteractorStyleJoystickCamera";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleJoystickCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleJoystickCamera"));
		}

		public vtkInteractorStyleJoystickCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleJoystickCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleJoystickCamera New()
		{
			vtkInteractorStyleJoystickCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleJoystickCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_Dolly_01(HandleRef pThis);

		public override void Dolly()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Dolly_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleJoystickCamera_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleJoystickCamera_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleJoystickCamera_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleJoystickCamera NewInstance()
		{
			vtkInteractorStyleJoystickCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnLeftButtonDown_06(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnLeftButtonDown_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnLeftButtonUp_07(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnLeftButtonUp_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMiddleButtonDown_08(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMiddleButtonDown_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMiddleButtonUp_09(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMiddleButtonUp_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMouseMove_10(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMouseMove_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMouseWheelBackward_11(HandleRef pThis);

		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMouseWheelBackward_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnMouseWheelForward_12(HandleRef pThis);

		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnMouseWheelForward_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnRightButtonDown_13(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnRightButtonDown_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_OnRightButtonUp_14(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_OnRightButtonUp_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_Pan_15(HandleRef pThis);

		public override void Pan()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Pan_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_Rotate_16(HandleRef pThis);

		public override void Rotate()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Rotate_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleJoystickCamera_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleJoystickCamera SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleJoystickCamera vtkInteractorStyleJoystickCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleJoystickCamera = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleJoystickCamera.Register(null);
				}
			}
			return vtkInteractorStyleJoystickCamera;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickCamera_Spin_18(HandleRef pThis);

		public override void Spin()
		{
			vtkInteractorStyleJoystickCamera.vtkInteractorStyleJoystickCamera_Spin_18(base.GetCppThis());
		}
	}
}
