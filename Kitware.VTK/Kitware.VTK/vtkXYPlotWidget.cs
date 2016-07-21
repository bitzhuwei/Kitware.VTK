using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXYPlotWidget : vtkInteractorObserver
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXYPlotWidget";

		public new static readonly string MRClassNameKey;

		static vtkXYPlotWidget()
		{
			vtkXYPlotWidget.MRClassNameKey = "class vtkXYPlotWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXYPlotWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXYPlotWidget"));
		}

		public vtkXYPlotWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXYPlotWidget New()
		{
			vtkXYPlotWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYPlotWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXYPlotWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXYPlotWidget.vtkXYPlotWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotWidget_GetXYPlotActor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXYPlotActor GetXYPlotActor()
		{
			vtkXYPlotActor vtkXYPlotActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_GetXYPlotActor_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYPlotActor = (vtkXYPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYPlotActor.Register(null);
				}
			}
			return vtkXYPlotActor;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkXYPlotWidget_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXYPlotWidget.vtkXYPlotWidget_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkXYPlotWidget_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXYPlotWidget.vtkXYPlotWidget_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotWidget_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXYPlotWidget NewInstance()
		{
			vtkXYPlotWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYPlotWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkXYPlotWidget_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXYPlotWidget SafeDownCast(vtkObjectBase o)
		{
			vtkXYPlotWidget vtkXYPlotWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYPlotWidget.vtkXYPlotWidget_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYPlotWidget = (vtkXYPlotWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYPlotWidget.Register(null);
				}
			}
			return vtkXYPlotWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkXYPlotWidget_SetEnabled_07(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkXYPlotWidget.vtkXYPlotWidget_SetEnabled_07(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkXYPlotWidget_SetXYPlotActor_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetXYPlotActor(vtkXYPlotActor arg0)
		{
			vtkXYPlotWidget.vtkXYPlotWidget_SetXYPlotActor_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
