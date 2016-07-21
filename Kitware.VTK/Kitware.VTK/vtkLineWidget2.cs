using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLineWidget2 : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLineWidget2";

		public new static readonly string MRClassNameKey;

		static vtkLineWidget2()
		{
			vtkLineWidget2.MRClassNameKey = "class vtkLineWidget2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineWidget2"));
		}

		public vtkLineWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineWidget2 New()
		{
			vtkLineWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLineWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLineWidget2.vtkLineWidget2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkLineWidget2.vtkLineWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget2_GetLineRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkLineRepresentation GetLineRepresentation()
		{
			vtkLineRepresentation vtkLineRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_GetLineRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineRepresentation = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineRepresentation.Register(null);
				}
			}
			return vtkLineRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget2_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLineWidget2.vtkLineWidget2_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineWidget2_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLineWidget2.vtkLineWidget2_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget2_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLineWidget2 NewInstance()
		{
			vtkLineWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineWidget2_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkLineWidget2 vtkLineWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineWidget2.vtkLineWidget2_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineWidget = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineWidget.Register(null);
				}
			}
			return vtkLineWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget2_SetEnabled_08(HandleRef pThis, int enabling);

		public override void SetEnabled(int enabling)
		{
			vtkLineWidget2.vtkLineWidget2_SetEnabled_08(base.GetCppThis(), enabling);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget2_SetProcessEvents_09(HandleRef pThis, int arg0);

		public override void SetProcessEvents(int arg0)
		{
			vtkLineWidget2.vtkLineWidget2_SetProcessEvents_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineWidget2_SetRepresentation_10(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkLineRepresentation r)
		{
			vtkLineWidget2.vtkLineWidget2_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
