using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSobelGradientMagnitudePass : vtkImageProcessingPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSobelGradientMagnitudePass";

		public new static readonly string MRClassNameKey;

		static vtkSobelGradientMagnitudePass()
		{
			vtkSobelGradientMagnitudePass.MRClassNameKey = "class vtkSobelGradientMagnitudePass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSobelGradientMagnitudePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSobelGradientMagnitudePass"));
		}

		public vtkSobelGradientMagnitudePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSobelGradientMagnitudePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSobelGradientMagnitudePass New()
		{
			vtkSobelGradientMagnitudePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSobelGradientMagnitudePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSobelGradientMagnitudePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSobelGradientMagnitudePass_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSobelGradientMagnitudePass_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSobelGradientMagnitudePass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSobelGradientMagnitudePass NewInstance()
		{
			vtkSobelGradientMagnitudePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSobelGradientMagnitudePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSobelGradientMagnitudePass_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_ReleaseGraphicsResources_05(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSobelGradientMagnitudePass_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSobelGradientMagnitudePass SafeDownCast(vtkObjectBase o)
		{
			vtkSobelGradientMagnitudePass vtkSobelGradientMagnitudePass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSobelGradientMagnitudePass.vtkSobelGradientMagnitudePass_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSobelGradientMagnitudePass = (vtkSobelGradientMagnitudePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSobelGradientMagnitudePass.Register(null);
				}
			}
			return vtkSobelGradientMagnitudePass;
		}
	}
}
