using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDistanceWidget : vtkAbstractWidget
	{
		public enum Define_WrapperEnum
		{
			Define = 1,
			Manipulate,
			Start = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceWidget";

		public new static readonly string MRClassNameKey;

		static vtkDistanceWidget()
		{
			vtkDistanceWidget.MRClassNameKey = "class vtkDistanceWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceWidget"));
		}

		public vtkDistanceWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceWidget New()
		{
			vtkDistanceWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDistanceWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDistanceWidget.vtkDistanceWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkDistanceWidget.vtkDistanceWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceWidget_GetDistanceRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDistanceRepresentation GetDistanceRepresentation()
		{
			vtkDistanceRepresentation vtkDistanceRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_GetDistanceRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation.Register(null);
				}
			}
			return vtkDistanceRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceWidget_GetWidgetState_03(HandleRef pThis);

		public virtual int GetWidgetState()
		{
			return vtkDistanceWidget.vtkDistanceWidget_GetWidgetState_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceWidget_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistanceWidget.vtkDistanceWidget_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceWidget_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistanceWidget.vtkDistanceWidget_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistanceWidget NewInstance()
		{
			vtkDistanceWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceWidget SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceWidget vtkDistanceWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceWidget.vtkDistanceWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceWidget = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceWidget.Register(null);
				}
			}
			return vtkDistanceWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceWidget_SetEnabled_09(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkDistanceWidget.vtkDistanceWidget_SetEnabled_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceWidget_SetProcessEvents_10(HandleRef pThis, int arg0);

		public override void SetProcessEvents(int arg0)
		{
			vtkDistanceWidget.vtkDistanceWidget_SetProcessEvents_10(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceWidget_SetRepresentation_11(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkDistanceRepresentation r)
		{
			vtkDistanceWidget.vtkDistanceWidget_SetRepresentation_11(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceWidget_SetWidgetStateToManipulate_12(HandleRef pThis);

		public virtual void SetWidgetStateToManipulate()
		{
			vtkDistanceWidget.vtkDistanceWidget_SetWidgetStateToManipulate_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceWidget_SetWidgetStateToStart_13(HandleRef pThis);

		public virtual void SetWidgetStateToStart()
		{
			vtkDistanceWidget.vtkDistanceWidget_SetWidgetStateToStart_13(base.GetCppThis());
		}
	}
}
