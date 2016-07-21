using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWidgetSet : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetSet";

		public new static readonly string MRClassNameKey;

		static vtkWidgetSet()
		{
			vtkWidgetSet.MRClassNameKey = "class vtkWidgetSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetSet"));
		}

		public vtkWidgetSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetSet New()
		{
			vtkWidgetSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWidgetSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWidgetSet.vtkWidgetSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetSet_AddWidget_01(HandleRef pThis, HandleRef arg0);

		public void AddWidget(vtkAbstractWidget arg0)
		{
			vtkWidgetSet.vtkWidgetSet_AddWidget_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetSet_EnabledOff_02(HandleRef pThis);

		public virtual void EnabledOff()
		{
			vtkWidgetSet.vtkWidgetSet_EnabledOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetSet_EnabledOn_03(HandleRef pThis);

		public virtual void EnabledOn()
		{
			vtkWidgetSet.vtkWidgetSet_EnabledOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetSet_GetNthWidget_04(HandleRef pThis, uint arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractWidget GetNthWidget(uint arg0)
		{
			vtkAbstractWidget vtkAbstractWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_GetNthWidget_04(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractWidget = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractWidget.Register(null);
				}
			}
			return vtkAbstractWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern uint vtkWidgetSet_GetNumberOfWidgets_05(HandleRef pThis);

		public uint GetNumberOfWidgets()
		{
			return vtkWidgetSet.vtkWidgetSet_GetNumberOfWidgets_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetSet_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWidgetSet.vtkWidgetSet_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetSet_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWidgetSet.vtkWidgetSet_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetSet_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWidgetSet NewInstance()
		{
			vtkWidgetSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetSet_RemoveWidget_10(HandleRef pThis, HandleRef arg0);

		public void RemoveWidget(vtkAbstractWidget arg0)
		{
			vtkWidgetSet.vtkWidgetSet_RemoveWidget_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetSet_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetSet SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetSet vtkWidgetSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetSet = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetSet.Register(null);
				}
			}
			return vtkWidgetSet;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetSet_SetEnabled_12(HandleRef pThis, int arg0);

		public virtual void SetEnabled(int arg0)
		{
			vtkWidgetSet.vtkWidgetSet_SetEnabled_12(base.GetCppThis(), arg0);
		}
	}
}
