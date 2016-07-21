using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderedRepresentation : vtkDataRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkRenderedRepresentation()
		{
			vtkRenderedRepresentation.MRClassNameKey = "class vtkRenderedRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedRepresentation"));
		}

		public vtkRenderedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedRepresentation New()
		{
			vtkRenderedRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedRepresentation.vtkRenderedRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderedRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderedRepresentation.vtkRenderedRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedRepresentation_GetLabelRenderMode_01(HandleRef pThis);

		public virtual int GetLabelRenderMode()
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_GetLabelRenderMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedRepresentation_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedRepresentation_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedRepresentation_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderedRepresentation NewInstance()
		{
			vtkRenderedRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedRepresentation.vtkRenderedRepresentation_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedRepresentation_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedRepresentation vtkRenderedRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedRepresentation.vtkRenderedRepresentation_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedRepresentation = (vtkRenderedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedRepresentation.Register(null);
				}
			}
			return vtkRenderedRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedRepresentation_SetLabelRenderMode_07(HandleRef pThis, int _arg);

		public virtual void SetLabelRenderMode(int _arg)
		{
			vtkRenderedRepresentation.vtkRenderedRepresentation_SetLabelRenderMode_07(base.GetCppThis(), _arg);
		}
	}
}
