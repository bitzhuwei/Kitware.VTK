using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPCosmoHaloFinder : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCosmoHaloFinder";

		public new static readonly string MRClassNameKey;

		static vtkPCosmoHaloFinder()
		{
			vtkPCosmoHaloFinder.MRClassNameKey = "class vtkPCosmoHaloFinder";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCosmoHaloFinder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCosmoHaloFinder"));
		}

		public vtkPCosmoHaloFinder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoHaloFinder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCosmoHaloFinder New()
		{
			vtkPCosmoHaloFinder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCosmoHaloFinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPCosmoHaloFinder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkPCosmoHaloFinder_GetBB_01(HandleRef pThis);

		public virtual float GetBB()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetBB_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_GetComputeMostBoundParticle_02(HandleRef pThis);

		public virtual int GetComputeMostBoundParticle()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetComputeMostBoundParticle_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_GetComputeMostConnectedParticle_03(HandleRef pThis);

		public virtual int GetComputeMostConnectedParticle()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetComputeMostConnectedParticle_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_GetComputeSOD_04(HandleRef pThis);

		public virtual int GetComputeSOD()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetComputeSOD_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoHaloFinder_GetController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetController_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPCosmoHaloFinder_GetCopyHaloDataToParticles_06(HandleRef pThis);

		public virtual int GetCopyHaloDataToParticles()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetCopyHaloDataToParticles_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_GetNP_07(HandleRef pThis);

		public virtual int GetNP()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetNP_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkPCosmoHaloFinder_GetOverlap_08(HandleRef pThis);

		public virtual float GetOverlap()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetOverlap_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_GetPMin_09(HandleRef pThis);

		public virtual int GetPMin()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetPMin_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkPCosmoHaloFinder_GetRL_10(HandleRef pThis);

		public virtual float GetRL()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetRL_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkPCosmoHaloFinder_GetRhoCScale_11(HandleRef pThis);

		public virtual float GetRhoCScale()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetRhoCScale_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_GetSODCenterType_12(HandleRef pThis);

		public virtual int GetSODCenterType()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetSODCenterType_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkPCosmoHaloFinder_GetSODMassScale_13(HandleRef pThis);

		public virtual float GetSODMassScale()
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_GetSODMassScale_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoHaloFinder_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoHaloFinder_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPCosmoHaloFinder NewInstance()
		{
			vtkPCosmoHaloFinder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCosmoHaloFinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoHaloFinder_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCosmoHaloFinder SafeDownCast(vtkObjectBase o)
		{
			vtkPCosmoHaloFinder vtkPCosmoHaloFinder = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCosmoHaloFinder = (vtkPCosmoHaloFinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCosmoHaloFinder.Register(null);
				}
			}
			return vtkPCosmoHaloFinder;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetBB_19(HandleRef pThis, float _arg);

		public virtual void SetBB(float _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetBB_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetComputeMostBoundParticle_20(HandleRef pThis, int _arg);

		public virtual void SetComputeMostBoundParticle(int _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetComputeMostBoundParticle_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetComputeMostConnectedParticle_21(HandleRef pThis, int _arg);

		public virtual void SetComputeMostConnectedParticle(int _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetComputeMostConnectedParticle_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetComputeSOD_22(HandleRef pThis, int _arg);

		public virtual void SetComputeSOD(int _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetComputeSOD_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetController_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetController_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetCopyHaloDataToParticles_24(HandleRef pThis, int _arg);

		public virtual void SetCopyHaloDataToParticles(int _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetCopyHaloDataToParticles_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetNP_25(HandleRef pThis, int _arg);

		public virtual void SetNP(int _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetNP_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetOverlap_26(HandleRef pThis, float _arg);

		public virtual void SetOverlap(float _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetOverlap_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetPMin_27(HandleRef pThis, int _arg);

		public virtual void SetPMin(int _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetPMin_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetRL_28(HandleRef pThis, float _arg);

		public virtual void SetRL(float _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetRL_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetRhoCScale_29(HandleRef pThis, float _arg);

		public virtual void SetRhoCScale(float _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetRhoCScale_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetSODCenterType_30(HandleRef pThis, int _arg);

		public virtual void SetSODCenterType(int _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetSODCenterType_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoHaloFinder_SetSODMassScale_31(HandleRef pThis, float _arg);

		public virtual void SetSODMassScale(float _arg)
		{
			vtkPCosmoHaloFinder.vtkPCosmoHaloFinder_SetSODMassScale_31(base.GetCppThis(), _arg);
		}
	}
}
