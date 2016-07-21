using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitPlaneWidget2 : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneWidget2";

		public new static readonly string MRClassNameKey;

		static vtkImplicitPlaneWidget2()
		{
			vtkImplicitPlaneWidget2.MRClassNameKey = "class vtkImplicitPlaneWidget2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitPlaneWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneWidget2"));
		}

		public vtkImplicitPlaneWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitPlaneWidget2 New()
		{
			vtkImplicitPlaneWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitPlaneWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget2_GetImplicitPlaneRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImplicitPlaneRepresentation GetImplicitPlaneRepresentation()
		{
			vtkImplicitPlaneRepresentation vtkImplicitPlaneRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_GetImplicitPlaneRepresentation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneRepresentation = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneRepresentation.Register(null);
				}
			}
			return vtkImplicitPlaneRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget2_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneWidget2_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget2_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitPlaneWidget2 NewInstance()
		{
			vtkImplicitPlaneWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneWidget2_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitPlaneWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitPlaneWidget2 vtkImplicitPlaneWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneWidget = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneWidget.Register(null);
				}
			}
			return vtkImplicitPlaneWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneWidget2_SetRepresentation_08(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkImplicitPlaneRepresentation r)
		{
			vtkImplicitPlaneWidget2.vtkImplicitPlaneWidget2_SetRepresentation_08(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
