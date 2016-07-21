using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSplineWidget2 : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineWidget2";

		public new static readonly string MRClassNameKey;

		static vtkSplineWidget2()
		{
			vtkSplineWidget2.MRClassNameKey = "class vtkSplineWidget2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineWidget2"));
		}

		public vtkSplineWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineWidget2 New()
		{
			vtkSplineWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget2.vtkSplineWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSplineWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSplineWidget2.vtkSplineWidget2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkSplineWidget2.vtkSplineWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget2_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSplineWidget2.vtkSplineWidget2_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSplineWidget2_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSplineWidget2.vtkSplineWidget2_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget2_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSplineWidget2 NewInstance()
		{
			vtkSplineWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget2.vtkSplineWidget2_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineWidget2_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkSplineWidget2 vtkSplineWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineWidget2.vtkSplineWidget2_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineWidget = (vtkSplineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineWidget.Register(null);
				}
			}
			return vtkSplineWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSplineWidget2_SetRepresentation_07(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkSplineRepresentation r)
		{
			vtkSplineWidget2.vtkSplineWidget2_SetRepresentation_07(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
