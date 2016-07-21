using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderedSurfaceRepresentation : vtkRenderedRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedSurfaceRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkRenderedSurfaceRepresentation()
		{
			vtkRenderedSurfaceRepresentation.MRClassNameKey = "class vtkRenderedSurfaceRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedSurfaceRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedSurfaceRepresentation"));
		}

		public vtkRenderedSurfaceRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedSurfaceRepresentation New()
		{
			vtkRenderedSurfaceRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedSurfaceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderedSurfaceRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedSurfaceRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_GetCellColorArrayName_02(HandleRef pThis);

		public virtual string GetCellColorArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_GetCellColorArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedSurfaceRepresentation_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderedSurfaceRepresentation_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderedSurfaceRepresentation NewInstance()
		{
			vtkRenderedSurfaceRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedSurfaceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedSurfaceRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedSurfaceRepresentation vtkRenderedSurfaceRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedSurfaceRepresentation = (vtkRenderedSurfaceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedSurfaceRepresentation.Register(null);
				}
			}
			return vtkRenderedSurfaceRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderedSurfaceRepresentation_SetCellColorArrayName_08(HandleRef pThis, string arrayName);

		public virtual void SetCellColorArrayName(string arrayName)
		{
			vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_SetCellColorArrayName_08(base.GetCppThis(), arrayName);
		}
	}
}
