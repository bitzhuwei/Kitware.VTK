using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGaussianBlurPass : vtkImageProcessingPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianBlurPass";

		public new static readonly string MRClassNameKey;

		static vtkGaussianBlurPass()
		{
			vtkGaussianBlurPass.MRClassNameKey = "class vtkGaussianBlurPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianBlurPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianBlurPass"));
		}

		public vtkGaussianBlurPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianBlurPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGaussianBlurPass New()
		{
			vtkGaussianBlurPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianBlurPass.vtkGaussianBlurPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianBlurPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGaussianBlurPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGaussianBlurPass.vtkGaussianBlurPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGaussianBlurPass_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGaussianBlurPass.vtkGaussianBlurPass_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGaussianBlurPass_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGaussianBlurPass.vtkGaussianBlurPass_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianBlurPass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGaussianBlurPass NewInstance()
		{
			vtkGaussianBlurPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianBlurPass.vtkGaussianBlurPass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianBlurPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGaussianBlurPass_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkGaussianBlurPass.vtkGaussianBlurPass_ReleaseGraphicsResources_05(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianBlurPass_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGaussianBlurPass SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianBlurPass vtkGaussianBlurPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianBlurPass.vtkGaussianBlurPass_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianBlurPass = (vtkGaussianBlurPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianBlurPass.Register(null);
				}
			}
			return vtkGaussianBlurPass;
		}
	}
}
