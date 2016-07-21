using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLPolyDataMapper2D : vtkPolyDataMapper2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPolyDataMapper2D";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLPolyDataMapper2D()
		{
			vtkOpenGLPolyDataMapper2D.MRClassNameKey = "class vtkOpenGLPolyDataMapper2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLPolyDataMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPolyDataMapper2D"));
		}

		public vtkOpenGLPolyDataMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPolyDataMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLPolyDataMapper2D New()
		{
			vtkOpenGLPolyDataMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLPolyDataMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPolyDataMapper2D_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPolyDataMapper2D_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPolyDataMapper2D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLPolyDataMapper2D NewInstance()
		{
			vtkOpenGLPolyDataMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPolyDataMapper2D_RenderOverlay_05(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_RenderOverlay_05(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPolyDataMapper2D_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLPolyDataMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLPolyDataMapper2D vtkOpenGLPolyDataMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPolyDataMapper2D.vtkOpenGLPolyDataMapper2D_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLPolyDataMapper2D = (vtkOpenGLPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLPolyDataMapper2D.Register(null);
				}
			}
			return vtkOpenGLPolyDataMapper2D;
		}
	}
}
