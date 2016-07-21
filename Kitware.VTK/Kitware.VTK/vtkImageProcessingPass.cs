using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkImageProcessingPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageProcessingPass";

		public new static readonly string MRClassNameKey;

		static vtkImageProcessingPass()
		{
			vtkImageProcessingPass.MRClassNameKey = "class vtkImageProcessingPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageProcessingPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageProcessingPass"));
		}

		public vtkImageProcessingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageProcessingPass_GetDelegatePass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetDelegatePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageProcessingPass.vtkImageProcessingPass_GetDelegatePass_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageProcessingPass_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageProcessingPass.vtkImageProcessingPass_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageProcessingPass_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageProcessingPass.vtkImageProcessingPass_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageProcessingPass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageProcessingPass NewInstance()
		{
			vtkImageProcessingPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageProcessingPass.vtkImageProcessingPass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageProcessingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageProcessingPass_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkImageProcessingPass.vtkImageProcessingPass_ReleaseGraphicsResources_05(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageProcessingPass_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageProcessingPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageProcessingPass vtkImageProcessingPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageProcessingPass.vtkImageProcessingPass_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageProcessingPass = (vtkImageProcessingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageProcessingPass.Register(null);
				}
			}
			return vtkImageProcessingPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageProcessingPass_SetDelegatePass_07(HandleRef pThis, HandleRef delegatePass);

		public virtual void SetDelegatePass(vtkRenderPass delegatePass)
		{
			vtkImageProcessingPass.vtkImageProcessingPass_SetDelegatePass_07(base.GetCppThis(), (delegatePass == null) ? default(HandleRef) : delegatePass.GetCppThis());
		}
	}
}
