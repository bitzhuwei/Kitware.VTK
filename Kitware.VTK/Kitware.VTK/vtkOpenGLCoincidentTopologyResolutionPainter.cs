using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLCoincidentTopologyResolutionPainter : vtkCoincidentTopologyResolutionPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLCoincidentTopologyResolutionPainter";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLCoincidentTopologyResolutionPainter()
		{
			vtkOpenGLCoincidentTopologyResolutionPainter.MRClassNameKey = "class vtkOpenGLCoincidentTopologyResolutionPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLCoincidentTopologyResolutionPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLCoincidentTopologyResolutionPainter"));
		}

		public vtkOpenGLCoincidentTopologyResolutionPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLCoincidentTopologyResolutionPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLCoincidentTopologyResolutionPainter New()
		{
			vtkOpenGLCoincidentTopologyResolutionPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLCoincidentTopologyResolutionPainter.vtkOpenGLCoincidentTopologyResolutionPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCoincidentTopologyResolutionPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLCoincidentTopologyResolutionPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLCoincidentTopologyResolutionPainter.vtkOpenGLCoincidentTopologyResolutionPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLCoincidentTopologyResolutionPainter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLCoincidentTopologyResolutionPainter.vtkOpenGLCoincidentTopologyResolutionPainter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLCoincidentTopologyResolutionPainter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLCoincidentTopologyResolutionPainter.vtkOpenGLCoincidentTopologyResolutionPainter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLCoincidentTopologyResolutionPainter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLCoincidentTopologyResolutionPainter NewInstance()
		{
			vtkOpenGLCoincidentTopologyResolutionPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLCoincidentTopologyResolutionPainter.vtkOpenGLCoincidentTopologyResolutionPainter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCoincidentTopologyResolutionPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLCoincidentTopologyResolutionPainter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLCoincidentTopologyResolutionPainter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLCoincidentTopologyResolutionPainter vtkOpenGLCoincidentTopologyResolutionPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLCoincidentTopologyResolutionPainter.vtkOpenGLCoincidentTopologyResolutionPainter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLCoincidentTopologyResolutionPainter = (vtkOpenGLCoincidentTopologyResolutionPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLCoincidentTopologyResolutionPainter.Register(null);
				}
			}
			return vtkOpenGLCoincidentTopologyResolutionPainter;
		}
	}
}
