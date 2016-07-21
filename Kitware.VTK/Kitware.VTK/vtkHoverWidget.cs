using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHoverWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHoverWidget";

		public new static readonly string MRClassNameKey;

		static vtkHoverWidget()
		{
			vtkHoverWidget.MRClassNameKey = "class vtkHoverWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHoverWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHoverWidget"));
		}

		public vtkHoverWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHoverWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHoverWidget New()
		{
			vtkHoverWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHoverWidget.vtkHoverWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHoverWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHoverWidget.vtkHoverWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHoverWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkHoverWidget.vtkHoverWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHoverWidget_GetTimerDuration_02(HandleRef pThis);

		public virtual int GetTimerDuration()
		{
			return vtkHoverWidget.vtkHoverWidget_GetTimerDuration_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHoverWidget_GetTimerDurationMaxValue_03(HandleRef pThis);

		public virtual int GetTimerDurationMaxValue()
		{
			return vtkHoverWidget.vtkHoverWidget_GetTimerDurationMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHoverWidget_GetTimerDurationMinValue_04(HandleRef pThis);

		public virtual int GetTimerDurationMinValue()
		{
			return vtkHoverWidget.vtkHoverWidget_GetTimerDurationMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHoverWidget_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHoverWidget.vtkHoverWidget_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkHoverWidget_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHoverWidget.vtkHoverWidget_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHoverWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHoverWidget NewInstance()
		{
			vtkHoverWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHoverWidget.vtkHoverWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkHoverWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHoverWidget SafeDownCast(vtkObjectBase o)
		{
			vtkHoverWidget vtkHoverWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHoverWidget.vtkHoverWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHoverWidget = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHoverWidget.Register(null);
				}
			}
			return vtkHoverWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHoverWidget_SetEnabled_10(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkHoverWidget.vtkHoverWidget_SetEnabled_10(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkHoverWidget_SetTimerDuration_11(HandleRef pThis, int _arg);

		public virtual void SetTimerDuration(int _arg)
		{
			vtkHoverWidget.vtkHoverWidget_SetTimerDuration_11(base.GetCppThis(), _arg);
		}
	}
}
