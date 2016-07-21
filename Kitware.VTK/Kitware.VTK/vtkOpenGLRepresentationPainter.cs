using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLRepresentationPainter : vtkRepresentationPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRepresentationPainter";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLRepresentationPainter()
		{
			vtkOpenGLRepresentationPainter.MRClassNameKey = "class vtkOpenGLRepresentationPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRepresentationPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRepresentationPainter"));
		}

		public vtkOpenGLRepresentationPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRepresentationPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLRepresentationPainter New()
		{
			vtkOpenGLRepresentationPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRepresentationPainter.vtkOpenGLRepresentationPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRepresentationPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLRepresentationPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLRepresentationPainter.vtkOpenGLRepresentationPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkOpenGLRepresentationPainter_GetTimeToDraw_01(HandleRef pThis);

		public override double GetTimeToDraw()
		{
			return vtkOpenGLRepresentationPainter.vtkOpenGLRepresentationPainter_GetTimeToDraw_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRepresentationPainter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLRepresentationPainter.vtkOpenGLRepresentationPainter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRepresentationPainter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRepresentationPainter.vtkOpenGLRepresentationPainter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRepresentationPainter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLRepresentationPainter NewInstance()
		{
			vtkOpenGLRepresentationPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRepresentationPainter.vtkOpenGLRepresentationPainter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRepresentationPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRepresentationPainter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLRepresentationPainter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRepresentationPainter vtkOpenGLRepresentationPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRepresentationPainter.vtkOpenGLRepresentationPainter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRepresentationPainter = (vtkOpenGLRepresentationPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRepresentationPainter.Register(null);
				}
			}
			return vtkOpenGLRepresentationPainter;
		}
	}
}
