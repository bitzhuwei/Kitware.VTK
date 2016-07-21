using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLogoWidget : vtkBorderWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLogoWidget";

		public new static readonly string MRClassNameKey;

		static vtkLogoWidget()
		{
			vtkLogoWidget.MRClassNameKey = "class vtkLogoWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLogoWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLogoWidget"));
		}

		public vtkLogoWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLogoWidget New()
		{
			vtkLogoWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoWidget.vtkLogoWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLogoWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLogoWidget.vtkLogoWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLogoWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkLogoWidget.vtkLogoWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLogoWidget_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLogoWidget.vtkLogoWidget_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLogoWidget_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLogoWidget.vtkLogoWidget_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoWidget_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLogoWidget NewInstance()
		{
			vtkLogoWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoWidget.vtkLogoWidget_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLogoWidget_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLogoWidget SafeDownCast(vtkObjectBase o)
		{
			vtkLogoWidget vtkLogoWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLogoWidget.vtkLogoWidget_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLogoWidget = (vtkLogoWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLogoWidget.Register(null);
				}
			}
			return vtkLogoWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLogoWidget_SetRepresentation_07(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkLogoRepresentation r)
		{
			vtkLogoWidget.vtkLogoWidget_SetRepresentation_07(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
