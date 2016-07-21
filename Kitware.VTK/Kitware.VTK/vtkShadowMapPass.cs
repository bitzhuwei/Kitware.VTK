using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkShadowMapPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShadowMapPass";

		public new static readonly string MRClassNameKey;

		static vtkShadowMapPass()
		{
			vtkShadowMapPass.MRClassNameKey = "class vtkShadowMapPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShadowMapPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShadowMapPass"));
		}

		public vtkShadowMapPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShadowMapPass New()
		{
			vtkShadowMapPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkShadowMapPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkShadowMapPass.vtkShadowMapPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapPass_GetOpaquePass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetOpaquePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_GetOpaquePass_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkShadowMapPass_GetShadowMapBakerPass_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkShadowMapBakerPass GetShadowMapBakerPass()
		{
			vtkShadowMapBakerPass vtkShadowMapBakerPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_GetShadowMapBakerPass_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShadowMapBakerPass = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShadowMapBakerPass.Register(null);
				}
			}
			return vtkShadowMapBakerPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShadowMapPass_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShadowMapPass.vtkShadowMapPass_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShadowMapPass_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShadowMapPass.vtkShadowMapPass_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShadowMapPass NewInstance()
		{
			vtkShadowMapPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapPass_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkShadowMapPass.vtkShadowMapPass_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShadowMapPass SafeDownCast(vtkObjectBase o)
		{
			vtkShadowMapPass vtkShadowMapPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShadowMapPass = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShadowMapPass.Register(null);
				}
			}
			return vtkShadowMapPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapPass_SetOpaquePass_09(HandleRef pThis, HandleRef opaquePass);

		public virtual void SetOpaquePass(vtkRenderPass opaquePass)
		{
			vtkShadowMapPass.vtkShadowMapPass_SetOpaquePass_09(base.GetCppThis(), (opaquePass == null) ? default(HandleRef) : opaquePass.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapPass_SetShadowMapBakerPass_10(HandleRef pThis, HandleRef shadowMapBakerPass);

		public virtual void SetShadowMapBakerPass(vtkShadowMapBakerPass shadowMapBakerPass)
		{
			vtkShadowMapPass.vtkShadowMapPass_SetShadowMapBakerPass_10(base.GetCppThis(), (shadowMapBakerPass == null) ? default(HandleRef) : shadowMapBakerPass.GetCppThis());
		}
	}
}
