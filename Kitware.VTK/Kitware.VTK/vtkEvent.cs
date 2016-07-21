using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEvent : vtkObject
	{
		public enum EventModifiers
		{
			AltModifier = 4,
			AnyModifier = -1,
			ControlModifier = 2,
			NoModifier = 0,
			ShiftModifier
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkEvent";

		public new static readonly string MRClassNameKey;

		static vtkEvent()
		{
			vtkEvent.MRClassNameKey = "class vtkEvent";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEvent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEvent"));
		}

		public vtkEvent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkEvent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEvent New()
		{
			vtkEvent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEvent.vtkEvent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEvent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEvent.vtkEvent_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern uint vtkEvent_GetEventId_01(HandleRef pThis);

		public virtual uint GetEventId()
		{
			return vtkEvent.vtkEvent_GetEventId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern sbyte vtkEvent_GetKeyCode_02(HandleRef pThis);

		public virtual sbyte GetKeyCode()
		{
			return vtkEvent.vtkEvent_GetKeyCode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkEvent_GetKeySym_03(HandleRef pThis);

		public virtual string GetKeySym()
		{
			return Marshal.PtrToStringAnsi(vtkEvent.vtkEvent_GetKeySym_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEvent_GetModifier_04(HandleRef pThis);

		public virtual int GetModifier()
		{
			return vtkEvent.vtkEvent_GetModifier_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEvent_GetModifier_05(HandleRef arg0);

		public static int GetModifier(vtkRenderWindowInteractor arg0)
		{
			return vtkEvent.vtkEvent_GetModifier_05((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEvent_GetRepeatCount_06(HandleRef pThis);

		public virtual int GetRepeatCount()
		{
			return vtkEvent.vtkEvent_GetRepeatCount_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEvent_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEvent.vtkEvent_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkEvent_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEvent.vtkEvent_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkEvent_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEvent NewInstance()
		{
			vtkEvent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEvent.vtkEvent_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkEvent_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEvent SafeDownCast(vtkObjectBase o)
		{
			vtkEvent vtkEvent = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEvent.vtkEvent_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEvent = (vtkEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEvent.Register(null);
				}
			}
			return vtkEvent;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEvent_SetEventId_12(HandleRef pThis, uint _arg);

		public virtual void SetEventId(uint _arg)
		{
			vtkEvent.vtkEvent_SetEventId_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEvent_SetKeyCode_13(HandleRef pThis, sbyte _arg);

		public virtual void SetKeyCode(sbyte _arg)
		{
			vtkEvent.vtkEvent_SetKeyCode_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEvent_SetKeySym_14(HandleRef pThis, string _arg);

		public virtual void SetKeySym(string _arg)
		{
			vtkEvent.vtkEvent_SetKeySym_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEvent_SetModifier_15(HandleRef pThis, int _arg);

		public virtual void SetModifier(int _arg)
		{
			vtkEvent.vtkEvent_SetModifier_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkEvent_SetRepeatCount_16(HandleRef pThis, int _arg);

		public virtual void SetRepeatCount(int _arg)
		{
			vtkEvent.vtkEvent_SetRepeatCount_16(base.GetCppThis(), _arg);
		}
	}
}
