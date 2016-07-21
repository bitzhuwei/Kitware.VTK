using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkButtonWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkButtonWidget";

		public new static readonly string MRClassNameKey;

		static vtkButtonWidget()
		{
			vtkButtonWidget.MRClassNameKey = "class vtkButtonWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButtonWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonWidget"));
		}

		public vtkButtonWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkButtonWidget New()
		{
			vtkButtonWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkButtonWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkButtonWidget.vtkButtonWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkButtonWidget.vtkButtonWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonWidget_GetSliderRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkButtonRepresentation GetSliderRepresentation()
		{
			vtkButtonRepresentation vtkButtonRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_GetSliderRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonRepresentation = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonRepresentation.Register(null);
				}
			}
			return vtkButtonRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonWidget_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkButtonWidget.vtkButtonWidget_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonWidget_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkButtonWidget.vtkButtonWidget_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonWidget_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkButtonWidget NewInstance()
		{
			vtkButtonWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonWidget_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkButtonWidget SafeDownCast(vtkObjectBase o)
		{
			vtkButtonWidget vtkButtonWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonWidget.vtkButtonWidget_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonWidget = (vtkButtonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonWidget.Register(null);
				}
			}
			return vtkButtonWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonWidget_SetRepresentation_08(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkButtonRepresentation r)
		{
			vtkButtonWidget.vtkButtonWidget_SetRepresentation_08(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
