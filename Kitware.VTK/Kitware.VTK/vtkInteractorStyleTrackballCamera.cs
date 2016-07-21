using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleTrackballCamera : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackballCamera";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleTrackballCamera()
		{
			vtkInteractorStyleTrackballCamera.MRClassNameKey = "class vtkInteractorStyleTrackballCamera";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTrackballCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackballCamera"));
		}

		public vtkInteractorStyleTrackballCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackballCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTrackballCamera New()
		{
			vtkInteractorStyleTrackballCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleTrackballCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_Dolly_01(HandleRef pThis);

		public override void Dolly()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Dolly_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleTrackballCamera_GetMotionFactor_02(HandleRef pThis);

		public virtual double GetMotionFactor()
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_GetMotionFactor_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTrackballCamera_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTrackballCamera_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackballCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleTrackballCamera NewInstance()
		{
			vtkInteractorStyleTrackballCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnLeftButtonDown_07(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnLeftButtonDown_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnLeftButtonUp_08(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnLeftButtonUp_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMiddleButtonDown_09(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMiddleButtonDown_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMiddleButtonUp_10(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMiddleButtonUp_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMouseMove_11(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMouseMove_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMouseWheelBackward_12(HandleRef pThis);

		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMouseWheelBackward_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnMouseWheelForward_13(HandleRef pThis);

		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnMouseWheelForward_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnRightButtonDown_14(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnRightButtonDown_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_OnRightButtonUp_15(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_OnRightButtonUp_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_Pan_16(HandleRef pThis);

		public override void Pan()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Pan_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_Rotate_17(HandleRef pThis);

		public override void Rotate()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Rotate_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTrackballCamera_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTrackballCamera SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTrackballCamera vtkInteractorStyleTrackballCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTrackballCamera = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTrackballCamera.Register(null);
				}
			}
			return vtkInteractorStyleTrackballCamera;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_SetMotionFactor_19(HandleRef pThis, double _arg);

		public virtual void SetMotionFactor(double _arg)
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_SetMotionFactor_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTrackballCamera_Spin_20(HandleRef pThis);

		public override void Spin()
		{
			vtkInteractorStyleTrackballCamera.vtkInteractorStyleTrackballCamera_Spin_20(base.GetCppThis());
		}
	}
}
