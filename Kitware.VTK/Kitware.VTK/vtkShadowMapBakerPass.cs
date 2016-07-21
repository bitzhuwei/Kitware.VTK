using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkShadowMapBakerPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShadowMapBakerPass";

		public new static readonly string MRClassNameKey;

		static vtkShadowMapBakerPass()
		{
			vtkShadowMapBakerPass.MRClassNameKey = "class vtkShadowMapBakerPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShadowMapBakerPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShadowMapBakerPass"));
		}

		public vtkShadowMapBakerPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapBakerPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShadowMapBakerPass New()
		{
			vtkShadowMapBakerPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkShadowMapBakerPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkShadowMapBakerPass.vtkShadowMapBakerPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapBakerPass_GetCompositeZPass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetCompositeZPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetCompositeZPass_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkShadowMapBakerPass_GetHasShadows_02(HandleRef pThis);

		public bool GetHasShadows()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetHasShadows_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkShadowMapBakerPass_GetNeedUpdate_03(HandleRef pThis);

		public bool GetNeedUpdate()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetNeedUpdate_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapBakerPass_GetOpaquePass_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetOpaquePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetOpaquePass_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern float vtkShadowMapBakerPass_GetPolygonOffsetFactor_05(HandleRef pThis);

		public virtual float GetPolygonOffsetFactor()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetPolygonOffsetFactor_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkShadowMapBakerPass_GetPolygonOffsetUnits_06(HandleRef pThis);

		public virtual float GetPolygonOffsetUnits()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetPolygonOffsetUnits_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkShadowMapBakerPass_GetResolution_07(HandleRef pThis);

		public virtual uint GetResolution()
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_GetResolution_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShadowMapBakerPass_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShadowMapBakerPass_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkShadowMapBakerPass_LightCreatesShadow_10(HandleRef pThis, HandleRef l);

		public bool LightCreatesShadow(vtkLight l)
		{
			return vtkShadowMapBakerPass.vtkShadowMapBakerPass_LightCreatesShadow_10(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapBakerPass_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShadowMapBakerPass NewInstance()
		{
			vtkShadowMapBakerPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapBakerPass_OCCLUDER_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey OCCLUDER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_OCCLUDER_13(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapBakerPass_RECEIVER_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey RECEIVER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_RECEIVER_14(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapBakerPass_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_ReleaseGraphicsResources_15(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShadowMapBakerPass_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShadowMapBakerPass SafeDownCast(vtkObjectBase o)
		{
			vtkShadowMapBakerPass vtkShadowMapBakerPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShadowMapBakerPass.vtkShadowMapBakerPass_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkShadowMapBakerPass_SetCompositeZPass_17(HandleRef pThis, HandleRef compositeZPass);

		public virtual void SetCompositeZPass(vtkRenderPass compositeZPass)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetCompositeZPass_17(base.GetCppThis(), (compositeZPass == null) ? default(HandleRef) : compositeZPass.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapBakerPass_SetOpaquePass_18(HandleRef pThis, HandleRef opaquePass);

		public virtual void SetOpaquePass(vtkRenderPass opaquePass)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetOpaquePass_18(base.GetCppThis(), (opaquePass == null) ? default(HandleRef) : opaquePass.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapBakerPass_SetPolygonOffsetFactor_19(HandleRef pThis, float _arg);

		public virtual void SetPolygonOffsetFactor(float _arg)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetPolygonOffsetFactor_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapBakerPass_SetPolygonOffsetUnits_20(HandleRef pThis, float _arg);

		public virtual void SetPolygonOffsetUnits(float _arg)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetPolygonOffsetUnits_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapBakerPass_SetResolution_21(HandleRef pThis, uint _arg);

		public virtual void SetResolution(uint _arg)
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetResolution_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShadowMapBakerPass_SetUpToDate_22(HandleRef pThis);

		public void SetUpToDate()
		{
			vtkShadowMapBakerPass.vtkShadowMapBakerPass_SetUpToDate_22(base.GetCppThis());
		}
	}
}
