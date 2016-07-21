using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkMultiProcessController : vtkObject
	{
		public enum Consts
		{
			ANY_SOURCE = -1,
			INVALID_SOURCE = -2
		}

		public enum Errors
		{
			RMI_ARG_ERROR = 2,
			RMI_NO_ERROR = 0,
			RMI_TAG_ERROR
		}

		public enum Tags
		{
			BREAK_RMI_TAG = 3,
			RMI_ARG_TAG = 2,
			RMI_TAG = 1,
			XML_WRITER_DATA_INFO = 4
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiProcessController";

		public new static readonly string MRClassNameKey;

		static vtkMultiProcessController()
		{
			vtkMultiProcessController.MRClassNameKey = "class vtkMultiProcessController";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiProcessController.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiProcessController"));
		}

		public vtkMultiProcessController(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllGather_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length);

		public int AllGather(IntPtr sendBuffer, IntPtr recvBuffer, long length)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGather_01(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllGather_02(HandleRef pThis, string sendBuffer, string recvBuffer, long length);

		public int AllGather(string sendBuffer, string recvBuffer, long length)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGather_02(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllGather_03(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		public int AllGather(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGather_03(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllGatherV_04(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		public int AllGatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_04(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllGatherV_05(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		public int AllGatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_05(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllGatherV_06(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets);

		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_06(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllGatherV_07(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_07(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllReduce_08(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation);

		public int AllReduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllReduce_08(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllReduce_09(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation);

		public int AllReduce(string sendBuffer, string recvBuffer, long length, int operation)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllReduce_09(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_AllReduce_10(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation);

		public int AllReduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllReduce_10(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_Barrier_11(HandleRef pThis);

		public void Barrier()
		{
			vtkMultiProcessController.vtkMultiProcessController_Barrier_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Broadcast_12(HandleRef pThis, IntPtr data, long length, int srcProcessId);

		public int Broadcast(IntPtr data, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_12(base.GetCppThis(), data, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Broadcast_13(HandleRef pThis, string data, long length, int srcProcessId);

		public int Broadcast(string data, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_13(base.GetCppThis(), data, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Broadcast_14(HandleRef pThis, HandleRef data, int srcProcessId);

		public int Broadcast(vtkDataObject data, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_14(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Broadcast_15(HandleRef pThis, HandleRef data, int srcProcessId);

		public int Broadcast(vtkDataArray data, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_15(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_CreateOutputWindow_16(HandleRef pThis);

		public virtual void CreateOutputWindow()
		{
			vtkMultiProcessController.vtkMultiProcessController_CreateOutputWindow_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiProcessController_CreateSubController_17(HandleRef pThis, HandleRef group, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController CreateSubController(vtkProcessGroup group)
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_CreateSubController_17(base.GetCppThis(), (group == null) ? default(HandleRef) : group.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkMultiProcessController_Finalize_18(HandleRef pThis);

		public virtual void FinalizeWrapper()
		{
			vtkMultiProcessController.vtkMultiProcessController_Finalize_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_Finalize_19(HandleRef pThis, int finalizedExternally);

		public virtual void FinalizeWrapper(int finalizedExternally)
		{
			vtkMultiProcessController.vtkMultiProcessController_Finalize_19(base.GetCppThis(), finalizedExternally);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Gather_20(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId);

		public int Gather(IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Gather_20(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Gather_21(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int destProcessId);

		public int Gather(string sendBuffer, string recvBuffer, long length, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Gather_21(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Gather_22(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		public int Gather(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Gather_22(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GatherV_23(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		public int GatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_23(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GatherV_24(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		public int GatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_24(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GatherV_25(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_25(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GatherV_26(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_26(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GetBreakFlag_27(HandleRef pThis);

		public virtual int GetBreakFlag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetBreakFlag_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GetBreakRMITag_28();

		public static int GetBreakRMITag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetBreakRMITag_28();
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiProcessController_GetCommunicator_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCommunicator GetCommunicator()
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_GetCommunicator_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommunicator = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommunicator.Register(null);
				}
			}
			return vtkCommunicator;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern long vtkMultiProcessController_GetCount_30(HandleRef pThis);

		public long GetCount()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetCount_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiProcessController_GetGlobalController_31(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkMultiProcessController GetGlobalController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_GetGlobalController_31(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkMultiProcessController_GetLocalProcessId_32(HandleRef pThis);

		public int GetLocalProcessId()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetLocalProcessId_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GetNumberOfProcesses_33(HandleRef pThis);

		public int GetNumberOfProcesses()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetNumberOfProcesses_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GetRMIArgTag_34();

		public static int GetRMIArgTag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetRMIArgTag_34();
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_GetRMITag_35();

		public static int GetRMITag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetRMITag_35();
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_IsA_36(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiProcessController.vtkMultiProcessController_IsA_36(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_IsTypeOf_37(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiProcessController.vtkMultiProcessController_IsTypeOf_37(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_MultipleMethodExecute_38(HandleRef pThis);

		public virtual void MultipleMethodExecute()
		{
			vtkMultiProcessController.vtkMultiProcessController_MultipleMethodExecute_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiProcessController_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiProcessController NewInstance()
		{
			vtkMultiProcessController result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_NewInstance_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiProcessController_PartitionController_40(HandleRef pThis, int localColor, int localKey, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController PartitionController(int localColor, int localKey)
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_PartitionController_40(base.GetCppThis(), localColor, localKey, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkMultiProcessController_ProcessRMIs_41(HandleRef pThis, int reportErrors, int dont_loop);

		public int ProcessRMIs(int reportErrors, int dont_loop)
		{
			return vtkMultiProcessController.vtkMultiProcessController_ProcessRMIs_41(base.GetCppThis(), reportErrors, dont_loop);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_ProcessRMIs_42(HandleRef pThis);

		public int ProcessRMIs()
		{
			return vtkMultiProcessController.vtkMultiProcessController_ProcessRMIs_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Receive_43(HandleRef pThis, IntPtr data, long length, int remoteProcessId, int tag);

		public int Receive(IntPtr data, long length, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_43(base.GetCppThis(), data, length, remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Receive_44(HandleRef pThis, string data, long length, int remoteProcessId, int tag);

		public int Receive(string data, long length, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_44(base.GetCppThis(), data, length, remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Receive_45(HandleRef pThis, HandleRef data, int remoteProcessId, int tag);

		public int Receive(vtkDataObject data, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_45(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Receive_46(HandleRef pThis, HandleRef data, int remoteProcessId, int tag);

		public int Receive(vtkDataArray data, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_46(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiProcessController_ReceiveDataObject_47(HandleRef pThis, int remoteProcessId, int tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject ReceiveDataObject(int remoteProcessId, int tag)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_ReceiveDataObject_47(base.GetCppThis(), remoteProcessId, tag, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Reduce_48(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId);

		public int Reduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Reduce_48(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Reduce_49(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation, int destProcessId);

		public int Reduce(string sendBuffer, string recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Reduce_49(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Reduce_50(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation, int destProcessId);

		public int Reduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Reduce_50(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_RemoveAllRMICallbacks_51(HandleRef pThis, int tag);

		public void RemoveAllRMICallbacks(int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_RemoveAllRMICallbacks_51(base.GetCppThis(), tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_RemoveFirstRMI_52(HandleRef pThis, int tag);

		public int RemoveFirstRMI(int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_RemoveFirstRMI_52(base.GetCppThis(), tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_RemoveRMI_53(HandleRef pThis, uint id);

		public int RemoveRMI(uint id)
		{
			return vtkMultiProcessController.vtkMultiProcessController_RemoveRMI_53(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkMultiProcessController_RemoveRMICallback_54(HandleRef pThis, uint id);

		public bool RemoveRMICallback(uint id)
		{
			return vtkMultiProcessController.vtkMultiProcessController_RemoveRMICallback_54(base.GetCppThis(), id) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiProcessController_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiProcessController SafeDownCast(vtkObjectBase o)
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_SafeDownCast_55((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkMultiProcessController_Scatter_56(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId);

		public int Scatter(IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Scatter_56(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Scatter_57(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int srcProcessId);

		public int Scatter(string sendBuffer, string recvBuffer, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Scatter_57(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Scatter_58(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int srcProcessId);

		public int Scatter(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Scatter_58(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_ScatterV_59(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		public int ScatterV(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_ScatterV_59(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_ScatterV_60(HandleRef pThis, string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		public int ScatterV(string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_ScatterV_60(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Send_61(HandleRef pThis, IntPtr data, long length, int remoteProcessId, int tag);

		public int Send(IntPtr data, long length, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_61(base.GetCppThis(), data, length, remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Send_62(HandleRef pThis, string data, long length, int remoteProcessId, int tag);

		public int Send(string data, long length, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_62(base.GetCppThis(), data, length, remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Send_63(HandleRef pThis, HandleRef data, int remoteProcessId, int tag);

		public int Send(vtkDataObject data, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_63(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMultiProcessController_Send_64(HandleRef pThis, HandleRef data, int remoteProcessId, int tag);

		public int Send(vtkDataArray data, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_64(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_SetBreakFlag_65(HandleRef pThis, int _arg);

		public virtual void SetBreakFlag(int _arg)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetBreakFlag_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_SetGlobalController_66(HandleRef controller);

		public static void SetGlobalController(vtkMultiProcessController controller)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetGlobalController_66((controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_SetNumberOfProcesses_67(HandleRef pThis, int num);

		public void SetNumberOfProcesses(int num)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetNumberOfProcesses_67(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_SetSingleProcessObject_68(HandleRef pThis, HandleRef p);

		public void SetSingleProcessObject(vtkProcess p)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetSingleProcessObject_68(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_SingleMethodExecute_69(HandleRef pThis);

		public virtual void SingleMethodExecute()
		{
			vtkMultiProcessController.vtkMultiProcessController_SingleMethodExecute_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_TriggerBreakRMIs_70(HandleRef pThis);

		public void TriggerBreakRMIs()
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerBreakRMIs_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_TriggerRMI_71(HandleRef pThis, int remoteProcessId, IntPtr arg, int argLength, int tag);

		public void TriggerRMI(int remoteProcessId, IntPtr arg, int argLength, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMI_71(base.GetCppThis(), remoteProcessId, arg, argLength, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_TriggerRMI_72(HandleRef pThis, int remoteProcessId, string arg, int tag);

		public void TriggerRMI(int remoteProcessId, string arg, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMI_72(base.GetCppThis(), remoteProcessId, arg, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_TriggerRMI_73(HandleRef pThis, int remoteProcessId, int tag);

		public void TriggerRMI(int remoteProcessId, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMI_73(base.GetCppThis(), remoteProcessId, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_74(HandleRef pThis, IntPtr arg, int argLength, int tag);

		public void TriggerRMIOnAllChildren(IntPtr arg, int argLength, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMIOnAllChildren_74(base.GetCppThis(), arg, argLength, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_75(HandleRef pThis, string arg, int tag);

		public void TriggerRMIOnAllChildren(string arg, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMIOnAllChildren_75(base.GetCppThis(), arg, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_76(HandleRef pThis, int tag);

		public void TriggerRMIOnAllChildren(int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMIOnAllChildren_76(base.GetCppThis(), tag);
		}
	}
}
