using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGlyph2D : vtkGlyph3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph2D";

		public new static readonly string MRClassNameKey;

		static vtkGlyph2D()
		{
			vtkGlyph2D.MRClassNameKey = "class vtkGlyph2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyph2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph2D"));
		}

		public vtkGlyph2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyph2D New()
		{
			vtkGlyph2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph2D.vtkGlyph2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGlyph2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGlyph2D.vtkGlyph2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph2D_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGlyph2D.vtkGlyph2D_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGlyph2D_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGlyph2D.vtkGlyph2D_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph2D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGlyph2D NewInstance()
		{
			vtkGlyph2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph2D.vtkGlyph2D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGlyph2D_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlyph2D SafeDownCast(vtkObjectBase o)
		{
			vtkGlyph2D vtkGlyph2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlyph2D.vtkGlyph2D_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyph2D = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyph2D.Register(null);
				}
			}
			return vtkGlyph2D;
		}
	}
}
