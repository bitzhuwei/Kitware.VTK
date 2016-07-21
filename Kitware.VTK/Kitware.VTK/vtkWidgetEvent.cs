using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWidgetEvent : vtkObject
	{
		public enum WidgetEventIds
		{
			AddFinalPoint = 15,
			AddPoint = 14,
			Completed = 16,
			Delete = 3,
			EndResize = 9,
			EndRotate = 11,
			EndScale = 7,
			EndSelect = 2,
			EndTranslate = 5,
			ModifyEvent = 18,
			Move = 12,
			NoEvent = 0,
			Reset = 19,
			Resize = 8,
			Rotate = 10,
			Scale = 6,
			Select = 1,
			SizeHandles = 13,
			TimedOut = 17,
			Translate = 4
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetEvent";

		public new static readonly string MRClassNameKey;

		static vtkWidgetEvent()
		{
			vtkWidgetEvent.MRClassNameKey = "class vtkWidgetEvent";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetEvent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetEvent"));
		}

		public vtkWidgetEvent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEvent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetEvent New()
		{
			vtkWidgetEvent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetEvent.vtkWidgetEvent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWidgetEvent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWidgetEvent.vtkWidgetEvent_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern uint vtkWidgetEvent_GetEventIdFromString_01(string arg0);

		public static uint GetEventIdFromString(string arg0)
		{
			return vtkWidgetEvent.vtkWidgetEvent_GetEventIdFromString_01(arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEvent_GetStringFromEventId_02(uint arg0);

		public static string GetStringFromEventId(uint arg0)
		{
			return Marshal.PtrToStringAnsi(vtkWidgetEvent.vtkWidgetEvent_GetStringFromEventId_02(arg0));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetEvent_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWidgetEvent.vtkWidgetEvent_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetEvent_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWidgetEvent.vtkWidgetEvent_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEvent_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWidgetEvent NewInstance()
		{
			vtkWidgetEvent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetEvent.vtkWidgetEvent_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEvent_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetEvent SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetEvent vtkWidgetEvent = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetEvent.vtkWidgetEvent_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetEvent = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetEvent.Register(null);
				}
			}
			return vtkWidgetEvent;
		}
	}
}
