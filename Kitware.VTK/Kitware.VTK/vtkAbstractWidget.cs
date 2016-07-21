using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractWidget : vtkInteractorObserver
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractWidget";

		public new static readonly string MRClassNameKey;

		static vtkAbstractWidget()
		{
			vtkAbstractWidget.MRClassNameKey = "class vtkAbstractWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractWidget"));
		}

		public vtkAbstractWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public virtual void CreateDefaultRepresentation()
		{
			vtkAbstractWidget.vtkAbstractWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractWidget_GetEventTranslator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkWidgetEventTranslator GetEventTranslator()
		{
			vtkWidgetEventTranslator vtkWidgetEventTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_GetEventTranslator_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkAbstractWidget_GetManagesCursor_03(HandleRef pThis);

		public virtual int GetManagesCursor()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetManagesCursor_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractWidget_GetParent_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractWidget GetParent()
		{
			vtkAbstractWidget vtkAbstractWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_GetParent_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractWidget = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractWidget.Register(null);
				}
			}
			return vtkAbstractWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractWidget_GetProcessEvents_05(HandleRef pThis);

		public virtual int GetProcessEvents()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetProcessEvents_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractWidget_GetProcessEventsMaxValue_06(HandleRef pThis);

		public virtual int GetProcessEventsMaxValue()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetProcessEventsMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractWidget_GetProcessEventsMinValue_07(HandleRef pThis);

		public virtual int GetProcessEventsMinValue()
		{
			return vtkAbstractWidget.vtkAbstractWidget_GetProcessEventsMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractWidget_GetRepresentation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkWidgetRepresentation GetRepresentation()
		{
			vtkWidgetRepresentation vtkWidgetRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_GetRepresentation_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetRepresentation = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetRepresentation.Register(null);
				}
			}
			return vtkWidgetRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractWidget_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractWidget.vtkAbstractWidget_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractWidget_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractWidget.vtkAbstractWidget_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_ManagesCursorOff_11(HandleRef pThis);

		public virtual void ManagesCursorOff()
		{
			vtkAbstractWidget.vtkAbstractWidget_ManagesCursorOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_ManagesCursorOn_12(HandleRef pThis);

		public virtual void ManagesCursorOn()
		{
			vtkAbstractWidget.vtkAbstractWidget_ManagesCursorOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractWidget NewInstance()
		{
			vtkAbstractWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_ProcessEventsOff_14(HandleRef pThis);

		public virtual void ProcessEventsOff()
		{
			vtkAbstractWidget.vtkAbstractWidget_ProcessEventsOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_ProcessEventsOn_15(HandleRef pThis);

		public virtual void ProcessEventsOn()
		{
			vtkAbstractWidget.vtkAbstractWidget_ProcessEventsOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_Render_16(HandleRef pThis);

		public void Render()
		{
			vtkAbstractWidget.vtkAbstractWidget_Render_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractWidget_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractWidget SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractWidget vtkAbstractWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractWidget.vtkAbstractWidget_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractWidget = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractWidget.Register(null);
				}
			}
			return vtkAbstractWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_SetEnabled_18(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetEnabled_18(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_SetManagesCursor_19(HandleRef pThis, int _arg);

		public virtual void SetManagesCursor(int _arg)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetManagesCursor_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_SetParent_20(HandleRef pThis, HandleRef parent);

		public void SetParent(vtkAbstractWidget parent)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetParent_20(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_SetPriority_21(HandleRef pThis, float arg0);

		public override void SetPriority(float arg0)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetPriority_21(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractWidget_SetProcessEvents_22(HandleRef pThis, int _arg);

		public virtual void SetProcessEvents(int _arg)
		{
			vtkAbstractWidget.vtkAbstractWidget_SetProcessEvents_22(base.GetCppThis(), _arg);
		}
	}
}
