using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBorderWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBorderWidget";

		public new static readonly string MRClassNameKey;

		static vtkBorderWidget()
		{
			vtkBorderWidget.MRClassNameKey = "class vtkBorderWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBorderWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBorderWidget"));
		}

		public vtkBorderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBorderWidget New()
		{
			vtkBorderWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBorderWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBorderWidget.vtkBorderWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkBorderWidget.vtkBorderWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderWidget_GetBorderRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkBorderRepresentation GetBorderRepresentation()
		{
			vtkBorderRepresentation vtkBorderRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_GetBorderRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBorderRepresentation = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBorderRepresentation.Register(null);
				}
			}
			return vtkBorderRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderWidget_GetResizable_03(HandleRef pThis);

		public virtual int GetResizable()
		{
			return vtkBorderWidget.vtkBorderWidget_GetResizable_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderWidget_GetSelectable_04(HandleRef pThis);

		public virtual int GetSelectable()
		{
			return vtkBorderWidget.vtkBorderWidget_GetSelectable_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderWidget_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBorderWidget.vtkBorderWidget_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderWidget_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBorderWidget.vtkBorderWidget_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBorderWidget NewInstance()
		{
			vtkBorderWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_ResizableOff_09(HandleRef pThis);

		public virtual void ResizableOff()
		{
			vtkBorderWidget.vtkBorderWidget_ResizableOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_ResizableOn_10(HandleRef pThis);

		public virtual void ResizableOn()
		{
			vtkBorderWidget.vtkBorderWidget_ResizableOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBorderWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBorderWidget vtkBorderWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderWidget.vtkBorderWidget_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBorderWidget = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBorderWidget.Register(null);
				}
			}
			return vtkBorderWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_SelectableOff_12(HandleRef pThis);

		public virtual void SelectableOff()
		{
			vtkBorderWidget.vtkBorderWidget_SelectableOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_SelectableOn_13(HandleRef pThis);

		public virtual void SelectableOn()
		{
			vtkBorderWidget.vtkBorderWidget_SelectableOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_SetRepresentation_14(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkBorderRepresentation r)
		{
			vtkBorderWidget.vtkBorderWidget_SetRepresentation_14(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_SetResizable_15(HandleRef pThis, int _arg);

		public virtual void SetResizable(int _arg)
		{
			vtkBorderWidget.vtkBorderWidget_SetResizable_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderWidget_SetSelectable_16(HandleRef pThis, int _arg);

		public virtual void SetSelectable(int _arg)
		{
			vtkBorderWidget.vtkBorderWidget_SetSelectable_16(base.GetCppThis(), _arg);
		}
	}
}
