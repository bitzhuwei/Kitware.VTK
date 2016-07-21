using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorObserver : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorObserver";

		public new static readonly string MRClassNameKey;

		static vtkInteractorObserver()
		{
			vtkInteractorObserver.MRClassNameKey = "class vtkInteractorObserver";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorObserver.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorObserver"));
		}

		public vtkInteractorObserver(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_ComputeDisplayToWorld_01(HandleRef ren, double x, double y, double z, IntPtr worldPt);

		public static void ComputeDisplayToWorld(vtkRenderer ren, double x, double y, double z, IntPtr worldPt)
		{
			vtkInteractorObserver.vtkInteractorObserver_ComputeDisplayToWorld_01((ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y, z, worldPt);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_ComputeWorldToDisplay_02(HandleRef ren, double x, double y, double z, IntPtr displayPt);

		public static void ComputeWorldToDisplay(vtkRenderer ren, double x, double y, double z, IntPtr displayPt)
		{
			vtkInteractorObserver.vtkInteractorObserver_ComputeWorldToDisplay_02((ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y, z, displayPt);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_EnabledOff_03(HandleRef pThis);

		public void EnabledOff()
		{
			vtkInteractorObserver.vtkInteractorObserver_EnabledOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_EnabledOn_04(HandleRef pThis);

		public void EnabledOn()
		{
			vtkInteractorObserver.vtkInteractorObserver_EnabledOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorObserver_GetCurrentRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetCurrentRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_GetCurrentRenderer_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorObserver_GetDefaultRenderer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetDefaultRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_GetDefaultRenderer_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorObserver_GetEnabled_07(HandleRef pThis);

		public int GetEnabled()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetEnabled_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorObserver_GetInteractor_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_GetInteractor_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorObserver_GetKeyPressActivation_09(HandleRef pThis);

		public virtual int GetKeyPressActivation()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetKeyPressActivation_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern sbyte vtkInteractorObserver_GetKeyPressActivationValue_10(HandleRef pThis);

		public virtual sbyte GetKeyPressActivationValue()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetKeyPressActivationValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkInteractorObserver_GetPriority_11(HandleRef pThis);

		public virtual float GetPriority()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetPriority_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkInteractorObserver_GetPriorityMaxValue_12(HandleRef pThis);

		public virtual float GetPriorityMaxValue()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetPriorityMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkInteractorObserver_GetPriorityMinValue_13(HandleRef pThis);

		public virtual float GetPriorityMinValue()
		{
			return vtkInteractorObserver.vtkInteractorObserver_GetPriorityMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_GrabFocus_14(HandleRef pThis, HandleRef mouseEvents, HandleRef keypressEvents);

		public void GrabFocus(vtkCommand mouseEvents, vtkCommand keypressEvents)
		{
			vtkInteractorObserver.vtkInteractorObserver_GrabFocus_14(base.GetCppThis(), (mouseEvents == null) ? default(HandleRef) : mouseEvents.GetCppThis(), (keypressEvents == null) ? default(HandleRef) : keypressEvents.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorObserver_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorObserver.vtkInteractorObserver_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorObserver_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorObserver.vtkInteractorObserver_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_KeyPressActivationOff_17(HandleRef pThis);

		public virtual void KeyPressActivationOff()
		{
			vtkInteractorObserver.vtkInteractorObserver_KeyPressActivationOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_KeyPressActivationOn_18(HandleRef pThis);

		public virtual void KeyPressActivationOn()
		{
			vtkInteractorObserver.vtkInteractorObserver_KeyPressActivationOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorObserver_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorObserver NewInstance()
		{
			vtkInteractorObserver result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_Off_20(HandleRef pThis);

		public void Off()
		{
			vtkInteractorObserver.vtkInteractorObserver_Off_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_On_21(HandleRef pThis);

		public void On()
		{
			vtkInteractorObserver.vtkInteractorObserver_On_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_OnChar_22(HandleRef pThis);

		public virtual void OnChar()
		{
			vtkInteractorObserver.vtkInteractorObserver_OnChar_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_ReleaseFocus_23(HandleRef pThis);

		public void ReleaseFocus()
		{
			vtkInteractorObserver.vtkInteractorObserver_ReleaseFocus_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorObserver_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorObserver SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorObserver vtkInteractorObserver = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorObserver.vtkInteractorObserver_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorObserver = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorObserver.Register(null);
				}
			}
			return vtkInteractorObserver;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_SetCurrentRenderer_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetCurrentRenderer(vtkRenderer arg0)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetCurrentRenderer_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_SetDefaultRenderer_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetDefaultRenderer(vtkRenderer arg0)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetDefaultRenderer_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_SetEnabled_27(HandleRef pThis, int arg0);

		public virtual void SetEnabled(int arg0)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetEnabled_27(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_SetInteractor_28(HandleRef pThis, HandleRef iren);

		public virtual void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetInteractor_28(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_SetKeyPressActivation_29(HandleRef pThis, int _arg);

		public virtual void SetKeyPressActivation(int _arg)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetKeyPressActivation_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_SetKeyPressActivationValue_30(HandleRef pThis, sbyte _arg);

		public virtual void SetKeyPressActivationValue(sbyte _arg)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetKeyPressActivationValue_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorObserver_SetPriority_31(HandleRef pThis, float _arg);

		public virtual void SetPriority(float _arg)
		{
			vtkInteractorObserver.vtkInteractorObserver_SetPriority_31(base.GetCppThis(), _arg);
		}
	}
}
