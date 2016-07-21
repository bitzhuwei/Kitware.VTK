using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkRenderPass : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderPass";

		public new static readonly string MRClassNameKey;

		static vtkRenderPass()
		{
			vtkRenderPass.MRClassNameKey = "class vtkRenderPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderPass"));
		}

		public vtkRenderPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderPass_GetNumberOfRenderedProps_01(HandleRef pThis);

		public virtual int GetNumberOfRenderedProps()
		{
			return vtkRenderPass.vtkRenderPass_GetNumberOfRenderedProps_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderPass_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderPass.vtkRenderPass_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderPass_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderPass.vtkRenderPass_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderPass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderPass NewInstance()
		{
			vtkRenderPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderPass.vtkRenderPass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderPass_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef w);

		public virtual void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkRenderPass.vtkRenderPass_ReleaseGraphicsResources_05(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderPass_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderPass SafeDownCast(vtkObjectBase o)
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderPass.vtkRenderPass_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
