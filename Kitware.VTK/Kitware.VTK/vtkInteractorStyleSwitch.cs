using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleSwitch : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleSwitch";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleSwitch()
		{
			vtkInteractorStyleSwitch.MRClassNameKey = "class vtkInteractorStyleSwitch";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleSwitch.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleSwitch"));
		}

		public vtkInteractorStyleSwitch(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleSwitch_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleSwitch New()
		{
			vtkInteractorStyleSwitch result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleSwitch() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleSwitch_GetCurrentStyle_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInteractorStyle GetCurrentStyle()
		{
			vtkInteractorStyle vtkInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_GetCurrentStyle_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyle = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyle.Register(null);
				}
			}
			return vtkInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleSwitch_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleSwitch_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleSwitch_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleSwitch NewInstance()
		{
			vtkInteractorStyleSwitch result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_OnChar_06(HandleRef pThis);

		public override void OnChar()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_OnChar_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleSwitch_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleSwitch SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleSwitch vtkInteractorStyleSwitch = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleSwitch = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleSwitch.Register(null);
				}
			}
			return vtkInteractorStyleSwitch;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetAutoAdjustCameraClippingRange_08(HandleRef pThis, int value);

		public override void SetAutoAdjustCameraClippingRange(int value)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetAutoAdjustCameraClippingRange_08(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentRenderer_09(HandleRef pThis, HandleRef arg0);

		public override void SetCurrentRenderer(vtkRenderer arg0)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentRenderer_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToJoystickActor_10(HandleRef pThis);

		public void SetCurrentStyleToJoystickActor()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToJoystickActor_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToJoystickCamera_11(HandleRef pThis);

		public void SetCurrentStyleToJoystickCamera()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToJoystickCamera_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToTrackballActor_12(HandleRef pThis);

		public void SetCurrentStyleToTrackballActor()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToTrackballActor_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToTrackballCamera_13(HandleRef pThis);

		public void SetCurrentStyleToTrackballCamera()
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetCurrentStyleToTrackballCamera_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetDefaultRenderer_14(HandleRef pThis, HandleRef arg0);

		public override void SetDefaultRenderer(vtkRenderer arg0)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetDefaultRenderer_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleSwitch_SetInteractor_15(HandleRef pThis, HandleRef iren);

		public override void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkInteractorStyleSwitch.vtkInteractorStyleSwitch_SetInteractor_15(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}
	}
}
