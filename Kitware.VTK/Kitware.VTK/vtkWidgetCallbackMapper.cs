using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWidgetCallbackMapper : vtkObject
	{
		public delegate void CallbackType(IntPtr arg0);

		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetCallbackMapper";

		public new static readonly string MRClassNameKey;

		static vtkWidgetCallbackMapper()
		{
			vtkWidgetCallbackMapper.MRClassNameKey = "class vtkWidgetCallbackMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetCallbackMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetCallbackMapper"));
		}

		public vtkWidgetCallbackMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetCallbackMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetCallbackMapper New()
		{
			vtkWidgetCallbackMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWidgetCallbackMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetCallbackMapper_GetEventTranslator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkWidgetEventTranslator GetEventTranslator()
		{
			vtkWidgetEventTranslator vtkWidgetEventTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_GetEventTranslator_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkWidgetCallbackMapper_InvokeCallback_02(HandleRef pThis, uint widgetEvent);

		public void InvokeCallback(uint widgetEvent)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_InvokeCallback_02(base.GetCppThis(), widgetEvent);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetCallbackMapper_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetCallbackMapper_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetCallbackMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWidgetCallbackMapper NewInstance()
		{
			vtkWidgetCallbackMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetCallbackMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetCallbackMapper SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetCallbackMapper vtkWidgetCallbackMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetCallbackMapper = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetCallbackMapper.Register(null);
				}
			}
			return vtkWidgetCallbackMapper;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_08(HandleRef pThis, uint VTKEvent, uint widgetEvent, HandleRef w, vtkWidgetCallbackMapper.CallbackType f);

		public void SetCallbackMethod(uint VTKEvent, uint widgetEvent, vtkAbstractWidget w, vtkWidgetCallbackMapper.CallbackType f)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SetCallbackMethod_08(base.GetCppThis(), VTKEvent, widgetEvent, (w == null) ? default(HandleRef) : w.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_09(HandleRef pThis, uint VTKEvent, int modifiers, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent, HandleRef w, vtkWidgetCallbackMapper.CallbackType f);

		public void SetCallbackMethod(uint VTKEvent, int modifiers, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent, vtkAbstractWidget w, vtkWidgetCallbackMapper.CallbackType f)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SetCallbackMethod_09(base.GetCppThis(), VTKEvent, modifiers, keyCode, repeatCount, keySym, widgetEvent, (w == null) ? default(HandleRef) : w.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetCallbackMapper_SetEventTranslator_10(HandleRef pThis, HandleRef t);

		public void SetEventTranslator(vtkWidgetEventTranslator t)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SetEventTranslator_10(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}
	}
}
