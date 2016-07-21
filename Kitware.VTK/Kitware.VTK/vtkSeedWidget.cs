using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSeedWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSeedWidget";

		public new static readonly string MRClassNameKey;

		static vtkSeedWidget()
		{
			vtkSeedWidget.MRClassNameKey = "class vtkSeedWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSeedWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSeedWidget"));
		}

		public vtkSeedWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSeedWidget New()
		{
			vtkSeedWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSeedWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSeedWidget.vtkSeedWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_CompleteInteraction_01(HandleRef pThis);

		public virtual void CompleteInteraction()
		{
			vtkSeedWidget.vtkSeedWidget_CompleteInteraction_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_CreateDefaultRepresentation_02(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkSeedWidget.vtkSeedWidget_CreateDefaultRepresentation_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedWidget_CreateNewHandle_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleWidget CreateNewHandle()
		{
			vtkHandleWidget vtkHandleWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_CreateNewHandle_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleWidget = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleWidget.Register(null);
				}
			}
			return vtkHandleWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_DeleteSeed_04(HandleRef pThis, int n);

		public void DeleteSeed(int n)
		{
			vtkSeedWidget.vtkSeedWidget_DeleteSeed_04(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedWidget_GetSeed_05(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHandleWidget GetSeed(int n)
		{
			vtkHandleWidget vtkHandleWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_GetSeed_05(base.GetCppThis(), n, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleWidget = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleWidget.Register(null);
				}
			}
			return vtkHandleWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedWidget_GetSeedRepresentation_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSeedRepresentation GetSeedRepresentation()
		{
			vtkSeedRepresentation vtkSeedRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_GetSeedRepresentation_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSeedRepresentation = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSeedRepresentation.Register(null);
				}
			}
			return vtkSeedRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedWidget_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSeedWidget.vtkSeedWidget_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedWidget_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSeedWidget.vtkSeedWidget_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSeedWidget NewInstance()
		{
			vtkSeedWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_RestartInteraction_11(HandleRef pThis);

		public virtual void RestartInteraction()
		{
			vtkSeedWidget.vtkSeedWidget_RestartInteraction_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedWidget_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSeedWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSeedWidget vtkSeedWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSeedWidget = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSeedWidget.Register(null);
				}
			}
			return vtkSeedWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_SetCurrentRenderer_13(HandleRef pThis, HandleRef arg0);

		public override void SetCurrentRenderer(vtkRenderer arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetCurrentRenderer_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_SetEnabled_14(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetEnabled_14(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_SetInteractor_15(HandleRef pThis, HandleRef arg0);

		public override void SetInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetInteractor_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_SetProcessEvents_16(HandleRef pThis, int arg0);

		public override void SetProcessEvents(int arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetProcessEvents_16(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedWidget_SetRepresentation_17(HandleRef pThis, HandleRef rep);

		public void SetRepresentation(vtkSeedRepresentation rep)
		{
			vtkSeedWidget.vtkSeedWidget_SetRepresentation_17(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}
	}
}
