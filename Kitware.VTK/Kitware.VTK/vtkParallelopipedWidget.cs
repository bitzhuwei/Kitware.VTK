using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelopipedWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelopipedWidget";

		public new static readonly string MRClassNameKey;

		static vtkParallelopipedWidget()
		{
			vtkParallelopipedWidget.MRClassNameKey = "class vtkParallelopipedWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelopipedWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelopipedWidget"));
		}

		public vtkParallelopipedWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelopipedWidget New()
		{
			vtkParallelopipedWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelopipedWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelopipedWidget.vtkParallelopipedWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedWidget_EnableChairCreationOff_02(HandleRef pThis);

		public virtual void EnableChairCreationOff()
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_EnableChairCreationOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedWidget_EnableChairCreationOn_03(HandleRef pThis);

		public virtual void EnableChairCreationOn()
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_EnableChairCreationOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedWidget_GetEnableChairCreation_04(HandleRef pThis);

		public virtual int GetEnableChairCreation()
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_GetEnableChairCreation_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedWidget_GetParallelopipedRepresentation_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkParallelopipedRepresentation GetParallelopipedRepresentation()
		{
			vtkParallelopipedRepresentation vtkParallelopipedRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_GetParallelopipedRepresentation_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelopipedRepresentation = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelopipedRepresentation.Register(null);
				}
			}
			return vtkParallelopipedRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedWidget_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedWidget_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedWidget_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelopipedWidget NewInstance()
		{
			vtkParallelopipedWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedWidget_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelopipedWidget SafeDownCast(vtkObjectBase o)
		{
			vtkParallelopipedWidget vtkParallelopipedWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelopipedWidget = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelopipedWidget.Register(null);
				}
			}
			return vtkParallelopipedWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedWidget_SetEnableChairCreation_11(HandleRef pThis, int _arg);

		public virtual void SetEnableChairCreation(int _arg)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetEnableChairCreation_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedWidget_SetEnabled_12(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetEnabled_12(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedWidget_SetProcessEvents_13(HandleRef pThis, int arg0);

		public override void SetProcessEvents(int arg0)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetProcessEvents_13(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedWidget_SetRepresentation_14(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkParallelopipedRepresentation r)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetRepresentation_14(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
