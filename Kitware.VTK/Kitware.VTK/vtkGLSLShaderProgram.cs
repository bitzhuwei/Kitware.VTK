using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGLSLShaderProgram : vtkShaderProgram
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLShaderProgram";

		public new static readonly string MRClassNameKey;

		static vtkGLSLShaderProgram()
		{
			vtkGLSLShaderProgram.MRClassNameKey = "class vtkGLSLShaderProgram";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLShaderProgram.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLShaderProgram"));
		}

		public vtkGLSLShaderProgram(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShaderProgram_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGLSLShaderProgram New()
		{
			vtkGLSLShaderProgram result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShaderProgram.vtkGLSLShaderProgram_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGLSLShaderProgram() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGLSLShaderProgram.vtkGLSLShaderProgram_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkGLSLShaderProgram_GetProgram_01(HandleRef pThis);

		public uint GetProgram()
		{
			return vtkGLSLShaderProgram.vtkGLSLShaderProgram_GetProgram_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGLSLShaderProgram_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGLSLShaderProgram.vtkGLSLShaderProgram_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGLSLShaderProgram_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGLSLShaderProgram.vtkGLSLShaderProgram_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShaderProgram_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGLSLShaderProgram NewInstance()
		{
			vtkGLSLShaderProgram result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShaderProgram.vtkGLSLShaderProgram_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGLSLShaderProgram_PostRender_06(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void PostRender(vtkActor arg0, vtkRenderer arg1)
		{
			vtkGLSLShaderProgram.vtkGLSLShaderProgram_PostRender_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGLSLShaderProgram_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkGLSLShaderProgram.vtkGLSLShaderProgram_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGLSLShaderProgram_Render_08(HandleRef pThis, HandleRef actor, HandleRef renderer);

		public override void Render(vtkActor actor, vtkRenderer renderer)
		{
			vtkGLSLShaderProgram.vtkGLSLShaderProgram_Render_08(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShaderProgram_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGLSLShaderProgram SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLShaderProgram vtkGLSLShaderProgram = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShaderProgram.vtkGLSLShaderProgram_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLShaderProgram = (vtkGLSLShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLShaderProgram.Register(null);
				}
			}
			return vtkGLSLShaderProgram;
		}
	}
}
