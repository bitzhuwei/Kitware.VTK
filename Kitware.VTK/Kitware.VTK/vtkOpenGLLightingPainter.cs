using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLLightingPainter : vtkLightingPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLLightingPainter";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLLightingPainter()
		{
			vtkOpenGLLightingPainter.MRClassNameKey = "class vtkOpenGLLightingPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLLightingPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLLightingPainter"));
		}

		public vtkOpenGLLightingPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLLightingPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLLightingPainter New()
		{
			vtkOpenGLLightingPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLLightingPainter.vtkOpenGLLightingPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLightingPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLLightingPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLLightingPainter.vtkOpenGLLightingPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkOpenGLLightingPainter_GetTimeToDraw_01(HandleRef pThis);

		public override double GetTimeToDraw()
		{
			return vtkOpenGLLightingPainter.vtkOpenGLLightingPainter_GetTimeToDraw_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLLightingPainter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLLightingPainter.vtkOpenGLLightingPainter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLLightingPainter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLLightingPainter.vtkOpenGLLightingPainter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLLightingPainter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLLightingPainter NewInstance()
		{
			vtkOpenGLLightingPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLLightingPainter.vtkOpenGLLightingPainter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLightingPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLLightingPainter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLLightingPainter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLLightingPainter vtkOpenGLLightingPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLLightingPainter.vtkOpenGLLightingPainter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLLightingPainter = (vtkOpenGLLightingPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLLightingPainter.Register(null);
				}
			}
			return vtkOpenGLLightingPainter;
		}
	}
}
