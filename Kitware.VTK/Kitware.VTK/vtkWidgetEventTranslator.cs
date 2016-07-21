using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWidgetEventTranslator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetEventTranslator";

		public new static readonly string MRClassNameKey;

		static vtkWidgetEventTranslator()
		{
			vtkWidgetEventTranslator.MRClassNameKey = "class vtkWidgetEventTranslator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetEventTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetEventTranslator"));
		}

		public vtkWidgetEventTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEventTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetEventTranslator New()
		{
			vtkWidgetEventTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetEventTranslator.vtkWidgetEventTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWidgetEventTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWidgetEventTranslator.vtkWidgetEventTranslator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetEventTranslator_ClearEvents_01(HandleRef pThis);

		public void ClearEvents()
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_ClearEvents_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern uint vtkWidgetEventTranslator_GetTranslation_02(HandleRef pThis, uint VTKEvent);

		public uint GetTranslation(uint VTKEvent)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_02(base.GetCppThis(), VTKEvent);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEventTranslator_GetTranslation_03(HandleRef pThis, string VTKEvent);

		public string GetTranslation(string VTKEvent)
		{
			return Marshal.PtrToStringAnsi(vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_03(base.GetCppThis(), VTKEvent));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern uint vtkWidgetEventTranslator_GetTranslation_04(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym);

		public uint GetTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_04(base.GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern uint vtkWidgetEventTranslator_GetTranslation_05(HandleRef pThis, HandleRef VTKEvent);

		public uint GetTranslation(vtkEvent VTKEvent)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_05(base.GetCppThis(), (VTKEvent == null) ? default(HandleRef) : VTKEvent.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetEventTranslator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetEventTranslator_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEventTranslator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWidgetEventTranslator NewInstance()
		{
			vtkWidgetEventTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetEventTranslator.vtkWidgetEventTranslator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_10(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym);

		public int RemoveTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_10(base.GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_11(HandleRef pThis, HandleRef e);

		public int RemoveTranslation(vtkEvent e)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_11(base.GetCppThis(), (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_12(HandleRef pThis, uint VTKEvent);

		public int RemoveTranslation(uint VTKEvent)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_12(base.GetCppThis(), VTKEvent);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetEventTranslator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetEventTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetEventTranslator vtkWidgetEventTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetEventTranslator.vtkWidgetEventTranslator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetEventTranslator = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetEventTranslator.Register(null);
				}
			}
			return vtkWidgetEventTranslator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_14(HandleRef pThis, uint VTKEvent, uint widgetEvent);

		public void SetTranslation(uint VTKEvent, uint widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_14(base.GetCppThis(), VTKEvent, widgetEvent);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_15(HandleRef pThis, string VTKEvent, string widgetEvent);

		public void SetTranslation(string VTKEvent, string widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_15(base.GetCppThis(), VTKEvent, widgetEvent);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_16(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent);

		public void SetTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_16(base.GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym, widgetEvent);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_17(HandleRef pThis, HandleRef VTKevent, uint widgetEvent);

		public void SetTranslation(vtkEvent VTKevent, uint widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_17(base.GetCppThis(), (VTKevent == null) ? default(HandleRef) : VTKevent.GetCppThis(), widgetEvent);
		}
	}
}
