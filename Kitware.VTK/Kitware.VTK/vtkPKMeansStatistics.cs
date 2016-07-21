using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPKMeansStatistics : vtkKMeansStatistics
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPKMeansStatistics";

		public new static readonly string MRClassNameKey;

		static vtkPKMeansStatistics()
		{
			vtkPKMeansStatistics.MRClassNameKey = "class vtkPKMeansStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPKMeansStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPKMeansStatistics"));
		}

		public vtkPKMeansStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPKMeansStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPKMeansStatistics New()
		{
			vtkPKMeansStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKMeansStatistics.vtkPKMeansStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPKMeansStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPKMeansStatistics.vtkPKMeansStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPKMeansStatistics_CreateInitialClusterCenters_01(HandleRef pThis, long numToAllocate, HandleRef numberOfClusters, HandleRef inData, HandleRef curClusterElements, HandleRef newClusterElements);

		public virtual void CreateInitialClusterCenters(long numToAllocate, vtkIdTypeArray numberOfClusters, vtkTable inData, vtkTable curClusterElements, vtkTable newClusterElements)
		{
			vtkPKMeansStatistics.vtkPKMeansStatistics_CreateInitialClusterCenters_01(base.GetCppThis(), numToAllocate, (numberOfClusters == null) ? default(HandleRef) : numberOfClusters.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), (curClusterElements == null) ? default(HandleRef) : curClusterElements.GetCppThis(), (newClusterElements == null) ? default(HandleRef) : newClusterElements.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPKMeansStatistics_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKMeansStatistics.vtkPKMeansStatistics_GetController_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkPKMeansStatistics_GetTotalNumberOfObservations_03(HandleRef pThis, long numObservations);

		public virtual long GetTotalNumberOfObservations(long numObservations)
		{
			return vtkPKMeansStatistics.vtkPKMeansStatistics_GetTotalNumberOfObservations_03(base.GetCppThis(), numObservations);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPKMeansStatistics_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPKMeansStatistics.vtkPKMeansStatistics_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPKMeansStatistics_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPKMeansStatistics.vtkPKMeansStatistics_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPKMeansStatistics_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPKMeansStatistics NewInstance()
		{
			vtkPKMeansStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKMeansStatistics.vtkPKMeansStatistics_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPKMeansStatistics_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPKMeansStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkPKMeansStatistics vtkPKMeansStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKMeansStatistics.vtkPKMeansStatistics_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPKMeansStatistics = (vtkPKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPKMeansStatistics.Register(null);
				}
			}
			return vtkPKMeansStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPKMeansStatistics_SetController_09(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPKMeansStatistics.vtkPKMeansStatistics_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPKMeansStatistics_UpdateClusterCenters_10(HandleRef pThis, HandleRef newClusterElements, HandleRef curClusterElements, HandleRef numMembershipChanges, HandleRef numElementsInCluster, HandleRef error, HandleRef startRunID, HandleRef endRunID, HandleRef computeRun);

		public virtual void UpdateClusterCenters(vtkTable newClusterElements, vtkTable curClusterElements, vtkIdTypeArray numMembershipChanges, vtkIdTypeArray numElementsInCluster, vtkDoubleArray error, vtkIdTypeArray startRunID, vtkIdTypeArray endRunID, vtkIntArray computeRun)
		{
			vtkPKMeansStatistics.vtkPKMeansStatistics_UpdateClusterCenters_10(base.GetCppThis(), (newClusterElements == null) ? default(HandleRef) : newClusterElements.GetCppThis(), (curClusterElements == null) ? default(HandleRef) : curClusterElements.GetCppThis(), (numMembershipChanges == null) ? default(HandleRef) : numMembershipChanges.GetCppThis(), (numElementsInCluster == null) ? default(HandleRef) : numElementsInCluster.GetCppThis(), (error == null) ? default(HandleRef) : error.GetCppThis(), (startRunID == null) ? default(HandleRef) : startRunID.GetCppThis(), (endRunID == null) ? default(HandleRef) : endRunID.GetCppThis(), (computeRun == null) ? default(HandleRef) : computeRun.GetCppThis());
		}
	}
}
