using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSource : vtkProcessObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSource";

		public new static readonly string MRClassNameKey;

		static vtkSource()
		{
			vtkSource.MRClassNameKey = "class vtkSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSource"));
		}

		public vtkSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_ComputeInputUpdateExtents_01(HandleRef pThis, HandleRef output);

		public virtual void ComputeInputUpdateExtents(vtkDataObject output)
		{
			vtkSource.vtkSource_ComputeInputUpdateExtents_01(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSource_GetNumberOfOutputs_02(HandleRef pThis);

		public virtual int GetNumberOfOutputs()
		{
			return vtkSource.vtkSource_GetNumberOfOutputs_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSource_GetOutputIndex_03(HandleRef pThis, HandleRef arg0);

		public int GetOutputIndex(vtkDataObject arg0)
		{
			return vtkSource.vtkSource_GetOutputIndex_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSource_GetReleaseDataFlag_04(HandleRef pThis);

		public override int GetReleaseDataFlag()
		{
			return vtkSource.vtkSource_GetReleaseDataFlag_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSource_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSource.vtkSource_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSource_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSource.vtkSource_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSource_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSource NewInstance()
		{
			vtkSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSource.vtkSource_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_PropagateUpdateExtent_08(HandleRef pThis, HandleRef output);

		public virtual void PropagateUpdateExtent(vtkDataObject output)
		{
			vtkSource.vtkSource_PropagateUpdateExtent_08(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_ReleaseDataFlagOff_09(HandleRef pThis);

		public new virtual void ReleaseDataFlagOff()
		{
			vtkSource.vtkSource_ReleaseDataFlagOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_ReleaseDataFlagOn_10(HandleRef pThis);

		public new virtual void ReleaseDataFlagOn()
		{
			vtkSource.vtkSource_ReleaseDataFlagOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSource_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSource SafeDownCast(vtkObjectBase o)
		{
			vtkSource vtkSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSource.vtkSource_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSource = (vtkSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSource.Register(null);
				}
			}
			return vtkSource;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_SetExecutive_12(HandleRef pThis, HandleRef executive);

		public override void SetExecutive(vtkExecutive executive)
		{
			vtkSource.vtkSource_SetExecutive_12(base.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_SetReleaseDataFlag_13(HandleRef pThis, int arg0);

		public override void SetReleaseDataFlag(int arg0)
		{
			vtkSource.vtkSource_SetReleaseDataFlag_13(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_TriggerAsynchronousUpdate_14(HandleRef pThis);

		public virtual void TriggerAsynchronousUpdate()
		{
			vtkSource.vtkSource_TriggerAsynchronousUpdate_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_UnRegisterAllOutputs_15(HandleRef pThis);

		public void UnRegisterAllOutputs()
		{
			vtkSource.vtkSource_UnRegisterAllOutputs_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_Update_16(HandleRef pThis);

		public override void Update()
		{
			vtkSource.vtkSource_Update_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_UpdateData_17(HandleRef pThis, HandleRef output);

		public virtual void UpdateData(vtkDataObject output)
		{
			vtkSource.vtkSource_UpdateData_17(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_UpdateInformation_18(HandleRef pThis);

		public override void UpdateInformation()
		{
			vtkSource.vtkSource_UpdateInformation_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSource_UpdateWholeExtent_19(HandleRef pThis);

		public override void UpdateWholeExtent()
		{
			vtkSource.vtkSource_UpdateWholeExtent_19(base.GetCppThis());
		}
	}
}
