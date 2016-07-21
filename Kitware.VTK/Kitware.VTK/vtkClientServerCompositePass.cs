using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClientServerCompositePass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClientServerCompositePass";

		public new static readonly string MRClassNameKey;

		static vtkClientServerCompositePass()
		{
			vtkClientServerCompositePass.MRClassNameKey = "class vtkClientServerCompositePass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClientServerCompositePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClientServerCompositePass"));
		}

		public vtkClientServerCompositePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerCompositePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClientServerCompositePass New()
		{
			vtkClientServerCompositePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerCompositePass.vtkClientServerCompositePass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientServerCompositePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClientServerCompositePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClientServerCompositePass.vtkClientServerCompositePass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerCompositePass_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerCompositePass.vtkClientServerCompositePass_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerCompositePass_GetPostProcessingRenderPass_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetPostProcessingRenderPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerCompositePass.vtkClientServerCompositePass_GetPostProcessingRenderPass_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkClientServerCompositePass_GetProcessIsServer_03(HandleRef pThis);

		public virtual bool GetProcessIsServer()
		{
			return vtkClientServerCompositePass.vtkClientServerCompositePass_GetProcessIsServer_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerCompositePass_GetRenderPass_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetRenderPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerCompositePass.vtkClientServerCompositePass_GetRenderPass_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkClientServerCompositePass_GetServerSideRendering_05(HandleRef pThis);

		public virtual bool GetServerSideRendering()
		{
			return vtkClientServerCompositePass.vtkClientServerCompositePass_GetServerSideRendering_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkClientServerCompositePass_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClientServerCompositePass.vtkClientServerCompositePass_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkClientServerCompositePass_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClientServerCompositePass.vtkClientServerCompositePass_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerCompositePass_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClientServerCompositePass NewInstance()
		{
			vtkClientServerCompositePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerCompositePass.vtkClientServerCompositePass_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientServerCompositePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_ProcessIsServerOff_10(HandleRef pThis);

		public virtual void ProcessIsServerOff()
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_ProcessIsServerOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_ProcessIsServerOn_11(HandleRef pThis);

		public virtual void ProcessIsServerOn()
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_ProcessIsServerOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_ReleaseGraphicsResources_12(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_ReleaseGraphicsResources_12(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerCompositePass_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClientServerCompositePass SafeDownCast(vtkObjectBase o)
		{
			vtkClientServerCompositePass vtkClientServerCompositePass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerCompositePass.vtkClientServerCompositePass_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClientServerCompositePass = (vtkClientServerCompositePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClientServerCompositePass.Register(null);
				}
			}
			return vtkClientServerCompositePass;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_ServerSideRenderingOff_14(HandleRef pThis);

		public virtual void ServerSideRenderingOff()
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_ServerSideRenderingOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_ServerSideRenderingOn_15(HandleRef pThis);

		public virtual void ServerSideRenderingOn()
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_ServerSideRenderingOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_SetController_16(HandleRef pThis, HandleRef controller);

		public virtual void SetController(vtkMultiProcessController controller)
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_SetController_16(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_SetPostProcessingRenderPass_17(HandleRef pThis, HandleRef arg0);

		public void SetPostProcessingRenderPass(vtkRenderPass arg0)
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_SetPostProcessingRenderPass_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_SetProcessIsServer_18(HandleRef pThis, byte _arg);

		public virtual void SetProcessIsServer(bool _arg)
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_SetProcessIsServer_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_SetRenderPass_19(HandleRef pThis, HandleRef arg0);

		public void SetRenderPass(vtkRenderPass arg0)
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_SetRenderPass_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkClientServerCompositePass_SetServerSideRendering_20(HandleRef pThis, byte _arg);

		public virtual void SetServerSideRendering(bool _arg)
		{
			vtkClientServerCompositePass.vtkClientServerCompositePass_SetServerSideRendering_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
