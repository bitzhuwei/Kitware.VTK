using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGLSLShader : vtkShader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLShader";

		public new static readonly string MRClassNameKey;

		static vtkGLSLShader()
		{
			vtkGLSLShader.MRClassNameKey = "class vtkGLSLShader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLShader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLShader"));
		}

		public vtkGLSLShader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGLSLShader New()
		{
			vtkGLSLShader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShader.vtkGLSLShader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGLSLShader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGLSLShader.vtkGLSLShader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGLSLShader_Compile_01(HandleRef pThis);

		public override int Compile()
		{
			return vtkGLSLShader.vtkGLSLShader_Compile_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkGLSLShader_GetHandle_02(HandleRef pThis);

		public uint GetHandle()
		{
			return vtkGLSLShader.vtkGLSLShader_GetHandle_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkGLSLShader_GetProgram_03(HandleRef pThis);

		public virtual uint GetProgram()
		{
			return vtkGLSLShader.vtkGLSLShader_GetProgram_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGLSLShader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGLSLShader.vtkGLSLShader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGLSLShader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGLSLShader.vtkGLSLShader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGLSLShader NewInstance()
		{
			vtkGLSLShader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShader.vtkGLSLShader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGLSLShader_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkGLSLShader.vtkGLSLShader_ReleaseGraphicsResources_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGLSLShader SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLShader vtkGLSLShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShader.vtkGLSLShader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLShader = (vtkGLSLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLShader.Register(null);
				}
			}
			return vtkGLSLShader;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGLSLShader_SetProgram_10(HandleRef pThis, uint _arg);

		public virtual void SetProgram(uint _arg)
		{
			vtkGLSLShader.vtkGLSLShader_SetProgram_10(base.GetCppThis(), _arg);
		}
	}
}
