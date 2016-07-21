using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlaybackWidget : vtkBorderWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaybackWidget";

		public new static readonly string MRClassNameKey;

		static vtkPlaybackWidget()
		{
			vtkPlaybackWidget.MRClassNameKey = "class vtkPlaybackWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaybackWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaybackWidget"));
		}

		public vtkPlaybackWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaybackWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaybackWidget New()
		{
			vtkPlaybackWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaybackWidget.vtkPlaybackWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlaybackWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlaybackWidget.vtkPlaybackWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkPlaybackWidget.vtkPlaybackWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackWidget_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlaybackWidget.vtkPlaybackWidget_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackWidget_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlaybackWidget.vtkPlaybackWidget_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaybackWidget_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlaybackWidget NewInstance()
		{
			vtkPlaybackWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaybackWidget.vtkPlaybackWidget_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaybackWidget_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaybackWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPlaybackWidget vtkPlaybackWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaybackWidget.vtkPlaybackWidget_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaybackWidget = (vtkPlaybackWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaybackWidget.Register(null);
				}
			}
			return vtkPlaybackWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackWidget_SetRepresentation_07(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkPlaybackRepresentation r)
		{
			vtkPlaybackWidget.vtkPlaybackWidget_SetRepresentation_07(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
