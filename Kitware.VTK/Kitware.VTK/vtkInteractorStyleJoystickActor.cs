using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleJoystickActor : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleJoystickActor";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleJoystickActor()
		{
			vtkInteractorStyleJoystickActor.MRClassNameKey = "class vtkInteractorStyleJoystickActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleJoystickActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleJoystickActor"));
		}

		public vtkInteractorStyleJoystickActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleJoystickActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleJoystickActor New()
		{
			vtkInteractorStyleJoystickActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleJoystickActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_Dolly_01(HandleRef pThis);

		public override void Dolly()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Dolly_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleJoystickActor_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleJoystickActor_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleJoystickActor_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleJoystickActor NewInstance()
		{
			vtkInteractorStyleJoystickActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleJoystickActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_OnLeftButtonDown_06(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnLeftButtonDown_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_OnLeftButtonUp_07(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnLeftButtonUp_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_OnMiddleButtonDown_08(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnMiddleButtonDown_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_OnMiddleButtonUp_09(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnMiddleButtonUp_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_OnMouseMove_10(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnMouseMove_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_OnRightButtonDown_11(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnRightButtonDown_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_OnRightButtonUp_12(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_OnRightButtonUp_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_Pan_13(HandleRef pThis);

		public override void Pan()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Pan_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_Rotate_14(HandleRef pThis);

		public override void Rotate()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Rotate_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleJoystickActor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleJoystickActor SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleJoystickActor vtkInteractorStyleJoystickActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleJoystickActor = (vtkInteractorStyleJoystickActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleJoystickActor.Register(null);
				}
			}
			return vtkInteractorStyleJoystickActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_Spin_16(HandleRef pThis);

		public override void Spin()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_Spin_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleJoystickActor_UniformScale_17(HandleRef pThis);

		public override void UniformScale()
		{
			vtkInteractorStyleJoystickActor.vtkInteractorStyleJoystickActor_UniformScale_17(base.GetCppThis());
		}
	}
}
