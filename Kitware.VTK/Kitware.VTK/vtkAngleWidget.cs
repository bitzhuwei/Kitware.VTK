using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAngleWidget : vtkAbstractWidget
	{
		public enum Define_WrapperEnum
		{
			Define = 1,
			Manipulate,
			Start = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleWidget";

		public new static readonly string MRClassNameKey;

		static vtkAngleWidget()
		{
			vtkAngleWidget.MRClassNameKey = "class vtkAngleWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleWidget"));
		}

		public vtkAngleWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAngleWidget New()
		{
			vtkAngleWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAngleWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAngleWidget.vtkAngleWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkAngleWidget.vtkAngleWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleWidget_GetAngleRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAngleRepresentation GetAngleRepresentation()
		{
			vtkAngleRepresentation vtkAngleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_GetAngleRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation.Register(null);
				}
			}
			return vtkAngleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleWidget_GetWidgetState_03(HandleRef pThis);

		public virtual int GetWidgetState()
		{
			return vtkAngleWidget.vtkAngleWidget_GetWidgetState_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleWidget_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAngleWidget.vtkAngleWidget_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleWidget_IsAngleValid_05(HandleRef pThis);

		public int IsAngleValid()
		{
			return vtkAngleWidget.vtkAngleWidget_IsAngleValid_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleWidget_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAngleWidget.vtkAngleWidget_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAngleWidget NewInstance()
		{
			vtkAngleWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAngleWidget SafeDownCast(vtkObjectBase o)
		{
			vtkAngleWidget vtkAngleWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleWidget.vtkAngleWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleWidget = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleWidget.Register(null);
				}
			}
			return vtkAngleWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleWidget_SetEnabled_10(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkAngleWidget.vtkAngleWidget_SetEnabled_10(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleWidget_SetProcessEvents_11(HandleRef pThis, int arg0);

		public override void SetProcessEvents(int arg0)
		{
			vtkAngleWidget.vtkAngleWidget_SetProcessEvents_11(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleWidget_SetRepresentation_12(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkAngleRepresentation r)
		{
			vtkAngleWidget.vtkAngleWidget_SetRepresentation_12(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleWidget_SetWidgetStateToManipulate_13(HandleRef pThis);

		public virtual void SetWidgetStateToManipulate()
		{
			vtkAngleWidget.vtkAngleWidget_SetWidgetStateToManipulate_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleWidget_SetWidgetStateToStart_14(HandleRef pThis);

		public virtual void SetWidgetStateToStart()
		{
			vtkAngleWidget.vtkAngleWidget_SetWidgetStateToStart_14(base.GetCppThis());
		}
	}
}
