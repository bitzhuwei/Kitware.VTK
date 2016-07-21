using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalStreamTracer : vtkStreamTracer
	{
		public new enum Units
		{
			TERMINATION_STEP_UNIT = 1,
			TERMINATION_TIME_UNIT = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalStreamTracer";

		public new static readonly string MRClassNameKey;

		static vtkTemporalStreamTracer()
		{
			vtkTemporalStreamTracer.MRClassNameKey = "class vtkTemporalStreamTracer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalStreamTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalStreamTracer"));
		}

		public vtkTemporalStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalStreamTracer New()
		{
			vtkTemporalStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStreamTracer.vtkTemporalStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalStreamTracer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalStreamTracer.vtkTemporalStreamTracer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_AddSourceConnection_01(HandleRef pThis, HandleRef input);

		public void AddSourceConnection(vtkAlgorithmOutput input)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_AddSourceConnection_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_EnableParticleWritingOff_02(HandleRef pThis);

		public virtual void EnableParticleWritingOff()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_EnableParticleWritingOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_EnableParticleWritingOn_03(HandleRef pThis);

		public virtual void EnableParticleWritingOn()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_EnableParticleWritingOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStreamTracer_GetController_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetController_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTemporalStreamTracer_GetEnableParticleWriting_05(HandleRef pThis);

		public virtual int GetEnableParticleWriting()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetEnableParticleWriting_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalStreamTracer_GetForceReinjectionEveryNSteps_06(HandleRef pThis);

		public virtual int GetForceReinjectionEveryNSteps()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetForceReinjectionEveryNSteps_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalStreamTracer_GetIgnorePipelineTime_07(HandleRef pThis);

		public virtual int GetIgnorePipelineTime()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetIgnorePipelineTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStreamTracer_GetParticleFileName_08(HandleRef pThis);

		public virtual string GetParticleFileName()
		{
			return Marshal.PtrToStringAnsi(vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetParticleFileName_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStreamTracer_GetParticleWriter_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractParticleWriter GetParticleWriter()
		{
			vtkAbstractParticleWriter vtkAbstractParticleWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetParticleWriter_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractParticleWriter = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractParticleWriter.Register(null);
				}
			}
			return vtkAbstractParticleWriter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalStreamTracer_GetStaticMesh_10(HandleRef pThis);

		public virtual int GetStaticMesh()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetStaticMesh_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalStreamTracer_GetStaticSeeds_11(HandleRef pThis);

		public virtual int GetStaticSeeds()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetStaticSeeds_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkTemporalStreamTracer_GetTerminationTime_12(HandleRef pThis);

		public virtual double GetTerminationTime()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetTerminationTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalStreamTracer_GetTerminationTimeUnit_13(HandleRef pThis);

		public virtual int GetTerminationTimeUnit()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetTerminationTimeUnit_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkTemporalStreamTracer_GetTimeStep_14(HandleRef pThis);

		public virtual uint GetTimeStep()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetTimeStep_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkTemporalStreamTracer_GetTimeStepResolution_15(HandleRef pThis);

		public virtual double GetTimeStepResolution()
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_GetTimeStepResolution_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_IgnorePipelineTimeOff_16(HandleRef pThis);

		public virtual void IgnorePipelineTimeOff()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_IgnorePipelineTimeOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_IgnorePipelineTimeOn_17(HandleRef pThis);

		public virtual void IgnorePipelineTimeOn()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_IgnorePipelineTimeOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalStreamTracer_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalStreamTracer_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalStreamTracer.vtkTemporalStreamTracer_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStreamTracer_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalStreamTracer NewInstance()
		{
			vtkTemporalStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStreamTracer.vtkTemporalStreamTracer_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_RemoveAllSources_22(HandleRef pThis);

		public void RemoveAllSources()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_RemoveAllSources_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStreamTracer_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalStreamTracer SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalStreamTracer vtkTemporalStreamTracer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStreamTracer.vtkTemporalStreamTracer_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalStreamTracer = (vtkTemporalStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalStreamTracer.Register(null);
				}
			}
			return vtkTemporalStreamTracer;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetController_24(HandleRef pThis, HandleRef controller);

		public virtual void SetController(vtkMultiProcessController controller)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetController_24(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetEnableParticleWriting_25(HandleRef pThis, int _arg);

		public virtual void SetEnableParticleWriting(int _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetEnableParticleWriting_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetForceReinjectionEveryNSteps_26(HandleRef pThis, int _arg);

		public virtual void SetForceReinjectionEveryNSteps(int _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetForceReinjectionEveryNSteps_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetIgnorePipelineTime_27(HandleRef pThis, int _arg);

		public virtual void SetIgnorePipelineTime(int _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetIgnorePipelineTime_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetParticleFileName_28(HandleRef pThis, string _arg);

		public virtual void SetParticleFileName(string _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetParticleFileName_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetParticleWriter_29(HandleRef pThis, HandleRef pw);

		public virtual void SetParticleWriter(vtkAbstractParticleWriter pw)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetParticleWriter_29(base.GetCppThis(), (pw == null) ? default(HandleRef) : pw.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetStaticMesh_30(HandleRef pThis, int _arg);

		public virtual void SetStaticMesh(int _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetStaticMesh_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetStaticSeeds_31(HandleRef pThis, int _arg);

		public virtual void SetStaticSeeds(int _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetStaticSeeds_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetTerminationTime_32(HandleRef pThis, double _arg);

		public virtual void SetTerminationTime(double _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetTerminationTime_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetTerminationTimeUnit_33(HandleRef pThis, int _arg);

		public virtual void SetTerminationTimeUnit(int _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetTerminationTimeUnit_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetTerminationTimeUnitToStepUnit_34(HandleRef pThis);

		public void SetTerminationTimeUnitToStepUnit()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetTerminationTimeUnitToStepUnit_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetTerminationTimeUnitToTimeUnit_35(HandleRef pThis);

		public void SetTerminationTimeUnitToTimeUnit()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetTerminationTimeUnitToTimeUnit_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetTimeStep_36(HandleRef pThis, uint _arg);

		public virtual void SetTimeStep(uint _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetTimeStep_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_SetTimeStepResolution_37(HandleRef pThis, double _arg);

		public virtual void SetTimeStepResolution(double _arg)
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_SetTimeStepResolution_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_StaticMeshOff_38(HandleRef pThis);

		public virtual void StaticMeshOff()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_StaticMeshOff_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_StaticMeshOn_39(HandleRef pThis);

		public virtual void StaticMeshOn()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_StaticMeshOn_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_StaticSeedsOff_40(HandleRef pThis);

		public virtual void StaticSeedsOff()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_StaticSeedsOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalStreamTracer_StaticSeedsOn_41(HandleRef pThis);

		public virtual void StaticSeedsOn()
		{
			vtkTemporalStreamTracer.vtkTemporalStreamTracer_StaticSeedsOn_41(base.GetCppThis());
		}
	}
}
