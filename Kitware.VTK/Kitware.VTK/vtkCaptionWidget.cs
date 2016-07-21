using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCaptionWidget : vtkBorderWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionWidget";

		public new static readonly string MRClassNameKey;

		static vtkCaptionWidget()
		{
			vtkCaptionWidget.MRClassNameKey = "class vtkCaptionWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCaptionWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionWidget"));
		}

		public vtkCaptionWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCaptionWidget New()
		{
			vtkCaptionWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCaptionWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCaptionWidget.vtkCaptionWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkCaptionWidget.vtkCaptionWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionWidget_GetCaptionActor2D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCaptionActor2D GetCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_GetCaptionActor2D_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionWidget_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCaptionWidget.vtkCaptionWidget_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionWidget_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCaptionWidget.vtkCaptionWidget_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionWidget_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCaptionWidget NewInstance()
		{
			vtkCaptionWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionWidget_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCaptionWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCaptionWidget vtkCaptionWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionWidget = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionWidget.Register(null);
				}
			}
			return vtkCaptionWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionWidget_SetCaptionActor2D_08(HandleRef pThis, HandleRef capActor);

		public void SetCaptionActor2D(vtkCaptionActor2D capActor)
		{
			vtkCaptionWidget.vtkCaptionWidget_SetCaptionActor2D_08(base.GetCppThis(), (capActor == null) ? default(HandleRef) : capActor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionWidget_SetEnabled_09(HandleRef pThis, int enabling);

		public override void SetEnabled(int enabling)
		{
			vtkCaptionWidget.vtkCaptionWidget_SetEnabled_09(base.GetCppThis(), enabling);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkCaptionRepresentation r)
		{
			vtkCaptionWidget.vtkCaptionWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
