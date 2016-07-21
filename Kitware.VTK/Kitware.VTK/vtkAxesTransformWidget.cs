using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAxesTransformWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxesTransformWidget";

		public new static readonly string MRClassNameKey;

		static vtkAxesTransformWidget()
		{
			vtkAxesTransformWidget.MRClassNameKey = "class vtkAxesTransformWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxesTransformWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesTransformWidget"));
		}

		public vtkAxesTransformWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxesTransformWidget New()
		{
			vtkAxesTransformWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAxesTransformWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAxesTransformWidget.vtkAxesTransformWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformWidget_GetLineRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAxesTransformRepresentation GetLineRepresentation()
		{
			vtkAxesTransformRepresentation vtkAxesTransformRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_GetLineRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesTransformRepresentation = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesTransformRepresentation.Register(null);
				}
			}
			return vtkAxesTransformRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformWidget_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAxesTransformWidget.vtkAxesTransformWidget_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformWidget_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAxesTransformWidget.vtkAxesTransformWidget_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformWidget_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAxesTransformWidget NewInstance()
		{
			vtkAxesTransformWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformWidget_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxesTransformWidget SafeDownCast(vtkObjectBase o)
		{
			vtkAxesTransformWidget vtkAxesTransformWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformWidget.vtkAxesTransformWidget_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesTransformWidget = (vtkAxesTransformWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesTransformWidget.Register(null);
				}
			}
			return vtkAxesTransformWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformWidget_SetEnabled_08(HandleRef pThis, int enabling);

		public override void SetEnabled(int enabling)
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_SetEnabled_08(base.GetCppThis(), enabling);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformWidget_SetProcessEvents_09(HandleRef pThis, int arg0);

		public override void SetProcessEvents(int arg0)
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_SetProcessEvents_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkAxesTransformRepresentation r)
		{
			vtkAxesTransformWidget.vtkAxesTransformWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
